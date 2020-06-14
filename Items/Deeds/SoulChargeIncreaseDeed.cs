//Add SoulCharge to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class SoulChargeIncreaseTarget : Target
	{			
		private SoulChargeIncreaseDeed m_Deed;

		public SoulChargeIncreaseTarget( SoulChargeIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int SoulChargeAdd = 1; //Amount of SoulCharge to be added
			int SoulChargeCap = 50; //Limit of SoulCharge that an item can have
			
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
						from.SendMessage( "You cannot add SoulCharge to that item there!" ); 
					}
					else
					{
						SoulChargeAdd = SoulChargeToAdd(((BaseArmor)item).ArmorAttributes.SoulCharge, SoulChargeAdd, SoulChargeCap, from);
						if( SoulChargeAdd > 0 )
						{
							((BaseArmor)item).ArmorAttributes.SoulCharge += SoulChargeAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int SoulChargeToAdd(int itemSoulCharge, int SoulChargeAdd ,int SoulChargeCap, Mobile from)
		{
			int ret = 0;
			if(itemSoulCharge < SoulChargeCap)
			{
				if( (itemSoulCharge + SoulChargeAdd ) > SoulChargeCap )
				{
					ret = SoulChargeAdd - ( (itemSoulCharge + SoulChargeAdd ) - SoulChargeCap );
					from.SendMessage("You increase the SoulCharge on the item and it has now reached it's max. +"+ret+" SoulCharge has been added.");
				}
				else{
					from.SendMessage( "You increase the SoulCharge on the item. +"+SoulChargeAdd+" SoulCharge has been added." );
					ret = SoulChargeAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of SoulCharge." );
			}
			
			return ret;
		}
	}

	public class SoulChargeIncreaseDeed : Item
	{
		[Constructable]
		public SoulChargeIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1% SoulCharge Increase Deed";
			LootType = LootType.Blessed;
		}

		public SoulChargeIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase SoulCharge?"  );
				from.Target = new SoulChargeIncreaseTarget( this );
			}
		}	
	}
}