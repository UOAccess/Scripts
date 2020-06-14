//Add LowerRegCost to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class LowerRegCostIncreaseTarget : Target
	{			
		private LowerRegCostIncreaseDeed m_Deed;

		public LowerRegCostIncreaseTarget( LowerRegCostIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int LowerRegCostAdd = 1; //Amount of Lower Reg Cost to be added
			int LowerRegCostCap = 100; //Limit of Lower Reg Cost that an item can have
			
			//Change to false if you don't want it to be used on any of these items
      bool allowWeapon = true;
			bool allowArmor = true;
			bool allowJewel = true;
			bool allowClothing = true;
			bool allowSpellbook = true;
			bool allowTalisman = true;
			bool allowQuiver = true;
			
			if ( target is BaseWeapon && allowWeapon)
			{
				Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addLower Reg Cost to that item there!" ); 
					}
					else
					{
						LowerRegCostAdd = LowerRegCostToAdd(((BaseWeapon)item).Attributes.LowerRegCost, LowerRegCostAdd, LowerRegCostCap, from);
						if( LowerRegCostAdd > 0 )
						{
							((BaseWeapon)item).Attributes.LowerRegCost += LowerRegCostAdd;
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
						from.SendMessage( "You cannot addLower Reg Cost to that item there!" ); 
					}
					else
					{
						LowerRegCostAdd = LowerRegCostToAdd(((BaseArmor)item).Attributes.LowerRegCost, LowerRegCostAdd, LowerRegCostCap, from);
						if( LowerRegCostAdd > 0 )
						{
							((BaseArmor)item).Attributes.LowerRegCost += LowerRegCostAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addLower Reg Cost to that item there!" ); 
					}
					else
					{
						LowerRegCostAdd = LowerRegCostToAdd(((BaseClothing)item).Attributes.LowerRegCost, LowerRegCostAdd, LowerRegCostCap, from);
						if( LowerRegCostAdd > 0 )
						{
							((BaseClothing)item).Attributes.LowerRegCost += LowerRegCostAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addLower Reg Cost to that item there!" ); 
					}
					else
					{
						LowerRegCostAdd = LowerRegCostToAdd(((BaseTalisman)item).Attributes.LowerRegCost, LowerRegCostAdd, LowerRegCostCap, from);
						if( LowerRegCostAdd > 0 )
						{
							((BaseTalisman)item).Attributes.LowerRegCost += LowerRegCostAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addLower Reg Cost to that item there!" ); 
					}
					else
					{
						LowerRegCostAdd = LowerRegCostToAdd(((BaseJewel)item).Attributes.LowerRegCost, LowerRegCostAdd, LowerRegCostCap, from);
						if( LowerRegCostAdd > 0 )
						{
							((BaseJewel)item).Attributes.LowerRegCost += LowerRegCostAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addLower Reg Cost to that item there!" ); 
					}
					else
					{
						LowerRegCostAdd = LowerRegCostToAdd(((Spellbook)item).Attributes.LowerRegCost, LowerRegCostAdd, LowerRegCostCap, from);
						if( LowerRegCostAdd > 0 )
						{
							((Spellbook)item).Attributes.LowerRegCost += LowerRegCostAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addLower Reg Cost to that item there!" ); 
					}
					else
					{
						LowerRegCostAdd = LowerRegCostToAdd(((BaseQuiver)item).Attributes.LowerRegCost, LowerRegCostAdd, LowerRegCostCap, from);
						if( LowerRegCostAdd > 0 )
						{
							((BaseQuiver)item).Attributes.LowerRegCost += LowerRegCostAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int LowerRegCostToAdd(int itemLowerRegCost, int LowerRegCostAdd ,int LowerRegCostCap, Mobile from)
		{
			int ret = 0;
			if(itemLowerRegCost < LowerRegCostCap)
			{
				if( (itemLowerRegCost + LowerRegCostAdd ) > LowerRegCostCap )
				{
					ret = LowerRegCostAdd - ( (itemLowerRegCost + LowerRegCostAdd ) - LowerRegCostCap );
					from.SendMessage("You increase theLower Reg Cost on the item and it has now reached it's max. +"+ret+"Lower Reg Cost has been added.");
				}
				else{
					from.SendMessage( "You increase theLower Reg Cost on the item. +"+LowerRegCostAdd+"Lower Reg Cost has been added." );
					ret = LowerRegCostAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Lower Reg Cost." );
			}
			
			return ret;
		}
	}

	public class LowerRegCostIncreaseDeed : Item
	{
		[Constructable]
		public LowerRegCostIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Lower Reg Cost Increase Deed";
			LootType = LootType.Blessed;
		}

		public LowerRegCostIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increaseLower Reg Cost?"  );
				from.Target = new LowerRegCostIncreaseTarget( this );
			}
		}	
	}
}