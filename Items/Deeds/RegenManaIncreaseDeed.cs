//Add RegenMana to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class RegenManaIncreaseTarget : Target
	{			
		private RegenManaIncreaseDeed m_Deed;

		public RegenManaIncreaseTarget( RegenManaIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int RegenManaAdd = 1; //Amount of Regen Mana to be added
			int RegenManaCap = 100; //Limit of Regen Mana that an item can have
			
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
						from.SendMessage( "You cannot addRegen Mana to that item there!" ); 
					}
					else
					{
						RegenManaAdd = RegenManaToAdd(((BaseWeapon)item).Attributes.RegenMana, RegenManaAdd, RegenManaCap, from);
						if( RegenManaAdd > 0 )
						{
							((BaseWeapon)item).Attributes.RegenMana += RegenManaAdd;
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
						from.SendMessage( "You cannot addRegen Mana to that item there!" ); 
					}
					else
					{
						RegenManaAdd = RegenManaToAdd(((BaseArmor)item).Attributes.RegenMana, RegenManaAdd, RegenManaCap, from);
						if( RegenManaAdd > 0 )
						{
							((BaseArmor)item).Attributes.RegenMana += RegenManaAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Mana to that item there!" ); 
					}
					else
					{
						RegenManaAdd = RegenManaToAdd(((BaseClothing)item).Attributes.RegenMana, RegenManaAdd, RegenManaCap, from);
						if( RegenManaAdd > 0 )
						{
							((BaseClothing)item).Attributes.RegenMana += RegenManaAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Mana to that item there!" ); 
					}
					else
					{
						RegenManaAdd = RegenManaToAdd(((BaseTalisman)item).Attributes.RegenMana, RegenManaAdd, RegenManaCap, from);
						if( RegenManaAdd > 0 )
						{
							((BaseTalisman)item).Attributes.RegenMana += RegenManaAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Mana to that item there!" ); 
					}
					else
					{
						RegenManaAdd = RegenManaToAdd(((BaseJewel)item).Attributes.RegenMana, RegenManaAdd, RegenManaCap, from);
						if( RegenManaAdd > 0 )
						{
							((BaseJewel)item).Attributes.RegenMana += RegenManaAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Mana to that item there!" ); 
					}
					else
					{
						RegenManaAdd = RegenManaToAdd(((Spellbook)item).Attributes.RegenMana, RegenManaAdd, RegenManaCap, from);
						if( RegenManaAdd > 0 )
						{
							((Spellbook)item).Attributes.RegenMana += RegenManaAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Mana to that item there!" ); 
					}
					else
					{
						RegenManaAdd = RegenManaToAdd(((BaseQuiver)item).Attributes.RegenMana, RegenManaAdd, RegenManaCap, from);
						if( RegenManaAdd > 0 )
						{
							((BaseQuiver)item).Attributes.RegenMana += RegenManaAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int RegenManaToAdd(int itemRegenMana, int RegenManaAdd ,int RegenManaCap, Mobile from)
		{
			int ret = 0;
			if(itemRegenMana < RegenManaCap)
			{
				if( (itemRegenMana + RegenManaAdd ) > RegenManaCap )
				{
					ret = RegenManaAdd - ( (itemRegenMana + RegenManaAdd ) - RegenManaCap );
					from.SendMessage("You increase theRegen Mana on the item and it has now reached it's max. +"+ret+"Regen Mana has been added.");
				}
				else{
					from.SendMessage( "You increase theRegen Mana on the item. +"+RegenManaAdd+"Regen Mana has been added." );
					ret = RegenManaAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Regen Mana." );
			}
			
			return ret;
		}
	}

	public class RegenManaIncreaseDeed : Item
	{
		[Constructable]
		public RegenManaIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Regen Mana Increase Deed";
			LootType = LootType.Blessed;
		}

		public RegenManaIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increaseRegen Mana?"  );
				from.Target = new RegenManaIncreaseTarget( this );
			}
		}	
	}
}