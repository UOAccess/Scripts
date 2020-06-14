
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
	public class smallflowerwagonAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1191, -1, 0, 9}, {1191, -1, 1, 6}, {1191, -1, 2, 6}// 2	4	10	
			, {1191, -1, 0, 6}// 11	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new smallflowerwagonAddonDeed();
			}
		}

		[ Constructable ]
		public smallflowerwagonAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 8653, -2, -1, 6, 0, -1, "wagon", 1);// 1
			AddComplexComponent( (BaseAddon) this, 8655, -1, -2, 6, 0, -1, "wagon", 1);// 3
			AddComplexComponent( (BaseAddon) this, 8655, -1, 2, 7, 0, -1, "wagon", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1191, 0, 2, 6, 262, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 8653, -2, 0, 6, 0, -1, "wagon", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1191, 0, 1, 6, 262, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1191, 0, -1, 6, 372, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 8653, 0, -1, 7, 0, -1, "wagon", 1);// 12
			AddComplexComponent( (BaseAddon) this, 8653, 0, 2, 7, 0, -1, "wagon", 1);// 13
			AddComplexComponent( (BaseAddon) this, 8653, 0, 1, 7, 0, -1, "wagon", 1);// 14
			AddComplexComponent( (BaseAddon) this, 8653, 0, 0, 7, 0, -1, "wagon", 1);// 15
			AddComplexComponent( (BaseAddon) this, 8653, -2, 2, 6, 0, -1, "wagon", 1);// 16
			AddComplexComponent( (BaseAddon) this, 8655, 0, 2, 7, 0, -1, "wagon", 1);// 17
			AddComplexComponent( (BaseAddon) this, 8655, 0, -2, 6, 0, -1, "wagon", 1);// 18
			AddComplexComponent( (BaseAddon) this, 4124, -2, -1, 0, 0, -1, "Wagon Wheel", 1);// 19
			AddComplexComponent( (BaseAddon) this, 4124, -2, 2, 0, 0, -1, "Wagon Wheel", 1);// 20
			AddComplexComponent( (BaseAddon) this, 4124, 1, 2, 1, 0, -1, "Wagon Wheel", 1);// 21
			AddComplexComponent( (BaseAddon) this, 4124, 1, -1, 1, 0, -1, "Wagon Wheel", 1);// 22
			AddComplexComponent( (BaseAddon) this, 5453, -1, 3, 6, 0, -1, "Rain Barrel", 1);// 23
			AddComplexComponent( (BaseAddon) this, 3894, 2, 2, 12, 1149, -1, "Bag of Fertilizer", 1);// 24
			AddComplexComponent( (BaseAddon) this, 3894, 2, 3, 12, 1149, -1, "Bag of Fertilizer", 1);// 25
			AddComplexComponent( (BaseAddon) this, 3894, 2, 0, 11, 1149, -1, "Bag of Fertilizer", 1);// 26
			AddComplexComponent( (BaseAddon) this, 3894, 2, -1, 11, 1149, -1, "Bag of Fertilizer", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1191, 0, 0, 6, 262, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 8653, -1, 2, 17, 0, -1, "wagon", 1);// 29
			AddComplexComponent( (BaseAddon) this, 3220, 0, 2, 13, 1266, -1, "Lillies", 1);// 30
			AddComplexComponent( (BaseAddon) this, 3220, 0, 1, 13, 2558, -1, "Lillies", 1);// 31
			AddComplexComponent( (BaseAddon) this, 3220, 0, 0, 13, 2441, -1, "Lillies", 1);// 32
			AddComplexComponent( (BaseAddon) this, 9036, 0, 3, 24, 2289, -1, "Tulips", 1);// 33
			AddComplexComponent( (BaseAddon) this, 9036, -1, -1, 12, 2981, -1, "Tulips", 1);// 34
			AddComplexComponent( (BaseAddon) this, 9036, 0, 2, 23, 2260, -1, "Tulips", 1);// 35
			AddComplexComponent( (BaseAddon) this, 9036, -1, 0, 13, 2359, -1, "Tulips", 1);// 36
			AddComplexComponent( (BaseAddon) this, 5453, 0, 3, 7, 0, -1, "Rain Barrel", 1);// 37

		}

		public smallflowerwagonAddon( Serial serial ) : base( serial )
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

	public class smallflowerwagonAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new smallflowerwagonAddon();
			}
		}

		[Constructable]
		public smallflowerwagonAddonDeed()
		{
			Name = "smallflowerwagon";
		}

		public smallflowerwagonAddonDeed( Serial serial ) : base( serial )
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