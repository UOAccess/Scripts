//Add HitMagicArrow to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitMagicArrowIncreaseTarget : Target
	{			
		private HitMagicArrowIncreaseDeed m_Deed;

		public HitMagicArrowIncreaseTarget( HitMagicArrowIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitMagicArrowAdd = 1; //Amount of Hit Magic Arrow to be added
			int HitMagicArrowCap = 100; //Limit of Hit Magic Arrow that an item can have
			
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
						from.SendMessage( "You cannot add Hit Magic Arrow to that item there!" ); 
					}
					else
					{
						HitMagicArrowAdd = HitMagicArrowToAdd(((BaseWeapon)item).WeaponAttributes.HitMagicArrow, HitMagicArrowAdd, HitMagicArrowCap, from);
						if( HitMagicArrowAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitMagicArrow += HitMagicArrowAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitMagicArrowToAdd(int itemHitMagicArrow, int HitMagicArrowAdd ,int HitMagicArrowCap, Mobile from)
		{
			int ret = 0;
			if(itemHitMagicArrow < HitMagicArrowCap)
			{
				if( (itemHitMagicArrow + HitMagicArrowAdd ) > HitMagicArrowCap )
				{
					ret = HitMagicArrowAdd - ( (itemHitMagicArrow + HitMagicArrowAdd ) - HitMagicArrowCap );
					from.SendMessage("You increase the Hit Magic Arrow on the item and it has now reached it's max. +"+ret+" Hit Magic Arrow has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Magic Arrow on the item. +"+HitMagicArrowAdd+" Hit Magic Arrow has been added." );
					ret = HitMagicArrowAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Magic Arrow." );
			}
			
			return ret;
		}
	}

	public class HitMagicArrowIncreaseDeed : Item
	{
		[Constructable]
		public HitMagicArrowIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Magic Arrow Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitMagicArrowIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Magic Arrow?"  );
				from.Target = new HitMagicArrowIncreaseTarget( this );
			}
		}	
	}
}