
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
	public class TheBlarneyStoneAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TheBlarneyStoneAddonDeed();
			}
		}

		[ Constructable ]
		public TheBlarneyStoneAddon()
		{



			AddComplexComponent( (BaseAddon) this, 4958, 1, -1, 0, 2212, -1, "The Blarney Stone", 1);// 1
			AddComplexComponent( (BaseAddon) this, 4946, -1, 1, 0, 2212, -1, "The Blarney Stone", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4957, 1, 0, 0, 2212, -1, "The Blarney Stone", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4956, 0, 0, 0, 2212, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4947, 0, 1, 0, 2212, -1, "The Blarney Stone", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4948, 0, 0, 0, 2212, -1, "The Blarney Stone", 1);// 6
			AddComplexComponent( (BaseAddon) this, 4945, 2, 0, 0, 2212, -1, "The Blarney Stone", 1);// 7
			AddComplexComponent( (BaseAddon) this, 4944, 2, 1, 0, 2212, -1, "The Blarney Stone", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4943, 1, 1, 0, 2212, -1, "The Blarney Stone", 1);// 9
			AddComplexComponent( (BaseAddon) this, 5927, 0, 1, 15, 2716, -1, "Irish Moss", 1);// 10
			AddComplexComponent( (BaseAddon) this, 5927, 2, 1, 15, 2716, -1, "Irish Moss", 1);// 11
			AddComplexComponent( (BaseAddon) this, 5927, 1, 0, 15, 2716, -1, "Irish Moss", 1);// 12
			AddComplexComponent( (BaseAddon) this, 5927, 0, 1, 5, 2716, -1, "Irish Moss", 1);// 13
			AddComplexComponent( (BaseAddon) this, 5927, 2, 1, 5, 2716, -1, "Irish Moss", 1);// 14
			AddComplexComponent( (BaseAddon) this, 5927, 0, 2, 14, 2716, -1, "Irish Moss", 1);// 15
			AddComplexComponent( (BaseAddon) this, 5927, 2, 2, 25, 2716, -1, "Irish Moss", 1);// 16
			AddComplexComponent( (BaseAddon) this, 5927, 2, 2, 15, 2716, -1, "Irish Moss", 1);// 17

		}

		public TheBlarneyStoneAddon( Serial serial ) : base( serial )
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

	public class TheBlarneyStoneAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TheBlarneyStoneAddon();
			}
		}

		[Constructable]
		public TheBlarneyStoneAddonDeed()
		{
			Name = "TheBlarneyStone";
		}

		public TheBlarneyStoneAddonDeed( Serial serial ) : base( serial )
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