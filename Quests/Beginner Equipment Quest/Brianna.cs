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
	[CorpseName( "Brianna's corpse" )]
	public class Brianna : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Brianna()
		{
			Name = "Brianna";
                        Title = "the Youthful Summoner";
			Body = 0x191;
			Direction = Direction.East;
			CantWalk = true;
			Hue = Utility.RandomSkinHue();

			FancyDress fd = new FancyDress();
                        fd.Hue = 84;
                        AddItem( fd );

                        Sandals s = new Sandals();
                        s.Hue = 84;
                        AddItem( s );
                 
                        AddItem( new LongHair(52));

		}

		public Brianna( Serial serial ) : base( serial )
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new BriannaEntry( from, this ) ); 
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

		public class BriannaEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public BriannaEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( BriannaGump ) ) )
					{
						mobile.SendGump( new BriannaGump( mobile ));
						
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
				if( dropped is Level1Recommendation )
				{
					Mobile NewMobile = new DiseasedRat();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Brianna1Gump( mobile ));
					return true;
				}
				else if( dropped is Level2Recommendation )
				{
					Mobile NewMobile = new BloodBat();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Brianna2Gump( mobile ));
					return true;
				}
				else if( dropped is Level3Recommendation )
				{
					Mobile NewMobile = new VileToad();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Brianna3Gump( mobile ));
					return true;
				}
				else if( dropped is Level4Recommendation )
				{
					Mobile NewMobile = new AlbinoSerpent();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Brianna4Gump( mobile ));
					return true;
				}
				else if( dropped is Level5Recommendation )
				{
					Mobile NewMobile = new EnragedBear();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Brianna5Gump( mobile ));
					return true;
				}
				else if( dropped is Level6Recommendation )
				{
					Mobile NewMobile = new DarkHarpy();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Brianna6Gump( mobile ));
					return true;
				}
				else if( dropped is Level7Recommendation )
				{
					Mobile NewMobile = new Ikitari();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Brianna7Gump( mobile ));
					return true;
				}
				else if( dropped is Level8Recommendation )
				{
					Mobile NewMobile = new Shezothin();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Brianna8Gump( mobile ));
					return true;
				}
				else if( dropped is Level9Recommendation )
				{
					Mobile NewMobile = new Moruli();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Brianna9Gump( mobile ));
					return true;
				}
				else if( dropped is Level10Recommendation )
				{
					Mobile NewMobile = new Argolan();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Brianna10Gump( mobile ));
					return true;
				}
				else if( dropped is MasterRecommendation )
				{
					Mobile NewMobile = new Grianthiam();
					NewMobile.MoveToWorld( new Point3D( 6039, 359, 44 ), this.Map );
					dropped.Delete();
					mobile.SendGump( new Brianna11Gump( mobile ));
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