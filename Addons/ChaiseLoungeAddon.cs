
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
	public class ChaiseLoungeAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ChaiseLoungeAddonDeed();
			}
		}

		[ Constructable ]
		public ChaiseLoungeAddon()
		{



			AddComplexComponent( (BaseAddon) this, 6422, -1, 0, 0, 0, -1, "Chaise Lounge", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6423, 0, 0, 0, 0, -1, "Chaise Lounge", 1);// 2
			AddComplexComponent( (BaseAddon) this, 6421, -1, 0, 6, 1175, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2603, -1, 1, 0, 0, -1, "Short Table", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2706, 1, 1, 15, 1175, -1, "Towel", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3841, -1, 1, 6, 0, -1, "Sunscreen", 1);// 6

		}

		public ChaiseLoungeAddon( Serial serial ) : base( serial )
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

	public class ChaiseLoungeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ChaiseLoungeAddon();
			}
		}

		[Constructable]
		public ChaiseLoungeAddonDeed()
		{
			Name = "ChaiseLounge";
		}

		public ChaiseLoungeAddonDeed( Serial serial ) : base( serial )
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
