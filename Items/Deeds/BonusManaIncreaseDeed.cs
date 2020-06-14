//Add BonusMana to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class BonusManaIncreaseTarget : Target
	{			
		private BonusManaIncreaseDeed m_Deed;

		public BonusManaIncreaseTarget( BonusManaIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int BonusManaAdd = 1; //Amount ofBonus Mana to be added
			int BonusManaCap = 100; //Limit ofBonus Mana that an item can have
			
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
						from.SendMessage( "You cannot addBonus Mana to that item there!" ); 
					}
					else
					{
						BonusManaAdd = BonusManaToAdd(((BaseWeapon)item).Attributes.BonusMana, BonusManaAdd, BonusManaCap, from);
						if( BonusManaAdd > 0 )
						{
							((BaseWeapon)item).Attributes.BonusMana += BonusManaAdd;
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
						from.SendMessage( "You cannot addBonus Mana to that item there!" ); 
					}
					else
					{
						BonusManaAdd = BonusManaToAdd(((BaseArmor)item).Attributes.BonusMana, BonusManaAdd, BonusManaCap, from);
						if( BonusManaAdd > 0 )
						{
							((BaseArmor)item).Attributes.BonusMana += BonusManaAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Mana to that item there!" ); 
					}
					else
					{
						BonusManaAdd = BonusManaToAdd(((BaseClothing)item).Attributes.BonusMana, BonusManaAdd, BonusManaCap, from);
						if( BonusManaAdd > 0 )
						{
							((BaseClothing)item).Attributes.BonusMana += BonusManaAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Mana to that item there!" ); 
					}
					else
					{
						BonusManaAdd = BonusManaToAdd(((BaseTalisman)item).Attributes.BonusMana, BonusManaAdd, BonusManaCap, from);
						if( BonusManaAdd > 0 )
						{
							((BaseTalisman)item).Attributes.BonusMana += BonusManaAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Mana to that item there!" ); 
					}
					else
					{
						BonusManaAdd = BonusManaToAdd(((BaseJewel)item).Attributes.BonusMana, BonusManaAdd, BonusManaCap, from);
						if( BonusManaAdd > 0 )
						{
							((BaseJewel)item).Attributes.BonusMana += BonusManaAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Mana to that item there!" ); 
					}
					else
					{
						BonusManaAdd = BonusManaToAdd(((Spellbook)item).Attributes.BonusMana, BonusManaAdd, BonusManaCap, from);
						if( BonusManaAdd > 0 )
						{
							((Spellbook)item).Attributes.BonusMana += BonusManaAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Mana to that item there!" ); 
					}
					else
					{
						BonusManaAdd = BonusManaToAdd(((BaseQuiver)item).Attributes.BonusMana, BonusManaAdd, BonusManaCap, from);
						if( BonusManaAdd > 0 )
						{
							((BaseQuiver)item).Attributes.BonusMana += BonusManaAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int BonusManaToAdd(int itemBonusMana, int BonusManaAdd ,int BonusManaCap, Mobile from)
		{
			int ret = 0;
			if(itemBonusMana < BonusManaCap)
			{
				if( (itemBonusMana + BonusManaAdd ) > BonusManaCap )
				{
					ret = BonusManaAdd - ( (itemBonusMana + BonusManaAdd ) - BonusManaCap );
					from.SendMessage("You increase theBonus Mana on the item and it has now reached it's max. +"+ret+"Bonus Mana has been added.");
				}
				else{
					from.SendMessage( "You increase theBonus Mana on the item. +"+BonusManaAdd+"Bonus Mana has been added." );
					ret = BonusManaAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount ofBonus Mana." );
			}
			
			return ret;
		}
	}

	public class BonusManaIncreaseDeed : Item
	{
		[Constructable]
		public BonusManaIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Bonus Mana Increase Deed";
			LootType = LootType.Blessed;
		}

		public BonusManaIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increaseBonus Mana?"  );
				from.Target = new BonusManaIncreaseTarget( this );
			}
		}	
	}
}