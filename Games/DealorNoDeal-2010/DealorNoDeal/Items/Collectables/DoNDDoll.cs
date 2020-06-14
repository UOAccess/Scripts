using System;
using Server;

namespace Server.Items
{
	public class DoNDDoll : Item
	{
		[Constructable]
		public DoNDDoll() : base( 0x2107 )
		{
			int hours, minutes;
			Server.Items.Clock.GetTime( this.Map, this.X, this.Y, out hours, out minutes );

			switch ( Utility.Random( 26 ) )
			{
				default:
				case  0: Name = "Claudia"; break;
				case  1: Name = "Stacey"; break;
				case  2: Name = "Lisa"; break;
				case  3: Name = "Keltie"; break;
				case  4: Name = "Ursula"; break;
				case  5: Name = "Megan"; break;
				case  6: Name = "Sara"; break;
				case  7: Name = "Lauren"; break;
				case  8: Name = "Patricia"; break;
				case  9: Name = "Anya"; break;
				case  10: Name = "Katie"; break;
				case  11: Name = "Jill"; break;
				case  12: Name = "Leyla"; break;
				case  13: Name = "Pilar"; break;
				case  14: Name = "Brooke"; break;
				case  15: Name = "Krissy"; break;
				case  16: Name = "Jenelle"; break;
				case  17: Name = "Marisa"; break;
				case  18: Name = "Mylinda"; break;
				case  19: Name = "Alike"; break;
				case  20: Name = "Tameka"; break;
				case  21: Name = "Lianna"; break;
				case  22: Name = "Aubrie"; break;
				case  23: Name = "Kelly"; break;
				case  24: Name = "Hayley Marie"; break;
				case  25: Name = "Lindsay"; break;
			}

			LootType = LootType.Blessed;
			
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

		public DoNDDoll( Serial serial ) : base( serial )
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