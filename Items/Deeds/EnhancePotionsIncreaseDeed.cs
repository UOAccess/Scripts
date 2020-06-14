//Add EnhancePotions to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class EnhancePotionsIncreaseTarget : Target
	{			
		private EnhancePotionsIncreaseDeed m_Deed;

		public EnhancePotionsIncreaseTarget( EnhancePotionsIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int EnhancePotionsAdd = 1; //Amount of Enhance Potions to be added
			int EnhancePotionsCap = 100; //Limit of Enhance Potions that an item can have
			
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
						from.SendMessage( "You cannot add Enhance Potions to that item there!" ); 
					}
					else
					{
						EnhancePotionsAdd = EnhancePotionsToAdd(((BaseWeapon)item).Attributes.EnhancePotions, EnhancePotionsAdd, EnhancePotionsCap, from);
						if( EnhancePotionsAdd > 0 )
						{
							((BaseWeapon)item).Attributes.EnhancePotions += EnhancePotionsAdd;
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
						from.SendMessage( "You cannot add Enhance Potions to that item there!" ); 
					}
					else
					{
						EnhancePotionsAdd = EnhancePotionsToAdd(((BaseArmor)item).Attributes.EnhancePotions, EnhancePotionsAdd, EnhancePotionsCap, from);
						if( EnhancePotionsAdd > 0 )
						{
							((BaseArmor)item).Attributes.EnhancePotions += EnhancePotionsAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Enhance Potions to that item there!" ); 
					}
					else
					{
						EnhancePotionsAdd = EnhancePotionsToAdd(((BaseClothing)item).Attributes.EnhancePotions, EnhancePotionsAdd, EnhancePotionsCap, from);
						if( EnhancePotionsAdd > 0 )
						{
							((BaseClothing)item).Attributes.EnhancePotions += EnhancePotionsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Enhance Potions to that item there!" ); 
					}
					else
					{
						EnhancePotionsAdd = EnhancePotionsToAdd(((BaseTalisman)item).Attributes.EnhancePotions, EnhancePotionsAdd, EnhancePotionsCap, from);
						if( EnhancePotionsAdd > 0 )
						{
							((BaseTalisman)item).Attributes.EnhancePotions += EnhancePotionsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Enhance Potions to that item there!" ); 
					}
					else
					{
						EnhancePotionsAdd = EnhancePotionsToAdd(((BaseJewel)item).Attributes.EnhancePotions, EnhancePotionsAdd, EnhancePotionsCap, from);
						if( EnhancePotionsAdd > 0 )
						{
							((BaseJewel)item).Attributes.EnhancePotions += EnhancePotionsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Enhance Potions to that item there!" ); 
					}
					else
					{
						EnhancePotionsAdd = EnhancePotionsToAdd(((Spellbook)item).Attributes.EnhancePotions, EnhancePotionsAdd, EnhancePotionsCap, from);
						if( EnhancePotionsAdd > 0 )
						{
							((Spellbook)item).Attributes.EnhancePotions += EnhancePotionsAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Enhance Potions to that item there!" ); 
					}
					else
					{
						EnhancePotionsAdd = EnhancePotionsToAdd(((BaseQuiver)item).Attributes.EnhancePotions, EnhancePotionsAdd, EnhancePotionsCap, from);
						if( EnhancePotionsAdd > 0 )
						{
							((BaseQuiver)item).Attributes.EnhancePotions += EnhancePotionsAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int EnhancePotionsToAdd(int itemEnhancePotions, int EnhancePotionsAdd ,int EnhancePotionsCap, Mobile from)
		{
			int ret = 0;
			if(itemEnhancePotions < EnhancePotionsCap)
			{
				if( (itemEnhancePotions + EnhancePotionsAdd ) > EnhancePotionsCap )
				{
					ret = EnhancePotionsAdd - ( (itemEnhancePotions + EnhancePotionsAdd ) - EnhancePotionsCap );
					from.SendMessage("You increase the Enhance Potions on the item and it has now reached it's max. +"+ret+" Enhance Potions has been added.");
				}
				else{
					from.SendMessage( "You increase the Enhance Potions on the item. +"+EnhancePotionsAdd+" Enhance Potions has been added." );
					ret = EnhancePotionsAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Enhance Potions." );
			}
			
			return ret;
		}
	}

	public class EnhancePotionsIncreaseDeed : Item
	{
		[Constructable]
		public EnhancePotionsIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Enhance Potions Increase Deed";
			LootType = LootType.Blessed;
		}

		public EnhancePotionsIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Enhance Potions?"  );
				from.Target = new EnhancePotionsIncreaseTarget( this );
			}
		}	
	}
}