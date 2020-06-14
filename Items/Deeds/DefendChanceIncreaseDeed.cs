//Add DefendChance to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class DefendChanceIncreaseTarget : Target
	{			
		private DefendChanceIncreaseDeed m_Deed;

		public DefendChanceIncreaseTarget( DefendChanceIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int DefendChanceAdd = 1; //Amount of Defend Chance to be added
			int DefendChanceCap = 100; //Limit of Defend Chance that an item can have
			
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
						from.SendMessage( "You cannot add Defend Chance to that item there!" ); 
					}
					else
					{
						DefendChanceAdd = DefendChanceToAdd(((BaseWeapon)item).Attributes.DefendChance, DefendChanceAdd, DefendChanceCap, from);
						if( DefendChanceAdd > 0 )
						{
							((BaseWeapon)item).Attributes.DefendChance += DefendChanceAdd;
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
						from.SendMessage( "You cannot add Defend Chance to that item there!" ); 
					}
					else
					{
						DefendChanceAdd = DefendChanceToAdd(((BaseArmor)item).Attributes.DefendChance, DefendChanceAdd, DefendChanceCap, from);
						if( DefendChanceAdd > 0 )
						{
							((BaseArmor)item).Attributes.DefendChance += DefendChanceAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Defend Chance to that item there!" ); 
					}
					else
					{
						DefendChanceAdd = DefendChanceToAdd(((BaseClothing)item).Attributes.DefendChance, DefendChanceAdd, DefendChanceCap, from);
						if( DefendChanceAdd > 0 )
						{
							((BaseClothing)item).Attributes.DefendChance += DefendChanceAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Defend Chance to that item there!" ); 
					}
					else
					{
						DefendChanceAdd = DefendChanceToAdd(((BaseTalisman)item).Attributes.DefendChance, DefendChanceAdd, DefendChanceCap, from);
						if( DefendChanceAdd > 0 )
						{
							((BaseTalisman)item).Attributes.DefendChance += DefendChanceAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Defend Chance to that item there!" ); 
					}
					else
					{
						DefendChanceAdd = DefendChanceToAdd(((BaseJewel)item).Attributes.DefendChance, DefendChanceAdd, DefendChanceCap, from);
						if( DefendChanceAdd > 0 )
						{
							((BaseJewel)item).Attributes.DefendChance += DefendChanceAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Defend Chance to that item there!" ); 
					}
					else
					{
						DefendChanceAdd = DefendChanceToAdd(((Spellbook)item).Attributes.DefendChance, DefendChanceAdd, DefendChanceCap, from);
						if( DefendChanceAdd > 0 )
						{
							((Spellbook)item).Attributes.DefendChance += DefendChanceAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Defend Chance to that item there!" ); 
					}
					else
					{
						DefendChanceAdd = DefendChanceToAdd(((BaseQuiver)item).Attributes.DefendChance, DefendChanceAdd, DefendChanceCap, from);
						if( DefendChanceAdd > 0 )
						{
							((BaseQuiver)item).Attributes.DefendChance += DefendChanceAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int DefendChanceToAdd(int itemDefendChance, int DefendChanceAdd ,int DefendChanceCap, Mobile from)
		{
			int ret = 0;
			if(itemDefendChance < DefendChanceCap)
			{
				if( (itemDefendChance + DefendChanceAdd ) > DefendChanceCap )
				{
					ret = DefendChanceAdd - ( (itemDefendChance + DefendChanceAdd ) - DefendChanceCap );
					from.SendMessage("You increase the Defend Chance on the item and it has now reached it's max. +"+ret+" Defend Chance has been added.");
				}
				else{
					from.SendMessage( "You increase the Defend Chance on the item. +"+DefendChanceAdd+" Defend Chance has been added." );
					ret = DefendChanceAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Defend Chance." );
			}
			
			return ret;
		}
	}

	public class DefendChanceIncreaseDeed : Item
	{
		[Constructable]
		public DefendChanceIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Defend Chance Increase Deed";
			LootType = LootType.Blessed;
		}

		public DefendChanceIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Defend Chance?"  );
				from.Target = new DefendChanceIncreaseTarget( this );
			}
		}	
	}
}