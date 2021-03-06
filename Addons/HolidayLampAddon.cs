
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
	public class HolidayLampAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HolidayLampAddonDeed();
			}
		}

		[ Constructable ]
		public HolidayLampAddon()
		{



			AddComplexComponent( (BaseAddon) this, 2848, 0, 0, 0, 0, 29, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3976, 1, 1, 8, 72, -1, "Garland", 1);// 2
			AddComplexComponent( (BaseAddon) this, 12694, 1, 1, 11, 2456, -1, "Ornament", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3976, 1, 1, 12, 72, -1, "Garland", 1);// 4
			AddComplexComponent( (BaseAddon) this, 12694, 1, 1, 16, 38, -1, "Ornament", 1);// 5
			AddComplexComponent( (BaseAddon) this, 12694, 1, 1, 21, 73, -1, "Ornament", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3976, 1, 1, 18, 72, -1, "Garland", 1);// 7

		}

		public HolidayLampAddon( Serial serial ) : base( serial )
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

	public class HolidayLampAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HolidayLampAddon();
			}
		}

		[Constructable]
		public HolidayLampAddonDeed()
		{
			Name = "HolidayLamp";
		}

		public HolidayLampAddonDeed( Serial serial ) : base( serial )
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