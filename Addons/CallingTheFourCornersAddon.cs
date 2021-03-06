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
	public class CallingTheFourCornersAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CallingTheFourCornersAddonDeed();
			}
		}

		[ Constructable ]
		public CallingTheFourCornersAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 7418 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 6925 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 7421 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 7437 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 7441 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3295 );
			ac.Hue = 1107;
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 7431 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 7442 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 4089 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 7424 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 7413 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 7417 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 7414 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 6880 );
			AddComponent( ac, -1, 3, 2 );
			ac = new AddonComponent( 6921 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 7434 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 7419 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 6884 );
			AddComponent( ac, 3, 3, 6 );
			ac = new AddonComponent( 7415 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 7416 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 2483 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 7410 );
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 7423 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 7420 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 6882 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 7422 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 7430 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 7439 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 7428 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 7411 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 7436 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 6883 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 7412 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 8474 );
			ac.Hue = 37;
			AddComponent( ac, 4, -1, 4 );
			ac = new AddonComponent( 6881 );
			AddComponent( ac, 3, -1, 2 );
			ac = new AddonComponent( 7425 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 7435 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 7433 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 7427 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 7440 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 7429 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 7426 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 7409 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 7432 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 7438 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 3277 );
			AddComponent( ac, 3, -4, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 2842 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 3921 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 5037 );
			ac.Hue = 1175;
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 5037 );
			ac.Hue = 1175;
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 3293 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 8781 );
			ac.Hue = 907;
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 3285 );
			ac.Hue = 908;
			AddComponent( ac, -4, 3, 0 );
			ac = new AddonComponent( 3279 );
			ac.Hue = 908;
			AddComponent( ac, 3, -4, 0 );
			ac = new AddonComponent( 3283 );
			AddComponent( ac, -4, 3, 0 );
			ac = new AddonComponent( 5037 );
			ac.Hue = 1175;
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 5038 );
			ac.Hue = 1175;
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 3969 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 4307 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 4460 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 4310 );
			ac.Hue = 976;
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 3814 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 3811 );
			AddComponent( ac, 0, -3, 16 );
			ac = new AddonComponent( 8700 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 6664 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 4651 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 3798 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 6659 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 9777 );
			ac.Hue = 1109;
			AddComponent( ac, -4, 3, 12 );
			ac = new AddonComponent( 9777 );
			ac.Hue = 1109;
			AddComponent( ac, 3, -4, 15 );
			ac = new AddonComponent( 9770 );
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 14217 );
			ac.Hue = 2500;
			AddComponent( ac, 1, 1, 0 );

		}

		public CallingTheFourCornersAddon( Serial serial ) : base( serial )
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

	public class CallingTheFourCornersAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CallingTheFourCornersAddon();
			}
		}

		[Constructable]
		public CallingTheFourCornersAddonDeed()
		{
			Name = "CallingTheFourCorners";
		}

		public CallingTheFourCornersAddonDeed( Serial serial ) : base( serial )
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