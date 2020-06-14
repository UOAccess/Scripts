//Add RegenStam to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class RegenStamIncreaseTarget : Target
	{			
		private RegenStamIncreaseDeed m_Deed;

		public RegenStamIncreaseTarget( RegenStamIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int RegenStamAdd = 1; //Amount of Regen Stam to be added
			int RegenStamCap = 100; //Limit of Regen Stam that an item can have
			
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
						from.SendMessage( "You cannot addRegen Stam to that item there!" ); 
					}
					else
					{
						RegenStamAdd = RegenStamToAdd(((BaseWeapon)item).Attributes.RegenStam, RegenStamAdd, RegenStamCap, from);
						if( RegenStamAdd > 0 )
						{
							((BaseWeapon)item).Attributes.RegenStam += RegenStamAdd;
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
						from.SendMessage( "You cannot addRegen Stam to that item there!" ); 
					}
					else
					{
						RegenStamAdd = RegenStamToAdd(((BaseArmor)item).Attributes.RegenStam, RegenStamAdd, RegenStamCap, from);
						if( RegenStamAdd > 0 )
						{
							((BaseArmor)item).Attributes.RegenStam += RegenStamAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Stam to that item there!" ); 
					}
					else
					{
						RegenStamAdd = RegenStamToAdd(((BaseClothing)item).Attributes.RegenStam, RegenStamAdd, RegenStamCap, from);
						if( RegenStamAdd > 0 )
						{
							((BaseClothing)item).Attributes.RegenStam += RegenStamAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Stam to that item there!" ); 
					}
					else
					{
						RegenStamAdd = RegenStamToAdd(((BaseTalisman)item).Attributes.RegenStam, RegenStamAdd, RegenStamCap, from);
						if( RegenStamAdd > 0 )
						{
							((BaseTalisman)item).Attributes.RegenStam += RegenStamAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Stam to that item there!" ); 
					}
					else
					{
						RegenStamAdd = RegenStamToAdd(((BaseJewel)item).Attributes.RegenStam, RegenStamAdd, RegenStamCap, from);
						if( RegenStamAdd > 0 )
						{
							((BaseJewel)item).Attributes.RegenStam += RegenStamAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Stam to that item there!" ); 
					}
					else
					{
						RegenStamAdd = RegenStamToAdd(((Spellbook)item).Attributes.RegenStam, RegenStamAdd, RegenStamCap, from);
						if( RegenStamAdd > 0 )
						{
							((Spellbook)item).Attributes.RegenStam += RegenStamAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addRegen Stam to that item there!" ); 
					}
					else
					{
						RegenStamAdd = RegenStamToAdd(((BaseQuiver)item).Attributes.RegenStam, RegenStamAdd, RegenStamCap, from);
						if( RegenStamAdd > 0 )
						{
							((BaseQuiver)item).Attributes.RegenStam += RegenStamAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int RegenStamToAdd(int itemRegenStam, int RegenStamAdd ,int RegenStamCap, Mobile from)
		{
			int ret = 0;
			if(itemRegenStam < RegenStamCap)
			{
				if( (itemRegenStam + RegenStamAdd ) > RegenStamCap )
				{
					ret = RegenStamAdd - ( (itemRegenStam + RegenStamAdd ) - RegenStamCap );
					from.SendMessage("You increase theRegen Stam on the item and it has now reached it's max. +"+ret+"Regen Stam has been added.");
				}
				else{
					from.SendMessage( "You increase theRegen Stam on the item. +"+RegenStamAdd+"Regen Stam has been added." );
					ret = RegenStamAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Regen Stam." );
			}
			
			return ret;
		}
	}

	public class RegenStamIncreaseDeed : Item
	{
		[Constructable]
		public RegenStamIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Regen Stam Increase Deed";
			LootType = LootType.Blessed;
		}

		public RegenStamIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increaseRegen Stam?"  );
				from.Target = new RegenStamIncreaseTarget( this );
			}
		}	
	}
}