//Add HitHarm to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitHarmIncreaseTarget : Target
	{			
		private HitHarmIncreaseDeed m_Deed;

		public HitHarmIncreaseTarget( HitHarmIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitHarmAdd = 1; //Amount of Hit Harm to be added
			int HitHarmCap = 100; //Limit of Hit Harm that an item can have
			
			//Change to false if you don't want it to be used on any of these items
      bool allowWeapon = true;
			bool allowArmor = false;
			bool allowJewel = false;
			bool allowClothing = false;
			bool allowSpellbook = true;
			bool allowTalisman = false;
			bool allowQuiver = false;
			
			if ( target is BaseWeapon && allowWeapon)
			{
				Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Hit Harm to that item there!" ); 
					}
					else
					{
						HitHarmAdd = HitHarmToAdd(((BaseWeapon)item).WeaponAttributes.HitHarm, HitHarmAdd, HitHarmCap, from);
						if( HitHarmAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitHarm += HitHarmAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitHarmToAdd(int itemHitHarm, int HitHarmAdd ,int HitHarmCap, Mobile from)
		{
			int ret = 0;
			if(itemHitHarm < HitHarmCap)
			{
				if( (itemHitHarm + HitHarmAdd ) > HitHarmCap )
				{
					ret = HitHarmAdd - ( (itemHitHarm + HitHarmAdd ) - HitHarmCap );
					from.SendMessage("You increase the Hit Harm on the item and it has now reached it's max. +"+ret+" Hit Harm has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Harm on the item. +"+HitHarmAdd+" Hit Harm has been added." );
					ret = HitHarmAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Harm." );
			}
			
			return ret;
		}
	}

	public class HitHarmIncreaseDeed : Item
	{
		[Constructable]
		public HitHarmIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Harm Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitHarmIncreaseDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			LootType = LootType.Blessed;

			int version = reader.ReadInt();
		}

		public override bool DisplayLootType{ get{ return false; } }

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) )
			{
				 from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			else
			{
				from.SendMessage("Which item would you like to increase Hit Harm?"  );
				from.Target = new HitHarmIncreaseTarget( this );
			}
		}	
	}
}