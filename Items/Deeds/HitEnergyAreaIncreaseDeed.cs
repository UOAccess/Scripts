//Add HitEnergyArea to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitEnergyAreaIncreaseTarget : Target
	{			
		private HitEnergyAreaIncreaseDeed m_Deed;

		public HitEnergyAreaIncreaseTarget( HitEnergyAreaIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitEnergyAreaAdd = 1; //Amount of Hit Energy Area to be added
			int HitEnergyAreaCap = 100; //Limit of Hit Energy Area that an item can have
			
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
						from.SendMessage( "You cannot add Hit Energy Area to that item there!" ); 
					}
					else
					{
						HitEnergyAreaAdd = HitEnergyAreaToAdd(((BaseWeapon)item).WeaponAttributes.HitEnergyArea, HitEnergyAreaAdd, HitEnergyAreaCap, from);
						if( HitEnergyAreaAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitEnergyArea += HitEnergyAreaAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitEnergyAreaToAdd(int itemHitEnergyArea, int HitEnergyAreaAdd ,int HitEnergyAreaCap, Mobile from)
		{
			int ret = 0;
			if(itemHitEnergyArea < HitEnergyAreaCap)
			{
				if( (itemHitEnergyArea + HitEnergyAreaAdd ) > HitEnergyAreaCap )
				{
					ret = HitEnergyAreaAdd - ( (itemHitEnergyArea + HitEnergyAreaAdd ) - HitEnergyAreaCap );
					from.SendMessage("You increase the Hit Energy Area on the item and it has now reached it's max. +"+ret+" Hit Energy Area has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Energy Area on the item. +"+HitEnergyAreaAdd+" Hit Energy Area has been added." );
					ret = HitEnergyAreaAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Energy Area." );
			}
			
			return ret;
		}
	}

	public class HitEnergyAreaIncreaseDeed : Item
	{
		[Constructable]
		public HitEnergyAreaIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Energy Area Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitEnergyAreaIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Energy Area?"  );
				from.Target = new HitEnergyAreaIncreaseTarget( this );
			}
		}	
	}
}