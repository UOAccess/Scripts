using System;
using System.Collections.Generic;
using Server;

namespace Server.Mobiles
{
	public class GameVendor : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }

		[Constructable]
		public GameVendor() : base( "the Live Game Ticket Seller" )
		{
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBGameVendor() );
		}

		public GameVendor( Serial serial ) : base( serial )
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
	}
}