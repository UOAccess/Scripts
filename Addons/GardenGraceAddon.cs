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
	public class GardenGraceAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GardenGraceAddonDeed();
			}
		}

		[ Constructable ]
		public GardenGraceAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3235 );
			AddComponent( ac, 1, 0, 3 );
			ac = new AddonComponent( 6810 );
			AddComponent( ac, 0, 1, 5 );
			ac = new AddonComponent( 3265 );
			AddComponent( ac, 1, 2, 14 );
			ac = new AddonComponent( 3263 );
			AddComponent( ac, 1, 1, 5 );
			ac = new AddonComponent( 3224 );
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 3234 );
			AddComponent( ac, 1, 1, 4 );
			ac = new AddonComponent( 3170 );
			AddComponent( ac, 0, 1, 9 );
			ac = new AddonComponent( 4627 );
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 3195 );
			ac.Hue = 2950;
			AddComponent( ac, 0, -1, 6 );
			ac = new AddonComponent( 4624 );
			AddComponent( ac, 1, -1, 3 );
			ac = new AddonComponent( 3169 );
			AddComponent( ac, -1, 0, 3 );
			ac = new AddonComponent( 3209 );
			AddComponent( ac, 1, 0, 5 );
			ac = new AddonComponent( 4623 );
			AddComponent( ac, 0, -1, 3 );
			ac = new AddonComponent( 3195 );
			ac.Hue = 2950;
			AddComponent( ac, -1, 0, 7 );
			ac = new AddonComponent( 4629 );
			AddComponent( ac, -1, 0, 3 );
			ac = new AddonComponent( 4630 );
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 4622 );
			AddComponent( ac, -1, -1, 3 );
			ac = new AddonComponent( 3311 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 4626 );
			AddComponent( ac, 1, 1, 3 );
			ac = new AddonComponent( 3233 );
			AddComponent( ac, -1, 0, 3 );
			ac = new AddonComponent( 3233 );
			AddComponent( ac, 0, -1, 3 );
			ac = new AddonComponent( 4625 );
			AddComponent( ac, 1, 0, 3 );
			ac = new AddonComponent( 4628 );
			AddComponent( ac, -1, 1, 3 );
			ac = new AddonComponent( 3185 );
			ac.Hue = 2950;
			AddComponent( ac, 0, 1, 29 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 0, 0, 6 );
			ac = new AddonComponent( 3144 );
			AddComponent( ac, 0, 0, 26 );
			ac = new AddonComponent( 11535 );
			AddComponent( ac, 0, 0, 6 );
			ac = new AddonComponent( 3378 );
			AddComponent( ac, 0, 0, 6 );
			ac = new AddonComponent( 3255 );
			AddComponent( ac, -1, 0, 3 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 0, 0, 3 );

		}

		public GardenGraceAddon( Serial serial ) : base( serial )
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

	public class GardenGraceAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GardenGraceAddon();
			}
		}

		[Constructable]
		public GardenGraceAddonDeed()
		{
			Name = "GardenGrace";
		}

		public GardenGraceAddonDeed( Serial serial ) : base( serial )
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