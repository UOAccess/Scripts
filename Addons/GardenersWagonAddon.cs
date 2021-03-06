
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
	public class GardenersWagonAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4124, -1, 2, 0}, {4124, 1, 2, 0}, {4117, 1, 0, 0}// 1	2	3	
			, {2938, -1, 2, 3}, {2938, -1, 0, 3}, {2938, -1, 1, 3}// 4	5	6	
			, {2938, 0, 0, 3}, {2938, 0, 1, 3}, {2938, 0, 2, 3}// 7	8	9	
			, {2938, -1, -1, 3}, {2938, 0, -1, 3}, {3645, 2, 2, 5}// 10	11	12	
			, {3645, 2, 1, 5}, {3645, 2, 0, 5}, {3223, 0, 1, 9}// 13	14	15	
			, {3210, -1, 1, 10}, {3265, 0, 0, 11}, {9037, 0, -1, 12}// 16	17	18	
			, {3241, -1, -1, 9}, {8655, -1, 2, 7}, {8654, 0, 2, 7}// 19	20	21	
			, {8654, 0, 1, 7}, {8654, 0, 0, 7}, {8654, 0, -1, 7}// 22	23	24	
			, {8655, 0, 2, 7}, {8655, -1, -2, 7}, {8655, 0, -2, 7}// 25	26	27	
			, {8654, -2, -1, 7}, {8654, -2, 0, 7}, {8654, -2, 1, 7}// 28	29	30	
			, {8654, -2, 2, 7}, {3212, -1, 0, 10}, {3203, 0, 2, 12}// 31	32	35	
			, {3220, -1, 2, 10}, {4551, -1, 2, 0}, {4550, 0, 2, 0}// 36	37	38	
			, {2888, 2, 0, 11}, {3646, 2, 1, 9}, {3646, 2, 2, 9}// 39	40	41	
			, {3645, 2, 3, 5}, {3898, 1, 3, 31}, {2448, 2, 3, 10}// 42	43	46	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GardenersWagonAddonDeed();
			}
		}

		[ Constructable ]
		public GardenersWagonAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5368, 2, 2, 14, 1369, -1, "Garden Hose", 2);// 33
			AddComplexComponent( (BaseAddon) this, 4165, 2, 1, 15, 1834, -1, "Potting Soil", 2);// 34
			AddComplexComponent( (BaseAddon) this, 9557, 0, 3, 0, 0, -1, "Garden Hoe", 1);// 44
			AddComplexComponent( (BaseAddon) this, 4023, 1, 3, 0, 1845, -1, "Gardening Trowel", 1);// 45

		}

		public GardenersWagonAddon( Serial serial ) : base( serial )
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

	public class GardenersWagonAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GardenersWagonAddon();
			}
		}

		[Constructable]
		public GardenersWagonAddonDeed()
		{
			Name = "GardenersWagon";
		}

		public GardenersWagonAddonDeed( Serial serial ) : base( serial )
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