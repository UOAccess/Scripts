/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class EntertainmentCenterAAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new EntertainmentCenterAAddonDeed();
			}
		}

		[ Constructable ]
		public EntertainmentCenterAAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1986 );
			ac.Hue = 1051;
			AddComponent( ac, 2, 0, 6 );
			ac = new AddonComponent( 1986 );
			ac.Hue = 1051;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 0, 0, 9 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 1, 0, 2 );
			ac = new AddonComponent( 1986 );
			ac.Hue = 1051;
			AddComponent( ac, 2, 0, 12 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 1, 0, 6 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 2888 );
			AddComponent( ac, 2, 0, 14 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 1985 );
			ac.Hue = 1051;
			AddComponent( ac, -1, 0, 12 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 1, 0, 7 );
			ac = new AddonComponent( 5990 );
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 0, 0, 6 );
			ac = new AddonComponent( 1985 );
			ac.Hue = 1051;
			AddComponent( ac, -1, 0, 6 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 0, 0, 7 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 0, 0, 10 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 0, 0, 8 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 1, 0, 3 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1051;
			AddComponent( ac, 1, 0, 12 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 1, 0, 4 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 1, 0, 5 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 0, 0, 4 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 1, 0, 9 );
			ac = new AddonComponent( 5990 );
			ac.Hue = 1;
			AddComponent( ac, 1, 0, 8 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1051;
			AddComponent( ac, 0, 0, 12 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1051;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1985 );
			ac.Hue = 1051;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1051;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2888 );
			AddComponent( ac, -1, 0, 13 );
			ac = new AddonComponent( 10873 );
			AddComponent( ac, 1, 0, 9 );
			ac = new AddonComponent( 3205 );
			AddComponent( ac, -1, 0, 17 );
			ac = new AddonComponent( 3205 );
			AddComponent( ac, 2, 0, 18 );
			ac = new AddonComponent( 3859 );
			AddComponent( ac, 2, 1, 11 );
			ac = new AddonComponent( 3859 );
			AddComponent( ac, 2, 1, 14 );
			ac = new AddonComponent( 3746 );
			ac.Hue = 1150;
			AddComponent( ac, 1, 1, 8 );
			ac = new AddonComponent( 3859 );
			AddComponent( ac, 2, 1, 17 );

		}

		public EntertainmentCenterAAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class EntertainmentCenterAAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new EntertainmentCenterAAddon();
			}
		}

		[Constructable]
		public EntertainmentCenterAAddonDeed()
		{
			Name = "EntertainmentCenterA";
		}

		public EntertainmentCenterAAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}