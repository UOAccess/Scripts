
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class RichyRichCouchTealAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new RichyRichCouchTealAddonDeed();
			}
		}

		[ Constructable ]
		public RichyRichCouchTealAddon()
		{



			AddComplexComponent( (BaseAddon) this, 5037, 1, 2, 8, 291, -1, "a floor pillow", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3650, 1, 1, 4, 1160, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3650, 1, 2, 4, 1160, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3650, 1, 0, 0, 1160, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3650, 1, 2, 0, 1160, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3650, 1, -1, 4, 1160, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3650, 1, -1, 0, 1160, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3530, 1, 1, 8, 1160, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3651, 0, -2, 0, 1160, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 3530, 1, 2, 8, 1160, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2860, 0, 1, 0, 1160, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 3650, 1, 0, 4, 1160, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2860, 0, 0, 0, 1160, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2860, 0, -1, 0, 1160, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 3650, 1, 1, 0, 1160, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 3651, 0, 2, 0, 1160, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 3530, 1, 0, 8, 1160, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 3530, 1, -1, 8, 1160, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 3530, 0, -2, 4, 1160, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 3530, 0, 2, 4, 1160, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 5037, 1, 1, 8, 291, -1, "a floor pillow", 1);// 21
			AddComplexComponent( (BaseAddon) this, 5037, 1, 0, 8, 291, -1, "a floor pillow", 1);// 22
			AddComplexComponent( (BaseAddon) this, 5037, 1, -1, 8, 291, -1, "a floor pillow", 1);// 23
			AddComplexComponent( (BaseAddon) this, 5029, 0, -2, 4, 291, -1, "a bed pillow", 1);// 24
			AddComplexComponent( (BaseAddon) this, 5029, 0, 2, 4, 291, -1, "a bed pillow", 1);// 25
			AddComplexComponent( (BaseAddon) this, 5035, 0, -2, 5, 1160, -1, "a tagged pillow", 1);// 26
			AddComplexComponent( (BaseAddon) this, 5035, 0, 2, 5, 1160, -1, "a tagged pillow", 1);// 27
			AddComplexComponent( (BaseAddon) this, 5991, 0, -1, 1, 1160, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 5991, 0, 0, 1, 1160, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 5991, 0, 1, 1, 1160, -1, "", 1);// 30

		}

		public RichyRichCouchTealAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class RichyRichCouchTealAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new RichyRichCouchTealAddon();
			}
		}

		[Constructable]
		public RichyRichCouchTealAddonDeed()
		{
			Name = "RichyRichCouchTeal";
		}

		public RichyRichCouchTealAddonDeed( Serial serial ) : base( serial )
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