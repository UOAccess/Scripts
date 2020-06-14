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
	public class GardenCartAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GardenCartAddonDeed();
			}
		}

		[ Constructable ]
		public GardenCartAddon()
		{
			AddComponent( new AddonComponent( 3293 ), -3, 2, 0 );
			AddComponent( new AddonComponent( 3294 ), -3, 2, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 1 );
			AddComponent( ac, 2, 1, 12 );
			ac = new AddonComponent( 3263 );
			AddComponent( ac, 1, 1, 13 );
			ac = new AddonComponent( 6810 );
			AddComponent( ac, 0, 1, 13 );
			ac = new AddonComponent( 6003 );
			AddComponent( ac, 1, -1, 13 );
			ac = new AddonComponent( 3347 );
			AddComponent( ac, 4, -1, 16 );
			ac = new AddonComponent( 3146 );
			AddComponent( ac, 3, -1, 13 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, 3, -1, 17 );
			ac = new AddonComponent( 6809 );
			AddComponent( ac, 0, 2, 13 );
			ac = new AddonComponent( 20 );
			AddComponent( ac, 3, 1, 17 );
			ac = new AddonComponent( 9036 );
			AddComponent( ac, 3, 0, 22 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, 3, 0, 25 );
			ac = new AddonComponent( 6811 );
			AddComponent( ac, 3, 1, 22 );
			ac = new AddonComponent( 5378 );
			AddComponent( ac, 3, 0, 13 );
			ac = new AddonComponent( 3214 );
			AddComponent( ac, 2, 3, 13 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, 2, 0, 17 );
			ac = new AddonComponent( 10592 );
			AddComponent( ac, 3, 1, 17 );
			ac = new AddonComponent( 9036 );
			AddComponent( ac, -1, 0, 13 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 1, -2, 13 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, 2, 1, 17 );
			ac = new AddonComponent( 10592 );
			AddComponent( ac, 3, 0, 17 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, -1, -1, 13 );
			ac = new AddonComponent( 6809 );
			AddComponent( ac, 3, 1, 25 );
			ac = new AddonComponent( 6810 );
			AddComponent( ac, 3, 1, 23 );
			ac = new AddonComponent( 3522 );
			AddComponent( ac, 4, 2, 15 );
			ac = new AddonComponent( 5378 );
			AddComponent( ac, 3, 1, 13 );
			ac = new AddonComponent( 6809 );
			AddComponent( ac, 0, 0, 13 );
			ac = new AddonComponent( 6811 );
			AddComponent( ac, 0, -1, 13 );
			ac = new AddonComponent( 3206 );
			AddComponent( ac, 0, -2, 13 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, 3, 0, 17 );
			ac = new AddonComponent( 5379 );
			AddComponent( ac, 3, 2, 13 );
			ac = new AddonComponent( 9036 );
			AddComponent( ac, -1, -1, 17 );
			ac = new AddonComponent( 9035 );
			AddComponent( ac, -1, 1, 13 );
			ac = new AddonComponent( 3239 );
			AddComponent( ac, -1, -2, 13 );
			ac = new AddonComponent( 3127 );
			AddComponent( ac, 1, 1, 13 );
			ac = new AddonComponent( 3148 );
			AddComponent( ac, 2, -1, 13 );
			ac = new AddonComponent( 3144 );
			AddComponent( ac, 1, 2, 13 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, -1, 2, 13 );
			ac = new AddonComponent( 6008 );
			AddComponent( ac, 4, 3, 13 );
			ac = new AddonComponent( 3214 );
			AddComponent( ac, 2, -4, 17 );
			ac = new AddonComponent( 3214 );
			AddComponent( ac, 2, -4, 24 );
			ac = new AddonComponent( 6818 );
			ac.Hue = 2526;
			AddComponent( ac, 0, 5, 27 );
			ac = new AddonComponent( 6818 );
			ac.Hue = 2526;
			AddComponent( ac, 0, 4, 33 );
			ac = new AddonComponent( 6818 );
			ac.Hue = 2526;
			AddComponent( ac, 0, 4, 27 );
			ac = new AddonComponent( 3211 );
			AddComponent( ac, 4, 4, 13 );
			ac = new AddonComponent( 6815 );
			AddComponent( ac, 0, 4, 13 );
			ac = new AddonComponent( 3223 );
			AddComponent( ac, 1, 4, 18 );
			ac = new AddonComponent( 3223 );
			AddComponent( ac, 2, 4, 18 );
			ac = new AddonComponent( 6818 );
			ac.Hue = 2526;
			AddComponent( ac, 0, 5, 32 );
			ac = new AddonComponent( 3212 );
			AddComponent( ac, 3, 4, 13 );
			ac = new AddonComponent( 3212 );
			AddComponent( ac, 4, 4, 13 );
			ac = new AddonComponent( 3577 );
			ac.Hue = 53;
			AddComponent( ac, 2, 4, 24 );
			ac = new AddonComponent( 3223 );
			AddComponent( ac, 1, 4, 13 );
			ac = new AddonComponent( 3377 );
			AddComponent( ac, 0, 4, 13 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1146;
			AddComponent( ac, 2, 4, 25 );
			ac = new AddonComponent( 3577 );
			ac.Hue = 53;
			AddComponent( ac, 1, 4, 29 );
			ac = new AddonComponent( 3223 );
			AddComponent( ac, 2, 4, 13 );
			ac = new AddonComponent( 3223 );
			AddComponent( ac, 1, 4, 23 );
			ac = new AddonComponent( 6818 );
			ac.Hue = 2526;
			AddComponent( ac, 0, 5, 36 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1146;
			AddComponent( ac, 1, 4, 30 );

		}

		public GardenCartAddon( Serial serial ) : base( serial )
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

	public class GardenCartAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GardenCartAddon();
			}
		}

		[Constructable]
		public GardenCartAddonDeed()
		{
			Name = "GardenCart";
		}

		public GardenCartAddonDeed( Serial serial ) : base( serial )
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