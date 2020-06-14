//Add BonusStam to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class BonusStamIncreaseTarget : Target
	{			
		private BonusStamIncreaseDeed m_Deed;

		public BonusStamIncreaseTarget( BonusStamIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int BonusStamAdd = 1; //Amount ofBonus Stam to be added
			int BonusStamCap = 100; //Limit ofBonus Stam that an item can have
			
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
						from.SendMessage( "You cannot addBonus Stam to that item there!" ); 
					}
					else
					{
						BonusStamAdd = BonusStamToAdd(((BaseWeapon)item).Attributes.BonusStam, BonusStamAdd, BonusStamCap, from);
						if( BonusStamAdd > 0 )
						{
							((BaseWeapon)item).Attributes.BonusStam += BonusStamAdd;
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
						from.SendMessage( "You cannot addBonus Stam to that item there!" ); 
					}
					else
					{
						BonusStamAdd = BonusStamToAdd(((BaseArmor)item).Attributes.BonusStam, BonusStamAdd, BonusStamCap, from);
						if( BonusStamAdd > 0 )
						{
							((BaseArmor)item).Attributes.BonusStam += BonusStamAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Stam to that item there!" ); 
					}
					else
					{
						BonusStamAdd = BonusStamToAdd(((BaseClothing)item).Attributes.BonusStam, BonusStamAdd, BonusStamCap, from);
						if( BonusStamAdd > 0 )
						{
							((BaseClothing)item).Attributes.BonusStam += BonusStamAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Stam to that item there!" ); 
					}
					else
					{
						BonusStamAdd = BonusStamToAdd(((BaseTalisman)item).Attributes.BonusStam, BonusStamAdd, BonusStamCap, from);
						if( BonusStamAdd > 0 )
						{
							((BaseTalisman)item).Attributes.BonusStam += BonusStamAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Stam to that item there!" ); 
					}
					else
					{
						BonusStamAdd = BonusStamToAdd(((BaseJewel)item).Attributes.BonusStam, BonusStamAdd, BonusStamCap, from);
						if( BonusStamAdd > 0 )
						{
							((BaseJewel)item).Attributes.BonusStam += BonusStamAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Stam to that item there!" ); 
					}
					else
					{
						BonusStamAdd = BonusStamToAdd(((Spellbook)item).Attributes.BonusStam, BonusStamAdd, BonusStamCap, from);
						if( BonusStamAdd > 0 )
						{
							((Spellbook)item).Attributes.BonusStam += BonusStamAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addBonus Stam to that item there!" ); 
					}
					else
					{
						BonusStamAdd = BonusStamToAdd(((BaseQuiver)item).Attributes.BonusStam, BonusStamAdd, BonusStamCap, from);
						if( BonusStamAdd > 0 )
						{
							((BaseQuiver)item).Attributes.BonusStam += BonusStamAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int BonusStamToAdd(int itemBonusStam, int BonusStamAdd ,int BonusStamCap, Mobile from)
		{
			int ret = 0;
			if(itemBonusStam < BonusStamCap)
			{
				if( (itemBonusStam + BonusStamAdd ) > BonusStamCap )
				{
					ret = BonusStamAdd - ( (itemBonusStam + BonusStamAdd ) - BonusStamCap );
					from.SendMessage("You increase theBonus Stam on the item and it has now reached it's max. +"+ret+"Bonus Stam has been added.");
				}
				else{
					from.SendMessage( "You increase theBonus Stam on the item. +"+BonusStamAdd+"Bonus Stam has been added." );
					ret = BonusStamAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount ofBonus Stam." );
			}
			
			return ret;
		}
	}

	public class BonusStamIncreaseDeed : Item
	{
		[Constructable]
		public BonusStamIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Bonus Stam Increase Deed";
			LootType = LootType.Blessed;
		}

		public BonusStamIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increaseBonus Stam?"  );
				from.Target = new BonusStamIncreaseTarget( this );
			}
		}	
	}
}