//Add SplinteringWeapon to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class SplinteringWeaponIncreaseTarget : Target
	{			
		private SplinteringWeaponIncreaseDeed m_Deed;

		public SplinteringWeaponIncreaseTarget( SplinteringWeaponIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int SplinteringWeaponAdd = 1; //Amount of SplinteringWeapon to be added
			int SplinteringWeaponCap = 50; //Limit of SplinteringWeapon that an item can have
			
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
						from.SendMessage( "You cannot add SplinteringWeapon to that item there!" ); 
					}
					else
					{
						SplinteringWeaponAdd = SplinteringWeaponToAdd(((BaseWeapon)item).WeaponAttributes.SplinteringWeapon, SplinteringWeaponAdd, SplinteringWeaponCap, from);
						if( SplinteringWeaponAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.SplinteringWeapon += SplinteringWeaponAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int SplinteringWeaponToAdd(int itemSplinteringWeapon, int SplinteringWeaponAdd ,int SplinteringWeaponCap, Mobile from)
		{
			int ret = 0;
			if(itemSplinteringWeapon < SplinteringWeaponCap)
			{
				if( (itemSplinteringWeapon + SplinteringWeaponAdd ) > SplinteringWeaponCap )
				{
					ret = SplinteringWeaponAdd - ( (itemSplinteringWeapon + SplinteringWeaponAdd ) - SplinteringWeaponCap );
					from.SendMessage("You increase the SplinteringWeapon on the item and it has now reached it's max. +"+ret+" SplinteringWeapon has been added.");
				}
				else{
					from.SendMessage( "You increase the SplinteringWeapon on the item. +"+SplinteringWeaponAdd+" SplinteringWeapon has been added." );
					ret = SplinteringWeaponAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of SplinteringWeapon." );
			}
			
			return ret;
		}
	}

	public class SplinteringWeaponIncreaseDeed : Item
	{
		[Constructable]
		public SplinteringWeaponIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1% SplinteringWeapon Increase Deed";
			LootType = LootType.Blessed;
		}

		public SplinteringWeaponIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase SplinteringWeapon?"  );
				from.Target = new SplinteringWeaponIncreaseTarget( this );
			}
		}	
	}
}