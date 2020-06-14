//Add HitLeechStam to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitLeechStamIncreaseTarget : Target
	{			
		private HitLeechStamIncreaseDeed m_Deed;

		public HitLeechStamIncreaseTarget( HitLeechStamIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitLeechStamAdd = 1; //Amount of Hit Leech Stam to be added
			int HitLeechStamCap = 100; //Limit of Hit Leech Stam that an item can have
			
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
						from.SendMessage( "You cannot add Hit Leech Stam to that item there!" ); 
					}
					else
					{
						HitLeechStamAdd = HitLeechStamToAdd(((BaseWeapon)item).WeaponAttributes.HitLeechStam, HitLeechStamAdd, HitLeechStamCap, from);
						if( HitLeechStamAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitLeechStam += HitLeechStamAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitLeechStamToAdd(int itemHitLeechStam, int HitLeechStamAdd ,int HitLeechStamCap, Mobile from)
		{
			int ret = 0;
			if(itemHitLeechStam < HitLeechStamCap)
			{
				if( (itemHitLeechStam + HitLeechStamAdd ) > HitLeechStamCap )
				{
					ret = HitLeechStamAdd - ( (itemHitLeechStam + HitLeechStamAdd ) - HitLeechStamCap );
					from.SendMessage("You increase the Hit Leech Stam on the item and it has now reached it's max. +"+ret+" Hit Leech Stam has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Leech Stam on the item. +"+HitLeechStamAdd+" Hit Leech Stam has been added." );
					ret = HitLeechStamAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Leech Stam." );
			}
			
			return ret;
		}
	}

	public class HitLeechStamIncreaseDeed : Item
	{
		[Constructable]
		public HitLeechStamIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Leech Stam Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitLeechStamIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Leech Stam?"  );
				from.Target = new HitLeechStamIncreaseTarget( this );
			}
		}	
	}
}