//Add BonusInt to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class BonusIntIncreaseTarget : Target
	{			
		private BonusIntIncreaseDeed m_Deed;

		public BonusIntIncreaseTarget( BonusIntIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int BonusIntAdd = 1; //Amount of Bonus Int to be added
			int BonusIntCap = 100; //Limit of Bonus Int that an item can have
			
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
						from.SendMessage( "You cannot add Bonus Int to that item there!" ); 
					}
					else
					{
						BonusIntAdd = BonusIntToAdd(((BaseWeapon)item).Attributes.BonusInt, BonusIntAdd, BonusIntCap, from);
						if( BonusIntAdd > 0 )
						{
							((BaseWeapon)item).Attributes.BonusInt += BonusIntAdd;
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
						from.SendMessage( "You cannot add Bonus Int to that item there!" ); 
					}
					else
					{
						BonusIntAdd = BonusIntToAdd(((BaseArmor)item).Attributes.BonusInt, BonusIntAdd, BonusIntCap, from);
						if( BonusIntAdd > 0 )
						{
							((BaseArmor)item).Attributes.BonusInt += BonusIntAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Int to that item there!" ); 
					}
					else
					{
						BonusIntAdd = BonusIntToAdd(((BaseClothing)item).Attributes.BonusInt, BonusIntAdd, BonusIntCap, from);
						if( BonusIntAdd > 0 )
						{
							((BaseClothing)item).Attributes.BonusInt += BonusIntAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Int to that item there!" ); 
					}
					else
					{
						BonusIntAdd = BonusIntToAdd(((BaseTalisman)item).Attributes.BonusInt, BonusIntAdd, BonusIntCap, from);
						if( BonusIntAdd > 0 )
						{
							((BaseTalisman)item).Attributes.BonusInt += BonusIntAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Int to that item there!" ); 
					}
					else
					{
						BonusIntAdd = BonusIntToAdd(((BaseJewel)item).Attributes.BonusInt, BonusIntAdd, BonusIntCap, from);
						if( BonusIntAdd > 0 )
						{
							((BaseJewel)item).Attributes.BonusInt += BonusIntAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Int to that item there!" ); 
					}
					else
					{
						BonusIntAdd = BonusIntToAdd(((Spellbook)item).Attributes.BonusInt, BonusIntAdd, BonusIntCap, from);
						if( BonusIntAdd > 0 )
						{
							((Spellbook)item).Attributes.BonusInt += BonusIntAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Bonus Int to that item there!" ); 
					}
					else
					{
						BonusIntAdd = BonusIntToAdd(((BaseQuiver)item).Attributes.BonusInt, BonusIntAdd, BonusIntCap, from);
						if( BonusIntAdd > 0 )
						{
							((BaseQuiver)item).Attributes.BonusInt += BonusIntAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int BonusIntToAdd(int itemBonusInt, int BonusIntAdd ,int BonusIntCap, Mobile from)
		{
			int ret = 0;
			if(itemBonusInt < BonusIntCap)
			{
				if( (itemBonusInt + BonusIntAdd ) > BonusIntCap )
				{
					ret = BonusIntAdd - ( (itemBonusInt + BonusIntAdd ) - BonusIntCap );
					from.SendMessage("You increase the Bonus Int on the item and it has now reached it's max. +"+ret+" Bonus Int has been added.");
				}
				else{
					from.SendMessage( "You increase the Bonus Int on the item. +"+BonusIntAdd+" Bonus Int has been added." );
					ret = BonusIntAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Bonus Int." );
			}
			
			return ret;
		}
	}

	public class BonusIntIncreaseDeed : Item
	{
		[Constructable]
		public BonusIntIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Bonus Int Increase Deed";
			LootType = LootType.Blessed;
		}

		public BonusIntIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Bonus Int?"  );
				from.Target = new BonusIntIncreaseTarget( this );
			}
		}	
	}
}