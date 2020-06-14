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
	public class AsianPlasFenceNSRedAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AsianPlasFenceNSRedAddonDeed();
			}
		}

		[ Constructable ]
		public AsianPlasFenceNSRedAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, -4, 0 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, -5, 0 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, -5, 15 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, -5, 15 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, -4, 15 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, -4, 15 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, 4, 15 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, 3, 15 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, 6, 0 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, 0, 15 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, 2, 15 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, 1, 15 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, -1, 15 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, 3, 15 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, -3, 15 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, 4, 15 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, 1, 15 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, -2, 15 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, -3, 15 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, 0, 15 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, -2, 15 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, 5, 15 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 9181 );
			AddComponent( ac, 1, 6, 15 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, 5, 0 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, 6, 15 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, 5, 15 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, 2, 15 );
			ac = new AddonComponent( 9183 );
			AddComponent( ac, 0, -1, 15 );

		}

		public AsianPlasFenceNSRedAddon( Serial serial ) : base( serial )
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

	public class AsianPlasFenceNSRedAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AsianPlasFenceNSRedAddon();
			}
		}

		[Constructable]
		public AsianPlasFenceNSRedAddonDeed()
		{
			Name = "AsianPlasFenceNSRed";
		}

		public AsianPlasFenceNSRedAddonDeed( Serial serial ) : base( serial )
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