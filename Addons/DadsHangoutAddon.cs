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
	public class DadsHangoutAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DadsHangoutAddonDeed();
			}
		}

		[ Constructable ]
		public DadsHangoutAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 6047 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 6047 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 6047 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 6054 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 6053 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 6047 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 3144 );
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 6049 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 6049 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 3235 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 3655 );
			ac.Hue = 2507;
			AddComponent( ac, 1, 0, 1 );
			ac = new AddonComponent( 4012 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 6055 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 3542 );
			AddComponent( ac, 2, -1, 1 );
			ac = new AddonComponent( 2863 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 4604 );
			AddComponent( ac, -4, 3, 0 );
			ac = new AddonComponent( 6049 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 13442 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 6055 );
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 13443 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3145 );
			AddComponent( ac, 2, -1, 1 );
			ac = new AddonComponent( 6045 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 13442 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 6051 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 3242 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 13488 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 9304 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 7681 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 13442 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3555 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -3, 2, 2 );
			ac = new AddonComponent( 6056 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3255 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 13442 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 6045 );
			AddComponent( ac, 4, -1, 0 );
			ac = new AddonComponent( 6052 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 4030 );
			AddComponent( ac, -3, -1, 0 );

		}

		public DadsHangoutAddon( Serial serial ) : base( serial )
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

	public class DadsHangoutAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DadsHangoutAddon();
			}
		}

		[Constructable]
		public DadsHangoutAddonDeed()
		{
			Name = "DadsHangout";
		}

		public DadsHangoutAddonDeed( Serial serial ) : base( serial )
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