//Add HitPhysicalArea to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitPhysicalAreaIncreaseTarget : Target
	{			
		private HitPhysicalAreaIncreaseDeed m_Deed;

		public HitPhysicalAreaIncreaseTarget( HitPhysicalAreaIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitPhysicalAreaAdd = 1; //Amount of Hit Physical Area to be added
			int HitPhysicalAreaCap = 100; //Limit of Hit Physical Area that an item can have
			
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
						from.SendMessage( "You cannot add Hit Physical Area to that item there!" ); 
					}
					else
					{
						HitPhysicalAreaAdd = HitPhysicalAreaToAdd(((BaseWeapon)item).WeaponAttributes.HitPhysicalArea, HitPhysicalAreaAdd, HitPhysicalAreaCap, from);
						if( HitPhysicalAreaAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitPhysicalArea += HitPhysicalAreaAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitPhysicalAreaToAdd(int itemHitPhysicalArea, int HitPhysicalAreaAdd ,int HitPhysicalAreaCap, Mobile from)
		{
			int ret = 0;
			if(itemHitPhysicalArea < HitPhysicalAreaCap)
			{
				if( (itemHitPhysicalArea + HitPhysicalAreaAdd ) > HitPhysicalAreaCap )
				{
					ret = HitPhysicalAreaAdd - ( (itemHitPhysicalArea + HitPhysicalAreaAdd ) - HitPhysicalAreaCap );
					from.SendMessage("You increase the Hit Physical Area on the item and it has now reached it's max. +"+ret+" Hit Physical Area has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Physical Area on the item. +"+HitPhysicalAreaAdd+" Hit Physical Area has been added." );
					ret = HitPhysicalAreaAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Physical Area." );
			}
			
			return ret;
		}
	}

	public class HitPhysicalAreaIncreaseDeed : Item
	{
		[Constructable]
		public HitPhysicalAreaIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Physical Area Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitPhysicalAreaIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Physical Area?"  );
				from.Target = new HitPhysicalAreaIncreaseTarget( this );
			}
		}	
	}
}