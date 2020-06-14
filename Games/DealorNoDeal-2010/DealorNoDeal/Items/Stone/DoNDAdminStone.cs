using System;
using System.Collections;
using System.Collections.Generic;
using Server.Mobiles;
using Server.Gumps;

namespace Server.Items
{
	public class DoNDAdminStone : Item
	{
		private int i_Game;
		private int i_Cash;
		private int i_Replay;
		private bool b_DeBug;
		private bool b_Howey;
		private string s_Commercial;

		public int Game
		{
			get{ return i_Game; }
			set{ i_Game = value; }
		}

		public int Cash
		{
			get{ return i_Cash; }
			set{ i_Cash = value; }
		}

		public int Replay
		{
			get{ return i_Replay; }
			set{ i_Replay = value; }
		}

		public bool DeBugger
		{
			get{ return b_DeBug; }
			set{ b_DeBug = value; }
		}

		public bool SHowey
		{
			get{ return b_Howey; }
			set{ b_Howey = value; }
		}

		public string SCommercial
		{
			get{ return s_Commercial; }
			set{ s_Commercial = value; }
		}

		[Constructable]
		public DoNDAdminStone() : base( 0xED4 )
		{
			Name = "Deal or No Deal : System Off";
			Movable = false;
			Hue = 5;
			SCommercial = "Please edit this text to anything you want the player to read when the commercial appears to the player playing Deal or No Deal";
			Replay = 24;
		}

		public override void OnDoubleClick( Mobile from )
		{
			PlayerMobile pm = from as PlayerMobile;

			if ( pm == null )
				return;

			if ( pm.AccessLevel < AccessLevel.Administrator )
			{
				pm.SendMessage( pm.Name + ", Your not the Administrator, please send a page to activate Deal or No Deal!");
				return;
			}

			if ( Visible == true )
			{
				pm.SendMessage( pm.Name + ", The Game started, if you want to remove system, just delete the Stage, Howey and Stone!");
				SpawnStage(this);
				pm.BoltEffect( 0 );
				pm.PlaySound( 41 );
				Visible = false;
				pm.Z +=5;
				Name = "Deal or No Deal : System On : Howey Not Spawned";
				return;
			}

                 	if ( pm.InRange( this, 5 ) && DeBugger == false )
                      	{
				if ( SHowey == false )
					SpawnHowey(this);
				if (pm.HasGump( typeof( DoNDAdminGump )))
					pm.CloseGump( typeof( DoNDAdminGump ) );
				pm.SendGump( new DoNDAdminGump( this ) );
				pm.SendMessage( pm.Name + ", Howey Spawned!");
				return;
                        }

			if ( DeBugger == true )
			{
				if (pm.HasGump( typeof( DebugGump )))
					pm.CloseGump( typeof( DebugGump ) );
				pm.SendGump( new DebugGump( pm ) );
				if (pm.HasGump( typeof( DoNDAdminGump )))
					pm.CloseGump( typeof( DoNDAdminGump ) );
				pm.SendGump( new DoNDAdminGump( this ) );
				return;
			}
			return;
		}
		
		public static void SpawnStage( Item target )
		{
			DoNDAdminStone it = target as DoNDAdminStone;

			if ( it == null )
				return;

			Map map = it.Map;

			if ( map == null )
				return;

			DoNDStageAddon stage = new DoNDStageAddon();

			Point3D loc = it.Location;
			
			int x = it.X-1;
			int y = it.Y;
			int z = it.Z-2;

			loc = new Point3D( x, y, z );
			
			stage.MoveToWorld( loc, map );

			it.Z +=6;
		}

		public static void SpawnHowey( Item target )
		{
			DoNDAdminStone it = target as DoNDAdminStone;

			if ( it == null )
				return;

			Map map = it.Map;

			if ( map == null )
				return;

			Howey howey = new Howey( it );

			Point3D loc = it.Location;
			
			int x = it.X;
			int y = it.Y+1;
			int z = it.Z;

			loc = new Point3D( x, y, z );
			
			howey.MoveToWorld( loc, map );

			it.Name = "Deal or No Deal : System On : Howey Spawned";

			howey.FixedParticles( 0x37CC, 1, 40, 97, 3, 9917, EffectLayer.Waist );
           		howey.FixedParticles( 0x374A, 1, 15, 9502, 97, 3, (EffectLayer)255 );

			it.SHowey = true;
		}

		public DoNDAdminStone( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

			writer.Write( (int)i_Game );
			writer.Write( (int)i_Cash );
			writer.Write( (int)i_Replay );
			writer.Write( (bool)b_DeBug );
			writer.Write( (bool)b_Howey );
			writer.Write( (string)s_Commercial );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 0:
				{
					i_Game = (int)reader.ReadInt();
					i_Cash = (int)reader.ReadInt();
					i_Replay = (int)reader.ReadInt();
					b_DeBug = (bool)reader.ReadBool();
					b_Howey = (bool)reader.ReadBool();
					s_Commercial = (string)reader.ReadString();
					break;
				}
			}	
		}
	}
}