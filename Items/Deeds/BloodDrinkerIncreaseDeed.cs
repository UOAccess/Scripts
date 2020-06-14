//Add BloodDrinker to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class BloodDrinkerIncreaseTarget : Target
	{			
		private BloodDrinkerIncreaseDeed m_Deed;

		public BloodDrinkerIncreaseTarget( BloodDrinkerIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int BloodDrinkerAdd = 1; //Amount of BloodDrinker to be added
			int BloodDrinkerCap = 1; //Limit of BloodDrinker that an item can have
			
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
						from.SendMessage( "You cannot add BloodDrinker to that item there!" ); 
					}
					else
					{
						BloodDrinkerAdd = BloodDrinkerToAdd(((BaseWeapon)item).WeaponAttributes.BloodDrinker, BloodDrinkerAdd, BloodDrinkerCap, from);
						if( BloodDrinkerAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.BloodDrinker += BloodDrinkerAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int BloodDrinkerToAdd(int itemBloodDrinker, int BloodDrinkerAdd ,int BloodDrinkerCap, Mobile from)
		{
			int ret = 0;
			if(itemBloodDrinker < BloodDrinkerCap)
			{
				if( (itemBloodDrinker + BloodDrinkerAdd ) > BloodDrinkerCap )
				{
					ret = BloodDrinkerAdd - ( (itemBloodDrinker + BloodDrinkerAdd ) - BloodDrinkerCap );
					from.SendMessage("You increase the BloodDrinker on the item and it has now reached it's max. +"+ret+" BloodDrinker has been added.");
				}
				else{
					from.SendMessage( "You increase the BloodDrinker on the item. +"+BloodDrinkerAdd+" BloodDrinker has been added." );
					ret = BloodDrinkerAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of BloodDrinker." );
			}
			
			return ret;
		}
	}

	public class BloodDrinkerIncreaseDeed : Item
	{
		[Constructable]
		public BloodDrinkerIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "BloodDrinker Increase Deed";
			LootType = LootType.Blessed;
		}

		public BloodDrinkerIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase BloodDrinker?"  );
				from.Target = new BloodDrinkerIncreaseTarget( this );
			}
		}	
	}
}