
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
	public class SmallOreWagonAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1191, -1, -1, 7}, {1191, -1, 1, 7}, {1191, 0, 2, 6}// 2	4	6	
			, {1191, 0, 1, 7}, {1191, 0, -1, 7}, {1191, -1, 2, 7}// 8	9	10	
			, {1191, -1, 0, 7}, {1191, 0, 0, 7}, {4017, 0, 3, 5}// 11	24	29	
			, {4985, 2, 2, 8}, {4984, 2, 3, 8}, {7144, 2, 0, 7}// 30	31	32	
			, {7150, 2, -1, 8}, {7156, 2, -1, 5}, {7162, 2, 0, 4}// 33	34	35	
			, {15750, 1, 0, 0}, {15786, 1, 1, 0}// 39	40	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmallOreWagonAddonDeed();
			}
		}

		[ Constructable ]
		public SmallOreWagonAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 8653, -2, -1, 7, 0, -1, "wagon", 1);// 1
			AddComplexComponent( (BaseAddon) this, 8655, -1, -2, 7, 0, -1, "wagon", 1);// 3
			AddComplexComponent( (BaseAddon) this, 8655, -1, 2, 7, 0, -1, "wagon", 1);// 5
			AddComplexComponent( (BaseAddon) this, 8653, -2, 0, 7, 0, -1, "wagon", 1);// 7
			AddComplexComponent( (BaseAddon) this, 8653, 0, -1, 8, 0, -1, "wagon", 1);// 12
			AddComplexComponent( (BaseAddon) this, 8653, 0, 2, 8, 0, -1, "wagon", 1);// 13
			AddComplexComponent( (BaseAddon) this, 8653, 0, 1, 8, 0, -1, "wagon", 1);// 14
			AddComplexComponent( (BaseAddon) this, 8653, 0, 0, 8, 0, -1, "wagon", 1);// 15
			AddComplexComponent( (BaseAddon) this, 8653, -2, 2, 7, 0, -1, "wagon", 1);// 16
			AddComplexComponent( (BaseAddon) this, 8655, 0, 2, 7, 0, -1, "wagon", 1);// 17
			AddComplexComponent( (BaseAddon) this, 8655, 0, -2, 7, 0, -1, "wagon", 1);// 18
			AddComplexComponent( (BaseAddon) this, 4124, -2, -1, 0, 0, -1, "Wagon Wheel", 1);// 19
			AddComplexComponent( (BaseAddon) this, 4124, -2, 2, 0, 0, -1, "Wagon Wheel", 1);// 20
			AddComplexComponent( (BaseAddon) this, 4124, 1, 2, 1, 0, -1, "Wagon Wheel", 1);// 21
			AddComplexComponent( (BaseAddon) this, 4124, 1, -1, 1, 0, -1, "Wagon Wheel", 1);// 22
			AddComplexComponent( (BaseAddon) this, 5453, -1, 3, 6, 0, -1, "Rain Barrel", 1);// 23
			AddComplexComponent( (BaseAddon) this, 8653, -1, 2, 18, 0, -1, "wagon", 1);// 25
			AddComplexComponent( (BaseAddon) this, 6585, 0, 2, 14, 2418, -1, "", 2);// 26
			AddComplexComponent( (BaseAddon) this, 6585, 0, 1, 14, 2219, -1, "", 2);// 27
			AddComplexComponent( (BaseAddon) this, 6585, 0, 0, 14, 2207, -1, "", 2);// 28
			AddComplexComponent( (BaseAddon) this, 7162, 2, 0, 11, 1908, -1, "Shadow Iron", 1);// 36
			AddComplexComponent( (BaseAddon) this, 7162, 2, -1, 11, 562, -1, "Verite Ingots", 1);// 37
			AddComplexComponent( (BaseAddon) this, 7162, 2, -1, 2, 1201, -1, "Agapite Ingots", 1);// 38

		}

		public SmallOreWagonAddon( Serial serial ) : base( serial )
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

	public class SmallOreWagonAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmallOreWagonAddon();
			}
		}

		[Constructable]
		public SmallOreWagonAddonDeed()
		{
			Name = "SmallOreWagon";
		}

		public SmallOreWagonAddonDeed( Serial serial ) : base( serial )
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