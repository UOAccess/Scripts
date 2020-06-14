//Add LowerManaCost to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class LowerManaCostIncreaseTarget : Target
	{			
		private LowerManaCostIncreaseDeed m_Deed;

		public LowerManaCostIncreaseTarget( LowerManaCostIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int LowerManaCostAdd = 1; //Amount of Lower Mana Cost to be added
			int LowerManaCostCap = 95; //Limit of Lower Mana Cost that an item can have
			
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
						from.SendMessage( "You cannot addLower Mana Cost to that item there!" ); 
					}
					else
					{
						LowerManaCostAdd = LowerManaCostToAdd(((BaseWeapon)item).Attributes.LowerManaCost, LowerManaCostAdd, LowerManaCostCap, from);
						if( LowerManaCostAdd > 0 )
						{
							((BaseWeapon)item).Attributes.LowerManaCost += LowerManaCostAdd;
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
						from.SendMessage( "You cannot addLower Mana Cost to that item there!" ); 
					}
					else
					{
						LowerManaCostAdd = LowerManaCostToAdd(((BaseArmor)item).Attributes.LowerManaCost, LowerManaCostAdd, LowerManaCostCap, from);
						if( LowerManaCostAdd > 0 )
						{
							((BaseArmor)item).Attributes.LowerManaCost += LowerManaCostAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addLower Mana Cost to that item there!" ); 
					}
					else
					{
						LowerManaCostAdd = LowerManaCostToAdd(((BaseClothing)item).Attributes.LowerManaCost, LowerManaCostAdd, LowerManaCostCap, from);
						if( LowerManaCostAdd > 0 )
						{
							((BaseClothing)item).Attributes.LowerManaCost += LowerManaCostAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addLower Mana Cost to that item there!" ); 
					}
					else
					{
						LowerManaCostAdd = LowerManaCostToAdd(((BaseTalisman)item).Attributes.LowerManaCost, LowerManaCostAdd, LowerManaCostCap, from);
						if( LowerManaCostAdd > 0 )
						{
							((BaseTalisman)item).Attributes.LowerManaCost += LowerManaCostAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addLower Mana Cost to that item there!" ); 
					}
					else
					{
						LowerManaCostAdd = LowerManaCostToAdd(((BaseJewel)item).Attributes.LowerManaCost, LowerManaCostAdd, LowerManaCostCap, from);
						if( LowerManaCostAdd > 0 )
						{
							((BaseJewel)item).Attributes.LowerManaCost += LowerManaCostAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addLower Mana Cost to that item there!" ); 
					}
					else
					{
						LowerManaCostAdd = LowerManaCostToAdd(((Spellbook)item).Attributes.LowerManaCost, LowerManaCostAdd, LowerManaCostCap, from);
						if( LowerManaCostAdd > 0 )
						{
							((Spellbook)item).Attributes.LowerManaCost += LowerManaCostAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addLower Mana Cost to that item there!" ); 
					}
					else
					{
						LowerManaCostAdd = LowerManaCostToAdd(((BaseQuiver)item).Attributes.LowerManaCost, LowerManaCostAdd, LowerManaCostCap, from);
						if( LowerManaCostAdd > 0 )
						{
							((BaseQuiver)item).Attributes.LowerManaCost += LowerManaCostAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int LowerManaCostToAdd(int itemLowerManaCost, int LowerManaCostAdd ,int LowerManaCostCap, Mobile from)
		{
			int ret = 0;
			if(itemLowerManaCost < LowerManaCostCap)
			{
				if( (itemLowerManaCost + LowerManaCostAdd ) > LowerManaCostCap )
				{
					ret = LowerManaCostAdd - ( (itemLowerManaCost + LowerManaCostAdd ) - LowerManaCostCap );
					from.SendMessage("You increase theLower Mana Cost on the item and it has now reached it's max. +"+ret+"Lower Mana Cost has been added.");
				}
				else{
					from.SendMessage( "You increase theLower Mana Cost on the item. +"+LowerManaCostAdd+"Lower Mana Cost has been added." );
					ret = LowerManaCostAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Lower Mana Cost." );
			}
			
			return ret;
		}
	}

	public class LowerManaCostIncreaseDeed : Item
	{
		[Constructable]
		public LowerManaCostIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1Lower Mana Cost Increase Deed";
			LootType = LootType.Blessed;
		}

		public LowerManaCostIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increaseLower Mana Cost?"  );
				from.Target = new LowerManaCostIncreaseTarget( this );
			}
		}	
	}
}