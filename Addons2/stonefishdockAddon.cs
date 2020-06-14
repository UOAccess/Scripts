
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
	public class stonefishdockAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1277, -2, -1, 6}, {1277, -2, -3, 6}, {2286, -2, 0, 9}// 1	2	3	
			, {1277, -2, 1, 6}, {2286, -2, -6, 9}, {1277, -1, 0, 6}// 4	5	6	
			, {2286, -2, -2, 9}, {7883, -2, -2, 2}, {1277, -1, 1, 6}// 7	8	9	
			, {1277, -3, 3, 6}, {1277, -2, 0, 6}, {1277, -2, 3, 6}// 10	11	12	
			, {1277, -4, 3, 6}, {1277, -1, 2, 6}, {7883, -2, 2, 2}// 13	14	15	
			, {1277, -1, -4, 6}, {1277, -2, -6, 6}, {2286, -2, -1, 9}// 16	17	18	
			, {4090, -2, 3, 6}, {2286, -2, -4, 9}, {1277, -2, 2, 7}// 19	20	21	
			, {1277, -1, 3, 6}, {1277, -1, -1, 6}, {2286, -2, 2, 8}// 22	23	24	
			, {2286, -2, 1, 9}, {1277, -2, -2, 6}, {1277, -1, -6, 6}// 25	26	27	
			, {2285, -3, 3, 13}, {2284, -2, 3, 8}, {1277, -2, -5, 6}// 28	29	30	
			, {1277, -1, -2, 6}, {1277, -1, -3, 6}, {2286, -2, -3, 9}// 31	32	33	
			, {2285, -2, 3, 13}, {2286, -2, -5, 9}, {7883, -2, -6, 2}// 34	35	36	
			, {1277, -1, -5, 6}, {1277, -2, -4, 6}, {7883, -4, 3, 2}// 37	38	39	
			, {15759, -1, 2, 9}, {3540, -1, 6, 6}, {4604, -4, 4, 6}// 40	41	42	
			, {1277, -2, 6, 6}, {1277, -2, 5, 6}, {1277, -1, 6, 6}// 43	44	45	
			, {1277, -1, 5, 6}, {1277, -1, 4, 6}, {7883, -2, 6, 2}// 46	47	48	
			, {3542, -3, 4, 6}, {1277, -2, 4, 6}, {1277, -3, 5, 6}// 49	50	51	
			, {1277, -4, 5, 6}, {1277, -4, 4, 6}, {7883, -4, 6, 2}// 52	53	54	
			, {1277, -4, 6, 6}, {4604, -3, 5, 6}, {3520, -2, 6, 6}// 55	56	57	
			, {1277, -3, 4, 6}, {1277, -3, 6, 6}, {15759, 3, -2, 16}// 58	59	61	
			, {2284, 3, 3, 5}, {1277, 0, -3, 6}, {1277, 1, 2, 6}// 62	63	64	
			, {1277, 1, 2, 2}, {1277, 1, -1, 6}, {1277, 0, 0, 6}// 65	66	67	
			, {1277, 1, -3, 6}, {1277, 0, -1, 6}, {2286, 1, -2, 8}// 68	69	70	
			, {7883, 1, 2, 2}, {1277, 1, -4, 6}, {2285, 2, 3, 11}// 71	72	73	
			, {1277, 0, -2, 6}, {7883, 3, 3, 2}, {2286, 1, -4, 8}// 74	75	76	
			, {1277, 3, 3, 6}, {2286, 1, 2, 7}, {1277, 0, -6, 6}// 77	78	79	
			, {7883, 1, -6, 2}, {1277, 1, -6, 6}, {1277, 1, 1, 6}// 80	81	82	
			, {2285, 3, 3, 11}, {1277, 1, -6, 2}, {1277, 0, 2, 6}// 83	84	85	
			, {1277, 1, -5, 6}, {2286, 1, -1, 8}, {7883, 1, -2, 2}// 86	87	88	
			, {2286, 1, -5, 8}, {1277, 1, -2, 2}, {1277, 0, 1, 6}// 89	90	91	
			, {1277, 2, 3, 6}, {1277, 0, -4, 6}, {1277, 1, -2, 6}// 92	93	94	
			, {2286, 1, 1, 8}, {2286, 1, 0, 8}, {1277, 1, 0, 6}// 95	96	97	
			, {2286, 1, -6, 8}, {1277, 0, -5, 6}, {1277, 1, 3, 6}// 98	99	100	
			, {2286, 1, -3, 8}, {1277, 0, 3, 6}, {7844, 4, 3, 0}// 101	102	103	
			, {1277, 3, 6, 6}, {4604, 1, 6, 6}, {5153, 2, 4, 15}// 105	106	107	
			, {7883, 3, 6, 2}, {1277, 1, 5, 6}, {1277, 3, 5, 6}// 108	109	110	
			, {1277, 0, 4, 6}, {1277, 2, 5, 6}, {1277, 0, 5, 6}// 111	112	114	
			, {3519, 3, 5, 8}, {7883, 1, 6, 2}, {1277, 2, 4, 6}// 115	116	117	
			, {1277, 3, 4, 6}, {1277, 0, 6, 6}, {1277, 1, 4, 6}// 118	119	120	
			, {1277, 2, 6, 6}, {3530, 0, 6, 6}, {3538, 0, 5, 6}// 121	122	123	
			, {4604, 2, 4, 6}, {1277, 1, 6, 6}// 124	125	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new stonefishdockAddonDeed();
			}
		}

		[ Constructable ]
		public stonefishdockAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9405, -4, 6, 8, 0, 1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 10753, 0, 5, 9, 0, 1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 9405, 3, 6, 8, 0, 1, "", 1);// 113

		}

		public stonefishdockAddon( Serial serial ) : base( serial )
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

	public class stonefishdockAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new stonefishdockAddon();
			}
		}

		[Constructable]
		public stonefishdockAddonDeed()
		{
			Name = "stonefishdock";
		}

		public stonefishdockAddonDeed( Serial serial ) : base( serial )
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