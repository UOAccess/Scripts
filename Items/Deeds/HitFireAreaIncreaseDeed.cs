//Add HitFireArea to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitFireAreaIncreaseTarget : Target
	{			
		private HitFireAreaIncreaseDeed m_Deed;

		public HitFireAreaIncreaseTarget( HitFireAreaIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitFireAreaAdd = 1; //Amount of Hit Fire Area to be added
			int HitFireAreaCap = 100; //Limit of Hit Fire Area that an item can have
			
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
						from.SendMessage( "You cannot add Hit Fire Area to that item there!" ); 
					}
					else
					{
						HitFireAreaAdd = HitFireAreaToAdd(((BaseWeapon)item).WeaponAttributes.HitFireArea, HitFireAreaAdd, HitFireAreaCap, from);
						if( HitFireAreaAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitFireArea += HitFireAreaAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitFireAreaToAdd(int itemHitFireArea, int HitFireAreaAdd ,int HitFireAreaCap, Mobile from)
		{
			int ret = 0;
			if(itemHitFireArea < HitFireAreaCap)
			{
				if( (itemHitFireArea + HitFireAreaAdd ) > HitFireAreaCap )
				{
					ret = HitFireAreaAdd - ( (itemHitFireArea + HitFireAreaAdd ) - HitFireAreaCap );
					from.SendMessage("You increase the Hit Fire Area on the item and it has now reached it's max. +"+ret+" Hit Fire Area has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Fire Area on the item. +"+HitFireAreaAdd+" Hit Fire Area has been added." );
					ret = HitFireAreaAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Fire Area." );
			}
			
			return ret;
		}
	}

	public class HitFireAreaIncreaseDeed : Item
	{
		[Constructable]
		public HitFireAreaIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Fire Area Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitFireAreaIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Fire Area?"  );
				from.Target = new HitFireAreaIncreaseTarget( this );
			}
		}	
	}
}