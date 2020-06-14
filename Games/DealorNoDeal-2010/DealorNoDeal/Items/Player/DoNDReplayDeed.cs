using System;
using Server.Mobiles;

namespace Server.Items
{
	public class DoNDReplayDeed : Item
	{
		private int m_RP1 = 0; 
		private int m_RPM1 = 0; 
		private int m_Replay = 0; 

		public int RP1
		{
			get{ return m_RP1; }
			set{ m_RP1 = value; }
		}

		public int RPM1
		{
			get{ return m_RPM1; }
			set{ m_RPM1 = value; }
		}

		public int RReplay
		{
			get{ return m_Replay; }
			set{ m_Replay = value; }
		}


		[Constructable]
		public DoNDReplayDeed( Mobile m, Item i ) : base( 0x14EF )
		{
			PlayerMobile pm = m as PlayerMobile;

			if ( pm == null )
				return;

			DoNDGameDeed gd = i as DoNDGameDeed;

			if ( gd == null )
				return;
	
			RReplay = gd.DReplay;

			Name = "DoND Replay Deed for : " + pm.Name;
			LootType = LootType.Blessed;
			Weight = 0.0;

			Visible = false;
			Movable = false;
		}

		public override bool DisplayLootType{ get{ return false; } }

		public DoNDReplayDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

			writer.Write( (int)m_RP1 );
			writer.Write( (int)m_RPM1 );
			writer.Write( (int)m_Replay );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 0:
				{
					m_RP1 = (int)reader.ReadInt();
					m_RPM1 = (int)reader.ReadInt();
					m_Replay = (int)reader.ReadInt();
					break;
				}
			}
		}
	}
}