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
	public class DivingBoardsHighEaAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DivingBoardsHighEaAddonDeed();
			}
		}

		[ Constructable ]
		public DivingBoardsHighEaAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, 1, 5 );
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, 1, 10 );
			ac = new AddonComponent( 2213 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, 1, 15 );
			ac = new AddonComponent( 2213 );
			AddComponent( ac, -2, 0, 20 );
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, -1, 5 );
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, -1, 10 );
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, -1, 15 );
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, -1, 20 );
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, -1, 25 );
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, -1, 30 );
			ac = new AddonComponent( 1824 );
			ac.Hue = 1153;
			AddComponent( ac, -2, -1, 35 );
			ac = new AddonComponent( 1288 );
			ac.Hue = 47;
			AddComponent( ac, -1, 1, 20 );
			ac = new AddonComponent( 1288 );
			ac.Hue = 47;
			AddComponent( ac, -1, -1, 40 );
			ac = new AddonComponent( 1286 );
			ac.Hue = 47;
			AddComponent( ac, 0, -1, 40 );
			ac = new AddonComponent( 1286 );
			ac.Hue = 47;
			AddComponent( ac, 1, -1, 40 );
			ac = new AddonComponent( 1286 );
			ac.Hue = 47;
			AddComponent( ac, 2, -1, 40 );
			ac = new AddonComponent( 1286 );
			ac.Hue = 47;
			AddComponent( ac, 0, 1, 20 );
			ac = new AddonComponent( 1286 );
			ac.Hue = 47;
			AddComponent( ac, 1, 1, 20 );
			ac = new AddonComponent( 1286 );
			ac.Hue = 47;
			AddComponent( ac, 2, 1, 20 );

		}

		public DivingBoardsHighEaAddon( Serial serial ) : base( serial )
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

	public class DivingBoardsHighEaAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DivingBoardsHighEaAddon();
			}
		}

		[Constructable]
		public DivingBoardsHighEaAddonDeed()
		{
			Name = "DivingBoardsHighEa";
		}

		public DivingBoardsHighEaAddonDeed( Serial serial ) : base( serial )
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