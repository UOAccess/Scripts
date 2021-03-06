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
	public class GolfHoleAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GolfHoleAddonDeed();
			}
		}

		[ Constructable ]
		public GolfHoleAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 3289 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, -5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, -4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, -4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, -6, 0 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1539;
			AddComponent( ac, -2, 5, 9 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, 5, 0 );
			ac = new AddonComponent( 1340 );
			ac.Hue = 2660;
			AddComponent( ac, -2, -6, 1 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, 7, 0 );
			ac = new AddonComponent( 3289 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 3204 );
			AddComponent( ac, -2, 0, 1 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 3577 );
			ac.Hue = 1161;
			AddComponent( ac, -2, 1, 8 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, 6, 0 );
			ac = new AddonComponent( 2519 );
			ac.Hue = 1539;
			AddComponent( ac, -2, 1, 9 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 3288 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 3577 );
			ac.Hue = 1161;
			AddComponent( ac, -2, 5, 8 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, 7, 0 );
			ac = new AddonComponent( 5040 );
			AddComponent( ac, -1, 7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, 7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, 5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, 6, 0 );
			ac = new AddonComponent( 3288 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 3286 );
			AddComponent( ac, -3, 6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 3204 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -2, 5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, 5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, 6, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 3204 );
			AddComponent( ac, -2, 6, 0 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, -3, 6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 3223 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 3204 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -3, 6, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 3223 );
			AddComponent( ac, -2, 5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1351 );
			ac.Hue = 2660;
			AddComponent( ac, -3, -4, 1 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, -6, 0 );
			ac = new AddonComponent( 6057 );
			AddComponent( ac, -1, -1, 1 );
			ac = new AddonComponent( 6054 );
			AddComponent( ac, -3, -2, 1 );
			ac = new AddonComponent( 1344 );
			ac.Hue = 2660;
			AddComponent( ac, -2, -4, 1 );
			ac = new AddonComponent( 1350 );
			ac.Hue = 2660;
			AddComponent( ac, -2, -5, 1 );
			ac = new AddonComponent( 1356 );
			ac.Hue = 2660;
			AddComponent( ac, -3, -5, 1 );
			ac = new AddonComponent( 1346 );
			ac.Hue = 2660;
			AddComponent( ac, -1, -6, 1 );
			ac = new AddonComponent( 1359 );
			ac.Hue = 2660;
			AddComponent( ac, -1, -7, 1 );
			ac = new AddonComponent( 1386 );
			ac.Hue = 2660;
			AddComponent( ac, -3, -6, 1 );
			ac = new AddonComponent( 6048 );
			AddComponent( ac, -2, -2, 1 );
			ac = new AddonComponent( 1353 );
			ac.Hue = 2660;
			AddComponent( ac, -2, -7, 1 );
			ac = new AddonComponent( 6059 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, -5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, -6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, -4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, -5, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, -1, 0, 1 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, -2, -1, 1 );
			ac = new AddonComponent( 6060 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 6056 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 6053 );
			AddComponent( ac, -1, -2, 1 );
			ac = new AddonComponent( 6050 );
			AddComponent( ac, -1, 1, 1 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -1, -7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, -7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -2, -7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, -6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, -6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, -4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, -7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -7, 0 );
			ac = new AddonComponent( 1361 );
			ac.Hue = 2660;
			AddComponent( ac, 0, -6, 1 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, -7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, 7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 3289 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, 6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 7, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 3, 5, 0 );
			ac = new AddonComponent( 3288 );
			AddComponent( ac, 3, 5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 12694 );
			AddComponent( ac, 0, 7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, 7, 0 );
			ac = new AddonComponent( 3289 );
			AddComponent( ac, 3, 5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, 5, 0 );
			ac = new AddonComponent( 3288 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, 5, 0 );
			ac = new AddonComponent( 3287 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, 7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, 6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, 7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, 6, 0 );
			ac = new AddonComponent( 3286 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, 5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 12694 );
			AddComponent( ac, 1, 7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2533 );
			ac.Hue = 1;
			AddComponent( ac, 0, -4, 1 );
			ac = new AddonComponent( 6053 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 169 );
			AddComponent( ac, 0, -4, 5 );
			ac = new AddonComponent( 1362 );
			ac.Hue = 2660;
			AddComponent( ac, 1, -6, 1 );
			ac = new AddonComponent( 1352 );
			ac.Hue = 2660;
			AddComponent( ac, 2, -7, 1 );
			ac = new AddonComponent( 1343 );
			ac.Hue = 2660;
			AddComponent( ac, 2, -6, 1 );
			ac = new AddonComponent( 1339 );
			ac.Hue = 2660;
			AddComponent( ac, 4, -4, 1 );
			ac = new AddonComponent( 1344 );
			ac.Hue = 2660;
			AddComponent( ac, 4, -3, 1 );
			ac = new AddonComponent( 1350 );
			ac.Hue = 2660;
			AddComponent( ac, 3, -2, 1 );
			ac = new AddonComponent( 1344 );
			ac.Hue = 2660;
			AddComponent( ac, 3, -1, 1 );
			ac = new AddonComponent( 1386 );
			ac.Hue = 2660;
			AddComponent( ac, 2, -2, 1 );
			ac = new AddonComponent( 1351 );
			ac.Hue = 2660;
			AddComponent( ac, 2, -5, 1 );
			ac = new AddonComponent( 1351 );
			ac.Hue = 2660;
			AddComponent( ac, 3, -4, 1 );
			ac = new AddonComponent( 1352 );
			ac.Hue = 2660;
			AddComponent( ac, 4, -5, 1 );
			ac = new AddonComponent( 1352 );
			ac.Hue = 2660;
			AddComponent( ac, 3, -6, 1 );
			ac = new AddonComponent( 6048 );
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 1353 );
			ac.Hue = 2660;
			AddComponent( ac, 3, -3, 1 );
			ac = new AddonComponent( 6050 );
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 1352 );
			ac.Hue = 2660;
			AddComponent( ac, 0, -7, 1 );
			ac = new AddonComponent( 1339 );
			ac.Hue = 2660;
			AddComponent( ac, 3, -5, 1 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, 6, 0 );
			ac = new AddonComponent( 6055 );
			AddComponent( ac, 3, 2, 1 );
			ac = new AddonComponent( 1356 );
			ac.Hue = 2660;
			AddComponent( ac, 2, -1, 1 );
			ac = new AddonComponent( 1353 );
			ac.Hue = 2660;
			AddComponent( ac, 1, -7, 1 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, 5, 0 );
			ac = new AddonComponent( 6053 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, -7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, -6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, -5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, -4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 2, -4, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, 2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, 1, 0 );
			ac = new AddonComponent( 6050 );
			AddComponent( ac, 2, 2, 1 );
			ac = new AddonComponent( 6057 );
			AddComponent( ac, 1, 0, 1 );
			ac = new AddonComponent( 3755 );
			ac.Hue = 2654;
			AddComponent( ac, 1, -4, 10 );
			ac = new AddonComponent( 6057 );
			AddComponent( ac, 2, 1, 1 );
			ac = new AddonComponent( 6056 );
			AddComponent( ac, 1, 2, 1 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -4, 0 );
			ac = new AddonComponent( 6059 );
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 0, -5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 1, -5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -7, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -5, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -6, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 6013 );
			AddComponent( ac, 4, -5, 0 );

		}

		public GolfHoleAddon( Serial serial ) : base( serial )
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

	public class GolfHoleAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GolfHoleAddon();
			}
		}

		[Constructable]
		public GolfHoleAddonDeed()
		{
			Name = "GolfHole";
		}

		public GolfHoleAddonDeed( Serial serial ) : base( serial )
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