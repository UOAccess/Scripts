using System;
using Server.Network;
using Server.Prompts;
using Server.Items;

namespace Server.Items
{
	public class LetterofApprenticeship : Item
	{
		[Constructable]
		public LetterofApprenticeship() : base( 0x14F0 )
		{
			base.Weight = 1.0;
			base.Name = "Letter of Apprenticeship for Lothar in Uzeraan's Mansion";
			Hue = 319;
		}

		public LetterofApprenticeship( Serial serial ) : base( serial )
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

		public override void OnDoubleClick( Mobile m )
		{
			m.SendMessage( "Letter of Apprenticeship for Lothar" );
		}
	}
}


