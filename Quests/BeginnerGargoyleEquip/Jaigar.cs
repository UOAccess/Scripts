using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;
using Server.Accounting;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "Jaigar's corpse" )]
	public class Jaigar : Mobile
	{
          
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Jaigar()
		{
			Name = "Jaigar";
                        Title = "the Youthful Summoner";
			BodyValue = 667;
                        Race = Race.Gargoyle;
                        Female = true;
                        Str = 100;
                        Blessed = true;
                       if ( Female )
			          {
				      Body = 0x29B;
                          HairItemID = Race.RandomHair( Female );
			          HairHue = Race.RandomHairHue();
                       
                        
            
			Direction = Direction.East;
			CantWalk = true;
			Hue = 1102;

			ApprenticeFemaleGargoyleChest agc = new ApprenticeFemaleGargoyleChest();
                        AddItem( agc );

                        ApprenticeFemaleGargoyleLegs agl = new ApprenticeFemaleGargoyleLegs();
                        AddItem( agl );
                      
                        ApprenticeFemaleGargoyleKilt agk = new ApprenticeFemaleGargoyleKilt();
                        AddItem( agk );

                        }
                        

		}

		public Jaigar( Serial serial ) : base( serial )
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new JaigarEntry( from, this ) ); 
	        } 

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}

		public class JaigarEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public JaigarEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
			{
				m_Mobile = from;
				m_Giver = giver;
			}

			public override void OnClick()
			{
				

                          if( !( m_Mobile is PlayerMobile ) )
					return;
				
				PlayerMobile mobile = (PlayerMobile) m_Mobile;

				{
					if ( ! mobile.HasGump( typeof( JaigarGump ) ) )
					{
						mobile.SendGump( new JaigarGump( mobile ));
						
					} 
				}
			}
		}

		public override bool OnDragDrop( Mobile from, Item dropped )
		{          		
         	        Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;
			
			
			
			if( mobile != null )
			{
				if( dropped is Level1GargoyleRecommendation )
				{
					Mobile NewMobile = new DiseasedRat();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Jaigar1Gump( mobile ));
					return true;
				}
				else if( dropped is Level2GargoyleRecommendation )
				{
					Mobile NewMobile = new BloodBat();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Jaigar2Gump( mobile ));
					return true;
				}
				else if( dropped is Level3GargoyleRecommendation )
				{
					Mobile NewMobile = new VileToad();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Jaigar3Gump( mobile ));
					return true;
				}
				else if( dropped is Level4GargoyleRecommendation )
				{
					Mobile NewMobile = new AlbinoSerpent();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Jaigar4Gump( mobile ));
					return true;
				}
				else if( dropped is Level5GargoyleRecommendation )
				{
					Mobile NewMobile = new EnragedBear();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Jaigar5Gump( mobile ));
					return true;
				}
				else if( dropped is Level6GargoyleRecommendation )
				{
					Mobile NewMobile = new DarkHarpy();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Jaigar6Gump( mobile ));
					return true;
				}
				else if( dropped is Level7GargoyleRecommendation )
				{
					Mobile NewMobile = new Ikitari();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Jaigar7Gump( mobile ));
					return true;
				}
				else if( dropped is Level8GargoyleRecommendation )
				{
					Mobile NewMobile = new Shezothin();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Jaigar8Gump( mobile ));
					return true;
				}
				else if( dropped is Level9GargoyleRecommendation )
				{
					Mobile NewMobile = new Moruli();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Jaigar9Gump( mobile ));
					return true;
				}
				else if( dropped is Level10GargoyleRecommendation )
				{
					Mobile NewMobile = new Argolan();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Jaigar10Gump( mobile ));
					return true;
				}
				else if( dropped is MasterGargoyleRecommendation )
				{
					Mobile NewMobile = new Grianthiam();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Jaigar11Gump( mobile ));
					return true;
				}
				
					else
         				{
         					mobile.SendMessage("I have no need for this item");
         					
         				}
         			}
         		else
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "I have no need for this item.", mobile.NetState );
     				}
			return false;
		}
	}
}