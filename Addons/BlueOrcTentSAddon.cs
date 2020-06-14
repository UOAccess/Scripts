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
	public class BlueOrcTentSAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BlueOrcTentSAddonDeed();
			}
		}

		[ Constructable ]
		public BlueOrcTentSAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 496 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 500 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1064 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 501 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 885 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 502 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 497 );
			AddComponent( ac, 0, 1, 0 );

		}

		public BlueOrcTentSAddon( Serial serial ) : base( serial )
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

	public class BlueOrcTentSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BlueOrcTentSAddon();
			}
		}

		[Constructable]
		public BlueOrcTentSAddonDeed()
		{
			Name = "BlueOrcTentS";
		}

		public BlueOrcTentSAddonDeed( Serial serial ) : base( serial )
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