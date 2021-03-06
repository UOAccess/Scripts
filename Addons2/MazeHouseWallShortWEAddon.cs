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
	public class MazeHouseWallShortWEAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MazeHouseWallShortWEAddonDeed();
			}
		}

		[ Constructable ]
		public MazeHouseWallShortWEAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 12299 );
			ac.Hue = 1153;
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 12299 );
			ac.Hue = 1153;
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 12299 );
			ac.Hue = 1153;
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 12299 );
			ac.Hue = 1153;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 12299 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 12299 );
			ac.Hue = 1153;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 12299 );
			ac.Hue = 1153;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 12299 );
			ac.Hue = 1153;
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 12299 );
			ac.Hue = 1153;
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 12299 );
			ac.Hue = 1153;
			AddComponent( ac, 5, 0, 0 );

		}

		public MazeHouseWallShortWEAddon( Serial serial ) : base( serial )
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

	public class MazeHouseWallShortWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MazeHouseWallShortWEAddon();
			}
		}

		[Constructable]
		public MazeHouseWallShortWEAddonDeed()
		{
			Name = "MazeHouseWallShortWE";
		}

		public MazeHouseWallShortWEAddonDeed( Serial serial ) : base( serial )
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