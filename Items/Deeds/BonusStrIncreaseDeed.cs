//Add BonusStr to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class BonusStrIncreaseTarget : Target
	{			
		private BonusStrIncreaseDeed m_Deed;

		public BonusStrIncreaseTarget( BonusStrIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int BonusStrAdd = 1; //Amount of Bonus Str to be added
			int BonusStrCap = 100; //Limit of Bonus Str that an item can have
			
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
						from.SendMessage( "You cannot add Bonus Str to that item there!" ); 
					}
					else
					{
						BonusStrAdd = BonusStrToAdd(((BaseWeapon)item).Attributes.BonusStr, BonusStrAdd, BonusStrCap, from);
						if( BonusStrAdd > 0 )
						{
							((BaseWeapon)item).Attributes.BonusStr += BonusStrAdd;
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
						from.SendMessage( "You cannot add Bonus Str to that item there!" ); 
					}
					else
					{
						BonusStrAdd = BonusStrToAdd(((BaseArmor)item).Attributes.BonusStr, BonusStrAdd, BonusStrCap, from);
						if( BonusStrAdd > 0 )
						{
							((BaseArmor)item).Attributes.BonusStr += BonusStrAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Str to that item there!" ); 
					}
					else
					{
						BonusStrAdd = BonusStrToAdd(((BaseClothing)item).Attributes.BonusStr, BonusStrAdd, BonusStrCap, from);
						if( BonusStrAdd > 0 )
						{
							((BaseClothing)item).Attributes.BonusStr += BonusStrAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Str to that item there!" ); 
					}
					else
					{
						BonusStrAdd = BonusStrToAdd(((BaseTalisman)item).Attributes.BonusStr, BonusStrAdd, BonusStrCap, from);
						if( BonusStrAdd > 0 )
						{
							((BaseTalisman)item).Attributes.BonusStr += BonusStrAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Str to that item there!" ); 
					}
					else
					{
						BonusStrAdd = BonusStrToAdd(((BaseJewel)item).Attributes.BonusStr, BonusStrAdd, BonusStrCap, from);
						if( BonusStrAdd > 0 )
						{
							((BaseJewel)item).Attributes.BonusStr += BonusStrAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Str to that item there!" ); 
					}
					else
					{
						BonusStrAdd = BonusStrToAdd(((Spellbook)item).Attributes.BonusStr, BonusStrAdd, BonusStrCap, from);
						if( BonusStrAdd > 0 )
						{
							((Spellbook)item).Attributes.BonusStr += BonusStrAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Str to that item there!" ); 
					}
					else
					{
						BonusStrAdd = BonusStrToAdd(((BaseQuiver)item).Attributes.BonusStr, BonusStrAdd, BonusStrCap, from);
						if( BonusStrAdd > 0 )
						{
							((BaseQuiver)item).Attributes.BonusStr += BonusStrAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int BonusStrToAdd(int itemBonusStr, int BonusStrAdd ,int BonusStrCap, Mobile from)
		{
			int ret = 0;
			if(itemBonusStr < BonusStrCap)
			{
				if( (itemBonusStr + BonusStrAdd ) > BonusStrCap )
				{
					ret = BonusStrAdd - ( (itemBonusStr + BonusStrAdd ) - BonusStrCap );
					from.SendMessage("You increase the Bonus Str on the item and it has now reached it's max. +"+ret+" Bonus Str has been added.");
				}
				else{
					from.SendMessage( "You increase the Bonus Str on the item. +"+BonusStrAdd+" Bonus Str has been added." );
					ret = BonusStrAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Bonus Str." );
			}
			
			return ret;
		}
	}

	public class BonusStrIncreaseDeed : Item
	{
		[Constructable]
		public BonusStrIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Bonus Str Increase Deed";
			LootType = LootType.Blessed;
		}

		public BonusStrIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Bonus Str?"  );
				from.Target = new BonusStrIncreaseTarget( this );
			}
		}	
	}
}