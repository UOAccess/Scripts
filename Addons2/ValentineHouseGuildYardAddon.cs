
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
	public class ValentineHouseGuildYardAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6056, -4, -8, 1}, {6811, -4, -10, 1}, {3215, -4, 1, 1}// 1	2	3	
			, {3215, -4, 2, 1}, {3237, -4, -8, 1}, {6051, -4, -9, 1}// 4	5	6	
			, {7978, -4, -1, 0}, {3215, -4, 0, 1}, {3215, -4, -1, 1}// 8	9	10	
			, {3215, -4, 3, 1}, {7979, -4, -1, 7}, {9334, -5, 3, 1}// 11	12	13	
			, {9330, -5, 3, 2}, {9330, -7, -4, 2}, {9330, -4, -12, 2}// 16	18	19	
			, {9334, -7, -4, 1}, {6054, -4, -11, 1}, {6052, -4, -10, 1}// 20	21	23	
			, {3239, -4, -9, 1}, {9334, -4, -12, 1}, {7978, -4, 10, 0}// 25	26	27	
			, {3215, -4, 13, 1}, {3215, -4, 12, 1}, {3215, -4, 5, 1}// 28	29	30	
			, {7979, -4, 10, 7}, {7978, -4, 5, 0}, {7979, -4, 5, 7}// 31	34	35	
			, {3215, -4, 10, 1}, {9330, -9, 9, 2}, {3215, -4, 4, 1}// 37	38	39	
			, {9334, -9, 9, 1}, {3215, -4, 11, 1}, {8134, 0, -9, 1}// 41	42	43	
			, {9334, 8, -1, 1}, {6039, 0, -11, 1}, {163, 2, -12, 1}// 44	45	48	
			, {6039, -1, -11, 1}, {6039, 0, -9, 1}, {2920, 1, -5, 1}// 49	50	51	
			, {3215, 1, -1, 1}, {6039, -2, -11, 1}, {3211, -1, -7, 1}// 52	53	54	
			, {3224, -3, -7, 1}, {1183, -2, 2, 1}, {6049, -2, -7, 1}// 55	56	57	
			, {3332, -3, -7, 1}, {3257, 2, -11, 1}, {6039, 0, -10, 1}// 58	59	60	
			, {8134, -2, -9, 1}, {8134, 2, -9, 1}, {6811, 3, -10, 1}// 61	62	63	
			, {6039, -1, -12, 1}, {8134, -1, -9, 1}, {1183, -1, 1, 1}// 64	65	66	
			, {3208, -2, -7, 1}, {9334, 7, -7, 1}, {6039, -3, -10, 1}// 67	68	69	
			, {1183, -1, 2, 1}, {1183, -3, 3, 1}, {6055, 2, -7, 1}// 70	71	72	
			, {3224, 3, -7, 1}, {1183, -2, 3, 1}, {3144, 4, 1, 1}// 73	74	75	
			, {6045, 3, -10, 1}, {6050, -1, -7, 1}, {3144, 8, 2, 1}// 76	77	78	
			, {1183, -3, 1, 1}, {6039, 1, -11, 1}, {6055, 3, -8, 1}// 79	81	82	
			, {1183, 0, 0, 1}, {6049, 0, -7, 1}, {8114, 0, -11, 1}// 83	84	85	
			, {6039, 1, -9, 1}, {1183, 0, 3, 1}, {1183, -3, 0, 1}// 86	87	88	
			, {3257, -3, -11, 1}, {6058, 2, -8, 1}, {6039, -1, -9, 1}// 89	90	91	
			, {3332, 2, -7, 1}, {6053, 3, -11, 1}, {1183, -1, -1, 1}// 92	93	94	
			, {3215, 1, 3, 1}, {1183, -2, 0, 1}, {1183, -3, 2, 1}// 96	97	98	
			, {1183, 0, -1, 1}, {1183, -1, 3, 1}, {3144, 8, -5, 1}// 99	100	101	
			, {9329, 8, -1, 1}, {1183, -1, 0, 1}, {7979, 1, -1, 7}// 102	103	104	
			, {3215, 1, 2, 1}, {9329, 7, -7, 1}, {1183, -3, -1, 1}// 105	106	107	
			, {1183, -2, -1, 1}, {3215, 1, 0, 1}, {3208, 1, -7, 1}// 108	109	110	
			, {163, -3, -12, 1}, {1183, 0, 1, 1}, {3215, 1, 1, 1}// 111	112	113	
			, {9334, 3, -12, 1}, {3212, 0, -7, 1}, {2922, -1, -5, 1}// 114	115	116	
			, {7978, 1, -1, 0}, {2921, -2, -5, 1}, {6039, -2, -9, 1}// 117	118	120	
			, {6039, -2, -10, 1}, {13488, 0, -12, 1}, {6039, 2, -12, 1}// 121	122	123	
			, {6039, 1, -8, 1}, {6039, 2, -10, 1}, {6039, 2, -9, 1}// 124	125	126	
			, {6039, 0, -8, 1}, {6046, 3, -9, 1}, {6059, -3, -8, 1}// 127	128	129	
			, {3239, 3, -9, 1}, {6039, 0, -12, 1}, {6039, -2, -12, 1}// 130	131	132	
			, {1183, 0, 2, 1}, {6060, -3, -11, 1}, {6039, 1, -10, 1}// 133	134	135	
			, {6039, -1, -8, 1}, {6056, -3, -7, 1}, {6039, -1, -10, 1}// 136	137	138	
			, {6039, -3, -9, 1}, {6057, 2, -11, 1}, {6039, 1, -12, 1}// 139	140	141	
			, {8134, 1, -9, 1}, {3237, 3, -8, 1}, {6039, -2, -8, 1}// 142	143	144	
			, {9037, -1, -7, 1}, {9330, 3, -12, 2}, {9037, 0, -7, 1}// 145	146	147	
			, {2922, 0, -5, 1}, {6050, 1, -7, 1}, {1183, -2, 1, 1}// 148	149	150	
			, {5941, 7, 7, 1}, {5947, 5, 7, 1}, {5944, 6, 5, 1}// 151	152	153	
			, {3144, 9, 4, 1}, {1183, -2, 5, 1}, {1183, -3, 6, 1}// 154	155	156	
			, {1183, -3, 11, 1}, {1183, -2, 12, 1}, {3144, 9, 9, 1}// 157	158	159	
			, {1183, -3, 5, 1}, {1183, -2, 10, 1}, {1183, -2, 6, 1}// 160	161	162	
			, {1183, -2, 4, 1}, {1183, 0, 13, 1}, {1183, -3, 4, 1}// 163	164	165	
			, {3215, 1, 8, 1}, {3215, 1, 12, 1}, {3215, 1, 9, 1}// 166	167	168	
			, {3215, 1, 10, 1}, {3144, 7, 12, 1}, {3144, 3, 5, 1}// 169	170	171	
			, {5948, 4, 7, 1}, {5949, 4, 6, 1}, {5940, 7, 8, 1}// 172	173	174	
			, {1183, -2, 11, 1}, {9329, 2, 11, 1}, {3215, 1, 7, 1}// 175	176	177	
			, {3144, 4, 9, 1}, {3215, 1, 13, 1}, {1183, -3, 9, 1}// 178	179	180	
			, {1183, -2, 9, 1}, {5950, 5, 6, 1}, {1183, -3, 12, 1}// 181	182	183	
			, {5951, 5, 5, 1}, {5953, 4, 5, 1}, {3215, 1, 11, 1}// 184	185	186	
			, {5945, 6, 6, 1}, {1183, -2, 7, 1}, {5942, 7, 6, 1}// 187	188	189	
			, {5938, 5, 8, 1}, {1183, -1, 9, 1}, {5943, 7, 5, 1}// 190	191	192	
			, {1183, -1, 10, 1}, {1183, 0, 9, 1}, {1183, 0, 10, 1}// 193	194	195	
			, {1183, -1, 13, 1}, {5937, 4, 8, 1}, {1183, -1, 7, 1}// 196	197	198	
			, {1183, -1, 8, 1}, {1183, 0, 7, 1}, {1183, 0, 8, 1}// 199	200	201	
			, {3215, 1, 4, 1}, {1183, -3, 10, 1}, {1183, -2, 13, 1}// 203	204	205	
			, {1183, -1, 11, 1}, {1183, -1, 12, 1}, {1183, 0, 11, 1}// 207	208	209	
			, {1183, 0, 12, 1}, {1183, -2, 8, 1}, {9334, 2, 11, 1}// 210	211	212	
			, {1183, -3, 7, 1}, {3215, 1, 6, 1}, {1183, -3, 13, 1}// 213	214	215	
			, {1183, 0, 6, 1}, {1183, 0, 5, 1}, {1183, -1, 6, 1}// 216	217	218	
			, {9334, 2, 4, 1}, {5939, 6, 8, 1}, {1183, -1, 5, 1}// 219	220	221	
			, {5946, 6, 7, 1}, {1183, 0, 4, 1}, {9329, 2, 4, 1}// 222	223	224	
			, {1183, -3, 8, 1}, {3215, 1, 5, 1}, {1183, -1, 4, 1}// 225	226	227	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ValentineHouseGuildYardAddonDeed();
			}
		}

		[ Constructable ]
		public ValentineHouseGuildYardAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3144, -6, -8, 1, 25, -1, "fragrant rose petals", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3144, -7, -1, 1, 25, -1, "fragrant rose petals", 1);// 14
			AddComplexComponent( (BaseAddon) this, 6571, -4, -1, 10, 0, 29, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 3144, -8, -12, 1, 25, -1, "fragrant rose petals", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2647, -4, -6, 1, 0, -1, "Rolled Up Picnic Blanket", 1);// 22
			AddComplexComponent( (BaseAddon) this, 3515, -4, -11, 1, 1166, -1, "Cherry Blossom Petals", 1);// 24
			AddComplexComponent( (BaseAddon) this, 6571, -4, 10, 10, 0, 29, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 6571, -4, 5, 10, 0, 29, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 3144, -8, 11, 1, 25, -1, "fragrant rose petals", 1);// 36
			AddComplexComponent( (BaseAddon) this, 3144, -6, 6, 1, 25, -1, "fragrant rose petals", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1115, 5, 3, 1, 1153, -1, "Marble Bench", 1);// 46
			AddComplexComponent( (BaseAddon) this, 9433, 2, -6, 1, 0, -1, "Picnic Basket", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1115, 6, 3, 1, 1153, -1, "Marble Bench", 1);// 80
			AddComplexComponent( (BaseAddon) this, 6571, 1, -1, 10, 0, 29, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 3515, 3, -11, 1, 1166, -1, "Cherry Blossom Petals", 1);// 119
			AddComplexComponent( (BaseAddon) this, 1115, 6, 10, 1, 1153, -1, "Marble Bench", 1);// 202
			AddComplexComponent( (BaseAddon) this, 1115, 5, 10, 1, 1153, -1, "Marble Bench", 1);// 206

		}

		public ValentineHouseGuildYardAddon( Serial serial ) : base( serial )
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

	public class ValentineHouseGuildYardAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ValentineHouseGuildYardAddon();
			}
		}

		[Constructable]
		public ValentineHouseGuildYardAddonDeed()
		{
			Name = "ValentineHouseGuildYard";
		}

		public ValentineHouseGuildYardAddonDeed( Serial serial ) : base( serial )
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