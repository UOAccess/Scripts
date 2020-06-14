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
	public class BalloonsCAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BalloonsCAddonDeed();
			}
		}

		[ Constructable ]
		public BalloonsCAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 13932 );
			ac.Hue = 91;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 66;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 35;
			AddComponent( ac, 1, 1, 12 );
			ac = new AddonComponent( 875 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 56;
			AddComponent( ac, 0, -1, 0 );

		}

		public BalloonsCAddon( Serial serial ) : base( serial )
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

	public class BalloonsCAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BalloonsCAddon();
			}
		}

		[Constructable]
		public BalloonsCAddonDeed()
		{
			Name = "BalloonsC";
		}

		public BalloonsCAddonDeed( Serial serial ) : base( serial )
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