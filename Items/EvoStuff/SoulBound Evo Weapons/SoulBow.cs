/*----------------*/
/*--- Scripted ---*/
/*--- By: JBob ---*/
/*----------------*/
using System;
using Server;
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Engines;

namespace Server.Items
{
	[FlipableAttribute( 0x13B2, 0x13B1 )]
	public class SoulBow : BaseRanged
	{
        private int mEvolutionPoints;//Bow will only evolve to 50%
        [CommandProperty(AccessLevel.GameMaster)]
        public int EvolutionPoints { get { return mEvolutionPoints; } set { mEvolutionPoints = value; } }

		public int BoundToSoul = 0;// Start binding value as zero.
		
		public override int EffectID{ get{ return 0xF42; } }
		public override Type AmmoType{ get{ return typeof( Arrow ); } }
		public override Item Ammo{ get{ return new Arrow(); } }

		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MortalStrike; } }

		public override int AosStrengthReq{ get{ return 30; } }
		public override int AosMinDamage{ get{ return Core.ML ? 15 : 16; } }
		public override int AosMaxDamage{ get{ return Core.ML ? 19 : 18; } }
		public override int AosSpeed{ get{ return 25; } }
		public override float MlSpeed{ get{ return 4.25f; } }

		public override int OldStrengthReq{ get{ return 20; } }
		public override int OldMinDamage{ get{ return 9; } }
		public override int OldMaxDamage{ get{ return 41; } }
		public override int OldSpeed{ get{ return 20; } }

		public override int DefMaxRange{ get{ return 10; } }

		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.ShootBow; } }

		public override int InitMinHits{ get{ return 225; } }
		public override int InitMaxHits{ get{ return 225; } }

		[Constructable]
		public SoulBow() : base( 0x13B2 )
		{
			Weight = 7.0;
			Name = "<BASEFONT COLOR =#15D004>Soul Bow";
			Resource = CraftResource.None;//Resource None so the Bows name shows correct once Bound.
			Layer = Layer.TwoHanded;
			
			BoundToSoul = 0; 
			// Create item with value at zero. Will show in [props as ParentEntity and RootParentEntitty as null.
			
            Attributes.Luck = 100;
            WeaponAttributes.SelfRepair = 100;

            Attributes.WeaponDamage = 1;
            Attributes.WeaponSpeed = 10;
            Attributes.SpellChanneling = 1;
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
                this.Name = "< BASEFONT COLOR =#15D004>" + from.Name.ToString() + "'s Soul Bow";//Change item name and add who it is bound to. "Player's Soul Sword"
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
                this.Name = "< BASEFONT COLOR =#15D004>" + from.Name.ToString() + "'s Soul Bow";//Change item name and add who it is bound to. "Player's Soul Bow"
      			from.Emote( "*" + from.Name + " feels a weird energy overwhelming their body*" ); 
				base.OnEquip( from ); 
				return true;//Allow it to bind to the first player to equip it after creation.
							//Will show in [props as ParentEntity and RootParentEntitty as [m] Serial, "Player Name"
      		} 
           	else if(BoundToSoul == from.Serial) //Check to see if Bow is bound to who is equiping it.
      		{
				base.OnEquip( from );
				return true; //Allow player who had bound to Bow to equip it.
      		} 
      		else 
      		{ 
      			from.SendMessage( "The Bow refuses your soul" ); 
				return false; //Disallow any one else from equiping the Bow.
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
        /*public virtual void OnHit(Mobile attacker, Mobile defender)
        {
            if (Utility.Random(2) == 1)
            {
                ApplyGain();
            }
            base.OnHit(attacker, defender);
        }*/
        public override void OnHit(Mobile attacker, IDamageable damageable, double damageBonus)
        {
            if (Utility.Random(10) == 1)
            {
            ApplyGain();
            }
            base.OnHit(attacker, damageable, damageBonus);
        }
        /* Wrong Way
        public virtual void OnHit(Mobile attacker, Mobile defender, double damageBonus)
        {
            if (Utility.Random(5) == 1)
            {
                ApplyGain();
            }
            base.OnHit(attacker, defender, damageBonus);
        }
        */

        public void ApplyGain()
        {
            int expr;
            if (mEvolutionPoints < 200) // edit this to change how high you wish the Attributes to go 10000 means max attributes will be 100
            {
                mEvolutionPoints++;

                if ((mEvolutionPoints / 1) > 0)
                {
                    expr = mEvolutionPoints / 20;
                    //  200 / 10 = 20
                    
                    this.Attributes.BonusStr = expr;
                    this.Attributes.BonusDex = expr;
                    this.Attributes.BonusInt = expr;
                }

                if ((mEvolutionPoints / 2) > 0)
                {
                    expr = mEvolutionPoints / 3;

                    this.Attributes.AttackChance = expr;
                    this.Attributes.WeaponSpeed = expr;
                    this.Attributes.WeaponDamage = expr;
                    //this.Attributes.Luck = expr;
                    //this.Attributes.SpellDamage = expr;
                    //this.Attributes.DefendChance = expr;
                    //.Attributes.ReflectPhysical = expr;
                }

                if ((25 + (mEvolutionPoints / 2)) > 0) this.Attributes.WeaponSpeed = (25 + (mEvolutionPoints / 2));
                
                InvalidateProperties();
            }
        }

        public override bool CanEquip( Mobile from )
        {
            if ( from.Skills[SkillName.Archery].Base <= 75.0 )
			{
				from.SendMessage( "You are not skilled enough to equip that." );
                return false;
			}
            else
            {
                return base.CanEquip( from );
            }
        }	
		
		public SoulBow( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
			writer.Write( (int) mEvolutionPoints );//Serialize(Save) how many points the Bow has.
         	writer.Write( (int) BoundToSoul );//Serialize who it is bound to.
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			mEvolutionPoints = reader.ReadInt();//Read on startup how many points the Bow has.
         	BoundToSoul = reader.ReadInt();//Read on startup who it is bound to.
		}
	}
}
