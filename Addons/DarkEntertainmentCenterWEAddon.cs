
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
	public class DarkEntertainmentCenterWEAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DarkEntertainmentCenterWEAddonDeed();
			}
		}

		[ Constructable ]
		public DarkEntertainmentCenterWEAddon()
		{



			AddComplexComponent( (BaseAddon) this, 1982, 0, 0, 0, 1849, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1982, 1, 0, 0, 1849, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1825, -1, 0, 0, 1849, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1825, -1, 0, 5, 1849, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1825, -1, 0, 10, 1849, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1825, 2, 0, 0, 1849, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1825, 2, 0, 5, 1849, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1825, 2, 0, 10, 1849, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1982, 0, 0, 13, 1849, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1982, 1, 0, 13, 1849, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1989, -2, 0, 0, 1849, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1989, -2, 0, 6, 1849, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1989, -2, 0, 13, 1849, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1990, 3, 0, 0, 1849, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1990, 3, 0, 6, 1849, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1990, 3, 0, 13, 1849, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 9039, 1, 1, 0, 0, -1, "Television Screen", 1);// 17
			AddComplexComponent( (BaseAddon) this, 3862, -1, 1, 8, 1153, -1, "Volume Button", 1);// 18
			AddComplexComponent( (BaseAddon) this, 3862, -1, 1, 10, 1153, -1, "Channel Button", 1);// 19
			AddComplexComponent( (BaseAddon) this, 3862, -1, 1, 12, 1153, -1, "Power Button", 1);// 20

		}

		public DarkEntertainmentCenterWEAddon( Serial serial ) : base( serial )
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

	public class DarkEntertainmentCenterWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DarkEntertainmentCenterWEAddon();
			}
		}

		[Constructable]
		public DarkEntertainmentCenterWEAddonDeed()
		{
			Name = "DarkEntertainmentCenterWE";
		}

		public DarkEntertainmentCenterWEAddonDeed( Serial serial ) : base( serial )
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