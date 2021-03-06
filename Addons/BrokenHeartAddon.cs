
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
	public class BrokenHeartAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BrokenHeartAddonDeed();
			}
		}

		[ Constructable ]
		public BrokenHeartAddon()
		{



			AddComplexComponent( (BaseAddon) this, 1909, 0, 1, 2, 2454, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1911, 0, 2, 2, 2454, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 9035, 2, -1, 2, 2715, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1900, 2, 2, 0, 2454, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 9037, 1, 0, 8, 2646, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3213, 2, -2, 2, 2704, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1909, 1, 0, 2, 2454, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 9035, 1, -1, 2, 2715, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1912, 2, 0, 2, 2454, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 3213, 1, -1, 2, 2704, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1900, 1, 1, 0, 2454, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 3204, 0, 0, 2, 2716, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 9036, 0, 0, 2, 2712, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 9037, 2, -1, 2, 2646, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 3210, 2, -1, 2, 2716, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 9037, 2, 1, 5, 2646, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 9035, 2, 1, 2, 2715, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 3213, 1, -2, 2, 2704, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 9037, 0, -1, 2, 2646, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 9037, 1, 1, 5, 2646, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 9036, 1, 2, 6, 2712, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 3213, -1, 1, 2, 2712, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 3213, -1, 3, 2, 2712, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 3213, -2, 1, 2, 2712, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 3213, -2, 2, 2, 2712, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 3213, -1, 3, 2, 2712, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 3213, -2, 3, 2, 2712, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 3210, 0, 3, 2, 2716, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 9037, -1, 0, 2, 2712, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 3210, -1, 2, 2, 2716, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 3204, -1, 1, 2, 2716, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 9036, -1, 2, 2, 2712, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 9036, -3, 2, 2, 2712, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 3213, 3, -1, 2, 2704, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 3210, 3, 0, 2, 2716, -1, "", 1);// 35

		}

		public BrokenHeartAddon( Serial serial ) : base( serial )
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

	public class BrokenHeartAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BrokenHeartAddon();
			}
		}

		[Constructable]
		public BrokenHeartAddonDeed()
		{
			Name = "BrokenHeart";
		}

		public BrokenHeartAddonDeed( Serial serial ) : base( serial )
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