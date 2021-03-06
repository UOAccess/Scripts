
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
	public class UndertheStarsNSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3204, 0, -2, 0}, {3204, -1, -2, 0}, {3204, 1, -2, 0}// 3	18	19	
			, {11599, -2, -1, 0}, {3210, 0, 2, 0}, {3210, 1, 2, 0}// 25	30	31	
			, {3210, -1, 2, 0}, {11594, 2, 1, 0}// 33	41	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new UndertheStarsNSAddonDeed();
			}
		}

		[ Constructable ]
		public UndertheStarsNSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1219, 1, 0, 0, 2312, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1288, -2, -1, 0, 2312, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1219, 0, 0, 0, 2312, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1219, -1, 0, 0, 2312, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1285, 2, 0, 0, 2312, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1285, 2, -2, 0, 2312, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1285, 2, -1, 0, 2312, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2669, 1, 0, 2, 2262, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 5036, -1, 0, 3, 2235, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3239, -1, -2, 0, 2263, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 5034, 1, -1, 2, 2262, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1221, 1, -1, 0, 2312, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1288, -2, 0, 0, 2312, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 5035, 1, -1, 3, 2236, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 4607, -1, 0, 0, 2235, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 4607, 1, -1, 0, 2235, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 4608, 1, 0, 0, 2235, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1221, -1, -1, 0, 2312, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 3239, 1, -2, 0, 2263, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1288, -2, -2, 0, 2312, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 3239, 0, -2, 0, 2263, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 5033, -1, 0, 2, 2236, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1221, 0, -1, 0, 2312, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1220, 1, 1, 0, 2312, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1285, 2, 2, 0, 2312, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1220, -1, 1, 0, 2312, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 4608, -1, 1, 0, 2235, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1285, 2, 1, 0, 2312, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 3223, 1, 2, 0, 2263, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1288, -2, 1, 0, 2312, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1220, 0, 1, 0, 2312, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 3223, 0, 2, 0, 2263, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 2669, -1, 1, 2, 2262, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 3223, -1, 2, 0, 2263, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1288, -2, 2, 0, 2312, -1, "", 1);// 43

		}

		public UndertheStarsNSAddon( Serial serial ) : base( serial )
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

	public class UndertheStarsNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new UndertheStarsNSAddon();
			}
		}

		[Constructable]
		public UndertheStarsNSAddonDeed()
		{
			Name = "UndertheStarsNS";
		}

		public UndertheStarsNSAddonDeed( Serial serial ) : base( serial )
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