//Add HitLeechHits to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitLeechHitsIncreaseTarget : Target
	{			
		private HitLeechHitsIncreaseDeed m_Deed;

		public HitLeechHitsIncreaseTarget( HitLeechHitsIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitLeechHitsAdd = 1; //Amount of Hit Leech Hits to be added
			int HitLeechHitsCap = 100; //Limit of Hit Leech Hits that an item can have
			
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
						from.SendMessage( "You cannot add Hit Leech Hits to that item there!" ); 
					}
					else
					{
						HitLeechHitsAdd = HitLeechHitsToAdd(((BaseWeapon)item).WeaponAttributes.HitLeechHits, HitLeechHitsAdd, HitLeechHitsCap, from);
						if( HitLeechHitsAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitLeechHits += HitLeechHitsAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitLeechHitsToAdd(int itemHitLeechHits, int HitLeechHitsAdd ,int HitLeechHitsCap, Mobile from)
		{
			int ret = 0;
			if(itemHitLeechHits < HitLeechHitsCap)
			{
				if( (itemHitLeechHits + HitLeechHitsAdd ) > HitLeechHitsCap )
				{
					ret = HitLeechHitsAdd - ( (itemHitLeechHits + HitLeechHitsAdd ) - HitLeechHitsCap );
					from.SendMessage("You increase the Hit Leech Hits on the item and it has now reached it's max. +"+ret+" Hit Leech Hits has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Leech Hits on the item. +"+HitLeechHitsAdd+" Hit Leech Hits has been added." );
					ret = HitLeechHitsAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Leech Hits." );
			}
			
			return ret;
		}
	}

	public class HitLeechHitsIncreaseDeed : Item
	{
		[Constructable]
		public HitLeechHitsIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Leech Hits Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitLeechHitsIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Leech Hits?"  );
				from.Target = new HitLeechHitsIncreaseTarget( this );
			}
		}	
	}
}