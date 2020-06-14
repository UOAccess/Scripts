//Add HitLeechMana to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitLeechManaIncreaseTarget : Target
	{			
		private HitLeechManaIncreaseDeed m_Deed;

		public HitLeechManaIncreaseTarget( HitLeechManaIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitLeechManaAdd = 1; //Amount of Hit Leech Mana to be added
			int HitLeechManaCap = 100; //Limit of Hit Leech Mana that an item can have
			
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
						from.SendMessage( "You cannot add Hit Leech Mana to that item there!" ); 
					}
					else
					{
						HitLeechManaAdd = HitLeechManaToAdd(((BaseWeapon)item).WeaponAttributes.HitLeechMana, HitLeechManaAdd, HitLeechManaCap, from);
						if( HitLeechManaAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitLeechMana += HitLeechManaAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitLeechManaToAdd(int itemHitLeechMana, int HitLeechManaAdd ,int HitLeechManaCap, Mobile from)
		{
			int ret = 0;
			if(itemHitLeechMana < HitLeechManaCap)
			{
				if( (itemHitLeechMana + HitLeechManaAdd ) > HitLeechManaCap )
				{
					ret = HitLeechManaAdd - ( (itemHitLeechMana + HitLeechManaAdd ) - HitLeechManaCap );
					from.SendMessage("You increase the Hit Leech Mana on the item and it has now reached it's max. +"+ret+" Hit Leech Mana has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Leech Mana on the item. +"+HitLeechManaAdd+" Hit Leech Mana has been added." );
					ret = HitLeechManaAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Leech Mana." );
			}
			
			return ret;
		}
	}

	public class HitLeechManaIncreaseDeed : Item
	{
		[Constructable]
		public HitLeechManaIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Leech Mana Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitLeechManaIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Leech Mana?"  );
				from.Target = new HitLeechManaIncreaseTarget( this );
			}
		}	
	}
}