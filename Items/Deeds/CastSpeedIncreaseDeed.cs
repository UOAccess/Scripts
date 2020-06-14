//Add CastSpeed to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class CastSpeedIncreaseTarget : Target
	{			
		private CastSpeedIncreaseDeed m_Deed;

		public CastSpeedIncreaseTarget( CastSpeedIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int CastSpeedAdd = 1; //Amount of Cast Speed to be added
			int CastSpeedCap = 100; //Limit of Cast Speed that an item can have
			
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
						from.SendMessage( "You cannot add Cast Speed to that item there!" ); 
					}
					else
					{
						CastSpeedAdd = CastSpeedToAdd(((BaseWeapon)item).Attributes.CastSpeed, CastSpeedAdd, CastSpeedCap, from);
						if( CastSpeedAdd > 0 )
						{
							((BaseWeapon)item).Attributes.CastSpeed += CastSpeedAdd;
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
						from.SendMessage( "You cannot add Cast Speed to that item there!" ); 
					}
					else
					{
						CastSpeedAdd = CastSpeedToAdd(((BaseArmor)item).Attributes.CastSpeed, CastSpeedAdd, CastSpeedCap, from);
						if( CastSpeedAdd > 0 )
						{
							((BaseArmor)item).Attributes.CastSpeed += CastSpeedAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Cast Speed to that item there!" ); 
					}
					else
					{
						CastSpeedAdd = CastSpeedToAdd(((BaseClothing)item).Attributes.CastSpeed, CastSpeedAdd, CastSpeedCap, from);
						if( CastSpeedAdd > 0 )
						{
							((BaseClothing)item).Attributes.CastSpeed += CastSpeedAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Cast Speed to that item there!" ); 
					}
					else
					{
						CastSpeedAdd = CastSpeedToAdd(((BaseTalisman)item).Attributes.CastSpeed, CastSpeedAdd, CastSpeedCap, from);
						if( CastSpeedAdd > 0 )
						{
							((BaseTalisman)item).Attributes.CastSpeed += CastSpeedAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Cast Speed to that item there!" ); 
					}
					else
					{
						CastSpeedAdd = CastSpeedToAdd(((BaseJewel)item).Attributes.CastSpeed, CastSpeedAdd, CastSpeedCap, from);
						if( CastSpeedAdd > 0 )
						{
							((BaseJewel)item).Attributes.CastSpeed += CastSpeedAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Cast Speed to that item there!" ); 
					}
					else
					{
						CastSpeedAdd = CastSpeedToAdd(((Spellbook)item).Attributes.CastSpeed, CastSpeedAdd, CastSpeedCap, from);
						if( CastSpeedAdd > 0 )
						{
							((Spellbook)item).Attributes.CastSpeed += CastSpeedAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Cast Speed to that item there!" ); 
					}
					else
					{
						CastSpeedAdd = CastSpeedToAdd(((BaseQuiver)item).Attributes.CastSpeed, CastSpeedAdd, CastSpeedCap, from);
						if( CastSpeedAdd > 0 )
						{
							((BaseQuiver)item).Attributes.CastSpeed += CastSpeedAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int CastSpeedToAdd(int itemCastSpeed, int CastSpeedAdd ,int CastSpeedCap, Mobile from)
		{
			int ret = 0;
			if(itemCastSpeed < CastSpeedCap)
			{
				if( (itemCastSpeed + CastSpeedAdd ) > CastSpeedCap )
				{
					ret = CastSpeedAdd - ( (itemCastSpeed + CastSpeedAdd ) - CastSpeedCap );
					from.SendMessage("You increase the Cast Speed on the item and it has now reached it's max. +"+ret+" Cast Speed has been added.");
				}
				else{
					from.SendMessage( "You increase the Cast Speed on the item. +"+CastSpeedAdd+" Cast Speed has been added." );
					ret = CastSpeedAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Cast Speed." );
			}
			
			return ret;
		}
	}

	public class CastSpeedIncreaseDeed : Item
	{
		[Constructable]
		public CastSpeedIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Cast Speed Increase Deed";
			LootType = LootType.Blessed;
		}

		public CastSpeedIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Cast Speed?"  );
				from.Target = new CastSpeedIncreaseTarget( this );
			}
		}	
	}
}