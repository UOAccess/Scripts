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
	public class AsianPlastCorSWRedAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AsianPlastCorSWRedAddonDeed();
			}
		}

		[ Constructable ]
		public AsianPlastCorSWRedAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 9384 );
			ac.Hue = 2107;
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 9189 );
			ac.Hue = 38;
			AddComponent( ac, 0, 1, 17 );
			ac = new AddonComponent( 9191 );
			AddComponent( ac, 1, 0, 17 );
			ac = new AddonComponent( 9193 );
			ac.Hue = 38;
			AddComponent( ac, 0, 0, 17 );
			ac = new AddonComponent( 9187 );
			ac.Hue = 38;
			AddComponent( ac, 1, 1, 17 );

		}

		public AsianPlastCorSWRedAddon( Serial serial ) : base( serial )
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

	public class AsianPlastCorSWRedAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AsianPlastCorSWRedAddon();
			}
		}

		[Constructable]
		public AsianPlastCorSWRedAddonDeed()
		{
			Name = "AsianPlastCorSWRed";
		}

		public AsianPlastCorSWRedAddonDeed( Serial serial ) : base( serial )
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