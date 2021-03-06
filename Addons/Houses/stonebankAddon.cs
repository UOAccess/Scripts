
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
	public class stonebankAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1308, -5, -6, 0}, {1308, -4, -6, 0}, {1308, -3, -6, 0}// 1	2	3	
			, {1308, -2, -6, 0}, {1308, -1, -6, 0}, {1308, 0, -6, 0}// 4	5	6	
			, {1308, 1, -6, 0}, {200, -5, -7, 0}, {200, -4, -7, 0}// 7	8	9	
			, {200, -3, -7, 0}, {200, -2, -7, 0}, {200, -1, -7, 0}// 10	11	12	
			, {200, 0, -7, 0}, {200, 1, -7, 0}, {201, -6, -6, 0}// 13	14	15	
			, {204, -6, -7, 0}, {1476, -5, -6, 23}, {1476, -4, -6, 26}// 16	17	18	
			, {1476, -3, -6, 29}, {1476, -2, -6, 32}, {1476, -1, -6, 35}// 19	20	21	
			, {1476, 0, -6, 38}, {1474, 1, -6, 41}, {222, 1, -7, 20}// 22	23	24	
			, {222, 0, -7, 20}, {222, -1, -7, 20}, {222, -2, -7, 20}// 25	26	27	
			, {1308, -5, -5, 0}, {1308, -5, -4, 0}, {1308, -5, -3, 0}// 28	29	30	
			, {1308, -5, -2, 0}, {1308, -5, -1, 0}, {1308, -5, 0, 0}// 31	32	33	
			, {1308, -5, 1, 0}, {1308, -5, 2, 0}, {1308, -5, 3, 0}// 34	35	36	
			, {1308, -5, 4, 0}, {1308, -5, 5, 0}, {1308, -4, -5, 0}// 37	38	39	
			, {1308, -4, -4, 0}, {1308, -4, -3, 0}, {1308, -4, -2, 0}// 40	41	42	
			, {1308, -4, -1, 0}, {1308, -4, 0, 0}, {1308, -4, 1, 0}// 43	44	45	
			, {1308, -4, 2, 0}, {1308, -4, 3, 0}, {1308, -4, 4, 0}// 46	47	48	
			, {1308, -4, 5, 0}, {1308, -3, -5, 0}, {1308, -3, -4, 0}// 49	50	51	
			, {1308, -3, -3, 0}, {1308, -3, -2, 0}, {1308, -3, -1, 0}// 52	53	54	
			, {1308, -3, 0, 0}, {1308, -3, 1, 0}, {1308, -3, 2, 0}// 55	56	57	
			, {1308, -3, 3, 0}, {1308, -3, 4, 0}, {1308, -3, 5, 0}// 58	59	60	
			, {1308, -2, -5, 0}, {1308, -2, -4, 0}, {1308, -2, -3, 0}// 61	62	63	
			, {1308, -2, -2, 0}, {1308, -2, -1, 0}, {1308, -2, 0, 0}// 64	65	66	
			, {1308, -2, 1, 0}, {1308, -2, 2, 0}, {1308, -2, 3, 0}// 67	68	69	
			, {1308, -2, 4, 0}, {1308, -2, 5, 0}, {1308, -1, -5, 0}// 70	71	72	
			, {1308, -1, -4, 0}, {1308, -1, -3, 0}, {1308, -1, -2, 0}// 73	74	75	
			, {1308, -1, -1, 0}, {1308, -1, 0, 0}, {1308, -1, 1, 0}// 76	77	78	
			, {1308, -1, 2, 0}, {1308, -1, 3, 0}, {1308, -1, 4, 0}// 79	80	81	
			, {1308, -1, 5, 0}, {1308, 0, -5, 0}, {1308, 0, -4, 0}// 82	83	84	
			, {1308, 0, -3, 0}, {1308, 0, -2, 0}, {1308, 0, -1, 0}// 85	86	87	
			, {1308, 0, 0, 0}, {1308, 0, 1, 0}, {1308, 0, 2, 0}// 88	89	90	
			, {1308, 0, 3, 0}, {1308, 0, 4, 0}, {1308, 0, 5, 0}// 91	92	93	
			, {1308, 1, -5, 0}, {1308, 1, -4, 0}, {1308, 1, -3, 0}// 94	95	96	
			, {1308, 1, -2, 0}, {1308, 1, -1, 0}, {1308, 1, 0, 0}// 97	98	99	
			, {1308, 1, 1, 0}, {1308, 1, 2, 0}, {1308, 1, 3, 0}// 100	101	102	
			, {1308, 1, 4, 0}, {1308, 1, 5, 0}, {201, -6, -5, 0}// 103	104	105	
			, {201, -6, -4, 0}, {201, -6, -3, 0}, {201, -6, -2, 0}// 106	107	108	
			, {201, -6, -1, 0}, {201, -6, 0, 0}, {201, -6, 1, 0}// 109	110	111	
			, {201, -6, 2, 0}, {201, -6, 3, 0}, {201, -6, 4, 0}// 112	113	114	
			, {201, -6, 5, 0}, {200, -5, 5, 0}, {200, -4, 5, 0}// 115	116	117	
			, {200, -3, 5, 0}, {200, 0, -1, 0}, {200, -1, -1, 0}// 118	119	120	
			, {201, -2, 0, 0}, {201, -2, 1, 0}, {201, -2, 2, 0}// 121	122	123	
			, {201, -2, 3, 0}, {201, -2, 4, 0}, {199, -2, 5, 0}// 124	125	126	
			, {209, 1, -1, 0}, {2880, 0, 2, 0}, {2878, 1, 2, 0}// 127	128	129	
			, {2880, 0, 1, 0}, {204, -2, -1, 0}, {207, 1, 5, 0}// 130	131	133	
			, {209, 0, 5, 0}, {1476, -5, 7, 23}, {1476, -4, -5, 26}// 134	135	136	
			, {1476, -4, -4, 26}, {1476, -4, -3, 26}, {1476, -4, -2, 26}// 137	138	139	
			, {1476, -4, -1, 26}, {1476, -4, 0, 26}, {1476, -4, 1, 26}// 140	141	142	
			, {1476, -4, 2, 26}, {1476, -4, 3, 26}, {1476, -4, 4, 26}// 143	144	145	
			, {1476, -4, 5, 26}, {1476, -4, 6, 26}, {1476, -4, 7, 26}// 146	147	148	
			, {1476, -3, -5, 29}, {1476, -3, -4, 29}, {1476, -3, -3, 29}// 149	150	151	
			, {1476, -3, -2, 29}, {1476, -3, -1, 29}, {1476, -3, 0, 29}// 152	153	154	
			, {1476, -3, 1, 29}, {1476, -3, 2, 29}, {1476, -3, 3, 29}// 155	156	157	
			, {1476, -3, 4, 29}, {1476, -3, 5, 29}, {1476, -3, 6, 29}// 158	159	160	
			, {1476, -3, 7, 29}, {1476, -2, -5, 32}, {1476, -2, -4, 32}// 161	162	163	
			, {1476, -2, -3, 32}, {1476, -2, -2, 32}, {1476, -2, -1, 32}// 164	165	166	
			, {1476, -2, 0, 32}, {1476, -2, 1, 32}, {1476, -2, 2, 32}// 167	168	169	
			, {1476, -2, 3, 32}, {1476, -2, 4, 32}, {1476, -2, 5, 32}// 170	171	172	
			, {1476, -2, 6, 32}, {1476, -2, 7, 32}, {1476, -1, -5, 35}// 173	174	175	
			, {1476, -1, -4, 35}, {1476, -1, -3, 35}, {1476, -1, -2, 35}// 176	177	178	
			, {1476, -1, -1, 35}, {1476, -1, 0, 35}, {1476, -1, 1, 35}// 179	180	181	
			, {1476, -1, 2, 35}, {1476, -1, 3, 35}, {1476, -1, 4, 35}// 182	183	184	
			, {1476, -1, 5, 35}, {1476, -1, 6, 35}, {1476, -1, 7, 35}// 185	186	187	
			, {1476, 0, -5, 38}, {1476, 0, -4, 38}, {1476, 0, -3, 38}// 188	189	190	
			, {1476, 0, -2, 38}, {1476, 0, -1, 38}, {1476, 0, 0, 38}// 191	192	193	
			, {1476, 0, 1, 38}, {1476, 0, 2, 38}, {1476, 0, 3, 38}// 194	195	196	
			, {1476, 0, 4, 38}, {1476, 0, 5, 38}, {1476, 0, 6, 38}// 197	198	199	
			, {1476, 0, 7, 38}, {1474, 1, -5, 41}, {1474, 1, -4, 41}// 200	201	202	
			, {1474, 1, -3, 41}, {1474, 1, -2, 41}, {1474, 1, -1, 41}// 203	204	205	
			, {1474, 1, 0, 41}, {1474, 1, 1, 41}, {1474, 1, 2, 41}// 206	207	208	
			, {1474, 1, 3, 41}, {1474, 1, 4, 41}, {1474, 1, 5, 41}// 209	210	211	
			, {1474, 1, 6, 41}, {1474, 1, 7, 41}, {1476, -5, -5, 23}// 212	213	214	
			, {1476, -5, -4, 23}, {1476, -5, -3, 23}, {1476, -5, -2, 23}// 215	216	217	
			, {1476, -5, -1, 23}, {1476, -5, 0, 23}, {1476, -5, 1, 23}// 218	219	220	
			, {1476, -5, 2, 23}, {1476, -5, 3, 23}, {1476, -5, 4, 23}// 221	222	223	
			, {1476, -5, 5, 23}, {1476, -5, 6, 23}, {222, -1, 5, 23}// 224	225	226	
			, {222, -1, 5, 20}, {222, 0, 5, 20}, {222, 1, 5, 20}// 227	228	229	
			, {222, -2, 5, 20}, {222, -3, 5, 20}, {1308, 2, -6, 0}// 230	231	232	
			, {1308, 3, -6, 0}, {1308, 4, -6, 0}, {1308, 5, -6, 0}// 233	234	235	
			, {1308, 6, -6, 0}, {200, 2, -7, 0}, {200, 3, -7, 0}// 236	237	238	
			, {200, 4, -7, 0}, {200, 5, -7, 0}, {200, 6, -7, 0}// 239	240	241	
			, {201, 6, -6, 0}, {1475, 7, -6, 23}, {1475, 2, -6, 38}// 242	243	244	
			, {1475, 3, -6, 35}, {1475, 4, -6, 32}, {1475, 5, -6, 29}// 245	246	247	
			, {1475, 6, -6, 26}, {222, 2, -7, 20}, {222, 3, -7, 20}// 248	249	250	
			, {222, 4, -7, 20}, {1308, 2, -5, 0}, {1308, 2, -4, 0}// 251	252	253	
			, {1308, 2, -3, 0}, {1308, 2, -2, 0}, {1308, 2, -1, 0}// 254	255	256	
			, {1308, 2, 0, 0}, {1308, 2, 1, 0}, {1308, 2, 2, 0}// 257	258	259	
			, {1308, 2, 3, 0}, {1308, 2, 4, 0}, {1308, 2, 5, 0}// 260	261	262	
			, {1308, 3, -5, 0}, {1308, 3, -4, 0}, {1308, 3, -3, 0}// 263	264	265	
			, {1308, 3, -2, 0}, {1308, 3, -1, 0}, {1308, 3, 0, 0}// 266	267	268	
			, {1308, 3, 1, 0}, {1308, 3, 2, 0}, {1308, 3, 3, 0}// 269	270	271	
			, {1308, 3, 4, 0}, {1308, 3, 5, 0}, {1308, 4, -5, 0}// 272	273	274	
			, {1308, 4, -4, 0}, {1308, 4, -3, 0}, {1308, 4, -2, 0}// 275	276	277	
			, {1308, 4, -1, 0}, {1308, 4, 0, 0}, {1308, 4, 1, 0}// 278	279	280	
			, {1308, 4, 2, 0}, {1308, 4, 3, 0}, {1308, 4, 4, 0}// 281	282	283	
			, {1308, 4, 5, 0}, {1308, 5, -5, 0}, {1308, 5, -4, 0}// 284	285	286	
			, {1308, 5, -3, 0}, {1308, 5, -2, 0}, {1308, 5, -1, 0}// 287	288	289	
			, {1308, 5, 0, 0}, {1308, 5, 1, 0}, {1308, 5, 2, 0}// 290	291	292	
			, {1308, 5, 3, 0}, {1308, 5, 4, 0}, {1308, 5, 5, 0}// 293	294	295	
			, {1308, 6, -5, 0}, {1308, 6, -4, 0}, {1308, 6, -3, 0}// 296	297	298	
			, {1308, 6, -2, 0}, {1308, 6, -1, 0}, {1308, 6, 0, 0}// 299	300	301	
			, {1308, 6, 1, 0}, {1308, 6, 2, 0}, {1308, 6, 3, 0}// 302	303	304	
			, {1308, 6, 4, 0}, {1308, 6, 5, 0}, {201, 6, -5, 0}// 305	306	307	
			, {201, 6, -4, 0}, {201, 6, -3, 0}, {201, 6, -2, 0}// 308	309	310	
			, {201, 6, 0, 0}, {201, 6, 2, 0}, {201, 6, 4, 0}// 311	312	313	
			, {199, 6, 5, 0}, {200, 5, 5, 0}, {199, 6, -1, 0}// 314	315	316	
			, {200, 5, -1, 0}, {200, 4, -1, 0}, {200, 3, -1, 0}// 317	318	319	
			, {207, 2, -1, 0}, {2878, 3, 2, 0}, {2878, 5, 2, 0}// 320	321	322	
			, {2880, 4, 2, 0}, {2880, 2, 2, 0}, {200, 3, 5, 0}// 323	324	326	
			, {1475, 7, 7, 23}, {1475, 2, -5, 38}, {1475, 2, -4, 38}// 330	331	332	
			, {1475, 2, -3, 38}, {1475, 2, -2, 38}, {1475, 2, -1, 38}// 333	334	335	
			, {1475, 2, 0, 38}, {1475, 2, 1, 38}, {1475, 2, 2, 38}// 336	337	338	
			, {1475, 2, 3, 38}, {1475, 2, 4, 38}, {1475, 2, 5, 38}// 339	340	341	
			, {1475, 2, 6, 38}, {1475, 2, 7, 38}, {1475, 3, -5, 35}// 342	343	344	
			, {1475, 3, -4, 35}, {1475, 3, -3, 35}, {1475, 3, -2, 35}// 345	346	347	
			, {1475, 3, -1, 35}, {1475, 3, 0, 35}, {1475, 3, 1, 35}// 348	349	350	
			, {1475, 3, 2, 35}, {1475, 3, 3, 35}, {1475, 3, 4, 35}// 351	352	353	
			, {1475, 3, 5, 35}, {1475, 3, 6, 35}, {1475, 3, 7, 35}// 354	355	356	
			, {1475, 4, -5, 32}, {1475, 4, -4, 32}, {1475, 4, -3, 32}// 357	358	359	
			, {1475, 4, -2, 32}, {1475, 4, -1, 32}, {1475, 4, 0, 32}// 360	361	362	
			, {1475, 4, 1, 32}, {1475, 4, 2, 32}, {1475, 4, 3, 32}// 363	364	365	
			, {1475, 4, 4, 32}, {1475, 4, 5, 32}, {1475, 4, 6, 32}// 366	367	368	
			, {1475, 4, 7, 32}, {1475, 5, -5, 29}, {1475, 5, -4, 29}// 369	370	371	
			, {1475, 5, -3, 29}, {1475, 5, -2, 29}, {1475, 5, -1, 29}// 372	373	374	
			, {1475, 5, 0, 29}, {1475, 5, 1, 29}, {1475, 5, 2, 29}// 375	376	377	
			, {1475, 5, 3, 29}, {1475, 5, 4, 29}, {1475, 5, 5, 29}// 378	379	380	
			, {1475, 5, 6, 29}, {1475, 5, 7, 29}, {1475, 6, -5, 26}// 381	382	383	
			, {1475, 6, -4, 26}, {1475, 6, -3, 26}, {1475, 6, -2, 26}// 384	385	386	
			, {1475, 6, -1, 26}, {1475, 6, 0, 26}, {1475, 6, 1, 26}// 387	388	389	
			, {1475, 6, 2, 26}, {1475, 6, 3, 26}, {1475, 6, 4, 26}// 390	391	392	
			, {1475, 6, 5, 26}, {1475, 6, 6, 26}, {1475, 6, 7, 26}// 393	394	395	
			, {1475, 7, -5, 23}, {1475, 7, -4, 23}, {1475, 7, -3, 23}// 396	397	398	
			, {1475, 7, -2, 23}, {1475, 7, -1, 23}, {1475, 7, 0, 23}// 399	400	401	
			, {1475, 7, 1, 23}, {1475, 7, 2, 23}, {1475, 7, 3, 23}// 402	403	404	
			, {1475, 7, 4, 23}, {1475, 7, 5, 23}, {1475, 7, 6, 23}// 405	406	407	
			, {222, 3, 5, 23}, {222, 3, 5, 23}, {222, 2, 5, 20}// 408	409	410	
			, {222, 3, 5, 20}, {222, 4, 5, 20}// 411	412	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new stonebankAddonDeed();
			}
		}

		[ Constructable ]
		public stonebankAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 202, -1, 5, 0, 0, 1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 202, 2, 5, 0, 0, 1, "", 1);// 325
			AddComplexComponent( (BaseAddon) this, 203, 6, 3, 0, 0, 1, "", 1);// 327
			AddComplexComponent( (BaseAddon) this, 203, 6, 1, 0, 0, 1, "", 1);// 328
			AddComplexComponent( (BaseAddon) this, 202, 4, 5, 0, 0, 1, "", 1);// 329

		}

		public stonebankAddon( Serial serial ) : base( serial )
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

	public class stonebankAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new stonebankAddon();
			}
		}

		[Constructable]
		public stonebankAddonDeed()
		{
			Name = "stonebank";
		}

		public stonebankAddonDeed( Serial serial ) : base( serial )
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