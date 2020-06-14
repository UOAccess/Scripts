//Add ReactiveParalyze to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class ReactiveParalyzeIncreaseTarget : Target
	{			
		private ReactiveParalyzeIncreaseDeed m_Deed;

		public ReactiveParalyzeIncreaseTarget( ReactiveParalyzeIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int ReactiveParalyzeAdd = 1; //Amount of ReactiveParalyze to be added
			int ReactiveParalyzeCap = 1; //Limit of ReactiveParalyze that an item can have
			
			//Change to false if you don't want it to be used on any of these items
      bool allowWeapon = true;
			bool allowArmor = false;
			bool allowJewel = false;
			bool allowClothing = false;
			bool allowSpellbook = false;
			bool allowTalisman = false;
			bool allowQuiver = false;
			
			if ( target is BaseWeapon && allowWeapon)
			{
				Item item = (Item)target;
					if( item.RootParent != from )
					{
						from.SendMessage( "You cannot add ReactiveParalyze to that item there!" ); 
					}
					else
					{
						ReactiveParalyzeAdd = ReactiveParalyzeToAdd(((BaseWeapon)item).WeaponAttributes.ReactiveParalyze, ReactiveParalyzeAdd, ReactiveParalyzeCap, from);
						if( ReactiveParalyzeAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.ReactiveParalyze += ReactiveParalyzeAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int ReactiveParalyzeToAdd(int itemReactiveParalyze, int ReactiveParalyzeAdd ,int ReactiveParalyzeCap, Mobile from)
		{
			int ret = 0;
			if(itemReactiveParalyze < ReactiveParalyzeCap)
			{
				if( (itemReactiveParalyze + ReactiveParalyzeAdd ) > ReactiveParalyzeCap )
				{
					ret = ReactiveParalyzeAdd - ( (itemReactiveParalyze + ReactiveParalyzeAdd ) - ReactiveParalyzeCap );
					from.SendMessage("You increase the ReactiveParalyze on the item and it has now reached it's max. +"+ret+" ReactiveParalyze has been added.");
				}
				else{
					from.SendMessage( "You increase the ReactiveParalyze on the item. +"+ReactiveParalyzeAdd+" ReactiveParalyze has been added." );
					ret = ReactiveParalyzeAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of ReactiveParalyze." );
			}
			
			return ret;
		}
	}

	public class ReactiveParalyzeIncreaseDeed : Item
	{
		[Constructable]
		public ReactiveParalyzeIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "ReactiveParalyze Increase Deed";
			LootType = LootType.Blessed;
		}

		public ReactiveParalyzeIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase ReactiveParalyze?"  );
				from.Target = new ReactiveParalyzeIncreaseTarget( this );
			}
		}	
	}
}