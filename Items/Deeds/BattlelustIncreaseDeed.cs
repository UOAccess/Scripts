//Add BattleLust to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class BattleLustIncreaseTarget : Target
	{			
		private BattleLustIncreaseDeed m_Deed;

		public BattleLustIncreaseTarget( BattleLustIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int BattleLustAdd = 1; //Amount of BattleLust to be added
			int BattleLustCap = 1; //Limit of BattleLust that an item can have
			
			//Change to false if you don't want it to be used on any of these items
      bool allowWeapon = true;
			bool allowArmor = false;
			bool allowJewel = false;
			bool allowClothing = false;
			bool allowSpellbook = false;
			bool allowTalisman = false;
			bool allowQuiver = false;
			
			if ( target is BaseWeapon && allowWeapon)
			{
				Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add BattleLust to that item there!" ); 
					}
					else
					{
						BattleLustAdd = BattleLustToAdd(((BaseWeapon)item).WeaponAttributes.BattleLust, BattleLustAdd, BattleLustCap, from);
						if( BattleLustAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.BattleLust += BattleLustAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int BattleLustToAdd(int itemBattleLust, int BattleLustAdd ,int BattleLustCap, Mobile from)
		{
			int ret = 0;
			if(itemBattleLust < BattleLustCap)
			{
				if( (itemBattleLust + BattleLustAdd ) > BattleLustCap )
				{
					ret = BattleLustAdd - ( (itemBattleLust + BattleLustAdd ) - BattleLustCap );
					from.SendMessage("You increase the BattleLust on the item and it has now reached it's max. +"+ret+" BattleLust has been added.");
				}
				else{
					from.SendMessage( "You increase the BattleLust on the item. +"+BattleLustAdd+" BattleLust has been added." );
					ret = BattleLustAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of BattleLust." );
			}
			
			return ret;
		}
	}

	public class BattleLustIncreaseDeed : Item
	{
		[Constructable]
		public BattleLustIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "BattleLust Increase Deed";
			LootType = LootType.Blessed;
		}

		public BattleLustIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase BattleLust?"  );
				from.Target = new BattleLustIncreaseTarget( this );
			}
		}	
	}
}