//Add WeaponSpeed to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class WeaponSpeedIncreaseTarget : Target
	{			
		private WeaponSpeedIncreaseDeed m_Deed;

		public WeaponSpeedIncreaseTarget( WeaponSpeedIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int WeaponSpeedAdd = 1; //Amount of Weapon Speed to be added
			int WeaponSpeedCap = 100; //Limit of Weapon Speed that an item can have
			
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
						from.SendMessage( "You cannot add Weapon Speed to that item there!" ); 
					}
					else
					{
						WeaponSpeedAdd = WeaponSpeedToAdd(((BaseWeapon)item).Attributes.WeaponSpeed, WeaponSpeedAdd, WeaponSpeedCap, from);
						if( WeaponSpeedAdd > 0 )
						{
							((BaseWeapon)item).Attributes.WeaponSpeed += WeaponSpeedAdd;
							m_Deed.Delete();
						}
					}
					return;
			}
			else if ( target is BaseArmor && allowArmor )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Weapon Speed to that item there!" ); 
					}
					else
					{
						WeaponSpeedAdd = WeaponSpeedToAdd(((BaseArmor)item).Attributes.WeaponSpeed, WeaponSpeedAdd, WeaponSpeedCap, from);
						if( WeaponSpeedAdd > 0 )
						{
							((BaseArmor)item).Attributes.WeaponSpeed += WeaponSpeedAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Weapon Speed to that item there!" ); 
					}
					else
					{
						WeaponSpeedAdd = WeaponSpeedToAdd(((BaseClothing)item).Attributes.WeaponSpeed, WeaponSpeedAdd, WeaponSpeedCap, from);
						if( WeaponSpeedAdd > 0 )
						{
							((BaseClothing)item).Attributes.WeaponSpeed += WeaponSpeedAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Weapon Speed to that item there!" ); 
					}
					else
					{
						WeaponSpeedAdd = WeaponSpeedToAdd(((BaseTalisman)item).Attributes.WeaponSpeed, WeaponSpeedAdd, WeaponSpeedCap, from);
						if( WeaponSpeedAdd > 0 )
						{
							((BaseTalisman)item).Attributes.WeaponSpeed += WeaponSpeedAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Weapon Speed to that item there!" ); 
					}
					else
					{
						WeaponSpeedAdd = WeaponSpeedToAdd(((BaseJewel)item).Attributes.WeaponSpeed, WeaponSpeedAdd, WeaponSpeedCap, from);
						if( WeaponSpeedAdd > 0 )
						{
							((BaseJewel)item).Attributes.WeaponSpeed += WeaponSpeedAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Weapon Speed to that item there!" ); 
					}
					else
					{
						WeaponSpeedAdd = WeaponSpeedToAdd(((Spellbook)item).Attributes.WeaponSpeed, WeaponSpeedAdd, WeaponSpeedCap, from);
						if( WeaponSpeedAdd > 0 )
						{
							((Spellbook)item).Attributes.WeaponSpeed += WeaponSpeedAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Weapon Speed to that item there!" ); 
					}
					else
					{
						WeaponSpeedAdd = WeaponSpeedToAdd(((BaseQuiver)item).Attributes.WeaponSpeed, WeaponSpeedAdd, WeaponSpeedCap, from);
						if( WeaponSpeedAdd > 0 )
						{
							((BaseQuiver)item).Attributes.WeaponSpeed += WeaponSpeedAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int WeaponSpeedToAdd(int itemWeaponSpeed, int WeaponSpeedAdd ,int WeaponSpeedCap, Mobile from)
		{
			int ret = 0;
			if(itemWeaponSpeed < WeaponSpeedCap)
			{
				if( (itemWeaponSpeed + WeaponSpeedAdd ) > WeaponSpeedCap )
				{
					ret = WeaponSpeedAdd - ( (itemWeaponSpeed + WeaponSpeedAdd ) - WeaponSpeedCap );
					from.SendMessage("You increase the Weapon Speed on the item and it has now reached it's max. +"+ret+" Weapon Speed has been added.");
				}
				else{
					from.SendMessage( "You increase the Weapon Speed on the item. +"+WeaponSpeedAdd+" Weapon Speed has been added." );
					ret = WeaponSpeedAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Weapon Speed." );
			}
			
			return ret;
		}
	}

	public class WeaponSpeedIncreaseDeed : Item
	{
		[Constructable]
		public WeaponSpeedIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Weapon Speed Increase Deed";
			LootType = LootType.Blessed;
		}

		public WeaponSpeedIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Weapon Speed?"  );
				from.Target = new WeaponSpeedIncreaseTarget( this );
			}
		}	
	}
}