using System;
using Server.Network;
using Server;
using Server.Targets;
using Server.Targeting;
using Server.Mobiles;
using Server.Gumps;

namespace Server.Items
{
	public class PetResurrectDeed : Item
	{
		private BaseCreature pet;

		[Constructable]
        public PetResurrectDeed(): base(0x14F0)
		{
			Weight = 1.0;
			Movable = true;
			Name = "Pet Resurrection Deed";
		}

		public PetResurrectDeed( Serial serial ) : base( serial )
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

			int version = reader.ReadInt();
		}

        public override void OnDoubleClick(Mobile m)
		{
			if ( !IsChildOf( m.Backpack ) )
			{
				m.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			else if( m.InRange( this.GetWorldLocation(), 1 ) ) 
		        {
				m.Target = new PetResTarget( this );
				m.SendMessage( "What would you like to use this on." );
		        } 
		        else 
		        { 
		            m.SendLocalizedMessage( 500446 ); // That is too far away. 
		        }
		}
  		private class PetResTarget : Target 
      		{ 
         		private Mobile m_Owner; 
      
         		private PetResurrectDeed m_Powder; 

         		public PetResTarget( PetResurrectDeed charge ) : base ( 10, false, TargetFlags.None ) 
         		{ 
            			m_Powder=charge; 
         		} 
          
         		protected override void OnTarget( Mobile from, object target ) 
         		{ 

            			if( target == from ) 
               				from.SendMessage( "You cant do that." );
            
          			else if( target is BaseCreature ) 
          			{ 
            						
          				BaseCreature c = (BaseCreature)target;
					Mobile master = c.ControlMaster;
					if( c.Controlled == false )
					{
						from.SendMessage( "That creature is not tamed." );
					}	
					else if( !c.IsDeadPet )
					{
						from.SendMessage( "That creature is alive." );
					}

					else if ( c != null && c.IsDeadPet )
					{
						master.SendGump( new PetResurrectGump( from, c ) );
						from.PlaySound( 0x214 );
						from.FixedEffect( 0x376A, 10, 16 );

            					m_Powder.Delete(); 
					}
  
            			}
         		} 
      		}
	}
}

