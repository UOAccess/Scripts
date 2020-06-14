//Add HitLightning to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitLightningIncreaseTarget : Target
	{			
		private HitLightningIncreaseDeed m_Deed;

		public HitLightningIncreaseTarget( HitLightningIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitLightningAdd = 1; //Amount of Hit Lightning to be added
			int HitLightningCap = 100; //Limit of Hit Lightning that an item can have
			
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
						from.SendMessage( "You cannot add Hit Lightning to that item there!" ); 
					}
					else
					{
						HitLightningAdd = HitLightningToAdd(((BaseWeapon)item).WeaponAttributes.HitLightning, HitLightningAdd, HitLightningCap, from);
						if( HitLightningAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitLightning += HitLightningAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitLightningToAdd(int itemHitLightning, int HitLightningAdd ,int HitLightningCap, Mobile from)
		{
			int ret = 0;
			if(itemHitLightning < HitLightningCap)
			{
				if( (itemHitLightning + HitLightningAdd ) > HitLightningCap )
				{
					ret = HitLightningAdd - ( (itemHitLightning + HitLightningAdd ) - HitLightningCap );
					from.SendMessage("You increase the Hit Lightning on the item and it has now reached it's max. +"+ret+" Hit Lightning has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Lightning on the item. +"+HitLightningAdd+" Hit Lightning has been added." );
					ret = HitLightningAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Lightning." );
			}
			
			return ret;
		}
	}

	public class HitLightningIncreaseDeed : Item
	{
		[Constructable]
		public HitLightningIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Lightning Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitLightningIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Lightning?"  );
				from.Target = new HitLightningIncreaseTarget( this );
			}
		}	
	}
}