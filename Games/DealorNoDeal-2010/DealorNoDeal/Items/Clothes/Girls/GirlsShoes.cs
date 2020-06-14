using System;

namespace Server.Items
{
	[FlipableAttribute( 0x170d, 0x170e )]
	public class GirlsSandals : Sandals
	{
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }

		[Constructable]
		public GirlsSandals()
		{
			int hours, minutes;
			Server.Items.Clock.GetTime( this.Map, this.X, this.Y, out hours, out minutes );

			Name = "Sandals";
			Weight = 1.0;

			if ( hours == 1 )
				Hue = 6;
			if ( hours == 2 )
				Hue = 11;
			if ( hours == 3 )
				Hue = 16;
			if ( hours == 4 )
				Hue = 21;
			if ( hours == 5 )
				Hue = 26;
			if ( hours == 6 )
				Hue = 31;
			if ( hours == 7 )
				Hue = 36;
			if ( hours == 8 )
				Hue = 41;
			if ( hours == 9 )
				Hue = 46;
			if ( hours == 10 )
				Hue = 51;
			if ( hours == 11 )
				Hue = 56;
			if ( hours == 12 )
				Hue = 61;
			if ( hours == 13 )
				Hue = 66;
			if ( hours == 14 )
				Hue = 71;
			if ( hours == 15 )
				Hue = 76;
			if ( hours == 16 )
				Hue = 81;
			if ( hours == 17 )
				Hue = 86;
			if ( hours == 18 )
				Hue = 91;
			if ( hours == 19 )
				Hue = 96;
			if ( hours == 20 )
				Hue = 101;
			if ( hours == 21 )
				Hue = 106;
			if ( hours == 22 )
				Hue = 111;
			if ( hours == 23 )
				Hue = 116;
			if ( hours == 24 )
				Hue = 121;
		}

		public GirlsSandals( Serial serial ) : base( serial )
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
