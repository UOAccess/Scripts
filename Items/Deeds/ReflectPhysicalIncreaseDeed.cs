//Add ReflectPhysical to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class ReflectPhysicalIncreaseTarget : Target
	{			
		private ReflectPhysicalIncreaseDeed m_Deed;

		public ReflectPhysicalIncreaseTarget( ReflectPhysicalIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int ReflectPhysicalAdd = 1; //Amount of Reflect Physical to be added
			int ReflectPhysicalCap = 100; //Limit of Reflect Physical that an item can have
			
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
						from.SendMessage( "You cannot addReflect Physical to that item there!" ); 
					}
					else
					{
						ReflectPhysicalAdd = ReflectPhysicalToAdd(((BaseWeapon)item).Attributes.ReflectPhysical, ReflectPhysicalAdd, ReflectPhysicalCap, from);
						if( ReflectPhysicalAdd > 0 )
						{
							((BaseWeapon)item).Attributes.ReflectPhysical += ReflectPhysicalAdd;
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
						from.SendMessage( "You cannot addReflect Physical to that item there!" ); 
					}
					else
					{
						ReflectPhysicalAdd = ReflectPhysicalToAdd(((BaseArmor)item).Attributes.ReflectPhysical, ReflectPhysicalAdd, ReflectPhysicalCap, from);
						if( ReflectPhysicalAdd > 0 )
						{
							((BaseArmor)item).Attributes.ReflectPhysical += ReflectPhysicalAdd;
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addReflect Physical to that item there!" ); 
					}
					else
					{
						ReflectPhysicalAdd = ReflectPhysicalToAdd(((BaseClothing)item).Attributes.ReflectPhysical, ReflectPhysicalAdd, ReflectPhysicalCap, from);
						if( ReflectPhysicalAdd > 0 )
						{
							((BaseClothing)item).Attributes.ReflectPhysical += ReflectPhysicalAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addReflect Physical to that item there!" ); 
					}
					else
					{
						ReflectPhysicalAdd = ReflectPhysicalToAdd(((BaseTalisman)item).Attributes.ReflectPhysical, ReflectPhysicalAdd, ReflectPhysicalCap, from);
						if( ReflectPhysicalAdd > 0 )
						{
							((BaseTalisman)item).Attributes.ReflectPhysical += ReflectPhysicalAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addReflect Physical to that item there!" ); 
					}
					else
					{
						ReflectPhysicalAdd = ReflectPhysicalToAdd(((BaseJewel)item).Attributes.ReflectPhysical, ReflectPhysicalAdd, ReflectPhysicalCap, from);
						if( ReflectPhysicalAdd > 0 )
						{
							((BaseJewel)item).Attributes.ReflectPhysical += ReflectPhysicalAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addReflect Physical to that item there!" ); 
					}
					else
					{
						ReflectPhysicalAdd = ReflectPhysicalToAdd(((Spellbook)item).Attributes.ReflectPhysical, ReflectPhysicalAdd, ReflectPhysicalCap, from);
						if( ReflectPhysicalAdd > 0 )
						{
							((Spellbook)item).Attributes.ReflectPhysical += ReflectPhysicalAdd;
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot addReflect Physical to that item there!" ); 
					}
					else
					{
						ReflectPhysicalAdd = ReflectPhysicalToAdd(((BaseQuiver)item).Attributes.ReflectPhysical, ReflectPhysicalAdd, ReflectPhysicalCap, from);
						if( ReflectPhysicalAdd > 0 )
						{
							((BaseQuiver)item).Attributes.ReflectPhysical += ReflectPhysicalAdd;
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int ReflectPhysicalToAdd(int itemReflectPhysical, int ReflectPhysicalAdd ,int ReflectPhysicalCap, Mobile from)
		{
			int ret = 0;
			if(itemReflectPhysical < ReflectPhysicalCap)
			{
				if( (itemReflectPhysical + ReflectPhysicalAdd ) > ReflectPhysicalCap )
				{
					ret = ReflectPhysicalAdd - ( (itemReflectPhysical + ReflectPhysicalAdd ) - ReflectPhysicalCap );
					from.SendMessage("You increase theReflect Physical on the item and it has now reached it's max. +"+ret+"Reflect Physical has been added.");
				}
				else{
					from.SendMessage( "You increase theReflect Physical on the item. +"+ReflectPhysicalAdd+"Reflect Physical has been added." );
					ret = ReflectPhysicalAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Reflect Physical." );
			}
			
			return ret;
		}
	}

	public class ReflectPhysicalIncreaseDeed : Item
	{
		[Constructable]
		public ReflectPhysicalIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Reflect Physical Increase Deed";
			LootType = LootType.Blessed;
		}

		public ReflectPhysicalIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increaseReflect Physical?"  );
				from.Target = new ReflectPhysicalIncreaseTarget( this );
			}
		}	
	}
}