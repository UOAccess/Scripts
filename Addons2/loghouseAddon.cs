
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
	public class loghouseAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3349, -10, -2, 0}, {2147, -5, -1, 9}, {1193, 0, -1, 0}// 1	2	3	
			, {1199, 6, -1, 0}, {1199, 6, -2, 0}, {1199, 6, -3, 0}// 4	5	6	
			, {1199, 6, -4, 0}, {1193, 2, -6, 0}, {1199, 6, -5, 0}// 7	8	9	
			, {1199, 6, -6, 0}, {1197, -1, -1, 20}, {1199, 6, -7, 0}// 10	11	13	
			, {1194, 4, -2, 20}, {8526, 1, -5, 49}, {8522, 4, -8, 49}// 14	15	16	
			, {146, 0, -9, 0}, {1194, 5, -5, 20}, {1194, 4, -4, 20}// 17	18	19	
			, {1194, 5, -6, 20}, {1194, 5, 0, 20}, {145, 6, -1, 0}// 20	21	22	
			, {1194, 3, -5, 20}, {1194, 3, -4, 20}, {1194, 5, -1, 20}// 23	24	25	
			, {8522, -5, 0, 50}, {8524, 6, 0, 49}, {145, -2, -7, 0}// 26	27	28	
			, {1199, 6, -6, 20}, {147, -7, -1, 0}, {147, -7, -1, 20}// 29	30	31	
			, {145, -2, 0, 0}, {145, 6, -3, 0}, {8524, 6, -1, 49}// 32	33	34	
			, {1194, 5, -2, 20}, {2147, -3, -1, 0}, {1194, 4, -1, 20}// 35	36	37	
			, {1199, 6, -4, 20}, {147, -2, -1, 0}, {1200, -4, 0, 20}// 38	39	40	
			, {8526, 2, -5, 49}, {1194, 1, 0, 20}, {8524, 6, -7, 49}// 41	42	43	
			, {8522, -6, 0, 47}, {8524, 6, -4, 49}, {1199, 6, 0, 20}// 44	45	46	
			, {2148, -7, 0, 0}, {8520, -1, -3, 49}, {8526, 3, -5, 49}// 47	48	49	
			, {1197, -1, 0, 20}, {1194, 4, -7, 20}, {151, -2, -1, 20}// 50	51	52	
			, {1197, -1, -6, 20}, {8520, -2, -2, 46}, {1445, 5, 0, 52}// 53	54	55	
			, {145, -2, -5, 20}, {1194, 0, -3, 20}, {146, -1, -3, 20}// 56	57	58	
			, {145, -2, -6, 20}, {145, -2, -7, 20}, {1199, 6, -1, 20}// 59	60	61	
			, {1445, 5, -3, 52}, {1445, 5, -8, 52}, {1194, 3, -7, 20}// 62	63	64	
			, {8524, 6, -2, 49}, {145, 6, -8, 20}, {1194, 1, -1, 20}// 65	66	67	
			, {145, 6, -2, 0}, {145, 6, -4, 0}, {8526, -2, -5, 49}// 68	69	70	
			, {3341, -4, -4, 0}, {151, 6, -9, 20}, {8526, -1, -5, 49}// 71	72	73	
			, {1199, 6, -7, 20}, {146, 3, -9, 20}, {1445, 5, -5, 52}// 74	75	76	
			, {1199, 6, -5, 20}, {1194, 1, -2, 20}, {8520, 2, -2, 46}// 77	78	79	
			, {1194, 3, 0, 20}, {1194, 1, -3, 20}, {1194, 0, -7, 20}// 80	81	82	
			, {1194, 2, -5, 20}, {1194, 2, -6, 20}, {1194, 0, -1, 20}// 83	84	85	
			, {1194, 2, -7, 20}, {1194, 4, -6, 20}, {146, 0, -9, 20}// 86	87	88	
			, {1199, 6, -2, 20}, {1194, 0, -6, 20}, {146, -1, -9, 20}// 89	90	91	
			, {1194, 2, -4, 20}, {1200, -5, 0, 20}, {1194, 2, -3, 20}// 92	93	94	
			, {2187, -2, -2, 20}, {1194, 2, -2, 20}, {146, 5, -9, 20}// 95	96	97	
			, {1193, 2, -4, 0}, {1193, 1, -4, 0}, {1194, 1, -7, 20}// 98	99	100	
			, {8524, 6, -5, 49}, {1193, 1, 0, 0}, {1200, -3, 0, 20}// 101	102	103	
			, {8520, 3, -3, 49}, {1194, 3, -1, 20}, {146, -1, -9, 0}// 104	105	106	
			, {1194, 3, -2, 20}, {1194, 5, -3, 20}, {145, -2, -8, 0}// 107	108	110	
			, {8522, 3, -8, 46}, {146, 4, -9, 0}, {1445, -4, 0, 53}// 111	112	113	
			, {1452, 2, -7, 43}, {146, -6, -1, 20}, {8522, -7, -1, 20}// 114	116	117	
			, {145, 6, -2, 20}, {145, 6, 0, 0}, {1197, -1, -2, 20}// 118	119	120	
			, {8520, -2, -3, 49}, {1194, 3, -3, 20}, {1197, -1, -4, 0}// 121	122	123	
			, {145, 6, -7, 20}, {145, 6, -4, 20}, {8524, 6, -6, 49}// 124	125	126	
			, {151, 6, -9, 0}, {145, 6, -6, 0}, {145, -2, -5, 0}// 127	128	129	
			, {1194, 3, -6, 20}, {8524, 6, -3, 49}, {2149, -4, -1, 9}// 130	131	133	
			, {151, 2, -3, 20}, {8524, -1, 0, 44}, {145, 6, -5, 20}// 135	136	137	
			, {8522, 3, -2, 46}, {8526, 0, -5, 49}, {145, 6, -5, 0}// 138	139	140	
			, {145, -2, -6, 0}, {12791, -6, 0, 1}, {1200, 3, -8, 0}// 141	142	143	
			, {1197, -1, 0, 0}, {1193, 0, -4, 0}, {1200, 4, -8, 0}// 144	145	146	
			, {1193, 0, -7, 0}, {1193, 0, -3, 0}, {1193, 0, -2, 0}// 147	148	149	
			, {1197, -1, -1, 0}, {3340, -6, -3, 0}, {3347, -4, -6, 0}// 150	151	152	
			, {1193, 1, -7, 0}, {12791, -4, 0, 1}, {1199, 6, 0, 0}// 153	154	155	
			, {1193, 1, -2, 0}, {1193, 1, -3, 0}, {1193, 1, -1, 0}// 156	157	158	
			, {1197, -1, -5, 0}, {12791, -3, 0, 1}, {1197, -1, -6, 0}// 159	160	161	
			, {1197, -1, -7, 0}, {12791, -5, 0, 1}, {1203, 6, -8, 0}// 162	163	164	
			, {1193, 5, 0, 0}, {1193, 5, -1, 0}, {1193, 5, -2, 0}// 165	166	167	
			, {1193, 5, -3, 0}, {1193, 1, -5, 0}, {1193, 5, -4, 0}// 168	169	170	
			, {1193, 5, -5, 0}, {1193, 5, -6, 0}, {1193, 5, -7, 0}// 171	172	173	
			, {1193, 1, -6, 0}, {1200, 1, -8, 0}, {1193, 4, 0, 0}// 174	175	176	
			, {1193, 4, -1, 0}, {1193, 4, -2, 0}, {1193, 4, -3, 0}// 177	178	179	
			, {1193, 4, -4, 0}, {1193, 4, -5, 0}, {1193, 4, -6, 0}// 180	181	182	
			, {1193, 4, -7, 0}, {1200, 2, -8, 0}, {1197, -1, -3, 0}// 183	184	185	
			, {3310, -4, 0, 0}, {1204, -1, -8, 0}, {1193, 3, 0, 0}// 186	187	188	
			, {1193, 3, -1, 0}, {1193, 3, -2, 0}, {1193, 3, -3, 0}// 189	190	191	
			, {1193, 2, -5, 0}, {1193, 3, -4, 0}, {1193, 3, -5, 0}// 192	193	194	
			, {1193, 3, -6, 0}, {1193, 3, -7, 0}, {1197, -1, -2, 0}// 195	196	197	
			, {3262, -5, -3, 0}, {8522, 4, -7, 49}, {1193, 2, 0, 0}// 198	199	200	
			, {1450, 4, -3, 49}, {8522, 3, 0, 46}, {11541, 6, 0, 21}// 201	202	203	
			, {1193, 2, -1, 0}, {1193, 2, -2, 0}, {1193, 2, -3, 0}// 204	205	206	
			, {1200, 5, -8, 0}, {1457, 5, -4, 52}, {2187, -2, -1, 20}// 207	208	209	
			, {12791, -2, 0, 1}, {8522, 4, -6, 49}, {1193, 0, -5, 0}// 210	211	212	
			, {1193, 0, -6, 0}, {1193, 2, -7, 0}, {8522, 3, -1, 46}// 213	214	215	
			, {1448, 3, -4, 52}, {1448, 2, -4, 52}, {1448, 1, -4, 52}// 216	217	218	
			, {1448, 0, -4, 52}, {1448, -1, -4, 52}, {1448, -2, -4, 52}// 219	220	221	
			, {1193, 0, 0, 0}, {1452, 3, -6, 46}, {8522, 2, -8, 43}// 222	223	224	
			, {1449, 1, -7, 43}, {8522, 4, -2, 49}, {1194, 0, -5, 20}// 225	226	227	
			, {1204, -1, -8, 20}, {1194, 0, -4, 20}, {1452, 1, -8, 40}// 229	230	231	
			, {1200, 0, -8, 20}, {145, 6, -1, 20}, {1200, 4, -8, 20}// 232	233	234	
			, {1200, 5, -8, 20}, {1200, 3, -8, 20}, {1200, 2, -8, 20}// 235	236	237	
			, {1200, 1, -8, 20}, {1203, 6, -8, 20}, {147, -2, -9, 0}// 238	239	240	
			, {1450, 3, -2, 46}, {8526, 2, -6, 46}, {1449, 0, -7, 43}// 241	242	243	
			, {1449, -1, -7, 43}, {1449, -2, -7, 43}, {8522, 4, 0, 49}// 244	245	246	
			, {8522, 4, -1, 49}, {1449, -2, -8, 40}, {1200, 0, -8, 0}// 247	248	249	
			, {145, -2, -4, 20}, {146, 3, -9, 0}, {146, 5, -9, 0}// 250	251	252	
			, {146, 2, -9, 0}, {146, 1, -9, 0}, {1445, 5, -6, 52}// 253	254	255	
			, {8520, 2, -3, 49}, {146, 2, -9, 20}, {8522, 3, -7, 46}// 256	257	258	
			, {1448, 4, -4, 52}, {1194, 0, 0, 20}, {145, 2, -2, 20}// 259	260	261	
			, {8520, 0, -2, 46}, {1194, 0, -2, 20}, {1194, 1, -6, 20}// 262	263	264	
			, {1194, 1, -4, 20}, {1194, 2, 0, 20}, {1449, -1, -8, 40}// 265	267	268	
			, {1194, 4, 0, 20}, {8520, 0, -3, 49}, {8520, 1, -3, 49}// 269	270	271	
			, {11543, 1, -3, 20}, {8520, -1, -2, 46}, {2147, -5, -1, 0}// 272	273	274	
			, {145, -2, -3, 0}, {145, -2, -4, 0}, {1445, 5, -2, 52}// 275	276	277	
			, {11542, 0, -3, 20}, {1199, 6, -3, 20}, {8526, 1, -6, 46}// 278	279	280	
			, {8526, 0, -6, 46}, {145, -2, -8, 20}, {150, -2, -3, 20}// 281	282	283	
			, {2148, -7, 0, 9}, {1197, -1, -5, 20}, {1194, 4, -3, 20}// 284	285	286	
			, {1194, 4, -5, 20}, {1197, -1, -3, 20}, {1197, -1, -4, 20}// 287	288	289	
			, {8524, -2, 0, 47}, {8522, -7, 0, 43}, {1194, 1, -5, 20}// 290	291	292	
			, {1194, 5, -7, 20}, {145, -2, -1, 0}, {145, -2, -2, 0}// 293	294	295	
			, {1445, 5, -7, 52}, {1452, 4, -5, 49}, {147, -2, -9, 20}// 296	297	298	
			, {8524, 6, -8, 49}, {1445, 5, -1, 52}, {145, -7, 0, 20}// 299	300	301	
			, {8526, -1, -6, 46}, {8524, -3, 0, 50}, {2147, -3, -1, 9}// 302	303	304	
			, {1194, 2, -1, 20}, {8526, -2, -6, 46}, {1197, -1, -7, 20}// 305	306	307	
			, {3310, -6, 0, 0}, {8520, 1, -2, 46}, {1194, 5, -4, 20}// 308	309	310	
			, {146, -3, -1, 20}, {145, -2, 0, 20}, {1449, 0, -8, 40}// 311	313	314	
			, {145, 6, -7, 0}, {145, 6, -8, 0}, {2149, -6, -1, 0}// 315	316	317	
			, {2149, -4, -1, 0}, {2149, -6, -1, 9}, {1204, -6, 0, 20}// 318	319	320	
			, {1203, -2, 0, 20}, {1193, 0, 1, 0}, {8522, -5, 6, 50}// 321	322	323	
			, {1198, 0, 2, 20}, {1445, 5, 3, 52}, {8522, -5, 2, 50}// 324	325	326	
			, {2917, -3, 9, 0}, {1195, -5, 2, 20}, {1198, 3, 2, 20}// 327	328	329	
			, {12791, -6, 3, 1}, {150, -2, 2, 0}, {151, 2, 2, 0}// 330	331	332	
			, {8524, 6, 2, 49}, {8524, 6, 3, 49}, {2919, -4, 9, 0}// 333	334	335	
			, {144, -2, 5, 20}, {8524, -1, 4, 44}, {1194, 5, 1, 20}// 336	337	339	
			, {150, 2, 2, 20}, {8522, -6, 4, 47}, {8524, -1, 1, 44}// 341	342	343	
			, {147, 5, 2, 0}, {8524, -1, 6, 44}, {1198, -5, 5, 20}// 344	345	346	
			, {150, -7, 5, 20}, {1201, 6, 2, 0}, {1195, -3, 4, 20}// 347	348	349	
			, {1195, -3, 3, 20}, {1197, -6, 2, 20}, {145, -2, 1, 0}// 350	351	352	
			, {1445, -4, 4, 53}, {1195, -3, 2, 20}, {1194, 1, 1, 20}// 353	354	355	
			, {2917, -3, 7, 0}, {1193, 1, 1, 0}, {8522, -5, 5, 50}// 356	357	358	
			, {2149, -7, 1, 9}, {1445, 5, 2, 52}, {8524, -1, 2, 44}// 359	360	361	
			, {8522, -6, 2, 47}, {2147, -3, 5, 9}, {2147, -5, 5, 9}// 362	363	364	
			, {8522, -5, 1, 50}, {147, -2, 5, 0}, {2147, -3, 5, 0}// 365	366	367	
			, {8524, 5, 3, 16}, {2148, -7, 2, 9}, {145, 6, 1, 0}// 368	369	370	
			, {12791, -5, 4, 1}, {12791, -5, 5, 1}, {1199, -2, 2, 20}// 371	372	373	
			, {3310, -2, 6, 0}, {1445, -4, 3, 53}, {2919, -4, 7, 0}// 374	375	376	
			, {1199, -2, 1, 20}, {1198, -3, 5, 20}, {2148, -7, 4, 0}// 377	378	379	
			, {2148, -7, 2, 0}, {1194, 2, 1, 20}, {1195, -4, 3, 20}// 380	381	382	
			, {1197, -6, 1, 20}, {1195, -4, 2, 20}, {11543, 5, 2, 0}// 383	384	385	
			, {2918, -5, 7, 0}, {1445, 5, 1, 52}, {1195, -4, 1, 20}// 386	387	388	
			, {1197, -6, 3, 20}, {4574, -4, 8, 0}, {2147, -5, 5, 0}// 389	390	391	
			, {1195, -5, 1, 20}, {1194, 3, 1, 20}, {12791, -5, 1, 1}// 392	393	395	
			, {8522, 3, 3, 16}, {1198, -4, 5, 20}, {2148, -7, 4, 9}// 396	397	398	
			, {1199, -2, 3, 20}, {145, 2, 1, 20}, {3307, 2, 3, 0}// 399	400	401	
			, {1195, -3, 1, 20}, {1197, -6, 4, 20}, {8522, -5, 4, 50}// 402	403	404	
			, {8524, -1, 3, 44}, {1201, -2, 5, 20}, {150, -2, 2, 20}// 405	406	407	
			, {1445, 4, 3, 19}, {8524, -3, 1, 50}, {1195, -4, 4, 20}// 408	409	410	
			, {1195, -5, 4, 20}, {1199, -2, 4, 20}, {4573, -5, 8, 0}// 411	412	413	
			, {3310, 1, 3, 0}, {1195, -5, 3, 20}, {144, 6, 2, 20}// 414	416	417	
			, {1445, -4, 1, 53}, {8524, -3, 2, 50}, {8524, -3, 3, 50}// 418	419	420	
			, {145, -7, 1, 20}, {8522, -6, 1, 47}, {8522, -6, 5, 47}// 421	422	423	
			, {1445, -4, 2, 53}, {8524, -1, 5, 44}, {2182, 2, 4, 0}// 424	425	426	
			, {2177, 3, 5, 0}, {4572, -3, 8, 0}, {10629, 5, 4, 0}// 427	428	429	
			, {2918, -5, 9, 0}, {2451, -3, 8, 6}, {147, -7, 5, 0}// 430	431	432	
			, {1852, 6, 4, 0}, {3249, 3, 5, 0}, {7729, -6, 2, 1}// 433	434	435	
			, {6554, -6, 3, 1}, {6542, -6, 4, 1}, {2179, 6, 5, 0}// 436	437	438	
			, {12791, -2, 5, 1}, {12791, -2, 4, 1}, {10629, 3, 4, 0}// 439	440	441	
			, {1202, -1, 2, 0}, {12791, -3, 5, 1}, {10629, 5, 3, 0}// 442	443	444	
			, {1198, 5, 2, 0}, {10629, 4, 4, 0}, {1198, 0, 2, 0}// 446	447	448	
			, {12791, -4, 5, 1}, {1197, -1, 1, 0}, {3310, -6, 6, 0}// 449	450	451	
			, {3310, -7, 3, 0}, {12791, -4, 4, 1}, {12791, -6, 5, 1}// 452	453	454	
			, {12791, -3, 1, 1}, {12791, -4, 1, 1}, {12791, -5, 3, 1}// 456	457	460	
			, {1193, 5, 1, 0}, {12791, -3, 2, 1}, {3250, 5, 5, 0}// 461	462	463	
			, {11540, 6, 1, 21}, {10629, 4, 3, 0}, {10629, 3, 3, 0}// 464	466	467	
			, {1193, 4, 1, 0}, {3307, 2, 3, 20}, {12791, -4, 2, 1}// 468	469	470	
			, {1193, 3, 1, 0}, {12791, -6, 4, 1}, {7697, 6, 3, 0}// 471	472	474	
			, {1198, 2, 2, 0}, {1193, 2, 1, 0}, {8522, 3, 3, 46}// 475	476	477	
			, {8522, 3, 2, 46}, {8522, 3, 1, 46}, {2186, -1, 2, 20}// 478	479	480	
			, {12791, -6, 1, 1}, {2186, 1, 2, 20}, {12791, -3, 4, 1}// 481	482	483	
			, {12791, -2, 2, 1}, {12791, -5, 2, 1}, {2186, 0, 2, 20}// 484	485	486	
			, {12791, -2, 3, 1}, {1198, 4, 2, 0}, {1198, 3, 2, 0}// 487	488	489	
			, {12791, -3, 3, 1}, {3310, -7, 1, 0}, {11542, 3, 2, 0}// 490	491	492	
			, {11575, 4, 2, 0}, {1199, 6, 1, 0}, {1198, 1, 2, 0}// 493	494	495	
			, {1199, 6, 1, 20}, {8630, 3, 2, 43}, {8522, 4, 1, 49}// 496	497	498	
			, {8522, 4, 3, 49}, {12791, -2, 1, 1}, {146, -1, 2, 0}// 499	500	501	
			, {4016, -5, 4, 3}, {1194, 4, 1, 20}, {2149, -7, 1, 0}// 503	504	505	
			, {2149, -7, 3, 0}, {2149, -7, 3, 9}, {12791, -4, 3, 1}// 506	507	508	
			, {2149, -6, 5, 9}, {2149, -6, 5, 0}, {3245, 6, 5, 0}// 509	510	511	
			, {2149, -4, 5, 9}, {2149, -4, 5, 0}, {2214, -1, 3, 0}// 512	513	514	
			, {1993, 5, 1, 0}, {8522, 4, 2, 49}, {8630, -5, 5, 43}// 515	516	517	
			, {8630, -4, 5, 43}, {8524, -2, 5, 47}, {8524, -2, 4, 47}// 518	519	520	
			, {8524, -2, 3, 47}, {8524, -2, 2, 47}, {8524, -2, 1, 47}// 521	522	523	
			, {8524, -2, 6, 47}, {147, -2, 4, 20}, {8522, -7, 5, 43}// 524	525	526	
			, {8522, -7, 4, 43}, {8522, -7, 3, 43}, {8522, -7, 2, 43}// 527	528	529	
			, {8522, -7, 1, 43}, {8522, -7, 6, 43}, {8630, 5, 2, 43}// 530	531	532	
			, {8630, 4, 2, 43}, {146, 3, 2, 20}, {144, 6, 2, 0}// 533	535	536	
			, {1202, -1, 2, 20}, {8522, -6, 6, 47}, {8524, -3, 5, 50}// 537	538	539	
			, {1201, 6, 2, 20}, {146, -6, 5, 20}, {8630, -6, 5, 43}// 540	541	544	
			, {1198, 1, 2, 20}, {1445, -4, 6, 53}, {8524, -3, 6, 50}// 546	547	548	
			, {146, -3, 5, 20}, {8522, -5, 3, 50}, {1198, 2, 2, 20}// 549	550	551	
			, {145, -7, 4, 20}, {1198, 5, 2, 20}, {145, -7, 3, 20}// 552	553	554	
			, {145, -7, 2, 20}, {8524, -3, 4, 50}, {8524, 6, 1, 49}// 555	556	557	
			, {12791, -6, 2, 1}, {1198, 4, 2, 20}, {1197, -1, 1, 20}// 558	559	560	
			, {1445, -4, 5, 53}, {3254, 2, 3, 0}, {3310, -4, 6, 0}// 561	562	563	
			, {8522, -6, 3, 47}, {1202, -6, 5, 20}, {2182, 2, 3, 0}// 564	565	566	
			, {6019, -2, 5, 1}, {6019, -2, 3, 1}, {6019, -2, 4, 2}// 567	568	569	
			, {12788, 7, -3, 1}, {8524, 10, -6, 26}, {8524, 7, -4, 46}// 570	571	572	
			, {1446, 9, -2, 26}, {8524, 7, -7, 46}, {2321, 9, -2, 0}// 573	574	575	
			, {1446, 9, -5, 26}, {2186, 8, -7, 0}, {8524, 7, -2, 46}// 576	577	578	
			, {12788, 8, -5, 1}, {8524, 7, 0, 46}, {3900, 8, -4, 1}// 579	580	581	
			, {12788, 8, -6, 1}, {8524, 7, -6, 46}, {2187, 10, -3, 0}// 582	583	584	
			, {2187, 10, -4, 0}, {2187, 10, -5, 0}, {2187, 10, -6, 0}// 585	586	587	
			, {8524, 7, -5, 46}, {9, 7, -7, 0}, {12788, 7, -5, 1}// 588	589	590	
			, {8524, 7, -1, 46}, {3899, 8, -3, 1}, {8524, 10, -2, 26}// 591	592	593	
			, {1446, 8, -6, 23}, {8524, 7, -3, 46}, {2186, 10, -7, 0}// 594	595	596	
			, {8524, 7, -8, 46}, {12788, 7, -4, 1}, {7679, 8, -2, 0}// 597	598	599	
			, {1446, 9, -3, 26}, {1446, 8, -4, 23}, {7840, 11, -2, 2}// 600	601	602	
			, {4150, 9, -3, 1}, {4109, 7, -4, 1}, {2183, 8, 0, 19}// 603	604	605	
			, {1848, 7, 0, 15}, {7680, 9, -2, 0}, {2322, 9, -1, 0}// 606	607	608	
			, {147, 7, 0, 0}, {7869, 11, -3, 0}, {3707, 7, -1, 0}// 609	610	611	
			, {12788, 9, -4, 1}, {12788, 9, -3, 1}, {12788, 9, -5, 1}// 612	613	614	
			, {12788, 9, -6, 1}, {3392, 7, -2, 0}, {12788, 8, -3, 1}// 615	616	617	
			, {12788, 8, -4, 1}, {12788, 10, -5, 1}, {12788, 10, -6, 1}// 618	619	620	
			, {12788, 10, -3, 1}, {12788, 10, -4, 1}, {3893, 9, -5, 1}// 621	622	623	
			, {8524, 11, -4, 23}, {8524, 11, -2, 23}, {8524, 11, -3, 23}// 624	625	626	
			, {8524, 10, -3, 26}, {8524, 11, -5, 23}, {8524, 10, -4, 26}// 627	628	629	
			, {8524, 10, -5, 26}, {1446, 8, -3, 23}, {1446, 8, -2, 23}// 630	631	632	
			, {3895, 9, -6, 1}, {2176, 7, -1, 19}, {12788, 7, -6, 1}// 633	634	635	
			, {1446, 9, -4, 26}, {9, 7, -3, 0}, {2186, 9, -7, 0}// 636	637	638	
			, {1446, 8, -5, 23}, {8524, 11, -6, 23}, {9, 10, -3, 0}// 639	640	641	
			, {9, 10, -7, 0}, {7869, 11, -4, 0}, {1446, 9, -6, 26}// 642	643	644	
			, {2881, 7, -6, 1}, {2882, 7, -5, 1}, {6020, 8, -2, 1}// 645	646	647	
			, {6020, 9, -2, 2}, {6020, 10, -2, 1}, {8524, 7, 2, 46}// 648	649	650	
			, {1974, 7, 2, 5}, {2180, 8, 3, 4}, {8524, 7, 1, 46}// 651	652	653	
			, {1849, 7, 1, 15}, {8524, 7, 3, 46}, {1974, 7, 3, 0}// 654	655	656	
			, {3905, 8, 1, 10}, {1974, 7, 1, 10}, {2180, 8, 1, 14}// 657	658	659	
			, {2180, 8, 2, 9}, {1849, 7, 3, 5}, {7138, 8, 2, 0}// 660	661	662	
			, {3248, 7, 5, 0}, {1849, 7, 2, 10}, {7134, 8, 3, 2}// 663	664	665	
			, {1848, 7, 4, 0}, {2177, 7, 5, 5}, {4106, 8, 1, 0}// 666	667	668	
			, {2183, 8, 4, 4}// 669	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new loghouseAddonDeed();
			}
		}

		[ Constructable ]
		public loghouseAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 153, 6, -6, 20, 0, 1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 153, 2, 0, 20, 0, 1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 152, -5, -1, 20, 0, 0, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 153, 2, -1, 20, 0, 1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 152, 4, -9, 20, 0, 0, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 153, 6, -3, 20, 0, 1, "", 1);// 228
			AddComplexComponent( (BaseAddon) this, 152, 1, -9, 20, 0, 0, "", 1);// 266
			AddComplexComponent( (BaseAddon) this, 152, -4, -1, 20, 0, 0, "", 1);// 312
			AddComplexComponent( (BaseAddon) this, 152, 5, 2, 20, 0, 1, "", 1);// 338
			AddComplexComponent( (BaseAddon) this, 152, 4, 2, 20, 0, 1, "", 1);// 340
			AddComplexComponent( (BaseAddon) this, 1194, 0, 1, 20, 0, -1, "flowers", 1);// 394
			AddComplexComponent( (BaseAddon) this, 152, 1, 2, 0, 0, 1, "", 1);// 415
			AddComplexComponent( (BaseAddon) this, 6094, -1, 6, 17, 39, -1, "flowers", 1);// 445
			AddComplexComponent( (BaseAddon) this, 6094, -2, 6, 9, 39, -1, "flowers", 1);// 455
			AddComplexComponent( (BaseAddon) this, 6094, 2, 3, 40, 39, -1, "flowers", 1);// 458
			AddComplexComponent( (BaseAddon) this, 6094, -4, 6, 13, 39, -1, "flowers", 1);// 459
			AddComplexComponent( (BaseAddon) this, 6094, 2, 3, 17, 39, -1, "flowers", 1);// 465
			AddComplexComponent( (BaseAddon) this, 6094, 2, 3, 26, 39, -1, "flowers", 1);// 473
			AddComplexComponent( (BaseAddon) this, 152, 0, 2, 0, 0, 1, "", 1);// 502
			AddComplexComponent( (BaseAddon) this, 6094, 2, 3, 8, 39, -1, "flowers", 1);// 534
			AddComplexComponent( (BaseAddon) this, 152, -4, 5, 20, 0, 1, "", 1);// 542
			AddComplexComponent( (BaseAddon) this, 152, -5, 5, 20, 0, 1, "", 1);// 543
			AddComplexComponent( (BaseAddon) this, 153, -2, 1, 20, 0, 1, "", 1);// 545

		}

		public loghouseAddon( Serial serial ) : base( serial )
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

	public class loghouseAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new loghouseAddon();
			}
		}

		[Constructable]
		public loghouseAddonDeed()
		{
			Name = "loghouse";
		}

		public loghouseAddonDeed( Serial serial ) : base( serial )
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