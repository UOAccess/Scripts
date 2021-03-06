
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
	public class shortlogpathtileWEAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new shortlogpathtileWEAddonDeed();
			}
		}

		[ Constructable ]
		public shortlogpathtileWEAddon()
		{



			AddComplexComponent( (BaseAddon) this, 1287, -4, 0, 0, 1701, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1287, -4, 1, 0, 1701, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1287, -3, 0, 0, 1701, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1287, -3, 1, 0, 1701, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1287, -2, 0, 0, 1701, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1287, -2, 1, 0, 1701, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1287, -1, 0, 0, 1701, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1287, -1, 1, 0, 1701, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1287, 0, 0, 0, 1701, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1287, 0, 1, 0, 1701, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1287, 1, 0, 0, 1701, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1287, 1, 1, 0, 1701, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1287, 2, 0, 0, 1701, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1287, 2, 1, 0, 1701, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1287, 3, 0, 0, 1701, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1287, 3, 1, 0, 1701, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1287, 4, 0, 0, 1701, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1287, 4, 1, 0, 1701, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1287, 5, 0, 0, 1701, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1287, 5, 1, 0, 1701, -1, "", 1);// 20

		}

		public shortlogpathtileWEAddon( Serial serial ) : base( serial )
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

	public class shortlogpathtileWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new shortlogpathtileWEAddon();
			}
		}

		[Constructable]
		public shortlogpathtileWEAddonDeed()
		{
			Name = "shortlogpathtileWE";
		}

		public shortlogpathtileWEAddonDeed( Serial serial ) : base( serial )
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