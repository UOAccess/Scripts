
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
	public class drguildroadweAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1302, -52, -1, 0}, {1302, -51, -1, 0}, {1302, -54, 0, 0}// 1	2	3	
			, {1302, -53, 1, 0}, {1302, -55, 0, 0}, {1302, -46, 0, 0}// 4	5	6	
			, {1302, -47, -1, 0}, {1302, -49, -1, 0}, {1302, -48, -1, 0}// 7	8	9	
			, {1302, -51, 0, 0}, {1302, -54, -1, 0}, {1302, -46, -1, 0}// 10	11	12	
			, {1302, -47, 1, 0}, {1302, -55, 1, 0}, {1302, -51, 1, 0}// 13	14	15	
			, {1302, -56, -1, 0}, {1302, -47, 0, 0}, {1302, -50, -1, 0}// 16	17	18	
			, {1302, -56, 1, 0}, {1302, -48, 1, 0}, {1302, -48, 0, 0}// 19	20	21	
			, {1302, -55, -1, 0}, {1302, -53, -1, 0}, {1302, -46, 1, 0}// 22	23	24	
			, {1302, -49, 0, 0}, {1302, -52, 1, 0}, {1302, -49, 1, 0}// 25	26	27	
			, {1302, -54, 1, 0}, {1302, -50, 0, 0}, {1302, -50, 1, 0}// 28	29	30	
			, {1302, -56, 0, 0}, {1302, -53, 0, 0}, {1302, -52, 0, 0}// 31	32	33	
			, {1302, -39, 1, 0}, {1302, -41, 0, 0}, {1302, -43, 1, 0}// 34	35	36	
			, {1302, -38, 1, 0}, {1302, -38, 0, 0}, {1302, -45, 1, 0}// 37	38	39	
			, {1302, -45, 0, 0}, {1302, -44, 1, 0}, {1302, -43, 0, 0}// 40	41	42	
			, {1302, -36, 0, 0}, {1302, -36, -1, 0}, {1302, -37, -1, 0}// 43	44	45	
			, {1302, -35, -1, 0}, {1302, -34, -1, 0}, {1302, -43, -1, 0}// 46	47	48	
			, {1302, -30, -1, 0}, {1302, -32, -1, 0}, {1302, -38, -1, 0}// 49	50	51	
			, {1302, -39, -1, 0}, {1302, -45, -1, 0}, {1302, -42, -1, 0}// 52	53	54	
			, {1302, -44, -1, 0}, {1302, -31, -1, 0}, {1302, -37, 1, 0}// 55	56	57	
			, {1302, -37, 0, 0}, {1302, -41, -1, 0}, {1302, -40, -1, 0}// 58	59	60	
			, {1302, -33, -1, 0}, {1302, -42, 1, 0}, {1302, -44, 0, 0}// 61	62	63	
			, {1302, -36, 1, 0}, {1302, -42, 0, 0}, {1302, -40, 0, 0}// 64	65	66	
			, {1302, -40, 1, 0}, {1302, -39, 0, 0}, {1302, -41, 1, 0}// 67	68	69	
			, {1302, -35, 0, 0}, {1302, -35, 1, 0}, {1302, -34, 0, 0}// 70	71	72	
			, {1302, -34, 1, 0}, {1302, -33, 0, 0}, {1302, -33, 1, 0}// 73	74	75	
			, {1302, -32, 0, 0}, {1302, -32, 1, 0}, {1302, -31, 0, 0}// 76	77	78	
			, {1302, -31, 1, 0}, {1302, -30, 0, 0}, {1302, -30, 1, 0}// 79	80	81	
			, {1302, -16, -1, 0}, {1302, -24, -1, 0}, {1302, -23, -1, 0}// 82	83	84	
			, {1302, -21, 0, 0}, {1302, -25, -1, 0}, {1302, -21, -1, 0}// 85	86	87	
			, {1302, -20, -1, 0}, {1302, -17, 1, 0}, {1302, -21, 1, 0}// 88	89	90	
			, {1302, -20, 1, 0}, {1302, -19, 0, 0}, {1302, -18, 1, 0}// 91	92	93	
			, {1302, -25, 1, 0}, {1302, -16, 1, 0}, {1302, -22, 0, 0}// 94	95	96	
			, {1302, -19, 1, 0}, {1302, -22, -1, 0}, {1302, -15, 0, 0}// 97	98	99	
			, {1302, -14, -1, 0}, {1302, -22, 1, 0}, {1302, -26, 0, 0}// 100	101	102	
			, {1302, -17, 0, 0}, {1302, -25, 0, 0}, {1302, -15, -1, 0}// 103	104	105	
			, {1302, -27, -1, 0}, {1302, -16, 0, 0}, {1302, -18, 0, 0}// 106	107	108	
			, {1302, -24, 0, 0}, {1302, -14, 1, 0}, {1302, -18, -1, 0}// 109	110	111	
			, {1302, -23, 0, 0}, {1302, -26, 1, 0}, {1302, -23, 1, 0}// 112	113	114	
			, {1302, -26, -1, 0}, {1302, -17, -1, 0}, {1302, -15, 1, 0}// 115	116	117	
			, {1302, -29, -1, 0}, {1302, -20, 0, 0}, {1302, -28, -1, 0}// 118	119	120	
			, {1302, -14, 0, 0}, {1302, -19, -1, 0}, {1302, -24, 1, 0}// 121	122	123	
			, {1302, -29, 1, 0}, {1302, -29, 0, 0}, {1302, -28, 0, 0}// 124	125	126	
			, {1302, -27, 1, 0}, {1302, -28, 1, 0}, {1302, -27, 0, 0}// 127	128	129	
			, {1302, -12, 0, 0}, {1302, -3, -1, 0}, {1302, -5, -1, 0}// 130	131	132	
			, {1302, -11, 0, 0}, {1302, -11, 1, 0}, {1302, -12, 1, 0}// 133	134	135	
			, {1302, -5, 1, 0}, {1302, -5, 0, 0}, {1302, -8, -1, 0}// 136	137	138	
			, {1302, -13, 0, 0}, {1302, 0, -1, 0}, {1302, 2, 1, 0}// 139	140	141	
			, {1302, 2, 0, 0}, {1302, 1, 1, 0}, {1302, -9, 0, 0}// 142	143	144	
			, {1302, 1, 0, 0}, {1302, 0, 1, 0}, {1302, 0, 0, 0}// 145	146	147	
			, {1302, -1, 1, 0}, {1302, -1, 0, 0}, {1302, -10, 1, 0}// 148	149	150	
			, {1302, -6, -1, 0}, {1302, -2, 1, 0}, {1302, -2, 0, 0}// 151	152	153	
			, {1302, -3, 1, 0}, {1302, 2, -1, 0}, {1302, -3, 0, 0}// 154	155	156	
			, {1302, -4, 1, 0}, {1302, -4, 0, 0}, {1302, -7, -1, 0}// 157	158	159	
			, {1302, -13, -1, 0}, {1302, -6, 0, 0}, {1302, -10, -1, 0}// 160	161	162	
			, {1302, -2, -1, 0}, {1302, -7, 1, 0}, {1302, -12, -1, 0}// 163	164	165	
			, {1302, -8, 0, 0}, {1302, -8, 1, 0}, {1302, -7, 0, 0}// 166	167	168	
			, {1302, -6, 1, 0}, {1302, -11, -1, 0}, {1302, 1, -1, 0}// 169	170	171	
			, {1302, -9, -1, 0}, {1302, -1, -1, 0}, {1302, -4, -1, 0}// 172	173	174	
			, {1302, -10, 0, 0}, {1302, -13, 1, 0}, {1302, -9, 1, 0}// 175	176	177	
			, {1302, 17, -1, 0}, {1302, 14, 0, 0}, {1302, 6, -1, 0}// 178	179	180	
			, {1302, 13, 1, 0}, {1302, 13, 0, 0}, {1302, 12, 1, 0}// 181	182	183	
			, {1302, 12, 0, 0}, {1302, 11, 1, 0}, {1302, 13, -1, 0}// 184	185	186	
			, {1302, 11, 0, 0}, {1302, 10, 1, 0}, {1302, 10, 0, 0}// 187	188	189	
			, {1302, 9, 1, 0}, {1302, 9, 0, 0}, {1302, 8, 1, 0}// 190	191	192	
			, {1302, 8, 0, 0}, {1302, 10, -1, 0}, {1302, 7, 1, 0}// 193	194	195	
			, {1302, 7, 0, 0}, {1302, 6, 1, 0}, {1302, 6, 0, 0}// 196	197	198	
			, {1302, 5, 1, 0}, {1302, 5, 0, 0}, {1302, 4, 1, 0}// 199	200	201	
			, {1302, 4, 0, 0}, {1302, 3, 1, 0}, {1302, 3, 0, 0}// 202	203	204	
			, {1302, 11, -1, 0}, {1302, 7, -1, 0}, {1302, 4, -1, 0}// 205	206	207	
			, {1302, 14, 1, 0}, {1302, 17, 1, 0}, {1302, 18, 0, 0}// 208	209	210	
			, {1302, 17, 0, 0}, {1302, 16, 1, 0}, {1302, 16, 0, 0}// 211	212	213	
			, {1302, 15, 1, 0}, {1302, 5, -1, 0}, {1302, 18, 1, 0}// 214	215	216	
			, {1302, 12, -1, 0}, {1302, 9, -1, 0}, {1302, 3, -1, 0}// 217	218	219	
			, {1302, 18, -1, 0}, {1302, 16, -1, 0}, {1302, 8, -1, 0}// 220	221	222	
			, {1302, 14, -1, 0}, {1302, 15, 0, 0}, {1302, 15, -1, 0}// 223	224	225	
			, {1302, 21, 1, 0}, {1302, 20, 1, 0}, {1302, 27, -1, 0}// 226	227	228	
			, {1302, 19, 1, 0}, {1302, 19, 0, 0}, {1302, 30, -1, 0}// 229	230	231	
			, {1302, 34, -1, 0}, {1302, 29, 0, 0}, {1302, 32, 0, 0}// 232	233	234	
			, {1302, 25, 0, 0}, {1302, 24, 1, 0}, {1302, 34, 0, 0}// 235	236	237	
			, {1302, 22, 1, 0}, {1302, 31, 0, 0}, {1302, 30, 1, 0}// 238	239	240	
			, {1302, 26, -1, 0}, {1302, 31, 1, 0}, {1302, 33, -1, 0}// 241	242	243	
			, {1302, 33, 1, 0}, {1302, 24, 0, 0}, {1302, 30, 0, 0}// 244	245	246	
			, {1302, 22, -1, 0}, {1302, 28, 1, 0}, {1302, 25, -1, 0}// 247	248	249	
			, {1302, 28, -1, 0}, {1302, 20, 0, 0}, {1302, 24, -1, 0}// 250	251	252	
			, {1302, 23, -1, 0}, {1302, 20, -1, 0}, {1302, 34, 1, 0}// 253	254	255	
			, {1302, 21, 0, 0}, {1302, 32, 1, 0}, {1302, 29, -1, 0}// 256	257	258	
			, {1302, 31, -1, 0}, {1302, 32, -1, 0}, {1302, 21, -1, 0}// 259	260	261	
			, {1302, 25, 1, 0}, {1302, 27, 0, 0}, {1302, 29, 1, 0}// 262	263	264	
			, {1302, 23, 0, 0}, {1302, 23, 1, 0}, {1302, 27, 1, 0}// 265	266	267	
			, {1302, 28, 0, 0}, {1302, 26, 0, 0}, {1302, 26, 1, 0}// 268	269	270	
			, {1302, 22, 0, 0}, {1302, 33, 0, 0}, {1302, 19, -1, 0}// 271	272	273	
			, {1302, 48, -1, 0}, {1302, 38, -1, 0}, {1302, 49, -1, 0}// 274	275	276	
			, {1302, 37, -1, 0}, {1302, 47, -1, 0}, {1302, 46, -1, 0}// 277	278	279	
			, {1302, 45, -1, 0}, {1302, 43, -1, 0}, {1302, 42, -1, 0}// 280	281	282	
			, {1302, 50, -1, 0}, {1302, 36, -1, 0}, {1302, 35, 0, 0}// 283	284	285	
			, {1302, 35, -1, 0}, {1302, 40, -1, 0}, {1302, 41, -1, 0}// 286	287	288	
			, {1302, 44, -1, 0}, {1302, 41, 1, 0}, {1302, 41, 0, 0}// 289	290	291	
			, {1302, 40, 1, 0}, {1302, 40, 0, 0}, {1302, 39, 1, 0}// 292	293	294	
			, {1302, 39, 0, 0}, {1302, 38, 1, 0}, {1302, 38, 0, 0}// 295	296	297	
			, {1302, 37, 1, 0}, {1302, 37, 0, 0}, {1302, 36, 1, 0}// 298	299	300	
			, {1302, 36, 0, 0}, {1302, 35, 1, 0}, {1302, 42, 0, 0}// 301	302	303	
			, {1302, 46, 0, 0}, {1302, 46, 1, 0}, {1302, 45, 1, 0}// 304	305	306	
			, {1302, 45, 0, 0}, {1302, 44, 1, 0}, {1302, 44, 0, 0}// 307	308	309	
			, {1302, 43, 1, 0}, {1302, 43, 0, 0}, {1302, 48, 1, 0}// 310	311	312	
			, {1302, 49, 0, 0}, {1302, 48, 0, 0}, {1302, 47, 1, 0}// 313	314	315	
			, {1302, 47, 0, 0}, {1302, 50, 1, 0}, {1302, 50, 0, 0}// 316	317	318	
			, {1302, 49, 1, 0}, {1302, 39, -1, 0}, {1302, 42, 1, 0}// 319	320	321	
			, {1302, 55, -1, 0}, {1302, 54, -1, 0}, {1302, 51, -1, 0}// 322	323	324	
			, {1302, 52, -1, 0}, {1302, 53, -1, 0}, {1302, 51, 0, 0}// 325	326	327	
			, {1302, 52, 1, 0}, {1302, 52, 0, 0}, {1302, 51, 1, 0}// 328	329	330	
			, {1302, 54, 0, 0}, {1302, 53, 1, 0}, {1302, 53, 0, 0}// 331	332	333	
			, {1302, 56, 1, 0}, {1302, 56, 0, 0}, {1302, 55, 1, 0}// 334	335	336	
			, {1302, 55, 0, 0}, {1302, 54, 1, 0}, {1302, 56, -1, 0}// 337	338	339	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new drguildroadweAddonDeed();
			}
		}

		[ Constructable ]
		public drguildroadweAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public drguildroadweAddon( Serial serial ) : base( serial )
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

	public class drguildroadweAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new drguildroadweAddon();
			}
		}

		[Constructable]
		public drguildroadweAddonDeed()
		{
			Name = "drguildroadwe";
		}

		public drguildroadweAddonDeed( Serial serial ) : base( serial )
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