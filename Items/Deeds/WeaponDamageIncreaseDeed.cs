//Add WeaponDamage to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class WeaponDamageIncreaseTarget : Target
	{			
		private WeaponDamageIncreaseDeed m_Deed;

		public WeaponDamageIncreaseTarget( WeaponDamageIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int WeaponDamageAdd = 1; //Amount of Weapon Damage to be added
			int WeaponDamageCap = 100; //Limit of Weapon Damage that an item can have
			
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
						from.SendMessage( "You cannot add Weapon Damage to that item there!" ); 
					}
					else
					{
						WeaponDamageAdd = WeaponDamageToAdd(((BaseWeapon)item).Attributes.WeaponDamage, WeaponDamageAdd, WeaponDamageCap, from);
						if( WeaponDamageAdd > 0 )
						{
							((BaseWeapon)item).Attributes.WeaponDamage += WeaponDamageAdd;
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
						from.SendMessage( "You cannot add Weapon Damage to that item there!" ); 
					}
					else
					{
						WeaponDamageAdd = WeaponDamageToAdd(((BaseArmor)item).Attributes.WeaponDamage, WeaponDamageAdd, WeaponDamageCap, from);
						if( WeaponDamageAdd > 0 )
						{
							((BaseArmor)item).Attributes.WeaponDamage += WeaponDamageAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Weapon Damage to that item there!" ); 
					}
					else
					{
						WeaponDamageAdd = WeaponDamageToAdd(((BaseClothing)item).Attributes.WeaponDamage, WeaponDamageAdd, WeaponDamageCap, from);
						if( WeaponDamageAdd > 0 )
						{
							((BaseClothing)item).Attributes.WeaponDamage += WeaponDamageAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Weapon Damage to that item there!" ); 
					}
					else
					{
						WeaponDamageAdd = WeaponDamageToAdd(((BaseTalisman)item).Attributes.WeaponDamage, WeaponDamageAdd, WeaponDamageCap, from);
						if( WeaponDamageAdd > 0 )
						{
							((BaseTalisman)item).Attributes.WeaponDamage += WeaponDamageAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Weapon Damage to that item there!" ); 
					}
					else
					{
						WeaponDamageAdd = WeaponDamageToAdd(((BaseJewel)item).Attributes.WeaponDamage, WeaponDamageAdd, WeaponDamageCap, from);
						if( WeaponDamageAdd > 0 )
						{
							((BaseJewel)item).Attributes.WeaponDamage += WeaponDamageAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Weapon Damage to that item there!" ); 
					}
					else
					{
						WeaponDamageAdd = WeaponDamageToAdd(((Spellbook)item).Attributes.WeaponDamage, WeaponDamageAdd, WeaponDamageCap, from);
						if( WeaponDamageAdd > 0 )
						{
							((Spellbook)item).Attributes.WeaponDamage += WeaponDamageAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Weapon Damage to that item there!" ); 
					}
					else
					{
						WeaponDamageAdd = WeaponDamageToAdd(((BaseQuiver)item).Attributes.WeaponDamage, WeaponDamageAdd, WeaponDamageCap, from);
						if( WeaponDamageAdd > 0 )
						{
							((BaseQuiver)item).Attributes.WeaponDamage += WeaponDamageAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int WeaponDamageToAdd(int itemWeaponDamage, int WeaponDamageAdd ,int WeaponDamageCap, Mobile from)
		{
			int ret = 0;
			if(itemWeaponDamage < WeaponDamageCap)
			{
				if( (itemWeaponDamage + WeaponDamageAdd ) > WeaponDamageCap )
				{
					ret = WeaponDamageAdd - ( (itemWeaponDamage + WeaponDamageAdd ) - WeaponDamageCap );
					from.SendMessage("You increase the Weapon Damage on the item and it has now reached it's max. +"+ret+" Weapon Damage has been added.");
				}
				else{
					from.SendMessage( "You increase the Weapon Damage on the item. +"+WeaponDamageAdd+" Weapon Damage has been added." );
					ret = WeaponDamageAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Weapon Damage." );
			}
			
			return ret;
		}
	}

	public class WeaponDamageIncreaseDeed : Item
	{
		[Constructable]
		public WeaponDamageIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Weapon Damage Increase Deed";
			LootType = LootType.Blessed;
		}

		public WeaponDamageIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Weapon Damage?"  );
				from.Target = new WeaponDamageIncreaseTarget( this );
			}
		}	
	}
}