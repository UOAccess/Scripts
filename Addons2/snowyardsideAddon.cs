
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
	public class snowyardsideAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6077, -10, -19, 0}, {6077, -10, -18, 0}, {6077, -10, -17, 0}// 1	2	3	
			, {6077, -10, -16, 0}, {6077, -10, -15, 0}, {6077, -10, -14, 0}// 4	5	6	
			, {6077, -10, -13, 0}, {6077, -10, -12, 0}, {6077, -10, -11, 0}// 7	8	9	
			, {6077, -10, -10, 0}, {6077, -10, -9, 0}, {6077, -10, -8, 0}// 10	11	12	
			, {6077, -10, -7, 0}, {6077, -9, -19, 0}, {6077, -9, -18, 0}// 13	14	15	
			, {6077, -9, -17, 0}, {6077, -9, -16, 0}, {6077, -9, -15, 0}// 16	17	18	
			, {6077, -9, -14, 0}, {6077, -9, -13, 0}, {6077, -9, -12, 0}// 19	20	21	
			, {6077, -9, -11, 0}, {6077, -9, -10, 0}, {6077, -9, -9, 0}// 22	23	24	
			, {6077, -9, -8, 0}, {6077, -9, -7, 0}, {6077, -8, -19, 0}// 25	26	27	
			, {6077, -8, -18, 0}, {6077, -8, -17, 0}, {6077, -8, -16, 0}// 28	29	30	
			, {6077, -8, -15, 0}, {6077, -8, -14, 0}, {6077, -8, -13, 0}// 31	32	33	
			, {6077, -8, -12, 0}, {6077, -8, -11, 0}, {6077, -8, -10, 0}// 34	35	36	
			, {6077, -8, -9, 0}, {6077, -8, -8, 0}, {6077, -8, -7, 0}// 37	38	39	
			, {6077, -7, -19, 0}, {6077, -7, -18, 0}, {6077, -7, -17, 0}// 40	41	42	
			, {6077, -7, -16, 0}, {6077, -7, -15, 0}, {6077, -7, -14, 0}// 43	44	45	
			, {6077, -7, -13, 0}, {6077, -7, -12, 0}, {6077, -7, -11, 0}// 46	47	48	
			, {6077, -7, -10, 0}, {6077, -7, -9, 0}, {6077, -7, -8, 0}// 49	50	51	
			, {6077, -7, -7, 0}, {6077, -6, -19, 0}, {6077, -6, -18, 0}// 52	53	54	
			, {6077, -6, -17, 0}, {6077, -6, -16, 0}, {6077, -6, -15, 0}// 55	56	57	
			, {6077, -6, -14, 0}, {6077, -6, -13, 0}, {6077, -6, -12, 0}// 58	59	60	
			, {6077, -6, -11, 0}, {6077, -6, -10, 0}, {6077, -6, -9, 0}// 61	62	63	
			, {6077, -6, -8, 0}, {6077, -6, -7, 0}, {6077, -5, -19, 0}// 64	65	66	
			, {6077, -5, -18, 0}, {6077, -5, -17, 0}, {6077, -5, -16, 0}// 67	68	69	
			, {6077, -5, -15, 0}, {6077, -5, -14, 0}, {6077, -5, -13, 0}// 70	71	72	
			, {6077, -5, -12, 0}, {6077, -5, -11, 0}, {6077, -5, -10, 0}// 73	74	75	
			, {6077, -5, -9, 0}, {6077, -5, -8, 0}, {6077, -5, -7, 0}// 76	77	78	
			, {6077, -10, -6, 0}, {6077, -10, -5, 0}, {6077, -10, -4, 0}// 79	80	81	
			, {6077, -10, -3, 0}, {6077, -10, -2, 0}, {6077, -10, -1, 0}// 82	83	84	
			, {6077, -10, 0, 0}, {6077, -10, 1, 0}, {6077, -10, 2, 0}// 85	86	87	
			, {6077, -10, 3, 0}, {6077, -10, 4, 0}, {6077, -10, 5, 0}// 88	89	90	
			, {6077, -10, 6, 0}, {6077, -10, 7, 0}, {6077, -10, 8, 0}// 91	92	93	
			, {6077, -10, 9, 0}, {6077, -9, -6, 0}, {6077, -9, -5, 0}// 94	95	96	
			, {6077, -9, -4, 0}, {6077, -9, -3, 0}, {6077, -9, -2, 0}// 97	98	99	
			, {6077, -9, -1, 0}, {6077, -9, 0, 0}, {6077, -9, 1, 0}// 100	101	102	
			, {6077, -9, 2, 0}, {6077, -9, 3, 0}, {6077, -9, 4, 0}// 103	104	105	
			, {6077, -9, 5, 0}, {6077, -9, 6, 0}, {6077, -9, 7, 0}// 106	107	108	
			, {6077, -9, 8, 0}, {6077, -9, 9, 0}, {6077, -8, -6, 0}// 109	110	111	
			, {6077, -8, -5, 0}, {6077, -8, -4, 0}, {6077, -8, -3, 0}// 112	113	114	
			, {6077, -8, -2, 0}, {6077, -8, -1, 0}, {6077, -8, 0, 0}// 115	116	117	
			, {6077, -8, 1, 0}, {6077, -8, 2, 0}, {6077, -8, 3, 0}// 118	119	120	
			, {6077, -8, 4, 0}, {6077, -8, 5, 0}, {6077, -8, 6, 0}// 121	122	123	
			, {6077, -8, 7, 0}, {6077, -8, 8, 0}, {6077, -8, 9, 0}// 124	125	126	
			, {6077, -7, -6, 0}, {6077, -7, -5, 0}, {6077, -7, -4, 0}// 127	128	129	
			, {6077, -7, -3, 0}, {6077, -7, -2, 0}, {6077, -7, -1, 0}// 130	131	132	
			, {6077, -7, 0, 0}, {6077, -7, 1, 0}, {6077, -7, 2, 0}// 133	134	135	
			, {6077, -7, 3, 0}, {6077, -7, 4, 0}, {6077, -7, 5, 0}// 136	137	138	
			, {6077, -7, 6, 0}, {6077, -7, 7, 0}, {6077, -7, 8, 0}// 139	140	141	
			, {6077, -7, 9, 0}, {6077, -6, -6, 0}, {6077, -6, -5, 0}// 142	143	144	
			, {6077, -6, -4, 0}, {6077, -6, -3, 0}, {6077, -6, -2, 0}// 145	146	147	
			, {6077, -6, -1, 0}, {6077, -6, 0, 0}, {6077, -6, 1, 0}// 148	149	150	
			, {6077, -6, 2, 0}, {6077, -6, 3, 0}, {6077, -6, 4, 0}// 151	152	153	
			, {6077, -6, 5, 0}, {6077, -6, 6, 0}, {6077, -6, 7, 0}// 154	155	156	
			, {6077, -6, 8, 0}, {6077, -6, 9, 0}, {6077, -5, -6, 0}// 157	158	159	
			, {6077, -5, -5, 0}, {6077, -5, -4, 0}, {6077, -5, -3, 0}// 160	161	162	
			, {6077, -5, -2, 0}, {6077, -5, -1, 0}, {6077, -5, 0, 0}// 163	164	165	
			, {6077, -5, 1, 0}, {6077, -5, 2, 0}, {6077, -5, 3, 0}// 166	167	168	
			, {6077, -5, 4, 0}, {6077, -5, 5, 0}, {6077, -5, 6, 0}// 169	170	171	
			, {6077, -5, 7, 0}, {6077, -5, 8, 0}, {6077, -5, 9, 0}// 172	173	174	
			, {6077, -10, 10, 0}, {6077, -10, 11, 0}, {6077, -10, 12, 0}// 175	176	177	
			, {6077, -10, 13, 0}, {6077, -10, 14, 0}, {6077, -10, 15, 0}// 178	179	180	
			, {6077, -10, 16, 0}, {6077, -10, 17, 0}, {6077, -10, 18, 0}// 181	182	183	
			, {6077, -10, 19, 0}, {6077, -9, 10, 0}, {6077, -9, 11, 0}// 184	185	186	
			, {6077, -9, 12, 0}, {6077, -9, 13, 0}, {6077, -9, 14, 0}// 187	188	189	
			, {6077, -9, 15, 0}, {6077, -9, 16, 0}, {6077, -9, 17, 0}// 190	191	192	
			, {6077, -9, 18, 0}, {6077, -9, 19, 0}, {6077, -8, 10, 0}// 193	194	195	
			, {6077, -8, 11, 0}, {6077, -8, 12, 0}, {6077, -8, 13, 0}// 196	197	198	
			, {6077, -8, 14, 0}, {6077, -8, 15, 0}, {6077, -8, 16, 0}// 199	200	201	
			, {6077, -8, 17, 0}, {6077, -8, 18, 0}, {6077, -8, 19, 0}// 202	203	204	
			, {6077, -7, 10, 0}, {6077, -7, 11, 0}, {6077, -7, 12, 0}// 205	206	207	
			, {6077, -7, 13, 0}, {6077, -7, 14, 0}, {6077, -7, 15, 0}// 208	209	210	
			, {6077, -7, 16, 0}, {6077, -7, 17, 0}, {6077, -7, 18, 0}// 211	212	213	
			, {6077, -7, 19, 0}, {6077, -6, 10, 0}, {6077, -6, 11, 0}// 214	215	216	
			, {6077, -6, 12, 0}, {6077, -6, 13, 0}, {6077, -6, 14, 0}// 217	218	219	
			, {6077, -6, 15, 0}, {6077, -6, 16, 0}, {6077, -6, 17, 0}// 220	221	222	
			, {6077, -6, 18, 0}, {6077, -6, 19, 0}, {6077, -5, 10, 0}// 223	224	225	
			, {6077, -5, 11, 0}, {6077, -5, 12, 0}, {6077, -5, 13, 0}// 226	227	228	
			, {6077, -5, 14, 0}, {6077, -5, 15, 0}, {6077, -5, 16, 0}// 229	230	231	
			, {6077, -5, 17, 0}, {6077, -5, 18, 0}, {6077, -5, 19, 0}// 232	233	234	
			, {6077, -4, -19, 0}, {6077, -4, -18, 0}, {6077, -4, -17, 0}// 235	236	237	
			, {6077, -4, -16, 0}, {6077, -4, -15, 0}, {6077, -4, -14, 0}// 238	239	240	
			, {6077, -4, -13, 0}, {6077, -4, -12, 0}, {6077, -4, -11, 0}// 241	242	243	
			, {6077, -4, -10, 0}, {6077, -4, -9, 0}, {6077, -4, -8, 0}// 244	245	246	
			, {6077, -4, -7, 0}, {6077, -3, -19, 0}, {6077, -3, -18, 0}// 247	248	249	
			, {6077, -3, -17, 0}, {6077, -3, -16, 0}, {6077, -3, -15, 0}// 250	251	252	
			, {6077, -3, -14, 0}, {6077, -3, -13, 0}, {6077, -3, -12, 0}// 253	254	255	
			, {6077, -3, -11, 0}, {6077, -3, -10, 0}, {6077, -3, -9, 0}// 256	257	258	
			, {6077, -3, -8, 0}, {6077, -3, -7, 0}, {6077, -2, -19, 0}// 259	260	261	
			, {6077, -2, -18, 0}, {6077, -2, -17, 0}, {6077, -2, -16, 0}// 262	263	264	
			, {6077, -2, -15, 0}, {6077, -2, -14, 0}, {6077, -2, -13, 0}// 265	266	267	
			, {6077, -2, -12, 0}, {6077, -2, -11, 0}, {6077, -2, -10, 0}// 268	269	270	
			, {6077, -2, -9, 0}, {6077, -2, -8, 0}, {6077, -2, -7, 0}// 271	272	273	
			, {6077, -1, -19, 0}, {6077, -1, -18, 0}, {6077, -1, -17, 0}// 274	275	276	
			, {6077, -1, -16, 0}, {6077, -1, -15, 0}, {6077, -1, -14, 0}// 277	278	279	
			, {6077, -1, -13, 0}, {6077, -1, -12, 0}, {6077, -1, -11, 0}// 280	281	282	
			, {6077, -1, -10, 0}, {6077, -1, -9, 0}, {6077, -1, -8, 0}// 283	284	285	
			, {6077, -1, -7, 0}, {6077, 0, -19, 0}, {6077, 0, -18, 0}// 286	287	288	
			, {6077, 0, -17, 0}, {6077, 0, -16, 0}, {6077, 0, -15, 0}// 289	290	291	
			, {6077, 0, -14, 0}, {6077, 0, -13, 0}, {6077, 0, -12, 0}// 292	293	294	
			, {6077, 0, -11, 0}, {6077, 0, -10, 0}, {6077, 0, -9, 0}// 295	296	297	
			, {6077, 0, -8, 0}, {6077, 0, -7, 0}, {6077, 1, -19, 0}// 298	299	300	
			, {6077, 1, -18, 0}, {6077, 1, -17, 0}, {6077, 1, -16, 0}// 301	302	303	
			, {6077, 1, -15, 0}, {6077, 1, -14, 0}, {6077, 1, -13, 0}// 304	305	306	
			, {6077, 1, -12, 0}, {6077, 1, -11, 0}, {6077, 1, -10, 0}// 307	308	309	
			, {6077, 1, -9, 0}, {6077, 1, -8, 0}, {6077, 1, -7, 0}// 310	311	312	
			, {6077, 2, -19, 0}, {6077, 2, -18, 0}, {6077, 2, -17, 0}// 313	314	315	
			, {6077, 2, -16, 0}, {6077, 2, -15, 0}, {6077, 2, -14, 0}// 316	317	318	
			, {6077, 2, -13, 0}, {6077, 2, -12, 0}, {6077, 2, -11, 0}// 319	320	321	
			, {6077, 2, -10, 0}, {6077, 2, -9, 0}, {6077, 2, -8, 0}// 322	323	324	
			, {6077, 2, -7, 0}, {6077, 3, -19, 0}, {6077, 3, -18, 0}// 325	326	327	
			, {6077, 3, -17, 0}, {6077, 3, -16, 0}, {6077, 3, -15, 0}// 328	329	330	
			, {6077, 3, -14, 0}, {6077, 3, -13, 0}, {6077, 3, -12, 0}// 331	332	333	
			, {6077, 3, -11, 0}, {6077, 3, -10, 0}, {6077, 3, -9, 0}// 334	335	336	
			, {6077, 3, -8, 0}, {6077, 3, -7, 0}, {6077, 4, -19, 0}// 337	338	339	
			, {6077, 4, -18, 0}, {6077, 4, -17, 0}, {6077, 4, -16, 0}// 340	341	342	
			, {6077, 4, -15, 0}, {6077, 4, -14, 0}, {6077, 4, -13, 0}// 343	344	345	
			, {6077, 4, -12, 0}, {6077, 4, -11, 0}, {6077, 4, -10, 0}// 346	347	348	
			, {6077, 4, -9, 0}, {6077, 4, -8, 0}, {6077, 4, -7, 0}// 349	350	351	
			, {6077, 5, -19, 0}, {6077, 5, -18, 0}, {6077, 5, -17, 0}// 352	353	354	
			, {6077, 5, -16, 0}, {6077, 5, -15, 0}, {6077, 5, -14, 0}// 355	356	357	
			, {6077, 5, -13, 0}, {6077, 5, -12, 0}, {6077, 5, -11, 0}// 358	359	360	
			, {6077, 5, -10, 0}, {6077, 5, -9, 0}, {6077, 5, -8, 0}// 361	362	363	
			, {6077, 5, -7, 0}, {6077, 6, -19, 0}, {6077, 6, -18, 0}// 364	365	366	
			, {6077, 6, -17, 0}, {6077, 6, -16, 0}, {6077, 6, -15, 0}// 367	368	369	
			, {6077, 6, -14, 0}, {6077, 6, -13, 0}, {6077, 6, -12, 0}// 370	371	372	
			, {6077, 6, -11, 0}, {6077, 6, -10, 0}, {6077, 6, -9, 0}// 373	374	375	
			, {6077, 6, -8, 0}, {6077, 6, -7, 0}, {6077, 7, -19, 0}// 376	377	378	
			, {6077, 7, -18, 0}, {6077, 7, -17, 0}, {6077, 7, -16, 0}// 379	380	381	
			, {6077, 7, -15, 0}, {6077, 7, -14, 0}, {6077, 7, -13, 0}// 382	383	384	
			, {6077, 7, -12, 0}, {6077, 7, -11, 0}, {6077, 7, -10, 0}// 385	386	387	
			, {6077, 7, -9, 0}, {6077, 7, -8, 0}, {6077, 7, -7, 0}// 388	389	390	
			, {6077, 8, -19, 0}, {6077, 8, -18, 0}, {6077, 8, -17, 0}// 391	392	393	
			, {6077, 8, -16, 0}, {6077, 8, -15, 0}, {6077, 8, -14, 0}// 394	395	396	
			, {6077, 8, -13, 0}, {6077, 8, -12, 0}, {6077, 8, -11, 0}// 397	398	399	
			, {6077, 8, -10, 0}, {6077, 8, -9, 0}, {6077, 8, -8, 0}// 400	401	402	
			, {6077, 8, -7, 0}, {6077, 9, -19, 0}, {6077, 9, -18, 0}// 403	404	405	
			, {6077, 9, -17, 0}, {6077, 9, -16, 0}, {6077, 9, -15, 0}// 406	407	408	
			, {6077, 9, -14, 0}, {6077, 9, -13, 0}, {6077, 9, -12, 0}// 409	410	411	
			, {6077, 9, -11, 0}, {6077, 9, -10, 0}, {6077, 9, -9, 0}// 412	413	414	
			, {6077, 9, -8, 0}, {6077, 9, -7, 0}, {6077, 10, -19, 0}// 415	416	417	
			, {6077, 10, -18, 0}, {6077, 10, -17, 0}, {6077, 10, -16, 0}// 418	419	420	
			, {6077, 10, -15, 0}, {6077, 10, -14, 0}, {6077, 10, -13, 0}// 421	422	423	
			, {6077, 10, -12, 0}, {6077, 10, -11, 0}, {6077, 10, -10, 0}// 424	425	426	
			, {6077, 10, -9, 0}, {6077, 10, -8, 0}, {6077, 10, -7, 0}// 427	428	429	
			, {6077, -4, -6, 0}, {6077, -4, -5, 0}, {6077, -4, -4, 0}// 430	431	432	
			, {6077, -4, -3, 0}, {6077, -4, -2, 0}, {6077, -4, -1, 0}// 433	434	435	
			, {6077, -4, 0, 0}, {6077, -4, 1, 0}, {6077, -4, 2, 0}// 436	437	438	
			, {6077, -4, 3, 0}, {6077, -4, 4, 0}, {6077, -4, 5, 0}// 439	440	441	
			, {6077, -4, 6, 0}, {6077, -4, 7, 0}, {6077, -4, 8, 0}// 442	443	444	
			, {6077, -4, 9, 0}, {6077, -3, -6, 0}, {6077, -3, -5, 0}// 445	446	447	
			, {6077, -3, -4, 0}, {6077, -3, -3, 0}, {6077, -3, -2, 0}// 448	449	450	
			, {6077, -3, -1, 0}, {6077, -3, 0, 0}, {6077, -3, 1, 0}// 451	452	453	
			, {6077, -3, 2, 0}, {6077, -3, 3, 0}, {6077, -3, 4, 0}// 454	455	456	
			, {6077, -3, 5, 0}, {6077, -3, 6, 0}, {6077, -3, 7, 0}// 457	458	459	
			, {6077, -3, 8, 0}, {6077, -3, 9, 0}, {6077, -2, -6, 0}// 460	461	462	
			, {6077, -2, -5, 0}, {6077, -2, -4, 0}, {6077, -2, -3, 0}// 463	464	465	
			, {6077, -2, -2, 0}, {6077, -2, -1, 0}, {6077, -2, 0, 0}// 466	467	468	
			, {6077, -2, 1, 0}, {6077, -2, 2, 0}, {6077, -2, 3, 0}// 469	470	471	
			, {6077, -2, 4, 0}, {6077, -2, 5, 0}, {6077, -2, 6, 0}// 472	473	474	
			, {6077, -2, 7, 0}, {6077, -2, 8, 0}, {6077, -2, 9, 0}// 475	476	477	
			, {6077, -1, -6, 0}, {6077, -1, -5, 0}, {6077, -1, -4, 0}// 478	479	480	
			, {6077, -1, -3, 0}, {6077, -1, -2, 0}, {6077, -1, -1, 0}// 481	482	483	
			, {6077, -1, 0, 0}, {6077, -1, 1, 0}, {6077, -1, 2, 0}// 484	485	486	
			, {6077, -1, 3, 0}, {6077, -1, 4, 0}, {6077, -1, 5, 0}// 487	488	489	
			, {6077, -1, 6, 0}, {6077, -1, 7, 0}, {6077, -1, 8, 0}// 490	491	492	
			, {6077, -1, 9, 0}, {6077, 0, -6, 0}, {6077, 0, -5, 0}// 493	494	495	
			, {6077, 0, -4, 0}, {6077, 0, -3, 0}, {6077, 0, -2, 0}// 496	497	498	
			, {6077, 0, -1, 0}, {6077, 0, 0, 0}, {6077, 0, 1, 0}// 499	500	501	
			, {6077, 0, 2, 0}, {6077, 0, 3, 0}, {6077, 0, 4, 0}// 502	503	504	
			, {6077, 0, 5, 0}, {6077, 0, 6, 0}, {6077, 0, 7, 0}// 505	506	507	
			, {6077, 0, 8, 0}, {6077, 0, 9, 0}, {6077, 1, -6, 0}// 508	509	510	
			, {6077, 1, -5, 0}, {6077, 1, -4, 0}, {6077, 1, -3, 0}// 511	512	513	
			, {6077, 1, -2, 0}, {6077, 1, -1, 0}, {6077, 1, 0, 0}// 514	515	516	
			, {6077, 1, 1, 0}, {6077, 1, 2, 0}, {6077, 1, 3, 0}// 517	518	519	
			, {6077, 1, 4, 0}, {6077, 1, 5, 0}, {6077, 1, 6, 0}// 520	521	522	
			, {6077, 1, 7, 0}, {6077, 1, 8, 0}, {6077, 1, 9, 0}// 523	524	525	
			, {6077, 2, -6, 0}, {6077, 2, -5, 0}, {6077, 2, -4, 0}// 526	527	528	
			, {6077, 2, -3, 0}, {6077, 2, -2, 0}, {6077, 2, -1, 0}// 529	530	531	
			, {6077, 2, 0, 0}, {6077, 2, 1, 0}, {6077, 2, 2, 0}// 532	533	534	
			, {6077, 2, 3, 0}, {6077, 2, 4, 0}, {6077, 2, 5, 0}// 535	536	537	
			, {6077, 2, 6, 0}, {6077, 2, 7, 0}, {6077, 2, 8, 0}// 538	539	540	
			, {6077, 2, 9, 0}, {6077, 3, -6, 0}, {6077, 3, -5, 0}// 541	542	543	
			, {6077, 3, -4, 0}, {6077, 3, -3, 0}, {6077, 3, -2, 0}// 544	545	546	
			, {6077, 3, -1, 0}, {6077, 3, 0, 0}, {6077, 3, 1, 0}// 547	548	549	
			, {6077, 3, 2, 0}, {6077, 3, 3, 0}, {6077, 3, 4, 0}// 550	551	552	
			, {6077, 3, 5, 0}, {6077, 3, 6, 0}, {6077, 3, 7, 0}// 553	554	555	
			, {6077, 3, 8, 0}, {6077, 3, 9, 0}, {6077, 4, -6, 0}// 556	557	558	
			, {6077, 4, -5, 0}, {6077, 4, -4, 0}, {6077, 4, -3, 0}// 559	560	561	
			, {6077, 4, -2, 0}, {6077, 4, -1, 0}, {6077, 4, 0, 0}// 562	563	564	
			, {6077, 4, 1, 0}, {6077, 4, 2, 0}, {6077, 4, 3, 0}// 565	566	567	
			, {6077, 4, 4, 0}, {6077, 4, 5, 0}, {6077, 4, 6, 0}// 568	569	570	
			, {6077, 4, 7, 0}, {6077, 4, 8, 0}, {6077, 4, 9, 0}// 571	572	573	
			, {6077, 5, -6, 0}, {6077, 5, -5, 0}, {6077, 5, -4, 0}// 574	575	576	
			, {6077, 5, -3, 0}, {6077, 5, -2, 0}, {6077, 5, -1, 0}// 577	578	579	
			, {6077, 5, 0, 0}, {6077, 5, 1, 0}, {6077, 5, 2, 0}// 580	581	582	
			, {6077, 5, 3, 0}, {6077, 5, 4, 0}, {6077, 5, 5, 0}// 583	584	585	
			, {6077, 5, 6, 0}, {6077, 5, 7, 0}, {6077, 5, 8, 0}// 586	587	588	
			, {6077, 5, 9, 0}, {6077, 6, -6, 0}, {6077, 6, -5, 0}// 589	590	591	
			, {6077, 6, -4, 0}, {6077, 6, -3, 0}, {6077, 6, -2, 0}// 592	593	594	
			, {6077, 6, -1, 0}, {6077, 6, 0, 0}, {6077, 6, 1, 0}// 595	596	597	
			, {6077, 6, 2, 0}, {6077, 6, 3, 0}, {6077, 6, 4, 0}// 598	599	600	
			, {6077, 6, 5, 0}, {6077, 6, 6, 0}, {6077, 6, 7, 0}// 601	602	603	
			, {6077, 6, 8, 0}, {6077, 6, 9, 0}, {6077, 7, -6, 0}// 604	605	606	
			, {6077, 7, -5, 0}, {6077, 7, -4, 0}, {6077, 7, -3, 0}// 607	608	609	
			, {6077, 7, -2, 0}, {6077, 7, -1, 0}, {6077, 7, 0, 0}// 610	611	612	
			, {6077, 7, 1, 0}, {6077, 7, 2, 0}, {6077, 7, 3, 0}// 613	614	615	
			, {6077, 7, 4, 0}, {6077, 7, 5, 0}, {6077, 7, 6, 0}// 616	617	618	
			, {6077, 7, 7, 0}, {6077, 7, 8, 0}, {6077, 7, 9, 0}// 619	620	621	
			, {6077, 8, -6, 0}, {6077, 8, -5, 0}, {6077, 8, -4, 0}// 622	623	624	
			, {6077, 8, -3, 0}, {6077, 8, -2, 0}, {6077, 8, -1, 0}// 625	626	627	
			, {6077, 8, 0, 0}, {6077, 8, 1, 0}, {6077, 8, 2, 0}// 628	629	630	
			, {6077, 8, 3, 0}, {6077, 8, 4, 0}, {6077, 8, 5, 0}// 631	632	633	
			, {6077, 8, 6, 0}, {6077, 8, 7, 0}, {6077, 8, 8, 0}// 634	635	636	
			, {6077, 8, 9, 0}, {6077, 9, -6, 0}, {6077, 9, -5, 0}// 637	638	639	
			, {6077, 9, -4, 0}, {6077, 9, -3, 0}, {6077, 9, -2, 0}// 640	641	642	
			, {6077, 9, -1, 0}, {6077, 9, 0, 0}, {6077, 9, 1, 0}// 643	644	645	
			, {6077, 9, 2, 0}, {6077, 9, 3, 0}, {6077, 9, 4, 0}// 646	647	648	
			, {6077, 9, 5, 0}, {6077, 9, 6, 0}, {6077, 9, 7, 0}// 649	650	651	
			, {6077, 9, 8, 0}, {6077, 9, 9, 0}, {6077, 10, -6, 0}// 652	653	654	
			, {6077, 10, -5, 0}, {6077, 10, -4, 0}, {6077, 10, -3, 0}// 655	656	657	
			, {6077, 10, -2, 0}, {6077, 10, -1, 0}, {6077, 10, 0, 0}// 658	659	660	
			, {6077, 10, 1, 0}, {6077, 10, 2, 0}, {6077, 10, 3, 0}// 661	662	663	
			, {6077, 10, 4, 0}, {6077, 10, 5, 0}, {6077, 10, 6, 0}// 664	665	666	
			, {6077, 10, 7, 0}, {6077, 10, 8, 0}, {6077, 10, 9, 0}// 667	668	669	
			, {6077, -4, 10, 0}, {6077, -4, 11, 0}, {6077, -4, 12, 0}// 670	671	672	
			, {6077, -4, 13, 0}, {6077, -4, 14, 0}, {6077, -4, 15, 0}// 673	674	675	
			, {6077, -4, 16, 0}, {6077, -4, 17, 0}, {6077, -4, 18, 0}// 676	677	678	
			, {6077, -4, 19, 0}, {6077, -3, 10, 0}, {6077, -3, 11, 0}// 679	680	681	
			, {6077, -3, 12, 0}, {6077, -3, 13, 0}, {6077, -3, 14, 0}// 682	683	684	
			, {6077, -3, 15, 0}, {6077, -3, 16, 0}, {6077, -3, 17, 0}// 685	686	687	
			, {6077, -3, 18, 0}, {6077, -3, 19, 0}, {6077, -2, 10, 0}// 688	689	690	
			, {6077, -2, 11, 0}, {6077, -2, 12, 0}, {6077, -2, 13, 0}// 691	692	693	
			, {6077, -2, 14, 0}, {6077, -2, 15, 0}, {6077, -2, 16, 0}// 694	695	696	
			, {6077, -2, 17, 0}, {6077, -2, 18, 0}, {6077, -2, 19, 0}// 697	698	699	
			, {6077, -1, 10, 0}, {6077, -1, 11, 0}, {6077, -1, 12, 0}// 700	701	702	
			, {6077, -1, 13, 0}, {6077, -1, 14, 0}, {6077, -1, 15, 0}// 703	704	705	
			, {6077, -1, 16, 0}, {6077, -1, 17, 0}, {6077, -1, 18, 0}// 706	707	708	
			, {6077, -1, 19, 0}, {6077, 0, 10, 0}, {6077, 0, 11, 0}// 709	710	711	
			, {6077, 0, 12, 0}, {6077, 0, 13, 0}, {6077, 0, 14, 0}// 712	713	714	
			, {6077, 0, 15, 0}, {6077, 0, 16, 0}, {6077, 0, 17, 0}// 715	716	717	
			, {6077, 0, 18, 0}, {6077, 0, 19, 0}, {6077, 1, 10, 0}// 718	719	720	
			, {6077, 1, 11, 0}, {6077, 1, 12, 0}, {6077, 1, 13, 0}// 721	722	723	
			, {6077, 1, 14, 0}, {6077, 1, 15, 0}, {6077, 1, 16, 0}// 724	725	726	
			, {6077, 1, 17, 0}, {6077, 1, 18, 0}, {6077, 1, 19, 0}// 727	728	729	
			, {6077, 2, 10, 0}, {6077, 2, 11, 0}, {6077, 2, 12, 0}// 730	731	732	
			, {6077, 2, 13, 0}, {6077, 2, 14, 0}, {6077, 2, 15, 0}// 733	734	735	
			, {6077, 2, 16, 0}, {6077, 2, 17, 0}, {6077, 2, 18, 0}// 736	737	738	
			, {6077, 2, 19, 0}, {6077, 3, 10, 0}, {6077, 3, 11, 0}// 739	740	741	
			, {6077, 3, 12, 0}, {6077, 3, 13, 0}, {6077, 3, 14, 0}// 742	743	744	
			, {6077, 3, 15, 0}, {6077, 3, 16, 0}, {6077, 3, 17, 0}// 745	746	747	
			, {6077, 3, 18, 0}, {6077, 3, 19, 0}, {6077, 4, 10, 0}// 748	749	750	
			, {6077, 4, 11, 0}, {6077, 4, 12, 0}, {6077, 4, 13, 0}// 751	752	753	
			, {6077, 4, 14, 0}, {6077, 4, 15, 0}, {6077, 4, 16, 0}// 754	755	756	
			, {6077, 4, 17, 0}, {6077, 4, 18, 0}, {6077, 4, 19, 0}// 757	758	759	
			, {6077, 5, 10, 0}, {6077, 5, 11, 0}, {6077, 5, 12, 0}// 760	761	762	
			, {6077, 5, 13, 0}, {6077, 5, 14, 0}, {6077, 5, 15, 0}// 763	764	765	
			, {6077, 5, 16, 0}, {6077, 5, 17, 0}, {6077, 5, 18, 0}// 766	767	768	
			, {6077, 5, 19, 0}, {6077, 6, 10, 0}, {6077, 6, 11, 0}// 769	770	771	
			, {6077, 6, 12, 0}, {6077, 6, 13, 0}, {6077, 6, 14, 0}// 772	773	774	
			, {6077, 6, 15, 0}, {6077, 6, 16, 0}, {6077, 6, 17, 0}// 775	776	777	
			, {6077, 6, 18, 0}, {6077, 6, 19, 0}, {6077, 7, 10, 0}// 778	779	780	
			, {6077, 7, 11, 0}, {6077, 7, 12, 0}, {6077, 7, 13, 0}// 781	782	783	
			, {6077, 7, 14, 0}, {6077, 7, 15, 0}, {6077, 7, 16, 0}// 784	785	786	
			, {6077, 7, 17, 0}, {6077, 7, 18, 0}, {6077, 7, 19, 0}// 787	788	789	
			, {6077, 8, 10, 0}, {6077, 8, 11, 0}, {6077, 8, 12, 0}// 790	791	792	
			, {6077, 8, 13, 0}, {6077, 8, 14, 0}, {6077, 8, 15, 0}// 793	794	795	
			, {6077, 8, 16, 0}, {6077, 8, 17, 0}, {6077, 8, 18, 0}// 796	797	798	
			, {6077, 8, 19, 0}, {6077, 9, 10, 0}, {6077, 9, 11, 0}// 799	800	801	
			, {6077, 9, 12, 0}, {6077, 9, 13, 0}, {6077, 9, 14, 0}// 802	803	804	
			, {6077, 9, 15, 0}, {6077, 9, 16, 0}, {6077, 9, 17, 0}// 805	806	807	
			, {6077, 9, 18, 0}, {6077, 9, 19, 0}, {6077, 10, 10, 0}// 808	809	810	
			, {6077, 10, 11, 0}, {6077, 10, 12, 0}, {6077, 10, 13, 0}// 811	812	813	
			, {6077, 10, 14, 0}, {6077, 10, 15, 0}, {6077, 10, 16, 0}// 814	815	816	
			, {6077, 10, 17, 0}, {6077, 10, 18, 0}, {6077, 10, 19, 0}// 817	818	819	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new snowyardsideAddonDeed();
			}
		}

		[ Constructable ]
		public snowyardsideAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public snowyardsideAddon( Serial serial ) : base( serial )
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

	public class snowyardsideAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new snowyardsideAddon();
			}
		}

		[Constructable]
		public snowyardsideAddonDeed()
		{
			Name = "snowyardside";
		}

		public snowyardsideAddonDeed( Serial serial ) : base( serial )
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