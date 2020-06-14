
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
	public class Elevator2Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1848, -3, -4, 0}, {1848, -3, -3, 0}, {1848, -3, -2, 0}// 1	2	3	
			, {1848, -3, -1, 0}, {1848, -3, 0, 0}, {1848, -3, 1, 0}// 4	5	6	
			, {1848, -3, 2, 0}, {1848, -3, 3, 0}, {1848, -3, 4, 0}// 7	8	9	
			, {1848, -3, 5, 0}, {1848, -2, -4, 0}, {1848, -2, -3, 0}// 10	11	12	
			, {1848, -2, -2, 0}, {1848, -2, -1, 0}, {1848, -2, 0, 0}// 13	14	15	
			, {1848, -2, 1, 0}, {1848, -2, 2, 0}, {1848, -2, 3, 0}// 16	17	18	
			, {1848, -2, 4, 0}, {1848, -2, 5, 0}, {1848, -1, -4, 0}// 19	20	21	
			, {1848, -1, -3, 0}, {1848, -1, -2, 0}, {1848, -1, -1, 0}// 22	23	24	
			, {1848, -1, 0, 0}, {1848, -1, 1, 0}, {1848, -1, 2, 0}// 25	26	27	
			, {1848, -1, 3, 0}, {1848, -1, 4, 0}, {1848, -1, 5, 0}// 28	29	30	
			, {1848, 0, -4, 0}, {1848, 0, -3, 0}, {1848, 0, -2, 0}// 31	32	33	
			, {1848, 0, 3, 0}, {1848, 0, 4, 0}, {1848, 0, 5, 0}// 34	35	36	
			, {1848, 1, -4, 0}, {1848, 1, -3, 0}, {1848, 1, -2, 0}// 37	38	39	
			, {1848, 1, 3, 0}, {1848, 1, 4, 0}, {1848, 1, 5, 0}// 40	41	42	
			, {1848, -3, -4, 5}, {1848, -3, -3, 5}, {1848, -3, -2, 5}// 43	44	45	
			, {1848, -3, -1, 5}, {1848, -3, 0, 5}, {1848, -3, 1, 5}// 46	47	48	
			, {1848, -3, 2, 5}, {1848, -3, 3, 5}, {1848, -3, 4, 5}// 49	50	51	
			, {1848, -3, 5, 5}, {1848, -2, -4, 5}, {1848, -2, -3, 5}// 52	53	54	
			, {1848, -2, -2, 5}, {1848, -2, -1, 5}, {1848, -2, 0, 5}// 55	56	57	
			, {1848, -2, 1, 5}, {1848, -2, 2, 5}, {1848, -2, 3, 5}// 58	59	60	
			, {1848, -2, 4, 5}, {1848, -2, 5, 5}, {1848, -1, -4, 5}// 61	62	63	
			, {1848, -1, -3, 5}, {1848, -1, 4, 5}, {1848, -1, 5, 5}// 64	65	66	
			, {1848, 0, -4, 5}, {1848, 0, -3, 5}, {1848, 0, 3, 5}// 67	68	69	
			, {1848, 0, 4, 5}, {1848, 0, 5, 5}, {1848, 1, -4, 5}// 70	71	72	
			, {1848, 1, -3, 5}, {1848, 1, 3, 5}, {1848, 1, 4, 5}// 73	74	75	
			, {1848, 1, 5, 5}, {1852, -5, 0, 0}, {1852, -5, 1, 0}// 76	77	78	
			, {1848, -4, 0, 0}, {1848, -4, 1, 0}, {1852, -4, 0, 5}// 79	80	81	
			, {1852, -4, 1, 5}, {762, 0, -2, 0}, {762, 1, -2, 0}// 82	83	84	
			, {763, -1, -1, 0}, {763, -1, 0, 0}, {763, -1, 2, 0}// 85	86	87	
			, {763, -1, 1, 0}, {1247, -3, -4, 10}, {1246, -3, 5, 10}// 88	89	90	
			, {1245, -3, -3, 10}, {1245, -3, -2, 10}, {1245, -3, -1, 10}// 91	92	93	
			, {1245, -3, 0, 10}, {1245, -3, 1, 10}, {1245, -3, 2, 10}// 94	95	96	
			, {1245, -3, 3, 10}, {1245, -3, 4, 10}, {1243, -2, 5, 10}// 97	98	99	
			, {1243, -1, 5, 10}, {1243, 0, 5, 10}, {1243, 1, 5, 10}// 100	101	102	
			, {1242, -2, -4, 10}, {1242, -1, -4, 10}, {1242, 0, -4, 10}// 103	104	105	
			, {1242, 1, -4, 10}, {933, -1, -3, 12}, {933, 0, -3, 12}// 106	132	133	
			, {1848, -1, 2, 12}, {1848, -1, -1, 12}, {1848, 1, 4, 12}// 134	135	144	
			, {1848, 1, 3, 12}, {933, -1, 3, 12}, {933, -1, 3, 17}// 145	146	147	
			, {4121, -1, 3, 9}, {938, 1, 4, 17}, {933, 0, 4, 12}// 150	151	152	
			, {933, -1, 4, 12}, {938, -2, 4, 12}, {933, -1, 4, 17}// 153	154	155	
			, {933, 0, 4, 17}, {938, -1, 4, 22}, {933, 0, -2, 12}// 156	157	158	
			, {933, 0, -2, 17}, {933, 0, -2, 22}, {938, 0, -3, 17}// 159	160	161	
			, {938, 1, -3, 12}, {933, 0, -2, 27}, {933, -1, 3, 22}// 162	163	164	
			, {938, 0, -2, 32}, {7835, 1, -2, 15}, {7835, 1, -2, 24}// 165	168	169	
			, {7835, 1, 4, 33}, {7840, 0, 4, 16}, {938, -1, 3, 30}// 170	171	172	
			, {933, -1, 3, 27}, {938, 0, 4, 22}, {936, -1, 4, 31}// 173	174	175	
			, {936, -2, -2, 21}, {936, -1, -2, 21}, {1848, 2, -4, 0}// 176	177	181	
			, {1848, 2, -3, 0}, {1848, 2, -2, 0}, {1848, 2, 3, 0}// 182	183	184	
			, {1848, 2, 4, 0}, {1848, 2, 5, 0}, {1848, 3, -4, 0}// 185	186	187	
			, {1848, 3, -3, 0}, {1848, 3, -2, 0}, {1848, 3, 3, 0}// 188	189	190	
			, {1848, 3, 4, 0}, {1848, 3, 5, 0}, {1848, 4, -4, 0}// 191	192	193	
			, {1848, 4, -3, 0}, {1848, 4, -2, 0}, {1848, 4, -1, 0}// 194	195	196	
			, {1848, 4, 0, 0}, {1848, 4, 1, 0}, {1848, 4, 2, 0}// 197	198	199	
			, {1848, 4, 3, 0}, {1848, 4, 4, 0}, {1848, 4, 5, 0}// 200	201	202	
			, {1848, 5, -4, 0}, {1848, 5, -3, 0}, {1848, 5, -2, 0}// 203	204	205	
			, {1848, 5, -1, 0}, {1848, 5, 0, 0}, {1848, 5, 1, 0}// 206	207	208	
			, {1848, 5, 2, 0}, {1848, 5, 3, 0}, {1848, 5, 4, 0}// 209	210	211	
			, {1848, 5, 5, 0}, {1848, 6, -4, 0}, {1848, 6, -3, 0}// 212	213	214	
			, {1848, 6, -2, 0}, {1848, 6, -1, 0}, {1848, 6, 0, 0}// 215	216	217	
			, {1848, 6, 1, 0}, {1848, 6, 2, 0}, {1848, 6, 3, 0}// 218	219	220	
			, {1848, 6, 4, 0}, {1848, 6, 5, 0}, {1848, 2, -4, 5}// 221	222	223	
			, {1848, 2, -3, 5}, {1848, 2, 3, 5}, {1848, 2, 4, 5}// 224	225	226	
			, {1848, 2, 5, 5}, {1848, 3, -4, 5}, {1848, 3, -3, 5}// 227	228	229	
			, {1848, 3, 3, 5}, {1848, 3, 4, 5}, {1848, 3, 5, 5}// 230	231	232	
			, {1848, 4, -4, 5}, {1848, 4, -3, 5}, {1848, 4, -2, 5}// 233	234	235	
			, {1848, 4, -1, 5}, {1848, 4, 0, 5}, {1848, 4, 1, 5}// 236	237	238	
			, {1848, 4, 2, 5}, {1848, 4, 3, 5}, {1848, 4, 4, 5}// 239	240	241	
			, {1848, 4, 5, 5}, {1848, 5, -4, 5}, {1848, 5, -3, 5}// 242	243	244	
			, {1848, 5, -2, 5}, {1848, 5, -1, 5}, {1848, 5, 0, 5}// 245	246	247	
			, {1848, 5, 1, 5}, {1848, 5, 2, 5}, {1848, 5, 3, 5}// 248	249	250	
			, {1848, 5, 4, 5}, {1848, 5, 5, 5}, {1848, 6, -4, 5}// 251	252	253	
			, {1848, 6, -3, 5}, {1848, 6, -2, 5}, {1848, 6, -1, 5}// 254	255	256	
			, {1848, 6, 0, 5}, {1848, 6, 1, 5}, {1848, 6, 2, 5}// 257	258	259	
			, {1848, 6, 3, 5}, {1848, 6, 4, 5}, {1848, 6, 5, 5}// 260	261	262	
			, {762, 3, -2, 0}, {762, 2, -2, 0}, {1249, 6, -4, 10}// 263	264	265	
			, {1248, 6, 5, 10}, {1244, 6, -3, 10}, {1244, 6, -2, 10}// 266	267	268	
			, {1244, 6, -1, 10}, {1244, 6, 0, 10}, {1244, 6, 1, 10}// 269	270	271	
			, {1244, 6, 2, 10}, {1244, 6, 3, 10}, {1244, 6, 4, 10}// 272	273	274	
			, {1243, 2, 5, 10}, {1243, 3, 5, 10}, {1243, 4, 5, 10}// 275	276	277	
			, {1243, 5, 5, 10}, {1242, 2, -4, 10}, {1242, 3, -4, 10}// 278	279	280	
			, {1242, 4, -4, 10}, {1242, 5, -4, 10}, {933, 4, -3, 12}// 281	282	306	
			, {938, 5, -3, 12}, {2171, 3, 5, 10}, {2171, 2, 5, 10}// 307	308	309	
			, {2170, 5, 2, 12}, {2170, 5, -1, 12}, {1848, 4, 2, 12}// 310	311	312	
			, {1848, 4, -1, 12}, {1848, 3, 4, 12}, {1848, 2, 4, 12}// 313	322	323	
			, {1848, 2, 3, 12}, {938, 2, 4, 18}, {938, 4, 0, 12}// 324	326	327	
			, {938, 4, 1, 12}, {938, 4, -3, 17}, {933, 3, -2, 12}// 328	329	330	
			, {933, 3, -2, 17}, {933, 3, -2, 22}, {7835, 4, -2, 15}// 331	332	333	
			, {7835, 4, -2, 25}, {7840, 5, -1, 19}, {7840, 4, 5, 23}// 334	335	336	
			, {7835, 4, 3, 15}, {7835, 4, 3, 25}, {933, 3, -2, 27}// 337	338	339	
			, {933, 3, 3, 12}, {933, 3, 3, 17}, {933, 3, 3, 22}// 340	341	342	
			, {933, 3, 3, 27}, {938, 3, 3, 32}, {938, 3, -2, 32}// 343	344	345	
			, {933, 4, 4, 13}, {938, 4, 4, 18}, {938, 5, 4, 12}// 346	347	348	
			, {16, 3, 3, 7}, {17, 3, -1, 7}, {17, 3, 0, 7}// 349	350	351	
			, {17, 3, 2, 7}, {17, 3, 1, 7}// 352	354	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Elevator2AddonDeed();
			}
		}

		[ Constructable ]
		public Elevator2Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1981, -2, -3, 10, 1849, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 1981, -2, -2, 10, 1849, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 1981, -2, -1, 10, 1849, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 1981, -2, 0, 10, 1849, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 1981, -2, 1, 10, 1849, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 1981, -2, 2, 10, 1849, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 1981, -2, 3, 10, 1849, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 1981, -2, 4, 10, 1849, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 1981, -1, -3, 10, 1849, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 1981, 0, -3, 10, 1849, -1, "", 1);// 116
			AddComplexComponent( (BaseAddon) this, 1981, 1, -3, 10, 1849, -1, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 1981, -1, 4, 10, 1849, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 1981, 0, 4, 10, 1849, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 1981, 1, 4, 10, 1849, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 1981, -1, -2, 10, 2312, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 1981, -1, -1, 10, 1849, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 1981, -1, 0, 10, 1849, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 1981, -1, 1, 10, 1849, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 1981, -1, 2, 10, 1849, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 1981, -1, 3, 10, 1849, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 1981, 0, 3, 10, 1849, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 1981, 1, 3, 10, 1849, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 1981, -1, -2, 10, 1849, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 1981, 0, -2, 10, 1849, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 1981, 1, -2, 10, 1849, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1339, 0, -1, 0, 2161, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 1339, 0, 0, 0, 2161, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 1339, 0, 1, 0, 2161, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 1339, 1, -1, 0, 2161, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 1339, 1, 0, 0, 2161, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 1339, 1, 1, 0, 2161, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 7848, 1, 3, 17, 2698, -1, "Winch", 1);// 142
			AddComplexComponent( (BaseAddon) this, 7848, 1, -2, 12, 2698, -1, "Winch", 1);// 143
			AddComplexComponent( (BaseAddon) this, 4121, 1, 4, 12, 0, -1, "Rope Pulley Wheel", 1);// 148
			AddComplexComponent( (BaseAddon) this, 4121, -2, 3, 9, 0, -1, "Rope Pulley Wheel", 1);// 149
			AddComplexComponent( (BaseAddon) this, 4121, -1, -2, 10, 0, -1, "Rope Pulley Wheel", 1);// 166
			AddComplexComponent( (BaseAddon) this, 4121, -2, -2, 10, 0, -1, "Rope Pulley Wheel", 1);// 167
			AddComplexComponent( (BaseAddon) this, 2058, 1, -2, 12, 1899, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 2594, -1, -1, 17, 0, 10, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 2594, -1, 2, 17, 0, 10, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 1981, 5, -3, 10, 1849, -1, "", 1);// 283
			AddComplexComponent( (BaseAddon) this, 1981, 5, -2, 10, 1849, -1, "", 1);// 284
			AddComplexComponent( (BaseAddon) this, 1981, 5, -1, 10, 1849, -1, "", 1);// 285
			AddComplexComponent( (BaseAddon) this, 1981, 5, 0, 10, 1849, -1, "", 1);// 286
			AddComplexComponent( (BaseAddon) this, 1981, 5, 2, 10, 1849, -1, "", 1);// 287
			AddComplexComponent( (BaseAddon) this, 1981, 5, 3, 10, 1849, -1, "", 1);// 288
			AddComplexComponent( (BaseAddon) this, 1981, 5, 4, 10, 1849, -1, "", 1);// 289
			AddComplexComponent( (BaseAddon) this, 1981, 2, -3, 10, 1849, -1, "", 1);// 290
			AddComplexComponent( (BaseAddon) this, 1981, 3, -3, 10, 1849, -1, "", 1);// 291
			AddComplexComponent( (BaseAddon) this, 1981, 4, -3, 10, 1849, -1, "", 1);// 292
			AddComplexComponent( (BaseAddon) this, 1981, 2, 4, 10, 1849, -1, "", 1);// 293
			AddComplexComponent( (BaseAddon) this, 1981, 3, 4, 10, 1849, -1, "", 1);// 294
			AddComplexComponent( (BaseAddon) this, 1981, 4, 4, 10, 1849, -1, "", 1);// 295
			AddComplexComponent( (BaseAddon) this, 1981, 4, -2, 10, 1849, -1, "", 1);// 296
			AddComplexComponent( (BaseAddon) this, 1981, 2, 3, 10, 1849, -1, "", 1);// 297
			AddComplexComponent( (BaseAddon) this, 1981, 3, 3, 10, 1849, -1, "", 1);// 298
			AddComplexComponent( (BaseAddon) this, 1981, 4, 3, 10, 1849, -1, "", 1);// 299
			AddComplexComponent( (BaseAddon) this, 1981, 2, -2, 10, 1849, -1, "", 1);// 300
			AddComplexComponent( (BaseAddon) this, 1981, 3, -2, 10, 1849, -1, "", 1);// 301
			AddComplexComponent( (BaseAddon) this, 1981, 4, -1, 10, 1849, -1, "", 1);// 302
			AddComplexComponent( (BaseAddon) this, 1981, 4, 0, 10, 1849, -1, "", 1);// 303
			AddComplexComponent( (BaseAddon) this, 1981, 4, 1, 10, 1849, -1, "", 1);// 304
			AddComplexComponent( (BaseAddon) this, 1981, 4, 2, 10, 1849, -1, "", 1);// 305
			AddComplexComponent( (BaseAddon) this, 1339, 2, -1, 0, 2161, -1, "", 1);// 314
			AddComplexComponent( (BaseAddon) this, 1339, 2, 0, 0, 2161, -1, "", 1);// 315
			AddComplexComponent( (BaseAddon) this, 1339, 2, 1, 0, 2161, -1, "", 1);// 316
			AddComplexComponent( (BaseAddon) this, 7848, 4, 3, 12, 2698, -1, "Winch", 1);// 317
			AddComplexComponent( (BaseAddon) this, 7848, 2, 3, 17, 2698, -1, "Winch", 1);// 318
			AddComplexComponent( (BaseAddon) this, 7848, 3, -3, 12, 2698, -1, "Winch", 1);// 319
			AddComplexComponent( (BaseAddon) this, 7848, 4, -2, 12, 2698, -1, "Winch", 1);// 320
			AddComplexComponent( (BaseAddon) this, 7848, 2, -2, 12, 2698, -1, "Winch", 1);// 321
			AddComplexComponent( (BaseAddon) this, 7848, 3, 4, 17, 2698, -1, "Winch", 1);// 325
			AddComplexComponent( (BaseAddon) this, 1981, 5, 1, 10, 1849, -1, "", 1);// 353
			AddComplexComponent( (BaseAddon) this, 2058, 2, -2, 12, 1899, -1, "", 1);// 355
			AddComplexComponent( (BaseAddon) this, 2058, 3, -2, 12, 1899, -1, "", 1);// 356
			AddComplexComponent( (BaseAddon) this, 2594, 4, 2, 17, 0, 10, "", 1);// 357
			AddComplexComponent( (BaseAddon) this, 2594, 4, -1, 17, 0, 10, "", 1);// 358

		}

		public Elevator2Addon( Serial serial ) : base( serial )
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

	public class Elevator2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Elevator2Addon();
			}
		}

		[Constructable]
		public Elevator2AddonDeed()
		{
			Name = "Elevator2";
		}

		public Elevator2AddonDeed( Serial serial ) : base( serial )
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