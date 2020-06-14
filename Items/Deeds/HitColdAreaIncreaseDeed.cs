//Add HitColdArea to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitColdAreaIncreaseTarget : Target
	{			
		private HitColdAreaIncreaseDeed m_Deed;

		public HitColdAreaIncreaseTarget( HitColdAreaIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitColdAreaAdd = 1; //Amount of Hit Cold Area to be added
			int HitColdAreaCap = 100; //Limit of Hit Cold Area that an item can have
			
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
						from.SendMessage( "You cannot add Hit Cold Area to that item there!" ); 
					}
					else
					{
						HitColdAreaAdd = HitColdAreaToAdd(((BaseWeapon)item).WeaponAttributes.HitColdArea, HitColdAreaAdd, HitColdAreaCap, from);
						if( HitColdAreaAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitColdArea += HitColdAreaAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitColdAreaToAdd(int itemHitColdArea, int HitColdAreaAdd ,int HitColdAreaCap, Mobile from)
		{
			int ret = 0;
			if(itemHitColdArea < HitColdAreaCap)
			{
				if( (itemHitColdArea + HitColdAreaAdd ) > HitColdAreaCap )
				{
					ret = HitColdAreaAdd - ( (itemHitColdArea + HitColdAreaAdd ) - HitColdAreaCap );
					from.SendMessage("You increase the Hit Cold Area on the item and it has now reached it's max. +"+ret+" Hit Cold Area has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Cold Area on the item. +"+HitColdAreaAdd+" Hit Cold Area has been added." );
					ret = HitColdAreaAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Cold Area." );
			}
			
			return ret;
		}
	}

	public class HitColdAreaIncreaseDeed : Item
	{
		[Constructable]
		public HitColdAreaIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Cold Area Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitColdAreaIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Cold Area?"  );
				from.Target = new HitColdAreaIncreaseTarget( this );
			}
		}	
	}
}