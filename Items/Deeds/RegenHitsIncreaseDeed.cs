//Add RegenHits to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class RegenHitsIncreaseTarget : Target
	{			
		private RegenHitsIncreaseDeed m_Deed;

		public RegenHitsIncreaseTarget( RegenHitsIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int RegenHitsAdd = 1; //Amount of Regen Hits to be added
			int RegenHitsCap = 100; //Limit of Regen Hits that an item can have
			
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
						from.SendMessage( "You cannot addRegen Hits to that item there!" ); 
					}
					else
					{
						RegenHitsAdd = RegenHitsToAdd(((BaseWeapon)item).Attributes.RegenHits, RegenHitsAdd, RegenHitsCap, from);
						if( RegenHitsAdd > 0 )
						{
							((BaseWeapon)item).Attributes.RegenHits += RegenHitsAdd;
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
						from.SendMessage( "You cannot addRegen Hits to that item there!" ); 
					}
					else
					{
						RegenHitsAdd = RegenHitsToAdd(((BaseArmor)item).Attributes.RegenHits, RegenHitsAdd, RegenHitsCap, from);
						if( RegenHitsAdd > 0 )
						{
							((BaseArmor)item).Attributes.RegenHits += RegenHitsAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Hits to that item there!" ); 
					}
					else
					{
						RegenHitsAdd = RegenHitsToAdd(((BaseClothing)item).Attributes.RegenHits, RegenHitsAdd, RegenHitsCap, from);
						if( RegenHitsAdd > 0 )
						{
							((BaseClothing)item).Attributes.RegenHits += RegenHitsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Hits to that item there!" ); 
					}
					else
					{
						RegenHitsAdd = RegenHitsToAdd(((BaseTalisman)item).Attributes.RegenHits, RegenHitsAdd, RegenHitsCap, from);
						if( RegenHitsAdd > 0 )
						{
							((BaseTalisman)item).Attributes.RegenHits += RegenHitsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Hits to that item there!" ); 
					}
					else
					{
						RegenHitsAdd = RegenHitsToAdd(((BaseJewel)item).Attributes.RegenHits, RegenHitsAdd, RegenHitsCap, from);
						if( RegenHitsAdd > 0 )
						{
							((BaseJewel)item).Attributes.RegenHits += RegenHitsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Hits to that item there!" ); 
					}
					else
					{
						RegenHitsAdd = RegenHitsToAdd(((Spellbook)item).Attributes.RegenHits, RegenHitsAdd, RegenHitsCap, from);
						if( RegenHitsAdd > 0 )
						{
							((Spellbook)item).Attributes.RegenHits += RegenHitsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Hits to that item there!" ); 
					}
					else
					{
						RegenHitsAdd = RegenHitsToAdd(((BaseQuiver)item).Attributes.RegenHits, RegenHitsAdd, RegenHitsCap, from);
						if( RegenHitsAdd > 0 )
						{
							((BaseQuiver)item).Attributes.RegenHits += RegenHitsAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int RegenHitsToAdd(int itemRegenHits, int RegenHitsAdd ,int RegenHitsCap, Mobile from)
		{
			int ret = 0;
			if(itemRegenHits < RegenHitsCap)
			{
				if( (itemRegenHits + RegenHitsAdd ) > RegenHitsCap )
				{
					ret = RegenHitsAdd - ( (itemRegenHits + RegenHitsAdd ) - RegenHitsCap );
					from.SendMessage("You increase theRegen Hits on the item and it has now reached it's max. +"+ret+"Regen Hits has been added.");
				}
				else{
					from.SendMessage( "You increase theRegen Hits on the item. +"+RegenHitsAdd+"Regen Hits has been added." );
					ret = RegenHitsAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Regen Hits." );
			}
			
			return ret;
		}
	}

	public class RegenHitsIncreaseDeed : Item
	{
		[Constructable]
		public RegenHitsIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1Regen Hits Increase Deed";
			LootType = LootType.Blessed;
		}

		public RegenHitsIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increaseRegen Hits?"  );
				from.Target = new RegenHitsIncreaseTarget( this );
			}
		}	
	}
}