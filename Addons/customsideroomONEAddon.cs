
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
	public class customsideroomONEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1955, -4, -6, 0}, {1955, -4, -5, 0}, {1955, -4, -4, 0}// 1	2	3	
			, {1955, -4, -3, 0}, {1955, -4, -2, 0}, {1955, -4, -1, 0}// 4	5	6	
			, {1955, -4, 0, 0}, {1955, -4, 1, 0}, {1955, -4, 2, 0}// 7	8	9	
			, {1955, -4, 3, 0}, {1955, -3, -6, 0}, {1955, -3, -5, 0}// 10	11	12	
			, {1955, -3, -4, 0}, {1955, -3, -3, 0}, {1955, -3, -2, 0}// 13	14	15	
			, {1955, -3, -1, 0}, {1955, -3, 0, 0}, {1955, -3, 1, 0}// 16	17	18	
			, {1955, -3, 2, 0}, {1955, -3, 3, 0}, {1955, -2, -6, 0}// 19	20	21	
			, {1955, -2, -5, 0}, {1955, -2, -4, 0}, {1955, -2, -3, 0}// 22	23	24	
			, {1955, -2, -2, 0}, {1955, -2, -1, 0}, {1955, -2, 0, 0}// 25	26	27	
			, {1955, -2, 1, 0}, {1955, -2, 2, 0}, {1955, -2, 3, 0}// 28	29	30	
			, {1955, -1, -6, 0}, {1955, -1, -5, 0}, {1955, -1, -4, 0}// 31	32	33	
			, {1955, -1, -3, 0}, {1955, -1, -2, 0}, {1955, -1, -1, 0}// 34	35	36	
			, {1955, -1, 0, 0}, {1955, -1, 1, 0}, {1955, -1, 2, 0}// 37	38	39	
			, {1955, -1, 3, 0}, {1955, 0, -6, 0}, {1955, 0, -5, 0}// 40	41	42	
			, {1955, 0, -4, 0}, {1955, 0, -3, 0}, {1955, 0, -2, 0}// 43	44	45	
			, {1955, 0, -1, 0}, {1955, 0, 0, 0}, {1955, 0, 1, 0}// 46	47	48	
			, {1955, 0, 2, 0}, {1955, 0, 3, 0}, {1955, 1, -6, 0}// 49	50	51	
			, {1955, 1, -5, 0}, {1955, 1, -4, 0}, {1955, 1, -3, 0}// 52	53	54	
			, {1955, 1, -2, 0}, {1955, 1, -1, 0}, {1955, 1, 0, 0}// 55	56	57	
			, {1955, 1, 1, 0}, {1955, 1, 2, 0}, {1955, 1, 3, 0}// 58	59	60	
			, {1955, -4, -7, 0}, {1955, -3, -7, 0}, {1955, -2, -7, 0}// 61	62	63	
			, {1955, -1, -7, 0}, {1955, 0, -7, 0}, {1955, 1, -7, 0}// 64	65	66	
			, {1301, -4, -7, 5}, {1301, -4, -6, 5}, {1301, -4, -5, 5}// 67	68	69	
			, {1301, -4, -4, 5}, {1301, -4, -3, 5}, {1301, -4, -2, 5}// 70	71	72	
			, {1301, -4, -1, 5}, {1301, -4, 0, 5}, {1301, -4, 1, 5}// 73	74	75	
			, {1301, -4, 2, 5}, {1301, -4, 3, 5}, {1301, -3, -7, 5}// 76	77	78	
			, {1301, -3, -6, 5}, {1301, -3, -5, 5}, {1301, -3, -4, 5}// 79	80	81	
			, {1301, -3, -3, 5}, {1301, -3, -2, 5}, {1301, -3, -1, 5}// 82	83	84	
			, {1301, -3, 0, 5}, {1301, -3, 1, 5}, {1301, -3, 2, 5}// 85	86	87	
			, {1301, -3, 3, 5}, {1301, -2, -7, 5}, {1301, -2, -6, 5}// 88	89	90	
			, {1301, -2, -5, 5}, {1301, -2, -4, 5}, {1301, -2, -3, 5}// 91	92	93	
			, {1301, -2, -2, 5}, {1301, -2, -1, 5}, {1301, -2, 0, 5}// 94	95	96	
			, {1301, -2, 1, 5}, {1301, -2, 2, 5}, {1301, -2, 3, 5}// 97	98	99	
			, {1301, -1, -7, 5}, {1301, -1, -6, 5}, {1301, -1, -5, 5}// 100	101	102	
			, {1301, -1, -4, 5}, {1301, -1, -3, 5}, {1301, -1, -2, 5}// 103	104	105	
			, {1301, -1, -1, 5}, {1301, -1, 0, 5}, {1301, -1, 1, 5}// 106	107	108	
			, {1301, -1, 2, 5}, {1301, -1, 3, 5}, {1301, 0, -7, 5}// 109	110	111	
			, {1301, 0, -6, 5}, {1301, 0, -5, 5}, {1301, 0, -4, 5}// 112	113	114	
			, {1301, 0, -3, 5}, {1301, 0, -2, 5}, {1301, 0, -1, 5}// 115	116	117	
			, {1301, 0, 0, 5}, {1301, 0, 1, 5}, {1301, 0, 2, 5}// 118	119	120	
			, {1301, 0, 3, 5}, {1301, 1, -7, 5}, {1301, 1, -6, 5}// 121	122	123	
			, {1301, 1, -5, 5}, {1301, 1, -4, 5}, {1301, 1, -3, 5}// 124	125	126	
			, {1301, 1, -2, 5}, {1301, 1, -1, 5}, {1301, 1, 0, 5}// 127	128	129	
			, {1301, 1, 1, 5}, {1301, 1, 2, 5}, {1301, 1, 3, 5}// 130	131	132	
			, {464, -4, -8, 5}, {464, -3, -8, 5}, {464, -2, -8, 5}// 133	134	135	
			, {464, -1, -8, 5}, {464, 0, -8, 5}, {464, 1, -8, 5}// 136	137	138	
			, {1314, -4, -7, 25}, {1314, -4, -6, 25}, {1314, -4, -5, 25}// 139	140	141	
			, {1314, -4, -4, 25}, {1314, -4, -3, 25}, {1314, -4, -2, 25}// 142	143	144	
			, {1314, -4, -1, 25}, {1314, -4, 0, 25}, {1314, -4, 1, 25}// 145	146	147	
			, {1314, -4, 2, 25}, {1314, -4, 3, 25}, {1314, -3, -7, 25}// 148	149	150	
			, {1314, -3, -6, 25}, {1314, -3, -5, 25}, {1314, -3, -4, 25}// 151	152	153	
			, {1314, -3, -3, 25}, {1314, -3, -2, 25}, {1314, -3, -1, 25}// 154	155	156	
			, {1314, -3, 0, 25}, {1314, -3, 1, 25}, {1314, -3, 2, 25}// 157	158	159	
			, {1314, -3, 3, 25}, {1314, -2, -7, 25}, {1314, -2, -6, 25}// 160	161	162	
			, {1314, -2, -5, 25}, {1314, -2, -4, 25}, {1314, -2, -3, 25}// 163	164	165	
			, {1314, -2, -2, 25}, {1314, -2, -1, 25}, {1314, -2, 0, 25}// 166	167	168	
			, {1314, -2, 1, 25}, {1314, -2, 2, 25}, {1314, -2, 3, 25}// 169	170	171	
			, {1314, -1, -7, 25}, {1314, -1, -6, 25}, {1314, -1, -5, 25}// 172	173	174	
			, {1314, -1, -4, 25}, {1314, -1, -3, 25}, {1314, -1, -2, 25}// 175	176	177	
			, {1314, -1, -1, 25}, {1314, -1, 0, 25}, {1314, -1, 1, 25}// 178	179	180	
			, {1314, -1, 2, 25}, {1314, -1, 3, 25}, {1314, 0, -7, 25}// 181	182	183	
			, {1314, 0, -6, 25}, {1314, 0, -5, 25}, {1314, 0, -4, 25}// 184	185	186	
			, {1314, 0, -3, 25}, {1314, 0, -2, 25}, {1314, 0, -1, 25}// 187	188	189	
			, {1314, 0, 0, 25}, {1314, 0, 1, 25}, {1314, 0, 2, 25}// 190	191	192	
			, {1314, 0, 3, 25}, {1314, 1, -7, 25}, {1314, 1, -6, 25}// 193	194	195	
			, {1314, 1, -5, 25}, {1314, 1, -4, 25}, {1314, 1, -3, 25}// 196	197	198	
			, {1314, 1, -2, 25}, {1314, 1, -1, 25}, {1314, 1, 0, 25}// 199	200	201	
			, {1314, 1, 1, 25}, {1314, 1, 2, 25}, {1314, 1, 3, 25}// 202	203	204	
			, {1955, -4, 4, 0}, {1955, -4, 5, 0}, {1955, -4, 6, 0}// 205	206	207	
			, {1955, -4, 7, 0}, {1955, -4, 8, 0}, {1955, -3, 4, 0}// 208	209	210	
			, {1955, -3, 5, 0}, {1955, -3, 6, 0}, {1955, -3, 7, 0}// 211	212	213	
			, {1955, -3, 8, 0}, {1955, -2, 4, 0}, {1955, -2, 5, 0}// 214	215	216	
			, {1955, -2, 6, 0}, {1955, -2, 7, 0}, {1955, -2, 8, 0}// 217	218	219	
			, {1955, -1, 4, 0}, {1955, -1, 5, 0}, {1955, -1, 6, 0}// 220	221	222	
			, {1955, -1, 7, 0}, {1955, -1, 8, 0}, {1955, 0, 4, 0}// 223	224	225	
			, {1955, 0, 5, 0}, {1955, 0, 6, 0}, {1955, 0, 7, 0}// 226	227	228	
			, {1955, 0, 8, 0}, {1955, 1, 4, 0}, {1955, 1, 5, 0}// 229	230	231	
			, {1955, 1, 6, 0}, {1955, 1, 7, 0}, {1955, 1, 8, 0}// 232	233	234	
			, {1301, -4, 4, 5}, {1301, -4, 5, 5}, {1301, -4, 6, 5}// 235	236	237	
			, {1301, -4, 7, 5}, {1301, -4, 8, 5}, {1301, -3, 4, 5}// 238	239	240	
			, {1301, -3, 5, 5}, {1301, -3, 6, 5}, {1301, -3, 7, 5}// 241	242	243	
			, {1301, -3, 8, 5}, {1301, -2, 4, 5}, {1301, -2, 5, 5}// 244	245	246	
			, {1301, -2, 6, 5}, {1301, -2, 7, 5}, {1301, -2, 8, 5}// 247	248	249	
			, {1301, -1, 4, 5}, {1301, -1, 5, 5}, {1301, -1, 6, 5}// 250	251	252	
			, {1301, -1, 7, 5}, {1301, -1, 8, 5}, {1301, 0, 4, 5}// 253	254	255	
			, {1301, 0, 5, 5}, {1301, 0, 6, 5}, {1301, 0, 7, 5}// 256	257	258	
			, {1301, 0, 8, 5}, {1301, 1, 4, 5}, {1301, 1, 5, 5}// 259	260	261	
			, {1301, 1, 6, 5}, {1301, 1, 7, 5}, {1301, 1, 8, 5}// 262	263	264	
			, {464, -4, 8, 5}, {464, -3, 8, 5}, {464, -2, 8, 5}// 265	266	267	
			, {464, -1, 8, 5}, {464, 0, 8, 5}, {1314, -4, 4, 25}// 268	269	270	
			, {1314, -4, 5, 25}, {1314, -4, 6, 25}, {1314, -4, 7, 25}// 271	272	273	
			, {1314, -4, 8, 25}, {1314, -3, 4, 25}, {1314, -3, 5, 25}// 274	275	276	
			, {1314, -3, 6, 25}, {1314, -3, 7, 25}, {1314, -3, 8, 25}// 277	278	279	
			, {1314, -2, 4, 25}, {1314, -2, 5, 25}, {1314, -2, 6, 25}// 280	281	282	
			, {1314, -2, 7, 25}, {1314, -2, 8, 25}, {1314, -1, 4, 25}// 283	284	285	
			, {1314, -1, 5, 25}, {1314, -1, 6, 25}, {1314, -1, 7, 25}// 286	287	288	
			, {1314, -1, 8, 25}, {1314, 0, 4, 25}, {1314, 0, 5, 25}// 289	290	291	
			, {1314, 0, 6, 25}, {1314, 0, 7, 25}, {1314, 0, 8, 25}// 292	293	294	
			, {1314, 1, 4, 25}, {1314, 1, 5, 25}, {1314, 1, 6, 25}// 295	296	297	
			, {1314, 1, 7, 25}, {1314, 1, 8, 25}, {1955, 2, -6, 0}// 298	299	300	
			, {1955, 2, -5, 0}, {1955, 2, -4, 0}, {1955, 2, -3, 0}// 301	302	303	
			, {1955, 2, -2, 0}, {1955, 2, -1, 0}, {1955, 2, 0, 0}// 304	305	306	
			, {1955, 2, 1, 0}, {1955, 2, 2, 0}, {1955, 2, 3, 0}// 307	308	309	
			, {1955, 3, -6, 0}, {1955, 3, -5, 0}, {1955, 3, -4, 0}// 310	311	312	
			, {1955, 3, -3, 0}, {1955, 3, -2, 0}, {1955, 3, -1, 0}// 313	314	315	
			, {1955, 3, 0, 0}, {1955, 3, 1, 0}, {1955, 3, 2, 0}// 316	317	318	
			, {1955, 3, 3, 0}, {1955, 4, -6, 0}, {1955, 4, -5, 0}// 319	320	321	
			, {1955, 4, -4, 0}, {1955, 4, -3, 0}, {1955, 4, -2, 0}// 322	323	324	
			, {1955, 4, -1, 0}, {1955, 4, 0, 0}, {1955, 4, 1, 0}// 325	326	327	
			, {1955, 4, 2, 0}, {1955, 4, 3, 0}, {1955, 5, -6, 0}// 328	329	330	
			, {1955, 5, -5, 0}, {1955, 5, -4, 0}, {1955, 5, -3, 0}// 331	332	333	
			, {1955, 5, -2, 0}, {1955, 5, -1, 0}, {1955, 5, 0, 0}// 334	335	336	
			, {1955, 5, 1, 0}, {1955, 5, 2, 0}, {1955, 5, 3, 0}// 337	338	339	
			, {1955, 2, -7, 0}, {1955, 3, -7, 0}, {1955, 4, -7, 0}// 340	341	342	
			, {1955, 5, -7, 0}, {1301, 2, -7, 5}, {1301, 2, -6, 5}// 343	344	345	
			, {1301, 2, -5, 5}, {1301, 2, -4, 5}, {1301, 2, -3, 5}// 346	347	348	
			, {1301, 2, -2, 5}, {1301, 2, -1, 5}, {1301, 2, 0, 5}// 349	350	351	
			, {1301, 2, 1, 5}, {1301, 2, 2, 5}, {1301, 2, 3, 5}// 352	353	354	
			, {1301, 3, -7, 5}, {1301, 3, -6, 5}, {1301, 3, -5, 5}// 355	356	357	
			, {1301, 3, -4, 5}, {1301, 3, -3, 5}, {1301, 3, -2, 5}// 358	359	360	
			, {1301, 3, -1, 5}, {1301, 3, 0, 5}, {1301, 3, 1, 5}// 361	362	363	
			, {1301, 3, 2, 5}, {1301, 3, 3, 5}, {1301, 4, -7, 5}// 364	365	366	
			, {1301, 4, -6, 5}, {1301, 4, -5, 5}, {1301, 4, -4, 5}// 367	368	369	
			, {1301, 4, -3, 5}, {1301, 4, -2, 5}, {1301, 4, -1, 5}// 370	371	372	
			, {1301, 4, 0, 5}, {1301, 4, 1, 5}, {1301, 4, 2, 5}// 373	374	375	
			, {1301, 4, 3, 5}, {1301, 5, -7, 5}, {1301, 5, -6, 5}// 376	377	378	
			, {1301, 5, -5, 5}, {1301, 5, -4, 5}, {1301, 5, -3, 5}// 379	380	381	
			, {1301, 5, -2, 5}, {1301, 5, -1, 5}, {1301, 5, 0, 5}// 382	383	384	
			, {1301, 5, 1, 5}, {1301, 5, 2, 5}, {1301, 5, 3, 5}// 385	386	387	
			, {464, 2, -8, 5}, {464, 3, -8, 5}, {464, 4, -8, 5}// 388	389	390	
			, {464, 5, -8, 5}, {489, 5, -8, 0}, {489, 5, -8, 3}// 391	392	393	
			, {1314, 2, -7, 25}, {1314, 2, -6, 25}, {1314, 2, -5, 25}// 394	395	396	
			, {1314, 2, -4, 25}, {1314, 2, -3, 25}, {1314, 2, -2, 25}// 397	398	399	
			, {1314, 2, -1, 25}, {1314, 2, 0, 25}, {1314, 2, 1, 25}// 400	401	402	
			, {1314, 2, 2, 25}, {1314, 2, 3, 25}, {1314, 3, -7, 25}// 403	404	405	
			, {1314, 3, -6, 25}, {1314, 3, -5, 25}, {1314, 3, -4, 25}// 406	407	408	
			, {1314, 3, -3, 25}, {1314, 3, -2, 25}, {1314, 3, -1, 25}// 409	410	411	
			, {1314, 3, 0, 25}, {1314, 3, 1, 25}, {1314, 3, 2, 25}// 412	413	414	
			, {1314, 3, 3, 25}, {1314, 4, -7, 25}, {1314, 4, -6, 25}// 415	416	417	
			, {1314, 4, -5, 25}, {1314, 4, -4, 25}, {1314, 4, -3, 25}// 418	419	420	
			, {1314, 4, -2, 25}, {1314, 4, -1, 25}, {1314, 4, 0, 25}// 421	422	423	
			, {1314, 4, 1, 25}, {1314, 4, 2, 25}, {1314, 4, 3, 25}// 424	425	426	
			, {1314, 5, -7, 25}, {1314, 5, -6, 25}, {1314, 5, -5, 25}// 427	428	429	
			, {1314, 5, -4, 25}, {1314, 5, -3, 25}, {1314, 5, -2, 25}// 430	431	432	
			, {1314, 5, -1, 25}, {1314, 5, 0, 25}, {1314, 5, 1, 25}// 433	434	435	
			, {1314, 5, 2, 25}, {1314, 5, 3, 25}, {1955, 2, 4, 0}// 436	437	438	
			, {1955, 2, 5, 0}, {1955, 2, 6, 0}, {1955, 2, 7, 0}// 439	440	441	
			, {1955, 2, 8, 0}, {1955, 3, 4, 0}, {1955, 3, 5, 0}// 442	443	444	
			, {1955, 3, 6, 0}, {1955, 3, 7, 0}, {1955, 3, 8, 0}// 445	446	447	
			, {1955, 4, 4, 0}, {1955, 4, 5, 0}, {1955, 4, 6, 0}// 448	449	450	
			, {1955, 4, 7, 0}, {1955, 4, 8, 0}, {1955, 5, 4, 0}// 451	452	453	
			, {1955, 5, 5, 0}, {1955, 5, 6, 0}, {1955, 5, 7, 0}// 454	455	456	
			, {1955, 5, 8, 0}, {1301, 2, 4, 5}, {1301, 2, 5, 5}// 457	458	459	
			, {1301, 2, 6, 5}, {1301, 2, 7, 5}, {1301, 2, 8, 5}// 460	461	462	
			, {1301, 3, 4, 5}, {1301, 3, 5, 5}, {1301, 3, 6, 5}// 463	464	465	
			, {1301, 3, 7, 5}, {1301, 3, 8, 5}, {1301, 4, 4, 5}// 466	467	468	
			, {1301, 4, 5, 5}, {1301, 4, 6, 5}, {1301, 4, 7, 5}// 469	470	471	
			, {1301, 4, 8, 5}, {1301, 5, 4, 5}, {1301, 5, 5, 5}// 472	473	474	
			, {1301, 5, 6, 5}, {1301, 5, 7, 5}, {1301, 5, 8, 5}// 475	476	477	
			, {464, 3, 8, 5}, {464, 4, 8, 5}, {464, 5, 8, 5}// 478	479	480	
			, {1314, 2, 4, 25}, {1314, 2, 5, 25}, {1314, 2, 6, 25}// 481	482	483	
			, {1314, 2, 7, 25}, {1314, 2, 8, 25}, {1314, 3, 4, 25}// 484	485	486	
			, {1314, 3, 5, 25}, {1314, 3, 6, 25}, {1314, 3, 7, 25}// 487	488	489	
			, {1314, 3, 8, 25}, {1314, 4, 4, 25}, {1314, 4, 5, 25}// 490	491	492	
			, {1314, 4, 6, 25}, {1314, 4, 7, 25}, {1314, 4, 8, 25}// 493	494	495	
			, {1314, 5, 4, 25}, {1314, 5, 5, 25}, {1314, 5, 6, 25}// 496	497	498	
			, {1314, 5, 7, 25}, {1314, 5, 8, 25}// 499	500	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new customsideroomONEAddonDeed();
			}
		}

		[ Constructable ]
		public customsideroomONEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public customsideroomONEAddon( Serial serial ) : base( serial )
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

	public class customsideroomONEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new customsideroomONEAddon();
			}
		}

		[Constructable]
		public customsideroomONEAddonDeed()
		{
			Name = "customsideroomONE";
		}

		public customsideroomONEAddonDeed( Serial serial ) : base( serial )
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