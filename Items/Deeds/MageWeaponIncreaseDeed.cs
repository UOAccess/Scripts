//Add MageWeapon to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class MageWeaponIncreaseTarget : Target
	{			
		private MageWeaponIncreaseDeed m_Deed;

		public MageWeaponIncreaseTarget( MageWeaponIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int MageWeaponAdd = 1; //Amount of Mage Weapon to be added
			int MageWeaponCap = 100; //Limit of Mage Weapon that an item can have
			
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
						from.SendMessage( "You cannot add Mage Weapon to that item there!" ); 
					}
					else
					{
						MageWeaponAdd = MageWeaponToAdd(((BaseWeapon)item).WeaponAttributes.MageWeapon, MageWeaponAdd, MageWeaponCap, from);
						if( MageWeaponAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.MageWeapon += MageWeaponAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int MageWeaponToAdd(int itemMageWeapon, int MageWeaponAdd ,int MageWeaponCap, Mobile from)
		{
			int ret = 0;
			if(itemMageWeapon < MageWeaponCap)
			{
				if( (itemMageWeapon + MageWeaponAdd ) > MageWeaponCap )
				{
					ret = MageWeaponAdd - ( (itemMageWeapon + MageWeaponAdd ) - MageWeaponCap );
					from.SendMessage("You increase the Mage Weapon on the item and it has now reached it's max. +"+ret+" Mage Weapon has been added.");
				}
				else{
					from.SendMessage( "You increase the Mage Weapon on the item. +"+MageWeaponAdd+" Mage Weapon has been added." );
					ret = MageWeaponAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Mage Weapon." );
			}
			
			return ret;
		}
	}

	public class MageWeaponIncreaseDeed : Item
	{
		[Constructable]
		public MageWeaponIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Mage Weapon Increase Deed";
			LootType = LootType.Blessed;
		}

		public MageWeaponIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Mage Weapon?"  );
				from.Target = new MageWeaponIncreaseTarget( this );
			}
		}	
	}
}