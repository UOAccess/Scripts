//Add HitLowerDefend to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitLowerDefendIncreaseTarget : Target
	{			
		private HitLowerDefendIncreaseDeed m_Deed;

		public HitLowerDefendIncreaseTarget( HitLowerDefendIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitLowerDefendAdd = 1; //Amount of Hit Lower Defend to be added
			int HitLowerDefendCap = 100; //Limit of Hit Lower Defend that an item can have
			
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
						from.SendMessage( "You cannot add Hit Lower Defend to that item there!" ); 
					}
					else
					{
						HitLowerDefendAdd = HitLowerDefendToAdd(((BaseWeapon)item).WeaponAttributes.HitLowerDefend, HitLowerDefendAdd, HitLowerDefendCap, from);
						if( HitLowerDefendAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitLowerDefend += HitLowerDefendAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitLowerDefendToAdd(int itemHitLowerDefend, int HitLowerDefendAdd ,int HitLowerDefendCap, Mobile from)
		{
			int ret = 0;
			if(itemHitLowerDefend < HitLowerDefendCap)
			{
				if( (itemHitLowerDefend + HitLowerDefendAdd ) > HitLowerDefendCap )
				{
					ret = HitLowerDefendAdd - ( (itemHitLowerDefend + HitLowerDefendAdd ) - HitLowerDefendCap );
					from.SendMessage("You increase the Hit Lower Defend on the item and it has now reached it's max. +"+ret+" Hit Lower Defend has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Lower Defend on the item. +"+HitLowerDefendAdd+" Hit Lower Defend has been added." );
					ret = HitLowerDefendAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Lower Defend." );
			}
			
			return ret;
		}
	}

	public class HitLowerDefendIncreaseDeed : Item
	{
		[Constructable]
		public HitLowerDefendIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Lower Defend Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitLowerDefendIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Lower Defend?"  );
				from.Target = new HitLowerDefendIncreaseTarget( this );
			}
		}	
	}
}