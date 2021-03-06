
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
	public class GTWaterMoatAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {13422, -17, -7, 0}, {13422, -16, -7, 0}, {13422, -16, -6, 0}// 1	2	3	
			, {13422, -15, -7, 0}, {13422, -15, -6, 0}, {13422, -14, -7, 0}// 4	5	6	
			, {13422, -14, -6, 0}, {13422, -13, -7, 0}, {13422, -13, -6, 0}// 7	8	9	
			, {13422, -12, -7, 0}, {13422, -12, -6, 0}, {13422, -11, -7, 0}// 10	11	12	
			, {13422, -11, -6, 0}, {13422, -10, -7, 0}, {13422, -10, -6, 0}// 13	14	15	
			, {13422, -9, -7, 0}, {13422, -9, -6, 0}, {13422, -8, -7, 0}// 16	17	18	
			, {13422, -8, -6, 0}, {13422, -7, -7, 0}, {13422, -7, -6, 0}// 19	20	21	
			, {13422, -6, -7, 0}, {13422, -6, -6, 0}, {13422, -5, -7, 0}// 22	23	24	
			, {13422, -5, -6, 0}, {13422, -4, -7, 0}, {13422, -4, -6, 0}// 25	26	27	
			, {3220, -17, -6, 0}, {3241, -17, -7, 1}, {13422, -4, 6, 0}// 28	29	30	
			, {13422, -5, 5, 0}, {13422, -4, 5, 0}, {13422, -6, 4, 0}// 31	32	33	
			, {13422, -5, 4, 0}, {13422, -4, 4, 0}, {13422, -7, 3, 0}// 34	35	36	
			, {13422, -6, 3, 0}, {13422, -5, 3, 0}, {13422, -4, 3, 0}// 37	38	39	
			, {13422, -8, 2, 0}, {13422, -7, 2, 0}, {13422, -6, 2, 0}// 40	41	42	
			, {13422, -5, 2, 0}, {13422, -4, 2, 0}, {13422, -9, 1, 0}// 43	44	45	
			, {13422, -8, 1, 0}, {13422, -7, 1, 0}, {13422, -6, 1, 0}// 46	47	48	
			, {13422, -5, 1, 0}, {13422, -4, 1, 0}, {13422, -10, 0, 0}// 49	50	51	
			, {13422, -9, 0, 0}, {13422, -8, 0, 0}, {13422, -7, 0, 0}// 52	53	54	
			, {13422, -6, 0, 0}, {13422, -5, 0, 0}, {13422, -4, 0, 0}// 55	56	57	
			, {13422, -11, -1, 0}, {13422, -10, -1, 0}, {13422, -9, -1, 0}// 58	59	60	
			, {13422, -8, -1, 0}, {13422, -7, -1, 0}, {13422, -6, -1, 0}// 61	62	63	
			, {13422, -5, -1, 0}, {13422, -4, -1, 0}, {13422, -15, -5, 0}// 64	65	66	
			, {13422, -14, -5, 0}, {13422, -14, -4, 0}, {13422, -13, -5, 0}// 67	68	69	
			, {13422, -13, -4, 0}, {13422, -13, -3, 0}, {13422, -12, -5, 0}// 70	71	72	
			, {13422, -12, -4, 0}, {13422, -12, -3, 0}, {13422, -12, -2, 0}// 73	74	75	
			, {13422, -11, -5, 0}, {13422, -11, -4, 0}, {13422, -11, -3, 0}// 76	77	78	
			, {13422, -11, -2, 0}, {13422, -10, -5, 0}, {13422, -10, -4, 0}// 79	80	81	
			, {13422, -10, -3, 0}, {13422, -10, -2, 0}, {13422, -9, -5, 0}// 82	83	84	
			, {13422, -9, -4, 0}, {13422, -9, -3, 0}, {13422, -9, -2, 0}// 85	86	87	
			, {13422, -8, -5, 0}, {13422, -8, -4, 0}, {13422, -8, -3, 0}// 88	89	90	
			, {13422, -8, -2, 0}, {13422, -7, -5, 0}, {13422, -7, -4, 0}// 91	92	93	
			, {13422, -7, -3, 0}, {13422, -7, -2, 0}, {13422, -6, -5, 0}// 94	95	96	
			, {13422, -6, -4, 0}, {13422, -6, -3, 0}, {13422, -6, -2, 0}// 97	98	99	
			, {13422, -5, -5, 0}, {13422, -5, -4, 0}, {13422, -5, -3, 0}// 100	101	102	
			, {13422, -5, -2, 0}, {13422, -4, -5, 0}, {13422, -4, -4, 0}// 103	104	105	
			, {13422, -4, -3, 0}, {13422, -4, -2, 0}, {3220, -7, 4, 0}// 106	107	108	
			, {3209, -5, 6, 0}, {3209, -10, 1, 0}, {3209, -15, -4, 0}// 109	110	111	
			, {3224, -10, 1, 6}, {3223, -6, 5, 0}, {3223, -13, -2, 0}// 112	113	114	
			, {3223, -16, -5, 0}, {3204, -8, 3, 0}, {3204, -14, -3, 0}// 115	116	117	
			, {6811, -10, 1, 15}, {3264, -9, 2, 0}, {3264, -5, 6, 0}// 118	119	120	
			, {3265, -10, 1, 0}, {3265, -15, -4, 0}, {3237, -12, -1, 0}// 121	122	123	
			, {3263, -9, 2, 0}, {3241, -5, 5, 1}, {3241, -9, 1, 1}// 124	125	126	
			, {4964, -12, 0, 0}, {4970, -14, -2, 0}, {4970, -9, 3, 0}// 127	128	129	
			, {4973, -6, 6, 0}, {4973, -16, -4, 0}, {6012, -10, 2, 0}// 130	131	132	
			, {6004, -17, -5, 0}, {13422, -3, -7, 0}, {13422, -3, -6, 0}// 133	134	135	
			, {13422, -2, -7, 0}, {13422, -2, -6, 0}, {13422, -1, -7, 0}// 136	137	138	
			, {13422, -1, -6, 0}, {13422, 0, -7, 0}, {13422, 0, -6, 0}// 139	140	141	
			, {13422, 1, -7, 0}, {13422, 1, -6, 0}, {13422, 2, -7, 0}// 142	143	144	
			, {13422, 2, -6, 0}, {13422, 3, -7, 0}, {13422, 3, -6, 0}// 145	146	147	
			, {13422, 4, -7, 0}, {13422, 4, -6, 0}, {13422, 5, -7, 0}// 148	149	150	
			, {13422, 5, -6, 0}, {13422, 6, -7, 0}, {13422, 6, -6, 0}// 151	152	153	
			, {13422, 7, -7, 0}, {13422, 7, -6, 0}, {13422, 8, -7, 0}// 154	155	156	
			, {13422, 8, -6, 0}, {13422, 9, -7, 0}, {13422, 9, -6, 0}// 157	158	159	
			, {13422, 10, -7, 0}, {13422, 10, -6, 0}, {13422, 11, -7, 0}// 160	161	162	
			, {13422, 11, -6, 0}, {13422, 12, -7, 0}, {13422, 12, -6, 0}// 163	164	165	
			, {13422, -3, 6, 0}, {13422, -2, 6, 0}, {13422, -1, 6, 0}// 166	167	168	
			, {13422, 0, 6, 0}, {13422, 1, 6, 0}, {13422, 2, 6, 0}// 169	170	171	
			, {13422, 3, 6, 0}, {13422, -3, 5, 0}, {13422, -2, 5, 0}// 172	173	174	
			, {13422, -1, 5, 0}, {13422, 0, 5, 0}, {13422, 1, 5, 0}// 175	176	177	
			, {13422, 2, 5, 0}, {13422, 3, 5, 0}, {13422, 4, 5, 0}// 178	179	180	
			, {13422, -3, 4, 0}, {13422, -2, 4, 0}, {13422, -1, 4, 0}// 181	182	183	
			, {13422, 0, 4, 0}, {13422, 1, 4, 0}, {13422, 2, 4, 0}// 184	185	186	
			, {13422, 3, 4, 0}, {13422, 4, 4, 0}, {13422, 5, 4, 0}// 187	188	189	
			, {13422, -3, 3, 0}, {13422, -2, 3, 0}, {13422, -1, 3, 0}// 190	191	192	
			, {13422, 0, 3, 0}, {13422, 1, 3, 0}, {13422, 2, 3, 0}// 193	194	195	
			, {13422, 3, 3, 0}, {13422, 4, 3, 0}, {13422, 5, 3, 0}// 196	197	198	
			, {13422, 6, 3, 0}, {13422, -3, 2, 0}, {13422, -2, 2, 0}// 199	200	201	
			, {13422, -1, 2, 0}, {13422, 0, 2, 0}, {13422, 1, 2, 0}// 202	203	204	
			, {13422, 2, 2, 0}, {13422, 3, 2, 0}, {13422, 4, 2, 0}// 205	206	207	
			, {13422, 5, 2, 0}, {13422, 6, 2, 0}, {13422, 7, 2, 0}// 208	209	210	
			, {13422, -3, 1, 0}, {13422, -2, 1, 0}, {13422, -1, 1, 0}// 211	212	213	
			, {13422, 0, 1, 0}, {13422, 1, 1, 0}, {13422, 2, 1, 0}// 214	215	216	
			, {13422, 3, 1, 0}, {13422, 4, 1, 0}, {13422, 5, 1, 0}// 217	218	219	
			, {13422, 6, 1, 0}, {13422, 7, 1, 0}, {13422, 8, 1, 0}// 220	221	222	
			, {13422, -3, 0, 0}, {13422, -2, 0, 0}, {13422, -1, 0, 0}// 223	224	225	
			, {13422, 0, 0, 0}, {13422, 1, 0, 0}, {13422, 2, 0, 0}// 226	227	228	
			, {13422, 3, 0, 0}, {13422, 4, 0, 0}, {13422, 5, 0, 0}// 229	230	231	
			, {13422, 6, 0, 0}, {13422, 7, 0, 0}, {13422, 8, 0, 0}// 232	233	234	
			, {13422, 9, 0, 0}, {13422, -3, -1, 0}, {13422, -2, -1, 0}// 235	236	237	
			, {13422, -1, -1, 0}, {13422, 0, -1, 0}, {13422, 1, -1, 0}// 238	239	240	
			, {13422, 2, -1, 0}, {13422, 3, -1, 0}, {13422, 4, -1, 0}// 241	242	243	
			, {13422, 5, -1, 0}, {13422, 6, -1, 0}, {13422, 7, -1, 0}// 244	245	246	
			, {13422, 8, -1, 0}, {13422, 9, -1, 0}, {13422, 10, -1, 0}// 247	248	249	
			, {13422, -3, -5, 0}, {13422, -3, -4, 0}, {13422, -3, -3, 0}// 250	251	252	
			, {13422, -3, -2, 0}, {13422, -2, -5, 0}, {13422, -2, -4, 0}// 253	254	255	
			, {13422, -2, -3, 0}, {13422, -2, -2, 0}, {13422, -1, -5, 0}// 256	257	258	
			, {13422, -1, -4, 0}, {13422, -1, -3, 0}, {13422, -1, -2, 0}// 259	260	261	
			, {13422, 0, -5, 0}, {13422, 0, -4, 0}, {13422, 0, -3, 0}// 262	263	264	
			, {13422, 0, -2, 0}, {13422, 1, -5, 0}, {13422, 1, -4, 0}// 265	266	267	
			, {13422, 1, -3, 0}, {13422, 1, -2, 0}, {13422, 2, -5, 0}// 268	269	270	
			, {13422, 2, -4, 0}, {13422, 2, -3, 0}, {13422, 2, -2, 0}// 271	272	273	
			, {13422, 3, -5, 0}, {13422, 3, -4, 0}, {13422, 3, -3, 0}// 274	275	276	
			, {13422, 3, -2, 0}, {13422, 4, -5, 0}, {13422, 4, -4, 0}// 277	278	279	
			, {13422, 4, -3, 0}, {13422, 4, -2, 0}, {13422, 5, -5, 0}// 280	281	282	
			, {13422, 5, -4, 0}, {13422, 5, -3, 0}, {13422, 5, -2, 0}// 283	284	285	
			, {13422, 6, -5, 0}, {13422, 6, -4, 0}, {13422, 6, -3, 0}// 286	287	288	
			, {13422, 6, -2, 0}, {13422, 7, -5, 0}, {13422, 7, -4, 0}// 289	290	291	
			, {13422, 7, -3, 0}, {13422, 7, -2, 0}, {13422, 8, -5, 0}// 292	293	294	
			, {13422, 8, -4, 0}, {13422, 8, -3, 0}, {13422, 8, -2, 0}// 295	296	297	
			, {13422, 9, -5, 0}, {13422, 9, -4, 0}, {13422, 9, -3, 0}// 298	299	300	
			, {13422, 9, -2, 0}, {13422, 10, -5, 0}, {13422, 10, -4, 0}// 301	302	303	
			, {13422, 10, -3, 0}, {13422, 10, -2, 0}, {13422, 11, -5, 0}// 304	305	306	
			, {13422, 11, -4, 0}, {13422, 11, -3, 0}, {13422, 11, -2, 0}// 307	308	309	
			, {13422, 12, -5, 0}, {13422, 12, -4, 0}, {13422, 12, -3, 0}// 310	311	312	
			, {3220, 11, -1, 0}, {3220, 6, 4, 0}, {3209, 9, 1, 0}// 313	314	315	
			, {3224, 5, 7, 3}, {3223, 5, 5, 0}, {3223, 10, 0, 0}// 316	317	318	
			, {6811, 5, 7, 11}, {3204, 7, 3, 0}, {3265, 9, 1, 0}// 319	320	321	
			, {3237, 8, 2, 0}, {3241, 6, 3, 1}, {3241, 10, -1, 1}// 322	323	324	
			, {3237, 12, -2, 0}, {3245, 10, 0, 0}, {3247, 10, 0, 0}// 325	326	327	
			, {3248, 10, 1, 0}, {4967, 6, 5, 2}, {4968, 11, 0, 2}// 328	329	330	
			, {4970, 9, 2, 4}, {4972, 8, 3, 4}, {4972, 12, -1, 4}// 331	332	333	
			, {13422, 13, -7, 0}, {13422, 13, -6, 0}, {13422, 14, -7, 0}// 334	335	336	
			, {13422, 14, -6, 0}, {13422, 15, -7, 0}, {13422, 15, -6, 0}// 337	338	339	
			, {13422, 16, -7, 0}, {3220, 16, -6, 0}, {4967, 17, -7, 0}// 340	341	342	
			, {13422, 13, -5, 0}, {13422, 13, -4, 0}, {13422, 14, -5, 0}// 343	344	345	
			, {3209, 14, -4, 0}, {3224, 16, -4, 3}, {6811, 16, -4, 12}// 346	347	348	
			, {3204, 13, -3, 0}, {3265, 14, -4, 0}, {3241, 14, -5, 1}// 349	350	351	
			, {4971, 13, -2, 4}, {4969, 14, -3, 4}, {4968, 16, -5, 1}// 352	353	354	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GTWaterMoatAddonDeed();
			}
		}

		[ Constructable ]
		public GTWaterMoatAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public GTWaterMoatAddon( Serial serial ) : base( serial )
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

	public class GTWaterMoatAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GTWaterMoatAddon();
			}
		}

		[Constructable]
		public GTWaterMoatAddonDeed()
		{
			Name = "GTWaterMoat";
		}

		public GTWaterMoatAddonDeed( Serial serial ) : base( serial )
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