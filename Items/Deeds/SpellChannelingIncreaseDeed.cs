//Add SpellChanneling to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class SpellChannelingIncreaseTarget : Target
	{			
		private SpellChannelingIncreaseDeed m_Deed;

		public SpellChannelingIncreaseTarget( SpellChannelingIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int SpellChannelingAdd = 1; //Amount of Spell Channeling to be added
			int SpellChannelingCap = 100; //Limit of Spell Channeling that an item can have
			
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
						from.SendMessage( "You cannot add Spell Channeling to that item there!" ); 
					}
					else
					{
						SpellChannelingAdd = SpellChannelingToAdd(((BaseWeapon)item).Attributes.SpellChanneling, SpellChannelingAdd, SpellChannelingCap, from);
						if( SpellChannelingAdd > 0 )
						{
							((BaseWeapon)item).Attributes.SpellChanneling += SpellChannelingAdd;
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
						from.SendMessage( "You cannot add Spell Channeling to that item there!" ); 
					}
					else
					{
						SpellChannelingAdd = SpellChannelingToAdd(((BaseArmor)item).Attributes.SpellChanneling, SpellChannelingAdd, SpellChannelingCap, from);
						if( SpellChannelingAdd > 0 )
						{
							((BaseArmor)item).Attributes.SpellChanneling += SpellChannelingAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Spell Channeling to that item there!" ); 
					}
					else
					{
						SpellChannelingAdd = SpellChannelingToAdd(((BaseClothing)item).Attributes.SpellChanneling, SpellChannelingAdd, SpellChannelingCap, from);
						if( SpellChannelingAdd > 0 )
						{
							((BaseClothing)item).Attributes.SpellChanneling += SpellChannelingAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Spell Channeling to that item there!" ); 
					}
					else
					{
						SpellChannelingAdd = SpellChannelingToAdd(((BaseTalisman)item).Attributes.SpellChanneling, SpellChannelingAdd, SpellChannelingCap, from);
						if( SpellChannelingAdd > 0 )
						{
							((BaseTalisman)item).Attributes.SpellChanneling += SpellChannelingAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Spell Channeling to that item there!" ); 
					}
					else
					{
						SpellChannelingAdd = SpellChannelingToAdd(((BaseJewel)item).Attributes.SpellChanneling, SpellChannelingAdd, SpellChannelingCap, from);
						if( SpellChannelingAdd > 0 )
						{
							((BaseJewel)item).Attributes.SpellChanneling += SpellChannelingAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Spell Channeling to that item there!" ); 
					}
					else
					{
						SpellChannelingAdd = SpellChannelingToAdd(((Spellbook)item).Attributes.SpellChanneling, SpellChannelingAdd, SpellChannelingCap, from);
						if( SpellChannelingAdd > 0 )
						{
							((Spellbook)item).Attributes.SpellChanneling += SpellChannelingAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Spell Channeling to that item there!" ); 
					}
					else
					{
						SpellChannelingAdd = SpellChannelingToAdd(((BaseQuiver)item).Attributes.SpellChanneling, SpellChannelingAdd, SpellChannelingCap, from);
						if( SpellChannelingAdd > 0 )
						{
							((BaseQuiver)item).Attributes.SpellChanneling += SpellChannelingAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int SpellChannelingToAdd(int itemSpellChanneling, int SpellChannelingAdd ,int SpellChannelingCap, Mobile from)
		{
			int ret = 0;
			if(itemSpellChanneling < SpellChannelingCap)
			{
				if( (itemSpellChanneling + SpellChannelingAdd ) > SpellChannelingCap )
				{
					ret = SpellChannelingAdd - ( (itemSpellChanneling + SpellChannelingAdd ) - SpellChannelingCap );
					from.SendMessage("You increase the Spell Channeling on the item and it has now reached it's max. +"+ret+" Spell Channeling has been added.");
				}
				else{
					from.SendMessage( "You increase the Spell Channeling on the item. +"+SpellChannelingAdd+" Spell Channeling has been added." );
					ret = SpellChannelingAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Spell Channeling." );
			}
			
			return ret;
		}
	}

	public class SpellChannelingIncreaseDeed : Item
	{
		[Constructable]
		public SpellChannelingIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Spell Channeling Increase Deed";
			LootType = LootType.Blessed;
		}

		public SpellChannelingIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Spell Channeling?"  );
				from.Target = new SpellChannelingIncreaseTarget( this );
			}
		}	
	}
}