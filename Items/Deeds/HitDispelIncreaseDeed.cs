//Add HitDispel to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitDispelIncreaseTarget : Target
	{			
		private HitDispelIncreaseDeed m_Deed;

		public HitDispelIncreaseTarget( HitDispelIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitDispelAdd = 5; //Amount of Hit Dispel to be added
			int HitDispelCap = 100; //Limit of Hit Dispel that an item can have
			
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
						from.SendMessage( "You cannot add Hit Dispel to that item there!" ); 
					}
					else
					{
						HitDispelAdd = HitDispelToAdd(((BaseWeapon)item).WeaponAttributes.HitDispel, HitDispelAdd, HitDispelCap, from);
						if( HitDispelAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitDispel += HitDispelAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitDispelToAdd(int itemHitDispel, int HitDispelAdd ,int HitDispelCap, Mobile from)
		{
			int ret = 0;
			if(itemHitDispel < HitDispelCap)
			{
				if( (itemHitDispel + HitDispelAdd ) > HitDispelCap )
				{
					ret = HitDispelAdd - ( (itemHitDispel + HitDispelAdd ) - HitDispelCap );
					from.SendMessage("You increase the Hit Dispel on the item and it has now reached it's max. +"+ret+" Hit Dispel has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Dispel on the item. +"+HitDispelAdd+" Hit Dispel has been added." );
					ret = HitDispelAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Dispel." );
			}
			
			return ret;
		}
	}

	public class HitDispelIncreaseDeed : Item
	{
		[Constructable]
		public HitDispelIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+5 Hit Dispel Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitDispelIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Dispel?"  );
				from.Target = new HitDispelIncreaseTarget( this );
			}
		}	
	}
}