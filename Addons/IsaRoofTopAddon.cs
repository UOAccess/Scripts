
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
	public class IsaRoofTopAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1179, -12, -12, 0}, {1179, -12, -11, 0}, {1179, -12, -10, 0}// 1	2	3	
			, {1179, -12, -9, 0}, {1179, -12, -8, 0}, {1179, -12, -7, 0}// 4	5	6	
			, {1179, -12, -6, 0}, {1179, -12, -5, 0}, {1179, -12, -4, 0}// 7	8	9	
			, {1179, -12, -3, 0}, {1179, -12, -2, 0}, {1179, -12, -1, 0}// 10	11	12	
			, {1179, -11, -12, 0}, {1179, -11, -10, 0}, {1179, -11, -9, 0}// 13	14	15	
			, {1179, -11, -8, 0}, {1179, -11, -7, 0}, {1179, -11, -6, 0}// 16	17	18	
			, {1179, -11, -5, 0}, {1179, -11, -4, 0}, {1179, -11, -3, 0}// 19	20	21	
			, {1179, -11, -2, 0}, {1179, -11, -1, 0}, {1179, -10, -12, 0}// 22	23	24	
			, {1179, -10, -11, 0}, {1179, -10, -9, 0}, {1179, -10, -8, 0}// 25	26	27	
			, {1179, -10, -7, 0}, {1179, -10, -6, 0}, {1179, -10, -5, 0}// 28	29	30	
			, {1179, -10, -4, 0}, {1179, -10, -3, 0}, {1179, -10, -2, 0}// 31	32	33	
			, {1179, -10, -1, 0}, {1179, -9, -12, 0}, {1179, -9, -11, 0}// 34	35	36	
			, {1179, -9, -10, 0}, {1179, -8, -12, 0}, {1179, -8, -11, 0}// 37	38	39	
			, {1179, -8, -10, 0}, {1179, -7, -12, 0}, {1179, -7, -11, 0}// 40	41	42	
			, {1179, -7, -10, 0}, {1179, -7, -6, 0}, {1179, -7, -5, 0}// 43	44	45	
			, {1179, -7, -4, 0}, {1179, -7, -3, 0}, {1179, -7, -2, 0}// 46	47	48	
			, {1179, -7, -1, 0}, {1179, -6, -12, 0}, {1179, -6, -11, 0}// 49	50	51	
			, {1179, -6, -10, 0}, {1179, -6, -7, 0}, {1179, -6, -5, 0}// 52	53	54	
			, {1179, -6, -4, 0}, {1179, -6, -3, 0}, {1179, -6, -2, 0}// 55	56	57	
			, {1179, -6, -1, 0}, {1179, -5, -12, 0}, {1179, -5, -11, 0}// 58	59	60	
			, {1179, -5, -10, 0}, {1179, -5, -7, 0}, {1179, -5, -6, 0}// 61	62	63	
			, {1179, -4, -12, 0}, {1179, -4, -11, 0}, {1179, -4, -10, 0}// 64	65	66	
			, {1179, -4, -7, 0}, {1179, -4, -6, 0}, {1179, -3, -12, 0}// 67	68	69	
			, {1179, -3, -11, 0}, {1179, -3, -10, 0}, {1179, -3, -7, 0}// 70	71	72	
			, {1179, -3, -6, 0}, {1179, -2, -12, 0}, {1179, -2, -11, 0}// 73	74	75	
			, {1179, -2, -10, 0}, {1179, -2, -7, 0}, {1179, -2, -6, 0}// 76	77	78	
			, {1179, -2, -2, 0}, {1179, -2, -1, 0}, {1179, -1, -12, 0}// 79	80	81	
			, {1179, -1, -11, 0}, {1179, -1, -10, 0}, {1179, -1, -7, 0}// 82	83	84	
			, {1179, -1, -6, 0}, {1179, -1, -2, 0}, {1179, -1, -1, 0}// 85	86	87	
			, {1179, 0, -12, 0}, {1179, 0, -11, 0}, {1179, 0, -10, 0}// 88	89	90	
			, {1179, 0, -7, 0}, {1179, 0, -6, 0}, {1179, 0, -2, 0}// 91	92	93	
			, {1179, 0, -1, 0}, {1179, 1, -12, 0}, {1179, 1, -11, 0}// 94	95	96	
			, {1179, 1, -10, 0}, {1179, 1, -7, 0}, {1179, 1, -6, 0}// 97	98	99	
			, {1179, 1, -2, 0}, {1179, 1, -1, 0}, {1179, 2, -12, 0}// 100	101	102	
			, {1179, 2, -11, 0}, {1179, 2, -10, 0}, {1179, 2, -7, 0}// 103	104	105	
			, {1179, 2, -6, 0}, {1179, 2, -2, 0}, {1179, 2, -1, 0}// 106	107	108	
			, {1179, -10, -10, 0}, {1262, -9, -9, 0}, {1261, -8, -9, 0}// 109	110	111	
			, {1261, -7, -9, 0}, {1261, -6, -9, 0}, {1261, -5, -9, 0}// 112	113	114	
			, {1261, -4, -9, 0}, {1261, -3, -9, 0}, {1261, -2, -9, 0}// 115	116	117	
			, {1261, -1, -9, 0}, {1261, 0, -9, 0}, {1261, 1, -9, 0}// 118	119	120	
			, {1261, 2, -9, 0}, {1260, -9, -8, 0}, {1260, -9, -7, 0}// 121	122	123	
			, {1260, -9, -6, 0}, {1260, -9, -5, 0}, {1260, -9, -4, 0}// 124	125	126	
			, {1260, -9, -3, 0}, {1260, -9, -2, 0}, {1260, -9, -1, 0}// 127	128	129	
			, {1259, -7, -8, 0}, {1259, -6, -8, 0}, {1259, -5, -8, 0}// 130	131	132	
			, {1259, -4, -8, 0}, {1259, -3, -8, 0}, {1259, -2, -8, 0}// 133	134	135	
			, {1259, -1, -8, 0}, {1259, 0, -8, 0}, {1259, 1, -8, 0}// 136	137	138	
			, {1259, 2, -8, 0}, {1258, -8, -7, 0}, {1258, -8, -6, 0}// 139	140	141	
			, {1258, -8, -5, 0}, {1258, -8, -4, 0}, {1258, -8, -3, 0}// 142	143	144	
			, {1258, -8, -2, 0}, {1258, -8, -1, 0}, {1266, -8, -8, 0}// 145	146	147	
			, {1179, -7, -7, 0}, {1179, -6, -6, 0}, {1258, -3, -2, 0}// 148	149	150	
			, {1258, -3, -1, 0}, {1259, -2, -3, 0}, {1259, -1, -3, 0}// 151	152	153	
			, {1259, 0, -3, 0}, {1259, 1, -3, 0}, {1259, 2, -3, 0}// 154	155	156	
			, {1260, -5, -4, 0}, {1260, -5, -3, 0}, {1260, -5, -2, 0}// 157	158	159	
			, {1260, -5, -1, 0}, {1261, -4, -5, 0}, {1261, -3, -5, 0}// 160	161	162	
			, {1261, -2, -5, 0}, {1261, -1, -5, 0}, {1261, 0, -5, 0}// 163	164	165	
			, {1261, 1, -5, 0}, {1261, 2, -5, 0}, {1266, -4, -4, 0}// 166	167	168	
			, {1266, -4, -3, 0}, {1266, -4, -2, 0}, {1266, -4, -1, 0}// 169	170	171	
			, {1266, -3, -4, 0}, {1266, -2, -4, 0}, {1266, -1, -4, 0}// 172	173	174	
			, {1266, 0, -4, 0}, {1266, 1, -4, 0}, {1266, 2, -4, 0}// 175	176	177	
			, {1262, -5, -5, 0}, {1266, -3, -3, 0}, {3215, -12, -12, 1}// 178	179	180	
			, {3215, -12, -11, 1}, {3215, -12, -10, 1}, {3215, -12, -9, 1}// 181	182	183	
			, {3215, -12, -8, 1}, {3215, -12, -7, 1}, {3215, -12, -6, 1}// 184	185	186	
			, {3215, -12, -5, 1}, {3215, -12, -4, 1}, {3215, -12, -3, 1}// 187	188	189	
			, {3215, -12, -2, 1}, {3215, -12, -1, 1}, {3215, -12, -12, 6}// 190	191	192	
			, {3215, -12, -11, 6}, {3215, -12, -10, 6}, {3215, -12, -9, 6}// 193	194	195	
			, {3215, -12, -8, 6}, {3215, -12, -7, 6}, {3215, -12, -6, 6}// 196	197	198	
			, {3215, -12, -5, 6}, {3215, -12, -4, 6}, {3215, -12, -3, 6}// 199	200	201	
			, {3215, -12, -2, 6}, {3215, -12, -1, 6}, {3215, -11, -12, 1}// 202	203	204	
			, {3215, -10, -12, 1}, {3215, -9, -12, 1}, {3215, -8, -12, 1}// 205	206	207	
			, {3215, -7, -12, 1}, {3215, -6, -12, 1}, {3215, -5, -12, 1}// 208	209	210	
			, {3215, -4, -12, 1}, {3215, -3, -12, 1}, {3215, -2, -12, 1}// 211	212	213	
			, {3215, -1, -12, 1}, {3215, 0, -12, 1}, {3215, 1, -12, 1}// 214	215	216	
			, {3215, 2, -12, 1}, {3215, -11, -12, 6}, {3215, -10, -12, 6}// 217	218	219	
			, {3215, -9, -12, 6}, {3215, -8, -12, 6}, {3215, -7, -12, 6}// 220	221	222	
			, {3215, -6, -12, 6}, {3215, -5, -12, 6}, {3215, -4, -12, 6}// 223	224	225	
			, {3215, -3, -12, 6}, {3215, -2, -12, 6}, {3215, -1, -12, 6}// 226	227	228	
			, {3215, 0, -12, 6}, {3215, 1, -12, 6}, {3215, 2, -12, 6}// 229	230	231	
			, {3149, -12, -12, 9}, {3149, -11, -12, 9}, {3149, -10, -12, 9}// 232	233	234	
			, {3149, -9, -12, 9}, {3149, -8, -12, 9}, {3149, -7, -12, 9}// 235	236	237	
			, {3149, -6, -12, 9}, {3149, -5, -12, 9}, {3149, -4, -12, 9}// 238	239	240	
			, {3149, -3, -12, 9}, {3149, -2, -12, 9}, {3149, -1, -12, 9}// 241	242	243	
			, {3149, 0, -12, 9}, {3149, 1, -12, 9}, {3149, 2, -12, 9}// 244	245	246	
			, {3149, -12, -11, 9}, {3149, -12, -10, 9}, {3149, -12, -9, 9}// 247	248	249	
			, {3149, -12, -8, 9}, {3149, -12, -7, 9}, {3149, -12, -6, 9}// 250	251	252	
			, {3149, -12, -5, 9}, {3149, -12, -4, 9}, {3149, -12, -3, 9}// 253	254	255	
			, {3149, -12, -2, 9}, {3149, -12, -1, 9}, {3203, -10, -11, 1}// 256	257	258	
			, {3203, -9, -11, 1}, {3203, -8, -11, 1}, {3203, -7, -11, 1}// 259	260	261	
			, {3203, -6, -11, 1}, {3203, -5, -11, 1}, {3203, -4, -11, 1}// 262	263	264	
			, {3203, -3, -11, 1}, {3203, -2, -11, 1}, {3203, -1, -11, 1}// 265	266	267	
			, {3203, 0, -11, 1}, {3203, 1, -11, 1}, {3203, 2, -11, 1}// 268	269	270	
			, {3203, -11, -10, 1}, {3203, -11, -9, 1}, {3203, -11, -8, 1}// 271	272	273	
			, {3203, -11, -7, 1}, {3203, -11, -6, 1}, {3203, -11, -5, 1}// 274	275	276	
			, {3203, -11, -4, 1}, {3203, -11, -3, 1}, {3203, -11, -2, 1}// 277	278	279	
			, {3203, -11, -1, 1}, {1179, -12, 0, 0}, {1179, -12, 1, 0}// 280	281	282	
			, {1179, -12, 2, 0}, {1179, -12, 3, 0}, {1179, -12, 4, 0}// 283	284	285	
			, {1179, -12, 5, 0}, {1179, -12, 6, 0}, {1179, -12, 7, 0}// 286	287	288	
			, {1179, -12, 8, 0}, {1179, -12, 9, 0}, {1179, -12, 10, 0}// 289	290	291	
			, {1179, -12, 11, 0}, {1179, -12, 12, 0}, {1179, -11, 0, 0}// 292	293	294	
			, {1179, -11, 1, 0}, {1179, -11, 2, 0}, {1179, -11, 3, 0}// 295	296	297	
			, {1179, -11, 4, 0}, {1179, -11, 5, 0}, {1179, -11, 6, 0}// 298	299	300	
			, {1179, -11, 7, 0}, {1179, -11, 8, 0}, {1179, -11, 9, 0}// 301	302	303	
			, {1179, -11, 10, 0}, {1179, -11, 12, 0}, {1179, -10, 0, 0}// 304	305	306	
			, {1179, -10, 1, 0}, {1179, -10, 2, 0}, {1179, -10, 3, 0}// 307	308	309	
			, {1179, -10, 4, 0}, {1179, -10, 5, 0}, {1179, -10, 6, 0}// 310	311	312	
			, {1179, -10, 7, 0}, {1179, -10, 8, 0}, {1179, -10, 9, 0}// 313	314	315	
			, {1179, -10, 11, 0}, {1179, -10, 12, 0}, {1179, -9, 10, 0}// 316	317	318	
			, {1179, -9, 11, 0}, {1179, -9, 12, 0}, {1179, -8, 10, 0}// 319	320	321	
			, {1179, -8, 11, 0}, {1179, -8, 12, 0}, {1179, -7, 0, 0}// 322	323	324	
			, {1179, -7, 1, 0}, {1179, -7, 2, 0}, {1179, -7, 3, 0}// 325	326	327	
			, {1179, -7, 4, 0}, {1179, -7, 5, 0}, {1179, -7, 6, 0}// 328	329	330	
			, {1179, -7, 10, 0}, {1179, -7, 11, 0}, {1179, -7, 12, 0}// 331	332	333	
			, {1179, -6, 0, 0}, {1179, -6, 1, 0}, {1179, -6, 2, 0}// 334	335	336	
			, {1179, -6, 3, 0}, {1179, -6, 4, 0}, {1179, -6, 5, 0}// 337	338	339	
			, {1179, -6, 7, 0}, {1179, -6, 10, 0}, {1179, -6, 11, 0}// 340	341	342	
			, {1179, -6, 12, 0}, {1179, -5, 6, 0}, {1179, -5, 7, 0}// 343	344	345	
			, {1179, -5, 10, 0}, {1179, -5, 11, 0}, {1179, -5, 12, 0}// 346	347	348	
			, {1179, -4, 6, 0}, {1179, -4, 7, 0}, {1179, -4, 10, 0}// 349	350	351	
			, {1179, -4, 11, 0}, {1179, -4, 12, 0}, {1179, -3, 6, 0}// 352	353	354	
			, {1179, -3, 7, 0}, {1179, -3, 10, 0}, {1179, -3, 11, 0}// 355	356	357	
			, {1179, -3, 12, 0}, {1179, -2, 0, 0}, {1179, -2, 1, 0}// 358	359	360	
			, {1179, -2, 2, 0}, {1179, -2, 6, 0}, {1179, -2, 7, 0}// 361	362	363	
			, {1179, -2, 10, 0}, {1179, -2, 11, 0}, {1179, -2, 12, 0}// 364	365	366	
			, {1179, -1, 0, 0}, {1179, -1, 1, 0}, {1179, -1, 2, 0}// 367	368	369	
			, {1179, -1, 6, 0}, {1179, -1, 7, 0}, {1179, -1, 10, 0}// 370	371	372	
			, {1179, -1, 11, 0}, {1179, -1, 12, 0}, {1179, 0, 0, 0}// 373	374	375	
			, {1179, 0, 1, 0}, {1179, 0, 2, 0}, {1179, 0, 6, 0}// 376	377	378	
			, {1179, 0, 7, 0}, {1179, 0, 10, 0}, {1179, 0, 11, 0}// 379	380	381	
			, {1179, 0, 12, 0}, {1179, 1, 0, 0}, {1179, 1, 1, 0}// 382	383	384	
			, {1179, 1, 2, 0}, {1179, 1, 6, 0}, {1179, 1, 7, 0}// 385	386	387	
			, {1179, 1, 10, 0}, {1179, 1, 11, 0}, {1179, 1, 12, 0}// 388	389	390	
			, {1179, 2, 0, 0}, {1179, 2, 1, 0}, {1179, 2, 2, 0}// 391	392	393	
			, {1179, 2, 6, 0}, {1179, 2, 7, 0}, {1179, 2, 10, 0}// 394	395	396	
			, {1179, 2, 11, 0}, {1179, 2, 12, 0}, {1179, -11, 11, 0}// 397	398	399	
			, {1179, -10, 10, 0}, {1265, -9, 9, 0}, {1261, -7, 8, 0}// 400	401	402	
			, {1261, -6, 8, 0}, {1261, -5, 8, 0}, {1261, -4, 8, 0}// 403	404	405	
			, {1261, -3, 8, 0}, {1261, -2, 8, 0}, {1261, -1, 8, 0}// 406	407	408	
			, {1261, 0, 8, 0}, {1261, 1, 8, 0}, {1261, 2, 8, 0}// 409	410	411	
			, {1260, -9, 0, 0}, {1260, -9, 1, 0}, {1260, -9, 2, 0}// 412	413	414	
			, {1260, -9, 3, 0}, {1260, -9, 4, 0}, {1260, -9, 5, 0}// 415	416	417	
			, {1260, -9, 6, 0}, {1260, -9, 7, 0}, {1260, -9, 8, 0}// 418	419	420	
			, {1259, -8, 9, 0}, {1259, -7, 9, 0}, {1259, -6, 9, 0}// 421	422	423	
			, {1259, -5, 9, 0}, {1259, -4, 9, 0}, {1259, -3, 9, 0}// 424	425	426	
			, {1259, -2, 9, 0}, {1259, -1, 9, 0}, {1259, 0, 9, 0}// 427	428	429	
			, {1259, 1, 9, 0}, {1259, 2, 9, 0}, {1258, -8, 0, 0}// 430	431	432	
			, {1258, -8, 1, 0}, {1258, -8, 2, 0}, {1258, -8, 3, 0}// 433	434	435	
			, {1258, -8, 4, 0}, {1258, -8, 5, 0}, {1258, -8, 6, 0}// 436	437	438	
			, {1258, -8, 7, 0}, {1266, -8, 8, 0}, {1179, -7, 7, 0}// 439	440	441	
			, {1179, -6, 6, 0}, {1258, -3, 0, 0}, {1258, -3, 1, 0}// 442	443	444	
			, {1258, -3, 2, 0}, {1259, -4, 5, 0}, {1259, -3, 5, 0}// 445	446	447	
			, {1259, -2, 5, 0}, {1259, -1, 5, 0}, {1259, 0, 5, 0}// 448	449	450	
			, {1259, 1, 5, 0}, {1259, 2, 5, 0}, {1260, -5, 0, 0}// 451	452	453	
			, {1260, -5, 1, 0}, {1260, -5, 2, 0}, {1260, -5, 3, 0}// 454	455	456	
			, {1260, -5, 4, 0}, {1261, -2, 3, 0}, {1261, -1, 3, 0}// 457	458	459	
			, {1261, 0, 3, 0}, {1261, 1, 3, 0}, {1261, 2, 3, 0}// 460	461	462	
			, {1266, -4, 4, 0}, {1266, -3, 4, 0}, {1266, -2, 4, 0}// 463	464	465	
			, {1266, -1, 4, 0}, {1266, 0, 4, 0}, {1266, 1, 4, 0}// 466	467	468	
			, {1266, 2, 4, 0}, {1266, -4, 0, 0}, {1266, -4, 1, 0}// 469	470	471	
			, {1266, -4, 2, 0}, {1266, -4, 3, 0}, {1265, -5, 5, 0}// 472	473	474	
			, {1266, -3, 3, 0}, {3215, -12, 0, 1}, {3215, -12, 1, 1}// 475	476	477	
			, {3215, -12, 2, 1}, {3215, -12, 3, 1}, {3215, -12, 4, 1}// 478	479	480	
			, {3215, -12, 5, 1}, {3215, -12, 6, 1}, {3215, -12, 7, 1}// 481	482	483	
			, {3215, -12, 8, 1}, {3215, -12, 9, 1}, {3215, -12, 10, 1}// 484	485	486	
			, {3215, -12, 11, 1}, {3215, -12, 12, 1}, {3215, -12, 0, 6}// 487	488	489	
			, {3215, -12, 1, 6}, {3215, -12, 2, 6}, {3215, -12, 3, 6}// 490	491	492	
			, {3215, -12, 4, 6}, {3215, -12, 5, 6}, {3215, -12, 6, 6}// 493	494	495	
			, {3215, -12, 7, 6}, {3215, -12, 8, 6}, {3215, -12, 9, 6}// 496	497	498	
			, {3215, -12, 10, 6}, {3215, -12, 11, 6}, {3215, -12, 12, 6}// 499	500	501	
			, {3215, -11, 12, 1}, {3215, -10, 12, 1}, {3215, -9, 12, 1}// 502	503	504	
			, {3215, -8, 12, 1}, {3215, -7, 12, 1}, {3215, -6, 12, 1}// 505	506	507	
			, {3215, -5, 12, 1}, {3215, -4, 12, 1}, {3215, -3, 12, 1}// 508	509	510	
			, {3215, -2, 12, 1}, {3215, -1, 12, 1}, {3215, 0, 12, 1}// 511	512	513	
			, {3215, 1, 12, 1}, {3215, 2, 12, 1}, {3215, -11, 12, 6}// 514	515	516	
			, {3215, -10, 12, 6}, {3215, -9, 12, 6}, {3215, -8, 12, 6}// 517	518	519	
			, {3215, -7, 12, 6}, {3215, -6, 12, 6}, {3215, -5, 12, 6}// 520	521	522	
			, {3215, -4, 12, 6}, {3215, -3, 12, 6}, {3215, -2, 12, 6}// 523	524	525	
			, {3215, -1, 12, 6}, {3215, 0, 12, 6}, {3215, 1, 12, 6}// 526	527	528	
			, {3215, 2, 12, 6}, {3149, -11, 12, 9}, {3149, -10, 12, 9}// 529	530	531	
			, {3149, -9, 12, 9}, {3149, -8, 12, 9}, {3149, -7, 12, 9}// 532	533	534	
			, {3149, -6, 12, 9}, {3149, -5, 12, 9}, {3149, -4, 12, 9}// 535	536	537	
			, {3149, -3, 12, 9}, {3149, -2, 12, 9}, {3149, -1, 12, 9}// 538	539	540	
			, {3149, 0, 12, 9}, {3149, 1, 12, 9}, {3149, 2, 12, 9}// 541	542	543	
			, {3149, -12, 0, 9}, {3149, -12, 1, 9}, {3149, -12, 2, 9}// 544	545	546	
			, {3149, -12, 3, 9}, {3149, -12, 4, 9}, {3149, -12, 5, 9}// 547	548	549	
			, {3149, -12, 6, 9}, {3149, -12, 7, 9}, {3149, -12, 8, 9}// 550	551	552	
			, {3149, -12, 9, 9}, {3149, -12, 10, 9}, {3149, -12, 11, 9}// 553	554	555	
			, {3149, -12, 12, 9}, {3203, -11, 10, 1}, {3203, -10, 11, 1}// 556	557	558	
			, {3203, -9, 11, 1}, {3203, -8, 11, 1}, {3203, -7, 11, 1}// 559	560	561	
			, {3203, -6, 11, 1}, {3203, -5, 11, 1}, {3203, -4, 11, 1}// 562	563	564	
			, {3203, -3, 11, 1}, {3203, -2, 11, 1}, {3203, -1, 11, 1}// 565	566	567	
			, {3203, 0, 11, 1}, {3203, 1, 11, 1}, {3203, 2, 11, 1}// 568	569	570	
			, {3203, -11, 0, 1}, {3203, -11, 1, 1}, {3203, -11, 2, 1}// 571	572	573	
			, {3203, -11, 3, 1}, {3203, -11, 4, 1}, {3203, -11, 5, 1}// 574	575	576	
			, {3203, -11, 6, 1}, {3203, -11, 7, 1}, {3203, -11, 8, 1}// 577	578	579	
			, {3203, -11, 9, 1}, {1179, 3, -12, 0}, {1179, 3, -11, 0}// 580	581	582	
			, {1179, 3, -10, 0}, {1179, 3, -7, 0}, {1179, 3, -6, 0}// 583	584	585	
			, {1179, 4, -12, 0}, {1179, 4, -11, 0}, {1179, 4, -10, 0}// 586	587	588	
			, {1179, 4, -7, 0}, {1179, 4, -6, 0}, {1179, 5, -12, 0}// 589	590	591	
			, {1179, 5, -11, 0}, {1179, 5, -10, 0}, {1179, 5, -7, 0}// 592	593	594	
			, {1179, 5, -6, 0}, {1179, 6, -12, 0}, {1179, 6, -11, 0}// 595	596	597	
			, {1179, 6, -10, 0}, {1179, 6, -7, 0}, {1179, 6, -5, 0}// 598	599	600	
			, {1179, 6, -4, 0}, {1179, 6, -3, 0}, {1179, 6, -2, 0}// 601	602	603	
			, {1179, 6, -1, 0}, {1179, 7, -12, 0}, {1179, 7, -11, 0}// 604	605	606	
			, {1179, 7, -10, 0}, {1179, 7, -6, 0}, {1179, 7, -5, 0}// 607	608	609	
			, {1179, 7, -4, 0}, {1179, 7, -3, 0}, {1179, 7, -2, 0}// 610	611	612	
			, {1179, 7, -1, 0}, {1179, 8, -12, 0}, {1179, 8, -11, 0}// 613	614	615	
			, {1179, 8, -10, 0}, {1179, 9, -12, 0}, {1179, 9, -11, 0}// 616	617	618	
			, {1179, 9, -10, 0}, {1179, 10, -12, 0}, {1179, 10, -11, 0}// 619	620	621	
			, {1179, 10, -9, 0}, {1179, 10, -8, 0}, {1179, 10, -7, 0}// 622	623	624	
			, {1179, 10, -6, 0}, {1179, 10, -5, 0}, {1179, 10, -4, 0}// 625	626	627	
			, {1179, 10, -3, 0}, {1179, 10, -2, 0}, {1179, 10, -1, 0}// 628	629	630	
			, {1179, 11, -12, 0}, {1179, 11, -10, 0}, {1179, 11, -9, 0}// 631	632	633	
			, {1179, 11, -8, 0}, {1179, 11, -7, 0}, {1179, 11, -6, 0}// 634	635	636	
			, {1179, 11, -5, 0}, {1179, 11, -4, 0}, {1179, 11, -3, 0}// 637	638	639	
			, {1179, 11, -2, 0}, {1179, 11, -1, 0}, {1179, 12, -12, 0}// 640	641	642	
			, {1179, 12, -11, 0}, {1179, 12, -10, 0}, {1179, 12, -9, 0}// 643	644	645	
			, {1179, 12, -8, 0}, {1179, 12, -7, 0}, {1179, 12, -6, 0}// 646	647	648	
			, {1179, 12, -5, 0}, {1179, 12, -4, 0}, {1179, 12, -3, 0}// 649	650	651	
			, {1179, 12, -2, 0}, {1179, 12, -1, 0}, {1179, 11, -11, 0}// 652	653	654	
			, {1179, 10, -10, 0}, {1263, 9, -9, 0}, {1261, 3, -9, 0}// 655	656	657	
			, {1261, 4, -9, 0}, {1261, 5, -9, 0}, {1261, 6, -9, 0}// 658	659	660	
			, {1261, 7, -9, 0}, {1261, 8, -9, 0}, {1260, 8, -7, 0}// 661	662	663	
			, {1260, 8, -6, 0}, {1260, 8, -5, 0}, {1260, 8, -4, 0}// 664	665	666	
			, {1260, 8, -3, 0}, {1260, 8, -2, 0}, {1260, 8, -1, 0}// 667	668	669	
			, {1259, 3, -8, 0}, {1259, 4, -8, 0}, {1259, 5, -8, 0}// 670	671	672	
			, {1259, 6, -8, 0}, {1259, 7, -8, 0}, {1258, 9, -8, 0}// 673	674	675	
			, {1258, 9, -7, 0}, {1258, 9, -6, 0}, {1258, 9, -5, 0}// 676	677	678	
			, {1258, 9, -4, 0}, {1258, 9, -3, 0}, {1258, 9, -2, 0}// 679	680	681	
			, {1258, 9, -1, 0}, {1266, 8, -8, 0}, {1179, 7, -7, 0}// 682	683	684	
			, {1179, 6, -6, 0}, {1258, 5, -4, 0}, {1258, 5, -3, 0}// 685	686	687	
			, {1258, 5, -2, 0}, {1258, 5, -1, 0}, {1260, 3, -2, 0}// 688	689	690	
			, {1260, 3, -1, 0}, {1261, 3, -5, 0}, {1261, 4, -5, 0}// 691	692	693	
			, {1266, 4, -4, 0}, {1266, 4, -3, 0}, {1266, 4, -2, 0}// 694	695	696	
			, {1266, 4, -1, 0}, {1266, 3, -4, 0}, {1263, 5, -5, 0}// 697	698	699	
			, {1266, 3, -3, 0}, {3215, 3, -12, 1}, {3215, 4, -12, 1}// 700	701	702	
			, {3215, 5, -12, 1}, {3215, 6, -12, 1}, {3215, 7, -12, 1}// 703	704	705	
			, {3215, 8, -12, 1}, {3215, 9, -12, 1}, {3215, 10, -12, 1}// 706	707	708	
			, {3215, 11, -12, 1}, {3215, 12, -12, 1}, {3215, 12, -11, 1}// 709	710	711	
			, {3215, 12, -10, 1}, {3215, 12, -9, 1}, {3215, 12, -8, 1}// 712	713	714	
			, {3215, 12, -7, 1}, {3215, 12, -6, 1}, {3215, 12, -5, 1}// 715	716	717	
			, {3215, 12, -4, 1}, {3215, 12, -3, 1}, {3215, 12, -2, 1}// 718	719	720	
			, {3215, 12, -1, 1}, {3215, 3, -12, 6}, {3215, 4, -12, 6}// 721	722	723	
			, {3215, 5, -12, 6}, {3215, 6, -12, 6}, {3215, 7, -12, 6}// 724	725	726	
			, {3215, 8, -12, 6}, {3215, 9, -12, 6}, {3215, 10, -12, 6}// 727	728	729	
			, {3215, 11, -12, 6}, {3215, 12, -12, 6}, {3215, 12, -11, 6}// 730	731	732	
			, {3215, 12, -10, 6}, {3215, 12, -9, 6}, {3215, 12, -8, 6}// 733	734	735	
			, {3215, 12, -7, 6}, {3215, 12, -6, 6}, {3215, 12, -5, 6}// 736	737	738	
			, {3215, 12, -4, 6}, {3215, 12, -3, 6}, {3215, 12, -2, 6}// 739	740	741	
			, {3215, 12, -1, 6}, {3149, 3, -12, 9}, {3149, 4, -12, 9}// 742	743	744	
			, {3149, 5, -12, 9}, {3149, 6, -12, 9}, {3149, 7, -12, 9}// 745	746	747	
			, {3149, 8, -12, 9}, {3149, 9, -12, 9}, {3149, 10, -12, 9}// 748	749	750	
			, {3149, 11, -12, 9}, {3149, 12, -12, 9}, {3149, 12, -11, 9}// 751	752	753	
			, {3149, 12, -10, 9}, {3149, 12, -9, 9}, {3149, 12, -8, 9}// 754	755	756	
			, {3149, 12, -7, 9}, {3149, 12, -6, 9}, {3149, 12, -5, 9}// 757	758	759	
			, {3149, 12, -4, 9}, {3149, 12, -3, 9}, {3149, 12, -2, 9}// 760	761	762	
			, {3149, 12, -1, 9}, {3203, 3, -11, 1}, {3203, 4, -11, 1}// 763	764	765	
			, {3203, 5, -11, 1}, {3203, 6, -11, 1}, {3203, 7, -11, 1}// 766	767	768	
			, {3203, 8, -11, 1}, {3203, 9, -11, 1}, {3203, 10, -11, 1}// 769	770	771	
			, {3203, 11, -10, 1}, {3203, 11, -9, 1}, {3203, 11, -8, 1}// 772	773	774	
			, {3203, 11, -7, 1}, {3203, 11, -6, 1}, {3203, 11, -5, 1}// 775	776	777	
			, {3203, 11, -4, 1}, {3203, 11, -3, 1}, {3203, 11, -2, 1}// 778	779	780	
			, {3203, 11, -1, 1}, {1179, 3, 6, 0}, {1179, 3, 7, 0}// 781	782	783	
			, {1179, 3, 10, 0}, {1179, 3, 11, 0}, {1179, 3, 12, 0}// 784	785	786	
			, {1179, 4, 6, 0}, {1179, 4, 7, 0}, {1179, 4, 10, 0}// 787	788	789	
			, {1179, 4, 11, 0}, {1179, 4, 12, 0}, {1179, 5, 6, 0}// 790	791	792	
			, {1179, 5, 7, 0}, {1179, 5, 10, 0}, {1179, 5, 11, 0}// 793	794	795	
			, {1179, 5, 12, 0}, {1179, 6, 0, 0}, {1179, 6, 1, 0}// 796	797	798	
			, {1179, 6, 2, 0}, {1179, 6, 3, 0}, {1179, 6, 4, 0}// 799	800	801	
			, {1179, 6, 5, 0}, {1179, 6, 7, 0}, {1179, 6, 10, 0}// 802	803	804	
			, {1179, 6, 11, 0}, {1179, 6, 12, 0}, {1179, 7, 0, 0}// 805	806	807	
			, {1179, 7, 1, 0}, {1179, 7, 2, 0}, {1179, 7, 3, 0}// 808	809	810	
			, {1179, 7, 4, 0}, {1179, 7, 5, 0}, {1179, 7, 6, 0}// 811	812	813	
			, {1179, 7, 10, 0}, {1179, 7, 11, 0}, {1179, 7, 12, 0}// 814	815	816	
			, {1179, 8, 10, 0}, {1179, 8, 11, 0}, {1179, 8, 12, 0}// 817	818	819	
			, {1179, 9, 10, 0}, {1179, 9, 11, 0}, {1179, 9, 12, 0}// 820	821	822	
			, {1179, 10, 0, 0}, {1179, 10, 1, 0}, {1179, 10, 2, 0}// 823	824	825	
			, {1179, 10, 3, 0}, {1179, 10, 4, 0}, {1179, 10, 5, 0}// 826	827	828	
			, {1179, 10, 6, 0}, {1179, 10, 7, 0}, {1179, 10, 8, 0}// 829	830	831	
			, {1179, 10, 9, 0}, {1179, 10, 11, 0}, {1179, 10, 12, 0}// 832	833	834	
			, {1179, 11, 0, 0}, {1179, 11, 1, 0}, {1179, 11, 2, 0}// 835	836	837	
			, {1179, 11, 3, 0}, {1179, 11, 4, 0}, {1179, 11, 5, 0}// 838	839	840	
			, {1179, 11, 6, 0}, {1179, 11, 7, 0}, {1179, 11, 8, 0}// 841	842	843	
			, {1179, 11, 9, 0}, {1179, 11, 10, 0}, {1179, 11, 12, 0}// 844	845	846	
			, {1179, 12, 0, 0}, {1179, 12, 1, 0}, {1179, 12, 2, 0}// 847	848	849	
			, {1179, 12, 3, 0}, {1179, 12, 4, 0}, {1179, 12, 5, 0}// 850	851	852	
			, {1179, 12, 6, 0}, {1179, 12, 7, 0}, {1179, 12, 8, 0}// 853	854	855	
			, {1179, 12, 9, 0}, {1179, 12, 10, 0}, {1179, 12, 11, 0}// 856	857	858	
			, {1179, 12, 12, 0}, {1179, 11, 11, 0}, {1179, 10, 10, 0}// 859	860	861	
			, {1264, 9, 9, 0}, {1261, 3, 8, 0}, {1261, 4, 8, 0}// 862	863	864	
			, {1261, 5, 8, 0}, {1261, 6, 8, 0}, {1261, 7, 8, 0}// 865	866	867	
			, {1260, 8, 0, 0}, {1260, 8, 1, 0}, {1260, 8, 2, 0}// 868	869	870	
			, {1260, 8, 3, 0}, {1260, 8, 4, 0}, {1260, 8, 5, 0}// 871	872	873	
			, {1260, 8, 6, 0}, {1260, 8, 7, 0}, {1259, 3, 9, 0}// 874	875	876	
			, {1259, 4, 9, 0}, {1259, 5, 9, 0}, {1259, 6, 9, 0}// 877	878	879	
			, {1259, 7, 9, 0}, {1259, 8, 9, 0}, {1258, 9, 0, 0}// 880	881	882	
			, {1258, 9, 1, 0}, {1258, 9, 2, 0}, {1258, 9, 3, 0}// 883	884	885	
			, {1258, 9, 4, 0}, {1258, 9, 5, 0}, {1258, 9, 6, 0}// 886	887	888	
			, {1258, 9, 7, 0}, {1258, 9, 8, 0}, {1266, 8, 8, 0}// 889	890	891	
			, {1179, 7, 7, 0}, {1179, 6, 6, 0}, {1258, 5, 0, 0}// 892	893	894	
			, {1258, 5, 1, 0}, {1258, 5, 2, 0}, {1258, 5, 3, 0}// 895	896	897	
			, {1258, 5, 4, 0}, {1259, 3, 5, 0}, {1259, 4, 5, 0}// 898	899	900	
			, {1260, 3, 0, 0}, {1260, 3, 1, 0}, {1260, 3, 2, 0}// 901	902	903	
			, {1266, 4, 0, 0}, {1266, 4, 1, 0}, {1266, 4, 2, 0}// 904	905	906	
			, {1266, 4, 3, 0}, {1266, 4, 4, 0}, {1266, 3, 4, 0}// 907	908	909	
			, {1264, 5, 5, 0}, {1266, 3, 3, 0}, {3215, 12, 0, 1}// 910	911	912	
			, {3215, 12, 1, 1}, {3215, 12, 2, 1}, {3215, 12, 3, 1}// 913	914	915	
			, {3215, 12, 4, 1}, {3215, 12, 5, 1}, {3215, 12, 6, 1}// 916	917	918	
			, {3215, 12, 7, 1}, {3215, 12, 8, 1}, {3215, 12, 9, 1}// 919	920	921	
			, {3215, 12, 10, 1}, {3215, 12, 11, 1}, {3215, 12, 12, 1}// 922	923	924	
			, {3215, 3, 12, 1}, {3215, 4, 12, 1}, {3215, 5, 12, 1}// 925	926	927	
			, {3215, 6, 12, 1}, {3215, 7, 12, 1}, {3215, 8, 12, 1}// 928	929	930	
			, {3215, 9, 12, 1}, {3215, 10, 12, 1}, {3215, 11, 12, 1}// 931	932	933	
			, {3215, 12, 0, 6}, {3215, 12, 1, 6}, {3215, 12, 2, 6}// 934	935	936	
			, {3215, 12, 3, 6}, {3215, 12, 4, 6}, {3215, 12, 5, 6}// 937	938	939	
			, {3215, 12, 6, 6}, {3215, 12, 7, 6}, {3215, 12, 8, 6}// 940	941	942	
			, {3215, 12, 9, 6}, {3215, 12, 10, 6}, {3215, 12, 11, 6}// 943	944	945	
			, {3215, 12, 12, 6}, {3215, 3, 12, 6}, {3215, 4, 12, 6}// 946	947	948	
			, {3215, 5, 12, 6}, {3215, 6, 12, 6}, {3215, 7, 12, 6}// 949	950	951	
			, {3215, 8, 12, 6}, {3215, 9, 12, 6}, {3215, 10, 12, 6}// 952	953	954	
			, {3215, 11, 12, 6}, {3149, 12, 0, 9}, {3149, 12, 1, 9}// 955	956	957	
			, {3149, 12, 2, 9}, {3149, 12, 3, 9}, {3149, 12, 4, 9}// 958	959	960	
			, {3149, 12, 5, 9}, {3149, 12, 6, 9}, {3149, 12, 7, 9}// 961	962	963	
			, {3149, 12, 8, 9}, {3149, 12, 9, 9}, {3149, 12, 10, 9}// 964	965	966	
			, {3149, 12, 11, 9}, {3149, 12, 12, 9}, {3149, 3, 12, 9}// 967	968	969	
			, {3149, 4, 12, 9}, {3149, 5, 12, 9}, {3149, 6, 12, 9}// 970	971	972	
			, {3149, 7, 12, 9}, {3149, 8, 12, 9}, {3149, 9, 12, 9}// 973	974	975	
			, {3149, 10, 12, 9}, {3149, 11, 12, 9}, {3203, 11, 0, 1}// 976	977	978	
			, {3203, 11, 1, 1}, {3203, 11, 2, 1}, {3203, 11, 3, 1}// 979	980	981	
			, {3203, 11, 4, 1}, {3203, 11, 5, 1}, {3203, 11, 6, 1}// 982	983	984	
			, {3203, 11, 7, 1}, {3203, 11, 8, 1}, {3203, 11, 9, 1}// 985	986	987	
			, {3203, 11, 10, 1}, {3203, 3, 11, 1}, {3203, 4, 11, 1}// 988	989	990	
			, {3203, 5, 11, 1}, {3203, 6, 11, 1}, {3203, 7, 11, 1}// 991	992	993	
			, {3203, 8, 11, 1}, {3203, 9, 11, 1}, {3203, 10, 11, 0}// 994	995	996	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new IsaRoofTopAddonDeed();
			}
		}

		[ Constructable ]
		public IsaRoofTopAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public IsaRoofTopAddon( Serial serial ) : base( serial )
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

	public class IsaRoofTopAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new IsaRoofTopAddon();
			}
		}

		[Constructable]
		public IsaRoofTopAddonDeed()
		{
			Name = "IsaRoofTop";
		}

		public IsaRoofTopAddonDeed( Serial serial ) : base( serial )
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