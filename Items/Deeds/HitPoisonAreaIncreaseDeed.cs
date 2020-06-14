//Add HitPoisonArea to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitPoisonAreaIncreaseTarget : Target
	{			
		private HitPoisonAreaIncreaseDeed m_Deed;

		public HitPoisonAreaIncreaseTarget( HitPoisonAreaIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitPoisonAreaAdd = 1; //Amount of Hit Poison Area to be added
			int HitPoisonAreaCap = 100; //Limit of Hit Poison Area that an item can have
			
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
						from.SendMessage( "You cannot add Hit Poison Area to that item there!" ); 
					}
					else
					{
						HitPoisonAreaAdd = HitPoisonAreaToAdd(((BaseWeapon)item).WeaponAttributes.HitPoisonArea, HitPoisonAreaAdd, HitPoisonAreaCap, from);
						if( HitPoisonAreaAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitPoisonArea += HitPoisonAreaAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitPoisonAreaToAdd(int itemHitPoisonArea, int HitPoisonAreaAdd ,int HitPoisonAreaCap, Mobile from)
		{
			int ret = 0;
			if(itemHitPoisonArea < HitPoisonAreaCap)
			{
				if( (itemHitPoisonArea + HitPoisonAreaAdd ) > HitPoisonAreaCap )
				{
					ret = HitPoisonAreaAdd - ( (itemHitPoisonArea + HitPoisonAreaAdd ) - HitPoisonAreaCap );
					from.SendMessage("You increase the Hit Poison Area on the item and it has now reached it's max. +"+ret+" Hit Poison Area has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Poison Area on the item. +"+HitPoisonAreaAdd+" Hit Poison Area has been added." );
					ret = HitPoisonAreaAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Poison Area." );
			}
			
			return ret;
		}
	}

	public class HitPoisonAreaIncreaseDeed : Item
	{
		[Constructable]
		public HitPoisonAreaIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Poison Area Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitPoisonAreaIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Poison Area?"  );
				from.Target = new HitPoisonAreaIncreaseTarget( this );
			}
		}	
	}
}