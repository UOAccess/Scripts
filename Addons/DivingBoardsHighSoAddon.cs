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
	public class DivingBoardsHighSoAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DivingBoardsHighSoAddonDeed();
			}
		}

		[ Constructable ]
		public DivingBoardsHighSoAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2214 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, 1, -2, 5 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, 1, -2, 10 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, 1, -2, 15 );
			ac = new AddonComponent( 2214 );
			AddComponent( ac, 0, -2, 20 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, -1, -2, 5 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, -1, -2, 10 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, -1, -2, 15 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, -1, -2, 20 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, -1, -2, 25 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, -1, -2, 30 );
			ac = new AddonComponent( 1825 );
			ac.Hue = 1153;
			AddComponent( ac, -1, -2, 35 );
			ac = new AddonComponent( 1221 );
			ac.Hue = 47;
			AddComponent( ac, 1, -1, 20 );
			ac = new AddonComponent( 1221 );
			ac.Hue = 47;
			AddComponent( ac, -1, -1, 40 );
			ac = new AddonComponent( 1219 );
			ac.Hue = 47;
			AddComponent( ac, 1, 0, 20 );
			ac = new AddonComponent( 1219 );
			ac.Hue = 47;
			AddComponent( ac, 1, 1, 20 );
			ac = new AddonComponent( 1219 );
			ac.Hue = 47;
			AddComponent( ac, 1, 2, 20 );
			ac = new AddonComponent( 1219 );
			ac.Hue = 47;
			AddComponent( ac, -1, 0, 40 );
			ac = new AddonComponent( 1219 );
			ac.Hue = 47;
			AddComponent( ac, -1, 1, 40 );
			ac = new AddonComponent( 1219 );
			ac.Hue = 47;
			AddComponent( ac, -1, 2, 40 );

		}

		public DivingBoardsHighSoAddon( Serial serial ) : base( serial )
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

	public class DivingBoardsHighSoAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DivingBoardsHighSoAddon();
			}
		}

		[Constructable]
		public DivingBoardsHighSoAddonDeed()
		{
			Name = "DivingBoardsHighSo";
		}

		public DivingBoardsHighSoAddonDeed( Serial serial ) : base( serial )
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