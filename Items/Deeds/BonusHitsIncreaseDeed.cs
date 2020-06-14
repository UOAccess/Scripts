//Add BonusHits to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class BonusHitsIncreaseTarget : Target
	{			
		private BonusHitsIncreaseDeed m_Deed;

		public BonusHitsIncreaseTarget( BonusHitsIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int BonusHitsAdd = 1; //Amount of Bonus Hits to be added
			int BonusHitsCap = 100; //Limit of Bonus Hits that an item can have
			
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
						from.SendMessage( "You cannot addBonus Hits to that item there!" ); 
					}
					else
					{
						BonusHitsAdd = BonusHitsToAdd(((BaseWeapon)item).Attributes.BonusHits, BonusHitsAdd, BonusHitsCap, from);
						if( BonusHitsAdd > 0 )
						{
							((BaseWeapon)item).Attributes.BonusHits += BonusHitsAdd;
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
						from.SendMessage( "You cannot addBonus Hits to that item there!" ); 
					}
					else
					{
						BonusHitsAdd = BonusHitsToAdd(((BaseArmor)item).Attributes.BonusHits, BonusHitsAdd, BonusHitsCap, from);
						if( BonusHitsAdd > 0 )
						{
							((BaseArmor)item).Attributes.BonusHits += BonusHitsAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Hits to that item there!" ); 
					}
					else
					{
						BonusHitsAdd = BonusHitsToAdd(((BaseClothing)item).Attributes.BonusHits, BonusHitsAdd, BonusHitsCap, from);
						if( BonusHitsAdd > 0 )
						{
							((BaseClothing)item).Attributes.BonusHits += BonusHitsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Hits to that item there!" ); 
					}
					else
					{
						BonusHitsAdd = BonusHitsToAdd(((BaseTalisman)item).Attributes.BonusHits, BonusHitsAdd, BonusHitsCap, from);
						if( BonusHitsAdd > 0 )
						{
							((BaseTalisman)item).Attributes.BonusHits += BonusHitsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Hits to that item there!" ); 
					}
					else
					{
						BonusHitsAdd = BonusHitsToAdd(((BaseJewel)item).Attributes.BonusHits, BonusHitsAdd, BonusHitsCap, from);
						if( BonusHitsAdd > 0 )
						{
							((BaseJewel)item).Attributes.BonusHits += BonusHitsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Hits to that item there!" ); 
					}
					else
					{
						BonusHitsAdd = BonusHitsToAdd(((Spellbook)item).Attributes.BonusHits, BonusHitsAdd, BonusHitsCap, from);
						if( BonusHitsAdd > 0 )
						{
							((Spellbook)item).Attributes.BonusHits += BonusHitsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Hits to that item there!" ); 
					}
					else
					{
						BonusHitsAdd = BonusHitsToAdd(((BaseQuiver)item).Attributes.BonusHits, BonusHitsAdd, BonusHitsCap, from);
						if( BonusHitsAdd > 0 )
						{
							((BaseQuiver)item).Attributes.BonusHits += BonusHitsAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int BonusHitsToAdd(int itemBonusHits, int BonusHitsAdd ,int BonusHitsCap, Mobile from)
		{
			int ret = 0;
			if(itemBonusHits < BonusHitsCap)
			{
				if( (itemBonusHits + BonusHitsAdd ) > BonusHitsCap )
				{
					ret = BonusHitsAdd - ( (itemBonusHits + BonusHitsAdd ) - BonusHitsCap );
					from.SendMessage("You increase theBonus Hits on the item and it has now reached it's max. +"+ret+"Bonus Hits has been added.");
				}
				else{
					from.SendMessage( "You increase theBonus Hits on the item. +"+BonusHitsAdd+"Bonus Hits has been added." );
					ret = BonusHitsAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Bonus Hits." );
			}
			
			return ret;
		}
	}

	public class BonusHitsIncreaseDeed : Item
	{
		[Constructable]
		public BonusHitsIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1Bonus Hits Increase Deed";
			LootType = LootType.Blessed;
		}

		public BonusHitsIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increaseBonus Hits?"  );
				from.Target = new BonusHitsIncreaseTarget( this );
			}
		}	
	}
}