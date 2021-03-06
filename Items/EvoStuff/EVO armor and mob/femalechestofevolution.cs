using System;
using Server;

namespace Server.Items
{
	public class femalechestofevolution: LeatherBustierArms
	{

		private int mEvolutionPoints = 0;

        private int mBoundToSoul = 0;// Start binding value as zero.

        [CommandProperty( AccessLevel.GameMaster )]
		public int EvolutionPoints { get { return mEvolutionPoints; } set { mEvolutionPoints = value; } }
        [CommandProperty(AccessLevel.GameMaster)]
        public int BoundToSoul { get { return mBoundToSoul; } set { mBoundToSoul = value; } }

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
		public femalechestofevolution()
        {
            Name = "<BASEFONT COLOR=#2E9AFE>Evo Female Chest";
			Hue = 1910;

            ArmorAttributes.SelfRepair = 10;
            ArmorAttributes.MageArmor = 1;
            Attributes.LowerManaCost = 8;
            Attributes.LowerRegCost = 16;

            BoundToSoul = 0;
        }

        public femalechestofevolution(Serial serial)
            : base(serial)
        {
        }
        public override int OnHit( BaseWeapon weapon, int damageTaken )
        {
            if (Utility.Random(5) == 1)
            {
                //Console.WriteLine("should be applying gain");
                ApplyGain();
            }

            return base.OnHit(weapon, damageTaken);
        }

        public void ApplyGain()
        {
            int expr;
            if (mEvolutionPoints < 500) // edit this to change how high you wish the Attributes to go 10000 means max attributes will be 100
            {
                mEvolutionPoints++;
                //this.Name = "Evo Female Chest (" + mEvolutionPoints.ToString() + ")";

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

        public override bool OnDragLift(Mobile from)
        {
            if (from.AccessLevel >= AccessLevel.Seer)
            {
                return true;
            }
            else if (BoundToSoul == 0) //Check to see if bound to a serial.
            {
                BoundToSoul = from.Serial; //Bind to a serial on first time equiped.
                this.Name = "<BASEFONT COLOR=#2E9AFE>" + from.Name.ToString() + "'s Evo Female Chest";//Change item name and add who it is bound to. "Player's Soul Sword"
                from.Emote("*" + from.Name + " feels a weird energy overwhelming their body*");
                return true;//Allow it to bind to the first player to equip it after creation.
                            //Will show in [props as ParentEntity and RootParentEntitty as [m] Serial, "Player Name"
            }
            return base.OnDragLift(from);
        }

        public override bool OnEquip(Mobile from)
        {
            if (BoundToSoul == 0) //Check to see if bound to a serial.
            {
                BoundToSoul = from.Serial; //Bind to a serial on first time equiped.
                this.Name = "<BASEFONT COLOR=#2E9AFE>" + from.Name.ToString() + "'s Evo Female Chest";//Change item name and add who it is bound to. "Player's Soul Sword"
                from.Emote("*" + from.Name + " feels a weird energy overwhelming their body*");
                base.OnEquip(from);
                return true;//Allow it to bind to the first player to equip it after creation.
                            //Will show in [props as ParentEntity and RootParentEntitty as [m] Serial, "Player Name"
            }
            else if (BoundToSoul == from.Serial) //Check to see if sword is bound to who is equiping it.
            {
                base.OnEquip(from);
                return true; //Allow player who had bound to sword to equip it.
            }
            else
            {
                from.SendMessage("Sorry but this armor does not belong to you.");
                return false; //Disallow any one else from equiping the sword.
            }
        }
        public override void AddNameProperty(ObjectPropertyList list)
        {
            base.AddNameProperty(list);
            if (BoundToSoul == 0) //Check to see if bound to a serial.
            {
                list.Add("<BASEFONT COLOR=#666699>"/*Green*/ + "[Un-Bound]" + "<BASEFONT COLOR=#FFFFFF>"/*Back to White*/ );
            }
            else if (BoundToSoul > 0)//Once the sword is bound it will show the Evolution Points.
            {// \n puts the stuff after it on a new line
                list.Add("<BASEFONT COLOR=#666699>"/*Green*/ + "[Soulbound]\n" + "<BASEFONT COLOR=#669966>" + "Evolution Points: " + mEvolutionPoints.ToString() + "<BASEFONT COLOR=#FFFFFF>"/*Back to White*/ );
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1);
            writer.Write(mBoundToSoul);//Serialize who it is bound to.
            writer.Write(mEvolutionPoints);

        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 1:
                    {
                        mBoundToSoul = reader.ReadInt();
                        goto case 0;
                    }
                case 0:
                    {
                        mEvolutionPoints = reader.ReadInt();
                        break;
                    }
            }
        }
    }
}
