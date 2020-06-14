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
	[CorpseName( "Lothar's corpse" )]
	public class Lothar : Mobile
	{
		public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Lothar()
		{
			Name = "Lothar";
			Title = "the Youth Trainer";
			Body = 400;
			Direction = Direction.South;
			CantWalk = true;
			
			AddItem( new Server.Items.Boots() );
			AddItem( new Server.Items.Cloak(113) );
			AddItem( new Server.Items.CloseHelm() );
			AddItem( new Server.Items.PlateGorget() );
			AddItem( new Server.Items.PlateGloves() );
			AddItem( new Server.Items.PlateArms() );
			AddItem( new Server.Items.PlateLegs() );
			AddItem( new Server.Items.PlateChest() );
			AddItem( new Server.Items.OrderShield() );
			AddItem( new Server.Items.PaladinSword() );
			
			
			AddItem( new ShortHair(56));
			
		}
		
		public Lothar( Serial serial ) : base( serial )
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
		{
			base.GetContextMenuEntries( from, list );
			list.Add( new LotharEntry( from, this ) );
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
		
		public class LotharEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public LotharEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( LotharGump ) ) )
					{
						mobile.SendGump( new LotharGump( mobile ));
						
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
				if( dropped is LetterofApprenticeship )
				{
					dropped.Delete();
					mobile.AddToBackpack( new Level1Recommendation() );
					mobile.SendGump( new LotharStartGump( mobile ));
					return true;
				}
				else if( dropped is DiseasedRatMeat )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeRing() );
					mobile.AddToBackpack( new Level2Recommendation() );
					mobile.SendGump( new Lothar1Gump( mobile ));
					return true;
				}
				else if( dropped is BloodyBatWing )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeBracelet() );
					mobile.AddToBackpack( new Level3Recommendation() );
					mobile.SendGump( new Lothar2Gump( mobile ));
					return true;
				}
				else if( dropped is ToadEye )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeEarrings() );
					mobile.AddToBackpack( new Level4Recommendation() );
					mobile.SendGump( new Lothar3Gump( mobile ));
					return true;
				}
				else if( dropped is WhiteSnakeEgg )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeGorget() );
					mobile.AddToBackpack( new Level5Recommendation() );
					mobile.SendGump( new Lothar4Gump( mobile ));
					return true;
				}
				else if( dropped is BearFur )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeGloves() );
					mobile.AddToBackpack( new Level6Recommendation() );
					mobile.SendGump( new Lothar5Gump( mobile ));
					return true;
				}
				else if( dropped is DarkFeather )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeCap() );
					mobile.AddToBackpack( new Level7Recommendation() );
					mobile.SendGump( new Lothar6Gump( mobile ));
					return true;
				}
				else if( dropped is RodentBlood )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeSleeves() );
					mobile.AddToBackpack( new Level8Recommendation() );
					mobile.SendGump( new Lothar7Gump( mobile ));
					return true;
				}
				else if( dropped is ScaledLeather )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeLegs() );
					mobile.AddToBackpack( new Level9Recommendation() );
					mobile.SendGump( new Lothar8Gump( mobile ));
					return true;
				}
				else if( dropped is GlowingSkull )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeTunic() );
					mobile.AddToBackpack( new Level10Recommendation() );
					mobile.SendGump( new Lothar9Gump( mobile ));
					return true;
				}
				else if( dropped is MagicOrcHelm )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeShield() );
					mobile.AddToBackpack( new MasterRecommendation() );
					mobile.AddToBackpack( new BankCheck( 1500 ) );
					mobile.SendGump( new Lothar10Gump( mobile ));
					return true;
				}
				else if( dropped is SavageHead )
				{
					dropped.Delete();
					mobile.AddToBackpack( new ApprenticeSword() );
					mobile.AddToBackpack( new BankCheck( 3500 ) );
					mobile.SendGump( new LotharFinishGump( mobile ));
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