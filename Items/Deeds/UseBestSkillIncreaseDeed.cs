//Add UseBestSkill to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;

namespace Server.Items
{
	public class UseBestSkillIncreaseTarget : Target
	{			
		private UseBestSkillIncreaseDeed m_Deed;

		public UseBestSkillIncreaseTarget( UseBestSkillIncreaseDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int UseBestSkillAdd = 1; //Amount of Use Best Skill to be added
			int UseBestSkillCap = 1; //Limit of Use Best Skill that an item can have
			
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
						from.SendMessage( "You cannot add Use Best Skill to that item there!" ); 
					}
					else
					{
						UseBestSkillAdd = UseBestSkillToAdd(((BaseWeapon)item).WeaponAttributes.UseBestSkill, UseBestSkillAdd, UseBestSkillCap, from);
						if( UseBestSkillAdd > 0 )
						{
							((BaseWeapon)item).WeaponAttributes.UseBestSkill += UseBestSkillAdd;
							m_Deed.Delete();
								}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
       public int UseBestSkillToAdd(int itemUseBestSkill, int UseBestSkillAdd ,int UseBestSkillCap, Mobile from)
		{
			int ret = 0;
			if(itemUseBestSkill < UseBestSkillCap)
			{
				if( (itemUseBestSkill + UseBestSkillAdd ) > UseBestSkillCap )
				{
					ret = UseBestSkillAdd - ( (itemUseBestSkill + UseBestSkillAdd ) - UseBestSkillCap );
					from.SendMessage("You increase the Use Best Skill on the item and it has now reached it's max. +"+ret+" Use Best Skill has been added.");
				}
				else{
					from.SendMessage( "You increase the Use Best Skill on the item. +"+UseBestSkillAdd+" Use Best Skill has been added." );
					ret = UseBestSkillAdd;
				}
			}
			else
			{
				from.SendMessage( "That item has reached the maximum amount of Use Best Skill." );
			}
			
			return ret;
		}
	}

	public class UseBestSkillIncreaseDeed : Item
	{
		[Constructable]
		public UseBestSkillIncreaseDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "+1 Use Best Skill Increase Deed";
			LootType = LootType.Blessed;
		}

		public UseBestSkillIncreaseDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which item would you like to increase Use Best Skill?"  );
				from.Target = new UseBestSkillIncreaseTarget( this );
			}
		}	
	}
}