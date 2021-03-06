
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
	public class forgeplatformCDAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {8674, 4, -9, 2}, {1301, 0, -8, 2}, {1301, -1, 4, 2}// 1	2	3	
			, {1301, 3, -1, 2}, {1301, 2, -5, 2}, {1301, -2, 1, 2}// 4	5	6	
			, {1301, 1, 4, 2}, {1301, -6, -6, 2}, {1301, 2, 1, 2}// 7	8	9	
			, {1301, 1, -4, 2}, {8674, -1, -9, 2}, {1301, 2, 0, 2}// 10	11	12	
			, {1301, 2, -1, 2}, {1301, -4, -3, 2}, {1301, -1, 1, 2}// 13	14	15	
			, {1301, -6, 2, 2}, {5126, -7, -6, 10}, {1301, -7, -3, 2}// 16	17	18	
			, {1301, 0, 5, 2}, {1301, -1, 5, 2}, {1301, -2, -3, 2}// 19	20	21	
			, {1301, 3, 6, 2}, {1301, 0, 2, 2}, {1301, 0, 3, 2}// 22	23	24	
			, {1301, -1, -1, 2}, {1301, 4, -1, 2}, {1301, 1, -3, 2}// 25	26	27	
			, {3909, -5, -8, 4}, {1301, -7, -1, 2}, {1301, 3, 5, 2}// 28	29	30	
			, {1301, 2, -3, 2}, {1301, -4, -5, 2}, {1301, -6, -3, 2}// 31	32	33	
			, {1301, -6, -1, 2}, {8674, 2, -9, 2}, {1301, 1, 2, 2}// 34	35	36	
			, {1301, 3, -2, 2}, {1301, 4, -3, 2}, {1301, 1, 1, 2}// 37	38	39	
			, {763, -7, -8, 0}, {1301, 1, -4, 2}, {1301, 1, 3, 2}// 40	41	42	
			, {5045, -7, -8, 13}, {1301, 3, 2, 2}, {1301, -4, 6, 2}// 43	44	45	
			, {1301, -2, 6, 2}, {578, -8, -4, 2}, {1301, 3, -7, 2}// 46	47	48	
			, {1301, -3, -6, 2}, {1301, 2, -8, 2}, {1301, -1, 3, 2}// 49	50	51	
			, {1301, 0, -6, 2}, {1301, 4, 2, 2}, {1301, 3, 4, 2}// 52	53	54	
			, {1301, -1, -7, 2}, {1301, -3, 5, 2}, {1301, 3, 1, 2}// 55	56	57	
			, {5094, -7, -5, 15}, {1301, 3, -8, 2}, {1301, -1, 6, 2}// 58	59	60	
			, {761, -7, -4, 0}, {1301, 1, -2, 2}, {1301, -4, 3, 2}// 61	62	63	
			, {5049, -6, -8, 4}, {1301, -5, 4, 2}, {578, -8, -5, 2}// 64	65	66	
			, {1301, -4, 0, 2}, {1301, -5, -3, 2}, {1301, 3, -5, 2}// 67	68	69	
			, {5045, -7, -8, 11}, {1301, 3, -4, 2}, {1301, -6, 5, 2}// 70	71	72	
			, {1301, 4, -4, 2}, {1301, 2, -4, 2}, {1301, -6, -7, 2}// 73	74	75	
			, {1301, 1, 5, 2}, {1301, -3, 0, 2}, {1301, -2, 0, 2}// 76	77	78	
			, {1301, 1, 0, 2}, {1301, 4, 1, 2}, {1301, 1, -1, 2}// 79	80	81	
			, {764, -7, -9, 2}, {1301, 1, -6, 2}, {1301, -2, 4, 2}// 82	83	84	
			, {1301, -7, 1, 2}, {1180, -7, -7, 12}, {1301, 1, -6, 2}// 85	86	87	
			, {1301, 1, -8, 2}, {1301, -6, -5, 2}, {1301, -7, 2, 2}// 88	89	90	
			, {1301, 4, 4, 2}, {8674, -6, -9, 2}, {1301, -1, -6, 2}// 91	92	93	
			, {1301, -2, -8, 2}, {1301, -5, 5, 2}, {1301, 1, 6, 2}// 94	95	96	
			, {1301, -4, -8, 2}, {1301, -4, 2, 2}, {5050, -7, -7, 11}// 97	98	99	
			, {1301, 2, 4, 2}, {1301, 0, -4, 2}, {1301, -2, 5, 2}// 100	101	102	
			, {578, -8, -8, 2}, {1301, -3, 2, 2}, {1301, -1, 2, 2}// 103	104	105	
			, {763, -7, -5, 0}, {1301, -6, -8, 2}, {1301, 1, 1, 2}// 106	107	108	
			, {1180, -7, -6, 12}, {1301, 1, -5, 2}, {1301, -5, 2, 2}// 109	110	111	
			, {578, -8, -7, 2}, {8674, 3, -9, 2}, {1301, -3, -4, 2}// 112	113	114	
			, {1301, -3, -5, 2}, {1301, 4, 0, 2}, {1301, 3, -3, 2}// 115	116	117	
			, {1301, -1, -8, 2}, {1301, 1, 0, 2}, {1301, 1, -1, 2}// 118	119	120	
			, {1301, 1, -7, 2}, {5096, -7, -4, 12}, {1301, -4, -1, 2}// 121	122	123	
			, {1301, 4, -6, 2}, {5126, -7, -6, 14}, {1301, 3, 3, 2}// 124	125	126	
			, {1301, 1, -3, 2}, {1301, 4, -5, 2}, {1301, 0, 1, 2}// 127	128	129	
			, {1301, -4, -7, 2}, {1301, 3, -6, 2}, {1301, -3, -2, 2}// 130	131	132	
			, {1301, -6, 4, 2}, {763, -7, -6, 0}, {1301, -7, 0, 2}// 133	134	135	
			, {1301, -2, -1, 2}, {1301, 2, 5, 2}, {1301, -6, 0, 2}// 136	137	138	
			, {1301, 1, 3, 2}, {8674, 0, -9, 2}, {1301, -4, 4, 2}// 139	140	141	
			, {5088, -6, 6, 8}, {1301, -6, 6, 2}, {1301, 2, -2, 2}// 142	143	144	
			, {1301, -3, 1, 2}, {1301, -5, -2, 2}, {5098, -7, -6, 17}// 145	146	147	
			, {1301, 0, -2, 2}, {1301, -5, -7, 2}, {578, -8, -6, 2}// 148	149	150	
			, {1301, -3, -3, 2}, {1301, -5, -5, 2}, {1301, 4, 3, 2}// 151	152	153	
			, {1180, -7, -5, 12}, {1301, -2, -4, 2}, {1301, -7, -2, 2}// 154	155	156	
			, {1301, 0, -7, 2}, {8674, -7, -9, 2}, {1301, 2, 2, 2}// 157	158	159	
			, {1301, -7, 4, 2}, {1301, -1, 0, 2}, {1301, -2, 2, 2}// 160	161	162	
			, {1301, 0, 6, 2}, {1301, 2, 3, 2}, {1301, 2, -6, 2}// 163	164	165	
			, {1301, 4, -2, 2}, {1180, -7, -4, 12}, {1301, -5, -4, 2}// 166	167	168	
			, {578, -7, 5, 2}, {8674, -4, -9, 2}, {1301, 4, -7, 2}// 169	170	171	
			, {1301, 1, -5, 2}, {1301, -4, 5, 2}, {1301, 1, -2, 2}// 172	173	174	
			, {8673, -5, -9, 2}, {1301, -3, 6, 2}, {3909, -5, -8, 2}// 175	176	177	
			, {1301, -5, -1, 2}, {1301, -4, -6, 2}, {1301, 3, 0, 2}// 178	179	180	
			, {1301, 0, -3, 2}, {1301, -3, -7, 2}, {8674, -3, -9, 2}// 181	182	183	
			, {1301, -6, -4, 2}, {1301, -5, -8, 2}, {1301, 0, 4, 2}// 184	185	186	
			, {1301, -2, -7, 2}, {578, -7, 6, 2}, {1301, 1, 2, 2}// 187	188	189	
			, {1301, -6, 1, 2}, {1301, -6, 3, 2}, {1301, -3, -1, 2}// 190	191	192	
			, {1301, -4, 1, 2}, {5087, -6, 5, 9}, {1180, -7, -8, 12}// 193	194	195	
			, {1301, -4, -4, 2}, {763, -7, -7, 0}, {1301, -7, 3, 2}// 196	197	198	
			, {1301, 4, 6, 2}, {5058, -7, -8, 15}, {1301, -1, -4, 2}// 199	200	201	
			, {8674, 1, -9, 2}, {1301, -3, 3, 2}, {1301, -5, -6, 2}// 202	203	204	
			, {1301, 1, 4, 2}, {1301, -3, -8, 2}, {1301, 4, -8, 2}// 205	206	207	
			, {1301, 2, -7, 2}, {1301, -1, -5, 2}, {5049, -6, -8, 2}// 208	209	210	
			, {1301, -5, 6, 2}, {1301, -5, 1, 2}, {1301, -3, 4, 2}// 211	212	213	
			, {1301, -4, -2, 2}, {1301, -1, -2, 2}, {1301, -1, -3, 2}// 214	215	216	
			, {3936, -7, -7, 10}, {3910, -7, -5, 11}, {3909, -5, -8, 3}// 217	218	219	
			, {3916, -7, -4, 10}, {5049, -6, -8, 3}, {5126, -7, -6, 12}// 220	221	222	
			, {3916, -7, -4, 12}, {1301, -2, -2, 2}, {1301, 4, 5, 2}// 223	224	225	
			, {1301, -5, 3, 2}, {1301, -5, 0, 2}, {1301, 0, -1, 2}// 226	227	228	
			, {5057, -7, -7, 13}, {1301, -2, -5, 2}, {1301, 0, 0, 2}// 229	230	231	
			, {1301, -6, -2, 2}, {1301, -2, -6, 2}, {8674, -2, -9, 2}// 232	233	234	
			, {1301, 0, -5, 2}, {1301, -2, 3, 2}, {1301, 2, 6, 2}// 235	236	237	
			, {1301, -6, 7, 2}, {762, -6, 7, 2}, {1301, -4, 7, 2}// 238	239	240	
			, {1301, 0, 7, 2}, {1301, -5, 7, 2}, {578, -7, 7, 2}// 241	242	243	
			, {763, -5, 9, 2}, {1301, -3, 9, 2}, {1301, -2, 7, 2}// 244	245	246	
			, {1301, -2, 8, 2}, {1301, 1, 9, 2}, {1301, -2, 9, 2}// 247	248	249	
			, {1301, -1, 8, 2}, {1301, -1, 7, 2}, {1301, 2, 7, 2}// 250	251	252	
			, {1301, 0, 9, 2}, {1301, 4, 7, 2}, {1301, 1, 7, 2}// 253	254	255	
			, {1301, 3, 7, 2}, {1301, -4, 9, 2}, {763, -6, 8, 2}// 256	257	258	
			, {1301, -1, 9, 2}, {1301, 1, 8, 2}, {1301, -4, 8, 2}// 259	260	261	
			, {1301, -3, 8, 2}, {762, -5, 8, 2}, {1301, -1, 8, 2}// 262	263	264	
			, {1301, -5, 8, 2}, {1301, -3, 7, 2}, {1301, 2, 9, 2}// 265	266	267	
			, {1301, 2, 8, 2}, {1301, 0, 8, 2}, {1301, 6, 2, 2}// 268	269	270	
			, {1301, 8, -4, 2}, {1301, 6, 1, 2}, {1301, 6, 4, 2}// 271	272	273	
			, {1301, 7, 2, 2}, {1301, 8, -6, 2}, {1301, 6, -5, 2}// 274	275	276	
			, {1301, 8, -3, 2}, {1301, 7, 3, 2}, {1301, 6, 5, 2}// 277	278	279	
			, {1301, 5, -7, 2}, {1301, 6, -4, 2}, {1301, 5, -2, 2}// 280	281	282	
			, {1301, 5, -5, 2}, {1301, 5, -3, 2}, {1301, 8, 3, 2}// 283	284	285	
			, {1301, 8, 2, 2}, {1301, 5, 4, 2}, {1301, 6, -2, 2}// 286	287	288	
			, {1301, 8, 0, 2}, {1301, 7, 5, 2}, {8674, 7, -9, 2}// 289	290	291	
			, {1301, 7, 1, 2}, {1301, 6, -7, 2}, {1301, 6, -6, 2}// 292	293	294	
			, {1301, 6, -3, 2}, {1301, 5, -1, 2}, {1301, 8, 1, 2}// 295	296	297	
			, {1301, 5, -6, 2}, {1301, 5, -8, 2}, {1301, 6, 3, 2}// 298	299	300	
			, {1301, 8, -8, 2}, {8674, 6, -9, 2}, {1301, 8, 5, 2}// 301	302	303	
			, {1301, 7, -8, 2}, {8674, 8, -9, 2}, {1301, 5, 2, 2}// 304	305	306	
			, {1301, 7, -3, 2}, {1301, 7, 0, 2}, {1301, 5, 3, 2}// 307	308	309	
			, {1301, 7, -5, 2}, {1301, 5, 1, 2}, {1301, 7, -2, 2}// 310	311	312	
			, {1301, 7, -7, 2}, {1301, 7, -1, 2}, {1301, 8, -7, 2}// 313	314	315	
			, {1301, 8, -5, 2}, {1301, 7, -4, 2}, {1301, 7, 4, 2}// 316	317	318	
			, {1301, 6, -1, 2}, {1301, 8, -2, 2}, {1301, 6, 0, 2}// 319	320	321	
			, {1301, 5, 0, 2}, {1301, 7, -6, 2}, {1301, 8, 4, 2}// 322	323	324	
			, {1301, 5, 5, 2}, {1301, 5, -4, 2}, {1301, 8, -1, 2}// 325	326	327	
			, {8674, 5, -9, 2}, {1301, 6, -8, 2}// 328	329	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new forgeplatformCDAddonDeed();
			}
		}

		[ Constructable ]
		public forgeplatformCDAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public forgeplatformCDAddon( Serial serial ) : base( serial )
		{
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

	public class forgeplatformCDAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new forgeplatformCDAddon();
			}
		}

		[Constructable]
		public forgeplatformCDAddonDeed()
		{
			Name = "forgeplatformCD";
		}

		public forgeplatformCDAddonDeed( Serial serial ) : base( serial )
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