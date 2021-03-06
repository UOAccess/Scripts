
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
	public class SkullballStadiumAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1848, -12, -1, 10}, {1848, -11, -1, 10}, {1848, -10, -1, 10}// 1	2	3	
			, {1848, -9, -1, 10}, {1848, -8, -1, 10}, {1848, -7, -1, 10}// 4	5	6	
			, {1848, -6, -1, 10}, {1848, -5, -1, 10}, {1848, -4, -1, 10}// 7	8	9	
			, {1848, -3, -1, 10}, {1848, -12, -2, 15}, {1848, -11, -2, 15}// 10	11	12	
			, {1848, -10, -2, 15}, {1848, -9, -2, 15}, {1848, -8, -2, 15}// 13	14	15	
			, {1848, -7, -2, 15}, {1848, -6, -2, 15}, {1848, -5, -2, 15}// 16	17	18	
			, {1848, -4, -2, 15}, {1848, -3, -2, 15}, {933, -10, -2, 20}// 19	20	24	
			, {933, -12, -2, 20}, {933, -11, -2, 20}, {1849, -12, -1, 15}// 25	26	27	
			, {1849, -11, -1, 15}, {933, -12, -2, 30}, {933, -11, -2, 25}// 28	30	33	
			, {933, -12, -2, 25}, {2861, -10, -1, 15}, {2861, -9, -1, 15}// 34	35	36	
			, {2861, -8, -1, 15}, {2861, -7, -1, 15}, {2861, -6, -1, 15}// 37	38	39	
			, {2861, -5, -1, 15}, {2861, -4, -1, 15}, {2861, -3, -1, 15}// 40	41	42	
			, {1848, -12, 1, 0}, {1848, -11, 1, 0}, {1848, -10, 1, 0}// 43	44	45	
			, {1848, -9, 1, 0}, {1848, -8, 1, 0}, {1848, -7, 1, 0}// 46	47	48	
			, {1848, -6, 1, 0}, {1848, -5, 1, 0}, {1848, -4, 1, 0}// 49	50	51	
			, {1848, -3, 1, 0}, {1848, -12, 0, 5}, {1848, -11, 0, 5}// 52	53	54	
			, {1848, -10, 0, 5}, {1848, -9, 0, 5}, {1848, -8, 0, 5}// 55	56	57	
			, {1848, -7, 0, 5}, {1848, -6, 0, 5}, {1848, -5, 0, 5}// 58	59	60	
			, {1848, -4, 0, 5}, {1848, -3, 0, 5}, {1849, -12, 1, 5}// 61	62	63	
			, {1849, -11, 1, 5}, {1849, -12, 0, 10}, {1849, -11, 0, 10}// 64	65	66	
			, {1849, -12, 2, 0}, {1849, -11, 2, 0}, {2861, -10, 0, 10}// 67	68	69	
			, {2861, -9, 0, 10}, {2861, -8, 0, 10}, {2861, -7, 0, 10}// 70	71	72	
			, {2861, -6, 0, 10}, {2861, -5, 0, 10}, {2861, -4, 0, 10}// 73	74	75	
			, {2861, -3, 0, 10}, {2861, -10, 1, 5}, {2861, -9, 1, 5}// 76	77	78	
			, {2861, -8, 1, 5}, {2861, -7, 1, 5}, {2861, -6, 1, 5}// 79	80	81	
			, {2861, -5, 1, 5}, {2861, -4, 1, 5}, {2861, -3, 1, 5}// 82	83	84	
			, {2866, -10, 2, 0}, {2866, -9, 2, 0}, {2866, -8, 2, 0}// 85	86	87	
			, {2866, -7, 2, 0}, {2866, -6, 2, 0}, {2866, -5, 2, 0}// 88	89	90	
			, {2866, -4, 2, 0}, {2866, -3, 2, 0}, {1848, -2, -1, 10}// 91	92	93	
			, {1848, -1, -1, 10}, {1848, 0, -1, 10}, {1848, 1, -1, 10}// 94	95	96	
			, {1848, 2, -1, 10}, {1848, 3, -1, 10}, {1848, 4, -1, 10}// 97	98	99	
			, {1848, 5, -1, 10}, {1848, 6, -1, 10}, {1848, 7, -1, 10}// 100	101	102	
			, {1848, 8, -1, 10}, {1848, 9, -1, 10}, {1848, 10, -1, 10}// 103	104	105	
			, {1848, 11, -1, 10}, {1848, 12, -1, 10}, {1848, -2, -2, 15}// 106	107	108	
			, {1848, -1, -2, 15}, {1848, 0, -2, 15}, {1848, 1, -2, 15}// 109	110	111	
			, {1848, 2, -2, 15}, {1848, 3, -2, 15}, {1848, 4, -2, 15}// 112	113	114	
			, {1848, 5, -2, 15}, {1848, 6, -2, 15}, {1848, 7, -2, 15}// 115	116	117	
			, {1848, 8, -2, 15}, {1848, 9, -2, 15}, {1848, 10, -2, 15}// 118	119	120	
			, {1848, 11, -2, 15}, {1848, 12, -2, 15}, {1848, 12, -1, 0}// 121	122	127	
			, {1848, 12, -1, 5}, {1848, 12, -2, 0}, {1848, 12, -2, 5}// 128	129	130	
			, {1848, 12, -2, 10}, {1849, -1, -1, 15}, {1849, 0, -1, 15}// 131	138	139	
			, {1849, 1, -1, 15}, {933, 10, -2, 20}, {933, 11, -2, 25}// 140	141	142	
			, {933, 12, -2, 30}, {933, 0, -2, 30}, {933, 1, -2, 25}// 143	144	145	
			, {933, -1, -2, 25}, {933, -2, -2, 20}, {933, 2, -2, 20}// 146	147	148	
			, {1849, 11, -1, 15}, {1849, 12, -1, 15}, {933, 0, -2, 25}// 149	150	157	
			, {933, 12, -2, 25}, {933, 12, -2, 20}, {933, 11, -2, 20}// 158	159	160	
			, {933, 1, -2, 20}, {933, -1, -2, 20}, {933, 0, -2, 20}// 161	162	163	
			, {2861, -2, -1, 15}, {2861, 2, -1, 15}, {2861, 3, -1, 15}// 164	165	166	
			, {2861, 4, -1, 15}, {2861, 5, -1, 15}, {2861, 6, -1, 15}// 167	168	169	
			, {2861, 7, -1, 15}, {2861, 8, -1, 15}, {2861, 9, -1, 15}// 170	171	172	
			, {2861, 10, -1, 15}, {1848, -2, 1, 0}, {1848, -1, 1, 0}// 173	174	175	
			, {1848, 0, 1, 0}, {1848, 1, 1, 0}, {1848, 2, 1, 0}// 176	177	178	
			, {1848, 3, 1, 0}, {1848, 4, 1, 0}, {1848, 5, 1, 0}// 179	180	181	
			, {1848, 6, 1, 0}, {1848, 7, 1, 0}, {1848, 8, 1, 0}// 182	183	184	
			, {1848, 9, 1, 0}, {1848, 10, 1, 0}, {1848, 11, 1, 0}// 185	186	187	
			, {1848, 12, 1, 0}, {1848, -2, 0, 5}, {1848, -1, 0, 5}// 188	189	190	
			, {1848, 0, 0, 5}, {1848, 1, 0, 5}, {1848, 2, 0, 5}// 191	192	193	
			, {1848, 3, 0, 5}, {1848, 4, 0, 5}, {1848, 5, 0, 5}// 194	195	196	
			, {1848, 6, 0, 5}, {1848, 7, 0, 5}, {1848, 8, 0, 5}// 197	198	199	
			, {1848, 9, 0, 5}, {1848, 10, 0, 5}, {1848, 11, 0, 5}// 200	201	202	
			, {1848, 12, 0, 5}, {1849, -1, 1, 5}, {1849, 0, 1, 5}// 203	204	205	
			, {1849, 1, 1, 5}, {1848, 12, 0, 0}, {1849, 11, 1, 5}// 206	207	208	
			, {1849, 12, 1, 5}, {1849, -1, 0, 10}, {1849, 0, 0, 10}// 209	210	211	
			, {1849, 1, 0, 10}, {1849, 11, 0, 10}, {1849, 12, 0, 10}// 212	213	214	
			, {1849, 12, 2, 0}, {1849, 11, 2, 0}, {1849, 0, 2, 0}// 215	216	217	
			, {1849, -1, 2, 0}, {1849, 1, 2, 0}, {2861, -2, 0, 10}// 218	219	220	
			, {2861, -2, 1, 5}, {2861, 2, 0, 10}, {2861, 3, 0, 10}// 221	222	223	
			, {2861, 4, 0, 10}, {2861, 5, 0, 10}, {2861, 6, 0, 10}// 224	225	226	
			, {2861, 7, 0, 10}, {2861, 8, 0, 10}, {2861, 9, 0, 10}// 227	228	229	
			, {2861, 10, 0, 10}, {2861, 2, 1, 5}, {2861, 3, 1, 5}// 230	231	232	
			, {2861, 4, 1, 5}, {2861, 5, 1, 5}, {2861, 6, 1, 5}// 233	234	235	
			, {2861, 7, 1, 5}, {2861, 8, 1, 5}, {2861, 9, 1, 5}// 236	237	238	
			, {2861, 10, 1, 5}, {2866, -2, 2, 0}, {2866, 2, 2, 0}// 239	240	241	
			, {2866, 3, 2, 0}, {2866, 4, 2, 0}, {2866, 5, 2, 0}// 242	243	244	
			, {2866, 6, 2, 0}, {2866, 7, 2, 0}, {2866, 8, 2, 0}// 245	246	247	
			, {2866, 9, 2, 0}, {2866, 10, 2, 0}// 248	249	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SkullballStadiumAddonDeed();
			}
		}

		[ Constructable ]
		public SkullballStadiumAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6571, -11, -2, 31, 0, 0, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 6571, -12, -2, 36, 0, 0, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 6587, -12, -2, 35, 0, 0, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 6587, -10, -2, 25, 0, 0, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 6571, -10, -2, 26, 0, 0, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 6587, -11, -2, 30, 0, 0, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 6571, 2, -2, 26, 0, 0, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 6571, 1, -2, 31, 0, 0, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 6587, 1, -2, 30, 0, 0, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 6587, 0, -2, 35, 0, 0, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 6571, 12, -2, 36, 0, 0, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 6571, -1, -2, 31, 0, 0, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 6571, -2, -2, 26, 0, 0, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 6587, 11, -2, 30, 0, 0, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 6587, 10, -2, 25, 0, 0, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 6587, -2, -2, 25, 0, 0, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 6571, 11, -2, 31, 0, 0, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 6571, 10, -2, 26, 0, 0, "", 1);// 152
			AddComplexComponent( (BaseAddon) this, 6571, 0, -2, 36, 0, 0, "", 1);// 153
			AddComplexComponent( (BaseAddon) this, 6587, 12, -2, 35, 0, 0, "", 1);// 154
			AddComplexComponent( (BaseAddon) this, 6587, 2, -2, 25, 0, 0, "", 1);// 155
			AddComplexComponent( (BaseAddon) this, 6587, -1, -2, 30, 0, 0, "", 1);// 156

		}

		public SkullballStadiumAddon( Serial serial ) : base( serial )
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

	public class SkullballStadiumAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SkullballStadiumAddon();
			}
		}

		[Constructable]
		public SkullballStadiumAddonDeed()
		{
			Name = "SkullballStadium";
		}

		public SkullballStadiumAddonDeed( Serial serial ) : base( serial )
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