//Add HitFireball to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class HitFireballIncreaseTarget : Target
	{			
		private HitFireballIncreaseDeed m_Deed;

		public HitFireballIncreaseTarget( HitFireballIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int HitFireballAdd = 1; //Amount of Hit Fireball to be added
			int HitFireballCap = 100; //Limit of Hit Fireball that an item can have
			
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
						from.SendMessage( "You cannot add Hit Fireball to that item there!" ); 
					}
					else
					{
						HitFireballAdd = HitFireballToAdd(((BaseWeapon)item).WeaponAttributes.HitFireball, HitFireballAdd, HitFireballCap, from);
						if( HitFireballAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.HitFireball += HitFireballAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int HitFireballToAdd(int itemHitFireball, int HitFireballAdd ,int HitFireballCap, Mobile from)
		{
			int ret = 0;
			if(itemHitFireball < HitFireballCap)
			{
				if( (itemHitFireball + HitFireballAdd ) > HitFireballCap )
				{
					ret = HitFireballAdd - ( (itemHitFireball + HitFireballAdd ) - HitFireballCap );
					from.SendMessage("You increase the Hit Fireball on the item and it has now reached it's max. +"+ret+" Hit Fireball has been added.");
				}
				else{
					from.SendMessage( "You increase the Hit Fireball on the item. +"+HitFireballAdd+" Hit Fireball has been added." );
					ret = HitFireballAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Hit Fireball." );
			}
			
			return ret;
		}
	}

	public class HitFireballIncreaseDeed : Item
	{
		[Constructable]
		public HitFireballIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Hit Fireball Increase Deed";
			LootType = LootType.Blessed;
		}

		public HitFireballIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Hit Fireball?"  );
				from.Target = new HitFireballIncreaseTarget( this );
			}
		}	
	}
}