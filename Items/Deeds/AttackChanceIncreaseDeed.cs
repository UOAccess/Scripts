//Add AttackChance to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class AttackChanceIncreaseTarget : Target
	{			
		private AttackChanceIncreaseDeed m_Deed;

		public AttackChanceIncreaseTarget( AttackChanceIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int AttackChanceAdd = 1; //Amount of Attack Chance to be added
			int AttackChanceCap = 100; //Limit of Attack Chance that an item can have
			
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
						from.SendMessage( "You cannot add Attack Chance to that item there!" ); 
					}
					else
					{
						AttackChanceAdd = AttackChanceToAdd(((BaseWeapon)item).Attributes.AttackChance, AttackChanceAdd, AttackChanceCap, from);
						if( AttackChanceAdd > 0 )
						{
							((BaseWeapon)item).Attributes.AttackChance += AttackChanceAdd;
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
						from.SendMessage( "You cannot add Attack Chance to that item there!" ); 
					}
					else
					{
						AttackChanceAdd = AttackChanceToAdd(((BaseArmor)item).Attributes.AttackChance, AttackChanceAdd, AttackChanceCap, from);
						if( AttackChanceAdd > 0 )
						{
							((BaseArmor)item).Attributes.AttackChance += AttackChanceAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Attack Chance to that item there!" ); 
					}
					else
					{
						AttackChanceAdd = AttackChanceToAdd(((BaseClothing)item).Attributes.AttackChance, AttackChanceAdd, AttackChanceCap, from);
						if( AttackChanceAdd > 0 )
						{
							((BaseClothing)item).Attributes.AttackChance += AttackChanceAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Attack Chance to that item there!" ); 
					}
					else
					{
						AttackChanceAdd = AttackChanceToAdd(((BaseTalisman)item).Attributes.AttackChance, AttackChanceAdd, AttackChanceCap, from);
						if( AttackChanceAdd > 0 )
						{
							((BaseTalisman)item).Attributes.AttackChance += AttackChanceAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Attack Chance to that item there!" ); 
					}
					else
					{
						AttackChanceAdd = AttackChanceToAdd(((BaseJewel)item).Attributes.AttackChance, AttackChanceAdd, AttackChanceCap, from);
						if( AttackChanceAdd > 0 )
						{
							((BaseJewel)item).Attributes.AttackChance += AttackChanceAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Attack Chance to that item there!" ); 
					}
					else
					{
						AttackChanceAdd = AttackChanceToAdd(((Spellbook)item).Attributes.AttackChance, AttackChanceAdd, AttackChanceCap, from);
						if( AttackChanceAdd > 0 )
						{
							((Spellbook)item).Attributes.AttackChance += AttackChanceAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add Attack Chance to that item there!" ); 
					}
					else
					{
						AttackChanceAdd = AttackChanceToAdd(((BaseQuiver)item).Attributes.AttackChance, AttackChanceAdd, AttackChanceCap, from);
						if( AttackChanceAdd > 0 )
						{
							((BaseQuiver)item).Attributes.AttackChance += AttackChanceAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int AttackChanceToAdd(int itemAttackChance, int AttackChanceAdd ,int AttackChanceCap, Mobile from)
		{
			int ret = 0;
			if(itemAttackChance < AttackChanceCap)
			{
				if( (itemAttackChance + AttackChanceAdd ) > AttackChanceCap )
				{
					ret = AttackChanceAdd - ( (itemAttackChance + AttackChanceAdd ) - AttackChanceCap );
					from.SendMessage("You increase the Attack Chance on the item and it has now reached it's max. +"+ret+" Attack Chance has been added.");
				}
				else{
					from.SendMessage( "You increase the Attack Chance on the item. +"+AttackChanceAdd+" Attack Chance has been added." );
					ret = AttackChanceAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Attack Chance." );
			}
			
			return ret;
		}
	}

	public class AttackChanceIncreaseDeed : Item
	{
		[Constructable]
		public AttackChanceIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Attack Chance Increase Deed";
			LootType = LootType.Blessed;
		}

		public AttackChanceIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Attack Chance?"  );
				from.Target = new AttackChanceIncreaseTarget( this );
			}
		}	
	}
}