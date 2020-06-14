using System;
using Server;
using Server.Mobiles;
using Server.Network;
using System.Collections;

namespace Server.Items
{
	public class RingOfTheCuteFluffyBunny : GoldRing
	{
		//public override int LabelNumber{ get{ return 1061102; } } // Ring of the Vile
		public override int ArtifactRarity{ get{ return 13; } }
		
		private Mobile      m_Owner;  // i added for ownership

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Owner
		{
			get{ return m_Owner; }
			set{ m_Owner = value; }
		}
		[Constructable]
		public RingOfTheCuteFluffyBunny()
		{
			
			Name = "Ring of the Cute Fluffy Bunny";
			Hue = 2264;
			SkillBonuses.SetValues( 0, SkillName.AnimalTaming, 15.0 );
			SkillBonuses.SetValues( 1, SkillName.AnimalLore, 10.0 );
			SkillBonuses.SetValues( 2, SkillName.Veterinary, 10.0 );
			Attributes.CastRecovery = 1;
			Attributes.CastSpeed = 1;

		}

		public RingOfTheCuteFluffyBunny( Serial serial ) : base( serial )
		{
		}
/*		public override bool OnEquip( Mobile from ) 
	{
 
                if( m_Owner == null )
			{
				m_Owner = from;
				base.OnEquip( from );
				from.FollowersMax = 8;
				from.SendMessage( "This ring now belongs to you, and only you!" );
			}
			else if( from == m_Owner || from.AccessLevel >= AccessLevel.GameMaster )

			{
				base.OnEquip( from );
				from.FollowersMax = 8;
				from.SendMessage( "You now have 6 max followers" );
			}
			else
			{
				from.SendMessage( "DENIED!  You have angered the spirit of the Cute Fluffy Bunny!" );
				return false;
			}
			return true;
	}
		public override void OnRemoved( object parent )
		{ 

      if ( parent is Mobile ) 		                      
            {       
			((Mobile)parent).FollowersMax = 6;
            ((Mobile)parent).SendMessage("Your max followers has just been reduced to 6");	
			} 
   

                        
		 } */

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
