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
	public class CrystalLoveSeatAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CrystalLoveSeatAddonDeed();
			}
		}

		[ Constructable ]
		public CrystalLoveSeatAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2861 );
			ac.Hue = 2544;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 5029 );
			ac.Hue = 515;
			AddComponent( ac, 1, 0, 2 );
			ac = new AddonComponent( 1982 );
			ac.Hue = 2544;
			AddComponent( ac, 1, 1, 3 );
			ac = new AddonComponent( 5029 );
			ac.Hue = 515;
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 1982 );
			ac.Hue = 2544;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2861 );
			ac.Hue = 2544;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 2544;
			AddComponent( ac, 1, 1, 2 );
			ac = new AddonComponent( 1984 );
			ac.Hue = 2544;
			AddComponent( ac, 2, 0, 2 );
			ac = new AddonComponent( 1987 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1983 );
			ac.Hue = 2544;
			AddComponent( ac, -1, 0, 2 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 2544;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1988 );
			ac.Hue = 2544;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 2544;
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 2544;
			AddComponent( ac, 0, 1, 2 );
			ac = new AddonComponent( 13804 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 13804 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2888 );
			ac.Hue = 515;
			AddComponent( ac, 1, 1, 5 );
			ac = new AddonComponent( 2888 );
			ac.Hue = 515;
			AddComponent( ac, 0, 1, 5 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, 0, 1, 9 );
			ac = new AddonComponent( 9037 );
			AddComponent( ac, 1, 1, 9 );

		}

		public CrystalLoveSeatAddon( Serial serial ) : base( serial )
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

	public class CrystalLoveSeatAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CrystalLoveSeatAddon();
			}
		}

		[Constructable]
		public CrystalLoveSeatAddonDeed()
		{
			Name = "CrystalLoveSeat";
		}

		public CrystalLoveSeatAddonDeed( Serial serial ) : base( serial )
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