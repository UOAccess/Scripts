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
	public class EasterAngSEAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new EasterAngSEAddonDeed();
			}
		}

		[ Constructable ]
		public EasterAngSEAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1993 );
			ac.Hue = 2224;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 2224;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 2224;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 1993 );
			ac.Hue = 2224;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1993 );
			ac.Hue = 2224;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1993 );
			ac.Hue = 2224;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1993 );
			ac.Hue = 2224;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 2224;
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 1993 );
			ac.Hue = 2224;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 2224;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 3265 );
			ac.Hue = 2345;
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 2224;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 1997 );
			ac.Hue = 2224;
			AddComponent( ac, 0, 1, 0 );

		}

		public EasterAngSEAddon( Serial serial ) : base( serial )
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

	public class EasterAngSEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new EasterAngSEAddon();
			}
		}

		[Constructable]
		public EasterAngSEAddonDeed()
		{
			Name = "EasterAngSE";
		}

		public EasterAngSEAddonDeed( Serial serial ) : base( serial )
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