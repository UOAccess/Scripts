//Add HitLowerAttack to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitLowerAttackIncreaseTarget : Target
	{			
		private HitLowerAttackIncreaseDeed m_Deed;

		public HitLowerAttackIncreaseTarget( HitLowerAttackIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitLowerAttackAdd = 1; //Amount of Hit Lower Attack to be added
			int HitLowerAttackCap = 100; //Limit of Hit Lower Attack that an item can have
			
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
						from.SendMessage( "You cannot add Hit Lower Attack to that item there!" ); 
					}
					else
					{
						HitLowerAttackAdd = HitLowerAttackToAdd(((BaseWeapon)item).WeaponAttributes.HitLowerAttack, HitLowerAttackAdd, HitLowerAttackCap, from);
						if( HitLowerAttackAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitLowerAttack += HitLowerAttackAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitLowerAttackToAdd(int itemHitLowerAttack, int HitLowerAttackAdd ,int HitLowerAttackCap, Mobile from)
		{
			int ret = 0;
			if(itemHitLowerAttack < HitLowerAttackCap)
			{
				if( (itemHitLowerAttack + HitLowerAttackAdd ) > HitLowerAttackCap )
				{
					ret = HitLowerAttackAdd - ( (itemHitLowerAttack + HitLowerAttackAdd ) - HitLowerAttackCap );
					from.SendMessage("You increase the Hit Lower Attack on the item and it has now reached it's max. +"+ret+" Hit Lower Attack has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Lower Attack on the item. +"+HitLowerAttackAdd+" Hit Lower Attack has been added." );
					ret = HitLowerAttackAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Lower Attack." );
			}
			
			return ret;
		}
	}

	public class HitLowerAttackIncreaseDeed : Item
	{
		[Constructable]
		public HitLowerAttackIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Lower Attack Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitLowerAttackIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Lower Attack?"  );
				from.Target = new HitLowerAttackIncreaseTarget( this );
			}
		}	
	}
}