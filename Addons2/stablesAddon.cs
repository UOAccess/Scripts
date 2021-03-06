
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
	public class stablesAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {8, -6, -4, 0}, {8, -6, -3, 0}, {8, -6, -1, 0}// 1	2	3	
			, {8, -6, 0, 0}, {8, -6, 1, 0}, {8, -6, 3, 0}// 4	5	6	
			, {7, -5, -5, 0}, {7, -3, -5, 0}, {7, -2, -5, 0}// 7	8	9	
			, {7, 0, -5, 0}, {7, 1, -5, 0}, {7, -5, 4, 0}// 10	11	12	
			, {7, -4, 4, 0}, {7, -2, 4, 0}, {7, -1, 4, 0}// 13	14	15	
			, {7, 2, 4, 0}, {13, -6, 4, 0}, {9, -6, -5, 0}// 16	17	18	
			, {2187, -3, -4, 0}, {2187, -3, -3, 0}, {2187, -3, -2, 0}// 19	20	21	
			, {2187, -3, -1, 0}, {2187, 0, -4, 0}, {2187, 0, -3, 0}// 22	23	24	
			, {2187, 0, -2, 0}, {2187, 0, -1, 0}, {2186, -5, -1, 0}// 25	26	27	
			, {2186, -3, -1, 0}, {2186, -2, -1, 0}, {2186, 0, -1, 0}// 28	29	30	
			, {2186, 1, -1, 0}, {2879, -5, 1, 0}, {2879, -5, 3, 0}// 31	32	33	
			, {2879, -5, 2, 0}, {12790, -5, -4, 0}, {12790, -5, -3, 0}// 34	41	42	
			, {12790, -5, -2, 0}, {12790, -5, -1, 0}, {12790, -5, 0, 0}// 43	44	45	
			, {12790, -5, 1, 0}, {12790, -5, 2, 0}, {12790, -5, 3, 0}// 46	47	48	
			, {12790, -5, 4, 0}, {12790, -4, -4, 0}, {12790, -4, -3, 0}// 49	50	51	
			, {12790, -4, -2, 0}, {12790, -4, -1, 0}, {12790, -4, 0, 0}// 52	53	54	
			, {12790, -4, 1, 0}, {12790, -4, 2, 0}, {12790, -4, 3, 0}// 55	56	57	
			, {12790, -4, 4, 0}, {12790, -3, -4, 0}, {12790, -3, -3, 0}// 58	59	60	
			, {12790, -3, -2, 0}, {12790, -3, -1, 0}, {12790, -3, 0, 0}// 61	62	63	
			, {12790, -3, 1, 0}, {12790, -3, 2, 0}, {12790, -3, 3, 0}// 64	65	66	
			, {12790, -3, 4, 0}, {12790, -2, -4, 0}, {12790, -2, -3, 0}// 67	68	69	
			, {12790, -2, -2, 0}, {12790, -2, -1, 0}, {12790, -2, 0, 0}// 70	71	72	
			, {12790, -2, 1, 0}, {12790, -2, 2, 0}, {12790, -2, 3, 0}// 73	74	75	
			, {12790, -2, 4, 0}, {12790, -1, -4, 0}, {12790, -1, -3, 0}// 76	77	78	
			, {12790, -1, -2, 0}, {12790, -1, -1, 0}, {12790, -1, 0, 0}// 79	80	81	
			, {12790, -1, 1, 0}, {12790, -1, 2, 0}, {12790, -1, 3, 0}// 82	83	84	
			, {12790, -1, 4, 0}, {12790, 0, -4, 0}, {12790, 0, -3, 0}// 85	86	87	
			, {12790, 0, -2, 0}, {12790, 0, -1, 0}, {12790, 0, 0, 0}// 88	89	90	
			, {12790, 0, 1, 0}, {12790, 0, 2, 0}, {12790, 0, 3, 0}// 91	92	93	
			, {12790, 0, 4, 0}, {12790, 1, -4, 0}, {12790, 1, -3, 0}// 94	95	96	
			, {12790, 1, -2, 0}, {12790, 1, -1, 0}, {12790, 1, 0, 0}// 97	98	99	
			, {12790, 1, 1, 0}, {12790, 1, 2, 0}, {12790, 1, 3, 0}// 100	101	102	
			, {12790, 1, 4, 0}, {12790, 2, -4, 0}, {12790, 2, -3, 0}// 103	104	105	
			, {12790, 2, -2, 0}, {12790, 2, -1, 0}, {12790, 2, 0, 0}// 106	107	108	
			, {12790, 2, 1, 0}, {12790, 2, 2, 0}, {12790, 2, 3, 0}// 109	110	111	
			, {12790, 2, 4, 0}, {1192, -4, -3, 20}, {1192, -4, -2, 20}// 112	113	114	
			, {1192, -4, -1, 20}, {1192, -4, 0, 20}, {1192, -4, 1, 20}// 115	116	117	
			, {1192, -4, 2, 20}, {1192, -4, 3, 20}, {1192, -4, 4, 20}// 118	119	120	
			, {1192, -3, -3, 20}, {1192, -3, -2, 20}, {1192, -3, -1, 20}// 121	122	123	
			, {1192, -3, 0, 20}, {1192, -3, 1, 20}, {1192, -3, 2, 20}// 124	125	126	
			, {1192, -3, 3, 20}, {1192, -3, 4, 20}, {1192, -2, -3, 20}// 127	128	129	
			, {1192, -2, -2, 20}, {1192, -2, -1, 20}, {1192, -2, 0, 20}// 130	131	132	
			, {1192, -2, 1, 20}, {1192, -2, 2, 20}, {1192, -2, 3, 20}// 133	134	135	
			, {1192, -2, 4, 20}, {1192, -1, -3, 20}, {1192, -1, -2, 20}// 136	137	138	
			, {1192, -1, -1, 20}, {1192, -1, 0, 20}, {1192, -1, 1, 20}// 139	140	141	
			, {1192, -1, 2, 20}, {1192, -1, 3, 20}, {1192, -1, 4, 20}// 142	143	144	
			, {1192, 0, -3, 20}, {1192, 0, -2, 20}, {1192, 0, -1, 20}// 145	146	147	
			, {1192, 0, 0, 20}, {1192, 0, 1, 20}, {1192, 0, 2, 20}// 148	149	150	
			, {1192, 0, 3, 20}, {1192, 0, 4, 20}, {1192, 1, -3, 20}// 151	152	153	
			, {1192, 1, -2, 20}, {1192, 1, -1, 20}, {1192, 1, 0, 20}// 154	155	156	
			, {1192, 1, 1, 20}, {1192, 1, 2, 20}, {1192, 1, 3, 20}// 157	158	159	
			, {1192, 1, 4, 20}, {1192, 2, -3, 20}, {1192, 2, -2, 20}// 160	161	162	
			, {1192, 2, -1, 20}, {1192, 2, 0, 20}, {1192, 2, 1, 20}// 163	164	165	
			, {1192, 2, 2, 20}, {1192, 2, 3, 20}, {1192, 2, 4, 20}// 166	167	168	
			, {21, -6, -4, 20}, {21, -6, -3, 20}, {21, -6, -2, 20}// 169	170	171	
			, {21, -6, -1, 20}, {21, -6, 0, 20}, {21, -6, 1, 20}// 172	173	174	
			, {21, -6, 2, 20}, {21, -6, 3, 20}, {21, -6, 4, 20}// 175	176	177	
			, {22, -5, 4, 20}, {22, -4, 4, 20}, {22, -3, 4, 20}// 178	179	180	
			, {22, -2, 4, 20}, {22, -1, 4, 20}, {22, 0, 4, 20}// 181	182	183	
			, {22, 1, 4, 20}, {22, 2, 4, 20}, {22, -5, -5, 20}// 184	185	186	
			, {22, -4, -5, 20}, {22, -3, -5, 20}, {22, -2, -5, 20}// 187	188	189	
			, {22, -1, -5, 20}, {22, 0, -5, 20}, {22, 1, -5, 20}// 190	191	192	
			, {22, 2, -5, 20}, {1216, -5, -4, 20}, {1212, -4, -4, 20}// 193	194	195	
			, {1212, -3, -4, 20}, {1212, -2, -4, 20}, {1212, -1, -4, 20}// 196	197	198	
			, {1212, 0, -4, 20}, {1212, 1, -4, 20}, {1212, 2, -4, 20}// 199	200	201	
			, {1209, -5, -3, 20}, {1209, -5, -2, 20}, {1209, -5, -1, 20}// 202	203	204	
			, {1209, -5, 0, 20}, {1209, -5, 1, 20}, {1209, -5, 2, 20}// 205	206	207	
			, {1209, -5, 3, 20}, {1214, -5, 4, 20}, {2968, -5, 5, 0}// 208	209	210	
			, {3000, -5, 5, 0}, {3892, -4, -3, 0}, {3892, -1, -3, 0}// 211	212	213	
			, {3892, 2, -3, 0}, {4979, -5, 1, 6}, {8, 7, -4, 0}// 214	217	218	
			, {8, 7, -1, 0}, {8, 7, 0, 0}, {8, 7, 1, 0}// 219	220	221	
			, {8, 7, -3, 0}, {8, 7, 3, 0}, {7, 3, -5, 0}// 222	223	224	
			, {7, 4, -5, 0}, {7, 6, -5, 0}, {7, 3, 4, 0}// 225	226	227	
			, {7, 5, 4, 0}, {7, 6, 4, 0}, {6, 7, 4, 0}// 228	229	230	
			, {12, 7, -5, 0}, {2187, 3, -4, 0}, {2187, 3, -2, 0}// 231	232	233	
			, {2187, 3, -3, 0}, {2187, 3, -1, 0}, {2186, 4, -1, 0}// 234	235	236	
			, {2186, 6, -1, 0}, {2186, 7, -1, 0}, {12790, 3, -4, 0}// 237	238	243	
			, {12790, 3, -3, 0}, {12790, 3, -2, 0}, {12790, 3, -1, 0}// 244	245	246	
			, {12790, 3, 0, 0}, {12790, 3, 1, 0}, {12790, 3, 2, 0}// 247	248	249	
			, {12790, 3, 3, 0}, {12790, 3, 4, 0}, {12790, 4, -4, 0}// 250	251	252	
			, {12790, 4, -3, 0}, {12790, 4, -2, 0}, {12790, 4, -1, 0}// 253	254	255	
			, {12790, 4, 0, 0}, {12790, 4, 1, 0}, {12790, 4, 2, 0}// 256	257	258	
			, {12790, 4, 3, 0}, {12790, 4, 4, 0}, {12790, 5, -4, 0}// 259	260	261	
			, {12790, 5, -3, 0}, {12790, 5, -2, 0}, {12790, 5, -1, 0}// 262	263	264	
			, {12790, 5, 0, 0}, {12790, 5, 1, 0}, {12790, 5, 2, 0}// 265	266	267	
			, {12790, 5, 3, 0}, {12790, 5, 4, 0}, {12790, 6, -4, 0}// 268	269	270	
			, {12790, 6, -3, 0}, {12790, 6, -2, 0}, {12790, 6, -1, 0}// 271	272	273	
			, {12790, 6, 0, 0}, {12790, 6, 1, 0}, {12790, 6, 2, 0}// 274	275	276	
			, {12790, 6, 3, 0}, {12790, 6, 4, 0}, {12790, 7, -4, 0}// 277	278	279	
			, {12790, 7, -3, 0}, {12790, 7, -2, 0}, {12790, 7, -1, 0}// 280	281	282	
			, {12790, 7, 0, 0}, {12790, 7, 1, 0}, {12790, 7, 2, 0}// 283	284	285	
			, {12790, 7, 3, 0}, {12790, 7, 4, 0}, {1192, 3, -3, 20}// 286	287	288	
			, {1192, 3, -2, 20}, {1192, 3, -1, 20}, {1192, 3, 0, 20}// 289	290	291	
			, {1192, 3, 1, 20}, {1192, 3, 2, 20}, {1192, 3, 3, 20}// 292	293	294	
			, {1192, 3, 4, 20}, {1192, 4, -3, 20}, {1192, 4, -2, 20}// 295	296	297	
			, {1192, 4, -1, 20}, {1192, 4, 0, 20}, {1192, 4, 1, 20}// 298	299	300	
			, {1192, 4, 2, 20}, {1192, 4, 3, 20}, {1192, 4, 4, 20}// 301	302	303	
			, {1192, 5, -3, 20}, {1192, 5, -2, 20}, {1192, 5, -1, 20}// 304	305	306	
			, {1192, 5, 0, 20}, {1192, 5, 1, 20}, {1192, 5, 2, 20}// 307	308	309	
			, {1192, 5, 3, 20}, {1192, 5, 4, 20}, {1192, 6, -3, 20}// 310	311	312	
			, {1192, 6, -2, 20}, {1192, 6, -1, 20}, {1192, 6, 0, 20}// 313	314	315	
			, {1192, 6, 1, 20}, {1192, 6, 2, 20}, {1192, 6, 3, 20}// 316	317	318	
			, {1192, 6, 4, 20}, {1192, 7, -3, 20}, {1192, 7, -2, 20}// 319	320	321	
			, {1192, 7, -1, 20}, {1192, 7, 0, 20}, {1192, 7, 1, 20}// 322	323	324	
			, {1192, 7, 2, 20}, {1192, 7, 3, 20}, {1192, 7, 4, 20}// 325	326	327	
			, {20, 7, 4, 20}, {21, 7, -4, 20}, {21, 7, -3, 20}// 328	329	330	
			, {21, 7, -2, 20}, {21, 7, -1, 20}, {21, 7, 0, 20}// 331	332	333	
			, {21, 7, 1, 20}, {21, 7, 2, 20}, {21, 7, 3, 20}// 334	335	336	
			, {22, 3, 4, 20}, {22, 4, 4, 20}, {22, 5, 4, 20}// 337	338	339	
			, {22, 6, 4, 20}, {22, 3, -5, 20}, {22, 4, -5, 20}// 340	341	342	
			, {22, 5, -5, 20}, {22, 6, -5, 20}, {22, 7, -5, 20}// 343	344	345	
			, {1212, 3, -4, 20}, {1212, 4, -4, 20}, {1212, 5, -4, 20}// 346	347	348	
			, {1212, 6, -4, 20}, {1215, 7, -4, 20}, {3892, 5, -3, 0}// 349	350	351	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new stablesAddonDeed();
			}
		}

		[ Constructable ]
		public stablesAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 14, 2, -5, 0, 0, 1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 14, -1, -5, 0, 0, 1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 14, -4, -5, 0, 0, 1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 15, -6, -2, 0, 0, 1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 15, -6, 2, 0, 0, 1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 14, -3, 4, 0, 0, 1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 4981, -5, 3, 6, 1, -1, "", 1);// 215
			AddComplexComponent( (BaseAddon) this, 4976, -5, 2, 6, 33, -1, "", 1);// 216
			AddComplexComponent( (BaseAddon) this, 15, 7, -2, 0, 0, 1, "", 1);// 239
			AddComplexComponent( (BaseAddon) this, 15, 7, 2, 0, 0, 1, "", 1);// 240
			AddComplexComponent( (BaseAddon) this, 14, 5, -5, 0, 0, 1, "", 1);// 241
			AddComplexComponent( (BaseAddon) this, 14, 4, 4, 0, 0, 1, "", 1);// 242

		}

		public stablesAddon( Serial serial ) : base( serial )
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

	public class stablesAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new stablesAddon();
			}
		}

		[Constructable]
		public stablesAddonDeed()
		{
			Name = "stables";
		}

		public stablesAddonDeed( Serial serial ) : base( serial )
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