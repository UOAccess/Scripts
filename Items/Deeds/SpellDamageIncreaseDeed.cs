//Add SpellDamage to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class SpellDamageIncreaseTarget : Target
	{			
		private SpellDamageIncreaseDeed m_Deed;

		public SpellDamageIncreaseTarget( SpellDamageIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int SpellDamageAdd = 1; //Amount of Spell Damage to be added
			int SpellDamageCap = 1000; //Limit of Spell Damage that an item can have
			
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
						from.SendMessage( "You cannot add Spell Damage to that item there!" ); 
					}
					else
					{
						SpellDamageAdd = SpellDamageToAdd(((BaseWeapon)item).Attributes.SpellDamage, SpellDamageAdd, SpellDamageCap, from);
						if( SpellDamageAdd > 0 )
						{
							((BaseWeapon)item).Attributes.SpellDamage += SpellDamageAdd;
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
						from.SendMessage( "You cannot add Spell Damage to that item there!" ); 
					}
					else
					{
						SpellDamageAdd = SpellDamageToAdd(((BaseArmor)item).Attributes.SpellDamage, SpellDamageAdd, SpellDamageCap, from);
						if( SpellDamageAdd > 0 )
						{
							((BaseArmor)item).Attributes.SpellDamage += SpellDamageAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Spell Damage to that item there!" ); 
					}
					else
					{
						SpellDamageAdd = SpellDamageToAdd(((BaseClothing)item).Attributes.SpellDamage, SpellDamageAdd, SpellDamageCap, from);
						if( SpellDamageAdd > 0 )
						{
							((BaseClothing)item).Attributes.SpellDamage += SpellDamageAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Spell Damage to that item there!" ); 
					}
					else
					{
						SpellDamageAdd = SpellDamageToAdd(((BaseTalisman)item).Attributes.SpellDamage, SpellDamageAdd, SpellDamageCap, from);
						if( SpellDamageAdd > 0 )
						{
							((BaseTalisman)item).Attributes.SpellDamage += SpellDamageAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Spell Damage to that item there!" ); 
					}
					else
					{
						SpellDamageAdd = SpellDamageToAdd(((BaseJewel)item).Attributes.SpellDamage, SpellDamageAdd, SpellDamageCap, from);
						if( SpellDamageAdd > 0 )
						{
							((BaseJewel)item).Attributes.SpellDamage += SpellDamageAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Spell Damage to that item there!" ); 
					}
					else
					{
						SpellDamageAdd = SpellDamageToAdd(((Spellbook)item).Attributes.SpellDamage, SpellDamageAdd, SpellDamageCap, from);
						if( SpellDamageAdd > 0 )
						{
							((Spellbook)item).Attributes.SpellDamage += SpellDamageAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Spell Damage to that item there!" ); 
					}
					else
					{
						SpellDamageAdd = SpellDamageToAdd(((BaseQuiver)item).Attributes.SpellDamage, SpellDamageAdd, SpellDamageCap, from);
						if( SpellDamageAdd > 0 )
						{
							((BaseQuiver)item).Attributes.SpellDamage += SpellDamageAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int SpellDamageToAdd(int itemSpellDamage, int SpellDamageAdd ,int SpellDamageCap, Mobile from)
		{
			int ret = 0;
			if(itemSpellDamage < SpellDamageCap)
			{
				if( (itemSpellDamage + SpellDamageAdd ) > SpellDamageCap )
				{
					ret = SpellDamageAdd - ( (itemSpellDamage + SpellDamageAdd ) - SpellDamageCap );
					from.SendMessage("You increase the Spell Damage on the item and it has now reached it's max. +"+ret+" Spell Damage has been added.");
				}
				else{
					from.SendMessage( "You increase the Spell Damage on the item. +"+SpellDamageAdd+" Spell Damage has been added." );
					ret = SpellDamageAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Spell Damage." );
			}
			
			return ret;
		}
	}

	public class SpellDamageIncreaseDeed : Item
	{
		[Constructable]
		public SpellDamageIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Spell Damage Increase Deed";
			LootType = LootType.Blessed;
		}

		public SpellDamageIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Spell Damage?"  );
				from.Target = new SpellDamageIncreaseTarget( this );
			}
		}	
	}
}
