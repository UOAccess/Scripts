
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class goldcarpetAddon2 : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new goldcarpetAddonDeed2();
			}
		}

		[ Constructable ]
		public goldcarpetAddon2()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 2779 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 2785 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 2785 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 2786 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 2786 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2781 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 2786 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 2782 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 2783 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 2783 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 2783 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 2784 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 2784 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 2784 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 2785 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 2780 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, 1, 1, 0 );

		}

		public goldcarpetAddon2( Serial serial ) : base( serial )
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

	public class goldcarpetAddonDeed2 : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new goldcarpetAddon2();
			}
		}

		[Constructable]
		public goldcarpetAddonDeed2()
		{
			Name = "goldcarpet";
		}

		public goldcarpetAddonDeed2( Serial serial ) : base( serial )
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
