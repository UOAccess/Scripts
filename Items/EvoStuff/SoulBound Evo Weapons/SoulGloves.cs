using System;
using Server;
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Engines;

namespace Server.Items
{
    [FlipableAttribute(0x1414, 0x1418)]
    public class SoulGloves : BaseArmor
	{

        private int mEvolutionPoints;//Sword will only evolve to 50%
        [CommandProperty(AccessLevel.GameMaster)]
        public int EvolutionPoints { get { return mEvolutionPoints; } set { mEvolutionPoints = value; } }

		public int BoundToSoul = 0;// Start binding value as zero.

		public override int ArtifactRarity{ get{ return 13; } }
        public override int BasePhysicalResistance { get { return 10; } }
        public override int BaseFireResistance { get { return 10; } }
        public override int BaseColdResistance { get { return 10; } }
        public override int BasePoisonResistance { get { return 10; } }
        public override int BaseEnergyResistance { get { return 10; } }
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }
        private Mobile m_Owner;
		[Constructable]
		public SoulGloves() : base (0x1414)
        {
            Name = "<BASEFONT COLOR=#2E9AFE>Soul Gloves";
			Hue = 1910;

			Resource = CraftResource.None;//Resource None so the Swords name shows correct once Bound.
			
			BoundToSoul = 0; 
			// Create item with value at zero. Will show in [props as ParentEntity and RootParentEntitty as null.
			
            Attributes.Luck = 100;
            ArmorAttributes.SelfRepair = 100;
            ArmorAttributes.MageArmor = 1;
            Attributes.LowerManaCost = 5;
            Attributes.LowerRegCost = 15;
        }

        public override bool OnDragLift(Mobile from)
        {
            if (from.AccessLevel >= AccessLevel.Seer)
            {
                return true;
            }
            else if (BoundToSoul == 0) //Check to see if bound to a serial.
            {
                BoundToSoul = from.Serial; //Bind to a serial on first time equiped.
                this.Name = "< BASEFONT COLOR =#15D004>" + from.Name.ToString() + "'s Soul Gloves";//Change item name and add who it is bound to. "Player's Soul Sword"
                from.Emote("*" + from.Name + " feels a weird energy overwhelming their body*");
                //base.OnEquip(from);
                return true;//Allow it to bind to the first player to equip it after creation.
                            //Will show in [props as ParentEntity and RootParentEntitty as [m] Serial, "Player Name"
            }
            return base.OnDragLift(from);
        }

        public override bool OnEquip( Mobile from ) 
		{ 
			if(BoundToSoul == 0) //Check to see if bound to a serial.
			{ 
      			BoundToSoul = from.Serial; //Bind to a serial on first time equiped.
                this.Name = "< BASEFONT COLOR =#15D004>" + from.Name.ToString() + "'s Soul Gloves";//Change item name and add who it is bound to. "Player's Soul Sword"
      			from.Emote( "*" + from.Name + " feels a weird energy overwhelming their body*" ); 
				base.OnEquip( from ); 
				return true;//Allow it to bind to the first player to equip it after creation.
							//Will show in [props as ParentEntity and RootParentEntitty as [m] Serial, "Player Name"
      		} 
           	else if(BoundToSoul == from.Serial) //Check to see if sword is bound to who is equiping it.
      		{
				base.OnEquip( from );
				return true; //Allow player who had bound to sword to equip it.
      		} 
      		else 
      		{ 
      			from.SendMessage( "The Armor refuses your soul" ); 
				return false; //Disallow any one else from equiping the sword.
			} 
		}

		public override void AddNameProperty(ObjectPropertyList list)
        {
			base.AddNameProperty( list );
            if (BoundToSoul == 0) //Check to see if bound to a serial.
            {
                list.Add("<BASEFONT COLOR=#666699>"/*Green*/ + "[Un-Bound]" + "<BASEFONT COLOR=#FFFFFF>"/*Back to White*/ );
            }
            else if (BoundToSoul > 0)//Once the sword is bound it will show the Evolution Points.
            {// \n puts the stuff after it on a new line
                list.Add("<BASEFONT COLOR=#666699>"/*Green*/ + "[Soulbound]\n" + "<BASEFONT COLOR=#669966>" + "Evolution Points: " + mEvolutionPoints.ToString() + "<BASEFONT COLOR=#FFFFFF>"/*Back to White*/ );
            }
        }
        /*When weapon hits this gives a chance to gain Evolution Points*/
        /*public override void OnHit(Mobile attacker, Mobile defender)
        {
            if (Utility.Random(2) == 1)
            {
                ApplyGain();
            }
            base.OnHit(attacker, defender);
        }*/
        public override int OnHit(BaseWeapon weapon, int damageTaken)
        {
            if (Utility.Random(5) == 1)
            {
                ApplyGain();
            }
            return base.OnHit(weapon, damageTaken);
        }

        public void ApplyGain()
        {
            int expr;
            if (mEvolutionPoints < 200) // edit this to change how high you wish the Attributes to go 10000 means max attributes will be 100
            {
                mEvolutionPoints++;

                if ((mEvolutionPoints / 1) > 0)
                {
                    expr = mEvolutionPoints / 2;//100Max

                    this.Attributes.BonusHits = expr;
                    this.Attributes.BonusMana = expr;
                    this.Attributes.BonusStam = expr;
                }

                if ((mEvolutionPoints / 4) > 0)
                {
                    expr = mEvolutionPoints / 4;//50Max

                    //this.Attributes.Luck = expr;
                    this.Attributes.SpellDamage = expr;
                    this.Attributes.DefendChance = expr;
                    this.Attributes.ReflectPhysical = expr;
                }

                if ((mEvolutionPoints / 20) > 0)
                {
                    expr = mEvolutionPoints / 10;//20Max

                    this.Attributes.BonusStr = expr;
                    this.Attributes.BonusDex = expr;
                    this.Attributes.BonusInt = expr;
                }
                InvalidateProperties();
            }
        }


        public SoulGloves( Serial serial ) : base( serial )
		{
		}

        public override ArmorMaterialType MaterialType
        {
            get
            {
                return ArmorMaterialType.Plate;
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
			writer.Write( (int) mEvolutionPoints );//Serialize(Save) how many points the Sword has.
         	writer.Write( (int) BoundToSoul );//Serialize who it is bound to.
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
			mEvolutionPoints = reader.ReadInt();//Read on startup how many points the Sword has.
         	BoundToSoul = reader.ReadInt();//Read on startup who it is bound to.
        }
    }
}
