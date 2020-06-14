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
	[CorpseName( "Kyle's corpse" )]
	public class Kyle : Mobile
	{
          

		[Constructable]
		public Kyle()
		{
			Name = "Kyle";
			Title = "the Youth Trainer";
			BodyValue = 666;
                        Race = Race.Gargoyle;
			Direction = Direction.South;
			CantWalk = true;
                        Hue = 1102;
                        Str = 100;
                        Blessed = true;
                         
                          HairItemID = Race.RandomHair( Female );
                          HairHue = Race.RandomHairHue();
			
		        ApprenticeMaleGargoyleChest amgc = new ApprenticeMaleGargoyleChest();
                        AddItem( amgc );
                        
                        ApprenticeMaleGargoyleLegs amgl = new ApprenticeMaleGargoyleLegs();
                        AddItem( amgl );
                          
                        
                        ApprenticeMaleGargoyleKilt amgk = new ApprenticeMaleGargoyleKilt();
                        AddItem( amgk );

                         }
			
			
			
		
		public Kyle( Serial serial ) : base( serial )
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
		{
			base.GetContextMenuEntries( from, list );
			list.Add( new KyleEntry( from, this ) );
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
		
		public class KyleEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public KyleEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( KyleGump ) ) )
					{
						mobile.SendGump( new KyleGump( mobile ));
						
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
				if( dropped is LetterofGargoyleApprenticeship )
				{
					dropped.Delete();
					mobile.AddToBackpack( new Level1GargoyleRecommendation() );
					mobile.SendGump( new KyleStartGump( mobile ));
					return true;
				}
				else if( dropped is DiseasedRatMeat )
				{
					dropped.Delete();
                    mobile.AddToBackpack(new ApprenticeGargoyleRing());
					mobile.AddToBackpack( new Level2GargoyleRecommendation() );
					mobile.SendGump( new Kyle1Gump( mobile ));
					return true;
				}
				else if( dropped is BloodyBatWing )
				{
					dropped.Delete();
                    mobile.AddToBackpack(new ApprenticeGargoyleBracelet());
					mobile.AddToBackpack( new Level3GargoyleRecommendation() );
					mobile.SendGump( new Kyle2Gump( mobile ));
					return true;
				}
				else if( dropped is ToadEye )
				{
					dropped.Delete();
                    mobile.AddToBackpack(new ApprenticeGargoyleEarrings());
					mobile.AddToBackpack( new Level4GargoyleRecommendation() );
					mobile.SendGump( new Kyle3Gump( mobile ));
					return true;
				}
				else if( dropped is WhiteSnakeEgg )
				{
					dropped.Delete();
                    mobile.AddToBackpack(new ApprenticeGargoyleApron());
					mobile.AddToBackpack( new Level5GargoyleRecommendation() );
					mobile.SendGump( new Kyle4Gump( mobile ));
					return true;
				}
				else if( dropped is BearFur )
				{
					dropped.Delete();
                    mobile.AddToBackpack(new ApprenticeGargoyleWingArmor());
					mobile.AddToBackpack( new Level6GargoyleRecommendation() );
					mobile.SendGump( new Kyle5Gump( mobile ));
					return true;
				}
				else if( dropped is DarkFeather )
                {
                    dropped.Delete();
                    
                    if (mobile.Female)
                        from.AddToBackpack(new ApprenticeFemaleGargoyleKilt());

                    else
                        
                    from.AddToBackpack(new ApprenticeMaleGargoyleKilt());
					mobile.AddToBackpack( new Level7GargoyleRecommendation() );
					mobile.SendGump( new Kyle6Gump( mobile ));
					return true;
				}
				else if( dropped is RodentBlood )
				{
					dropped.Delete();
                    
                        if (mobile.Female)
                        from.AddToBackpack(new ApprenticeFemaleGargoyleSleeves ());
                      else
                      
                    from.AddToBackpack(new ApprenticeMaleGargoyleSleeves ());
                    mobile.AddToBackpack( new Level8GargoyleRecommendation() );
					mobile.SendGump( new Kyle7Gump( mobile ));
					return true;
                         
				}
				else if( dropped is ScaledLeather )
				{
                    dropped.Delete();
                    
                      if (mobile.Female)
                        from.AddToBackpack(new ApprenticeFemaleGargoyleLegs());
                     
				 else
					from.AddToBackpack( new ApprenticeMaleGargoyleLegs() );
					mobile.AddToBackpack( new Level9GargoyleRecommendation() );
					mobile.SendGump( new Kyle8Gump( mobile ));
					return true;
				}
				else if( dropped is GlowingSkull )
				{
                    dropped.Delete();
                      
                     if (mobile.Female)
                        from.AddToBackpack(new ApprenticeFemaleGargoyleChest());
                       else
					from.AddToBackpack( new ApprenticeMaleGargoyleChest() );
					mobile.AddToBackpack( new Level10GargoyleRecommendation() );
					mobile.SendGump( new Kyle9Gump( mobile ));
					return true;
				}
				else if( dropped is MagicOrcHelm )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeGargoyleShield() );
					mobile.AddToBackpack( new MasterGargoyleRecommendation() );
					mobile.AddToBackpack( new BankCheck( 500 ) );
					mobile.SendGump( new Kyle10Gump( mobile ));
					return true;
				}
				else if( dropped is SavageHead )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeGargoyleSword  () );
					mobile.AddToBackpack( new BankCheck( 800 ) );
					mobile.SendGump( new KyleFinishGump( mobile ));
					return true;
				}
					else
					{
						mobile.SendMessage("I have no need for this item.");
                    
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
		
		
		
		
   
   









		
		
		
		

    
		


