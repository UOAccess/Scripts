/*----------------*/
/*--- Scripted ---*/
/*--- By: JBob ---*/
/*----------------*/
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server.Mobiles;
using Server;

namespace Server.Items
{
	public class UnbindingTarget : Target 
	{ 
		private Mobile m_Owner; 

		private UnbindingDeed m_Deed; 

		public UnbindingTarget( UnbindingDeed charge ) : base ( 10, false, TargetFlags.None ) 
		{ 
				m_Deed=charge; 
		} 
  
		protected override void OnTarget( Mobile from, object target ) 
		{ 
			if( target == from ) 
				from.SendMessage( "You cant do that." );

			else if( target is SoulSword ) 
			{ 			
				SoulSword ss = (SoulSword)target;
				if( ss.BoundToSoul == 0 )
				{
					from.SendMessage( "That is not Soul Bound." );
				}
				else if( ss.BoundToSoul != 0 )
				{
					ss.Name = "Soul Sword";
					ss.BoundToSoul = 0;
						m_Deed.Delete(); 
					from.SendMessage( "That Soul Weapon is now Unbound!" );
				}
			}
			else if( target is SoulBow ) 
			{ 		
				SoulBow sb = (SoulBow)target;
				if( sb.BoundToSoul == 0 )
				{
					from.SendMessage( "That is not Soul Bound." );
				}
				else if( sb.BoundToSoul != 0 )
				{
					sb.Name = "Soul Bow";
					sb.BoundToSoul = 0;
						m_Deed.Delete(); 
					from.SendMessage( "That Soul Weapon is now Unbound!" );
				}
			}	
			else if( target is SoulChest ) 
			{ 		
				SoulChest sc = (SoulChest)target;
				if( sc.BoundToSoul == 0 )
				{
					from.SendMessage( "That is not Soul Bound." );
				}
				else if( sc.BoundToSoul != 0 )
				{
					sc.Name = "Soul Chest";
					sc.BoundToSoul = 0;
						m_Deed.Delete(); 
					from.SendMessage( "That Soul Armor is now Unbound!" );
				}
			}				
		} 
	}

	public class UnbindingDeed : Item
	{
		[Constructable]
		public UnbindingDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			Name = "Unbinding Deed";
			LootType = LootType.Blessed;
		}

		public UnbindingDeed( Serial serial ) : base( serial )
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
				from.SendMessage("Which Soul Item would you like to Unbind?"  );
				from.Target = new UnbindingTarget( this );
			 }
		}	
	}
}