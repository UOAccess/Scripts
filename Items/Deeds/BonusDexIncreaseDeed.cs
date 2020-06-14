//Add BonusDex to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class BonusDexIncreaseTarget : Target
	{			
		private BonusDexIncreaseDeed m_Deed;

		public BonusDexIncreaseTarget( BonusDexIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int BonusDexAdd = 1; //Amount of Bonus Dex to be added
			int BonusDexCap = 100; //Limit of Bonus Dex that an item can have
			
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
						from.SendMessage( "You cannot add Bonus Dex to that item there!" ); 
					}
					else
					{
						BonusDexAdd = BonusDexToAdd(((BaseWeapon)item).Attributes.BonusDex, BonusDexAdd, BonusDexCap, from);
						if( BonusDexAdd > 0 )
						{
							((BaseWeapon)item).Attributes.BonusDex += BonusDexAdd;
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
						from.SendMessage( "You cannot add Bonus Dex to that item there!" ); 
					}
					else
					{
						BonusDexAdd = BonusDexToAdd(((BaseArmor)item).Attributes.BonusDex, BonusDexAdd, BonusDexCap, from);
						if( BonusDexAdd > 0 )
						{
							((BaseArmor)item).Attributes.BonusDex += BonusDexAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Dex to that item there!" ); 
					}
					else
					{
						BonusDexAdd = BonusDexToAdd(((BaseClothing)item).Attributes.BonusDex, BonusDexAdd, BonusDexCap, from);
						if( BonusDexAdd > 0 )
						{
							((BaseClothing)item).Attributes.BonusDex += BonusDexAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Dex to that item there!" ); 
					}
					else
					{
						BonusDexAdd = BonusDexToAdd(((BaseTalisman)item).Attributes.BonusDex, BonusDexAdd, BonusDexCap, from);
						if( BonusDexAdd > 0 )
						{
							((BaseTalisman)item).Attributes.BonusDex += BonusDexAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Dex to that item there!" ); 
					}
					else
					{
						BonusDexAdd = BonusDexToAdd(((BaseJewel)item).Attributes.BonusDex, BonusDexAdd, BonusDexCap, from);
						if( BonusDexAdd > 0 )
						{
							((BaseJewel)item).Attributes.BonusDex += BonusDexAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Dex to that item there!" ); 
					}
					else
					{
						BonusDexAdd = BonusDexToAdd(((Spellbook)item).Attributes.BonusDex, BonusDexAdd, BonusDexCap, from);
						if( BonusDexAdd > 0 )
						{
							((Spellbook)item).Attributes.BonusDex += BonusDexAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Dex to that item there!" ); 
					}
					else
					{
						BonusDexAdd = BonusDexToAdd(((BaseQuiver)item).Attributes.BonusDex, BonusDexAdd, BonusDexCap, from);
						if( BonusDexAdd > 0 )
						{
							((BaseQuiver)item).Attributes.BonusDex += BonusDexAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int BonusDexToAdd(int itemBonusDex, int BonusDexAdd ,int BonusDexCap, Mobile from)
		{
			int ret = 0;
			if(itemBonusDex < BonusDexCap)
			{
				if( (itemBonusDex + BonusDexAdd ) > BonusDexCap )
				{
					ret = BonusDexAdd - ( (itemBonusDex + BonusDexAdd ) - BonusDexCap );
					from.SendMessage("You increase the Bonus Dex on the item and it has now reached it's max. +"+ret+" Bonus Dex has been added.");
				}
				else{
					from.SendMessage( "You increase the Bonus Dex on the item. +"+BonusDexAdd+" Bonus Dex has been added." );
					ret = BonusDexAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Bonus Dex." );
			}
			
			return ret;
		}
	}

	public class BonusDexIncreaseDeed : Item
	{
		[Constructable]
		public BonusDexIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Bonus Dex Increase Deed";
			LootType = LootType.Blessed;
		}

		public BonusDexIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Bonus Dex?"  );
				from.Target = new BonusDexIncreaseTarget( this );
			}
		}	
	}
}