//Add ReactiveParalyzeArmor to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class ReactiveParalyzeArmorIncreaseTarget : Target
	{			
		private ReactiveParalyzeArmorIncreaseDeed m_Deed;

		public ReactiveParalyzeArmorIncreaseTarget( ReactiveParalyzeArmorIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int ReactiveParalyzeArmorAdd = 1; //Amount of ReactiveParalyzeArmor to be added
			int ReactiveParalyzeArmorCap = 1; //Limit of ReactiveParalyzeArmor that an item can have
			
			//Change to false if you don't want it to be used on any of these items
      bool allowWeapon = false;
			bool allowArmor = true;
			bool allowJewel = false;
			bool allowClothing = false;
			bool allowSpellbook = false;
			bool allowTalisman = false;
			bool allowQuiver = false;
			
			if ( target is BaseArmor && allowWeapon)
			{
				Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add ReactiveParalyzeArmor to that item there!" ); 
					}
					else
					{
						ReactiveParalyzeArmorAdd = ReactiveParalyzeArmorToAdd(((BaseArmor)item).ArmorAttributes.ReactiveParalyze, ReactiveParalyzeArmorAdd, ReactiveParalyzeArmorCap, from);
						if( ReactiveParalyzeArmorAdd > 0 )
						{
							((BaseArmor)item).ArmorAttributes.ReactiveParalyze += ReactiveParalyzeArmorAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int ReactiveParalyzeArmorToAdd(int itemReactiveParalyzeArmor, int ReactiveParalyzeArmorAdd ,int ReactiveParalyzeArmorCap, Mobile from)
		{
			int ret = 0;
			if(itemReactiveParalyzeArmor < ReactiveParalyzeArmorCap)
			{
				if( (itemReactiveParalyzeArmor + ReactiveParalyzeArmorAdd ) > ReactiveParalyzeArmorCap )
				{
					ret = ReactiveParalyzeArmorAdd - ( (itemReactiveParalyzeArmor + ReactiveParalyzeArmorAdd ) - ReactiveParalyzeArmorCap );
					from.SendMessage("You increase the ReactiveParalyzeArmor on the item and it has now reached it's max. +"+ret+" ReactiveParalyzeArmor has been added.");
				}
				else{
					from.SendMessage( "You increase the ReactiveParalyzeArmor on the item. +"+ReactiveParalyzeArmorAdd+" ReactiveParalyzeArmor has been added." );
					ret = ReactiveParalyzeArmorAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of ReactiveParalyzeArmor." );
			}
			
			return ret;
		}
	}

	public class ReactiveParalyzeArmorIncreaseDeed : Item
	{
		[Constructable]
		public ReactiveParalyzeArmorIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "ReactiveParalyzeArmor Increase Deed";
			LootType = LootType.Blessed;
		}

		public ReactiveParalyzeArmorIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase ReactiveParalyzeArmor?"  );
				from.Target = new ReactiveParalyzeArmorIncreaseTarget( this );
			}
		}	
	}
}