// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class FountainBarrelAddon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new FountainBarrelAddonDeed();}}
		[ Constructable ]
		public FountainBarrelAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 6212 );
			ac.Name = "water";
			AddComponent( ac, -1, -1, 2 );

			ac = new AddonComponent( 6212 );
			AddComponent( ac, 1, 1, 111 );

			ac = new AddonComponent( 13423 );
			AddComponent( ac, 1, 0, 3 );

			ac = new AddonComponent( 13423 );
			AddComponent( ac, -1, 1, 3 );

			ac = new AddonComponent( 13423 );
			AddComponent( ac, 1, 1, 3 );

			ac = new AddonComponent( 13423 );
			AddComponent( ac, 1, -1, 3 );

			ac = new AddonComponent( 13423 );
			AddComponent( ac, 0, 1, 3 );

			ac = new AddonComponent( 13451 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -1, -1, 4 );

			ac = new AddonComponent( 5952 );
			AddComponent( ac, -1, -1, 3 );

			ac = new AddonComponent( 5951 );
			AddComponent( ac, 0, -1, 3 );

			ac = new AddonComponent( 5950 );
			AddComponent( ac, 0, 0, 3 );

			ac = new AddonComponent( 5949 );
			AddComponent( ac, -1, 0, 3 );

			ac = new AddonComponent( 3255 );
			AddComponent( ac, 1, 0, 18 );

			ac = new AddonComponent( 3256 );
			AddComponent( ac, -1, 0, 7 );

			ac = new AddonComponent( 6212 );
			ac.Name = "water";
			AddComponent( ac, 1, 1, 12 );

			ac = new AddonComponent( 6011 );
			AddComponent( ac, -1, 2, 0 );

			ac = new AddonComponent( 13452 );
			AddComponent( ac, 1, 1, 14 );

			ac = new AddonComponent( 3203 );
			AddComponent( ac, -1, 1, 6 );

			ac = new AddonComponent( 3203 );
			AddComponent( ac, 1, -1, 6 );

			ac = new AddonComponent( 3223 );
			AddComponent( ac, 2, -1, 4 );

			ac = new AddonComponent( 3223 );
			AddComponent( ac, -1, 2, 4 );

			ac = new AddonComponent( 3224 );
			AddComponent( ac, 2, 2, 3 );

			ac = new AddonComponent( 3268 );
			AddComponent( ac, 2, 0, 4 );

			ac = new AddonComponent( 3268 );
			AddComponent( ac, 0, 2, 4 );

			ac = new AddonComponent( 3339 );
			AddComponent( ac, 1, 1, 8 );

			ac = new AddonComponent( 3338 );
			AddComponent( ac, 0, 1, 9 );

			ac = new AddonComponent( 3707 );
			AddComponent( ac, -2, -2, 0 );

			ac = new AddonComponent( 4963 );
			AddComponent( ac, -1, -2, 0 );

			ac = new AddonComponent( 4963 );
			AddComponent( ac, -2, -1, 0 );

			ac = new AddonComponent( 4967 );
			AddComponent( ac, 0, -2, 0 );

			ac = new AddonComponent( 4967 );
			AddComponent( ac, 2, 1, 0 );

			ac = new AddonComponent( 4963 );
			AddComponent( ac, 2, -1, 0 );

			ac = new AddonComponent( 4964 );
			AddComponent( ac, 2, 0, 0 );

			ac = new AddonComponent( 3208 );
			AddComponent( ac, 2, 2, 8 );

			ac = new AddonComponent( 3211 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -2, -2, 0 );


		}
		public FountainBarrelAddon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class FountainBarrelAddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new FountainBarrelAddon();}}
		[Constructable]
		public FountainBarrelAddonDeed(){Name = "FountainBarrel";}
		public FountainBarrelAddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}