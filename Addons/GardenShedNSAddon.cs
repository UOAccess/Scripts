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
	public class GardenShedNSAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GardenShedNSAddonDeed();
			}
		}

		[ Constructable ]
		public GardenShedNSAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 8 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 1357 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 7 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 1302 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1302 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 8 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 1302 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1302 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 8 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 6 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 7 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 8 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 1350 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 1302 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 3719 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1345 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1352 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 1302 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 1302 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 8 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1302 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 7 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1348 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1344 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, 0, 2, 20 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, 0, -1, 20 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, 0, 1, 20 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, 0, 0, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, 0, 2, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, 0, -2, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, -1, -2, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, -1, 2, 20 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, -2, 2, 20 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, -2, 1, 20 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, -2, 0, 20 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, -2, -1, 20 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -1, 0, 20 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, 0, 20 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 0, 0, 20 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, -1, -1, 22 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 0, -2, 20 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 0, 2, 20 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, 2, 20 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, -1, 1, 22 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, -1, 0, 22 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 0, -1, 20 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, -1, -2, 22 );
			ac = new AddonComponent( 9977 );
			AddComponent( ac, 0, 1, 20 );
			ac = new AddonComponent( 9976 );
			AddComponent( ac, -1, 2, 22 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, -1, 20 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, 1, 20 );
			ac = new AddonComponent( 9978 );
			AddComponent( ac, -2, -2, 20 );

		}

		public GardenShedNSAddon( Serial serial ) : base( serial )
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

	public class GardenShedNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GardenShedNSAddon();
			}
		}

		[Constructable]
		public GardenShedNSAddonDeed()
		{
			Name = "GardenShedNS";
		}

		public GardenShedNSAddonDeed( Serial serial ) : base( serial )
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