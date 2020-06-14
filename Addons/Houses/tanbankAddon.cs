
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
	public class tanbankAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9271, -1, -3, 7}, {11215, -1, -3, 27}, {9255, -4, -5, 7}// 1	 2	 3	 
			, {11215, -4, -5, 27}, {9271, 5, -5, 7}, {11215, 5, -5, 27}// 4	 5	 6	 
			, {11508, 4, 5, 7}, {9271, 4, 5, 7}, {11215, 4, 5, 27}// 7	 8	 9	 
			, {11774, 4, 5, 0}, {1811, 2, 6, 0}, {11508, 2, 5, 7}// 10	 11	 12	 
			, {9271, 2, 5, 7}, {11215, 2, 5, 27}, {11774, 2, 5, 0}// 13	 14	 15	 
			, {11507, -5, -1, 7}, {11773, -5, -1, 0}, {11507, -5, 0, 7}// 16	 17	 18	 
			, {11773, -5, 0, 0}, {11508, -4, -6, 7}, {11774, -4, -6, 0}// 19	 20	 21	 
			, {9271, 0, -5, 7}, {11215, 0, -5, 27}, {9271, -3, -5, 7}// 22	 23	 24	 
			, {11215, -3, -5, 27}, {9255, -2, -3, 7}, {11215, -2, -3, 27}// 25	 26	 27	 
			, {9270, 4, -2, 7}, {11215, 4, -2, 27}, {9269, 5, -2, 7}// 28	 29	 30	 
			, {11215, 5, -2, 27}, {9271, 1, 5, 7}, {11215, 1, 5, 27}// 31	 32	 33	 
			, {11774, 1, 5, 0}, {1979, 1, 6, 0}, {11508, -1, 5, 7}// 34	 35	 36	 
			, {9271, -1, 5, 7}, {11215, -1, 5, 27}, {11774, -1, 5, 0}// 37	 38	 39	 
			, {11508, -3, -6, 7}, {11774, -3, -6, 0}, {9270, 2, 2, 7}// 40	 41	 42	 
			, {11215, 2, 2, 27}, {9271, 2, -5, 7}, {11215, 2, -5, 27}// 43	 44	 45	 
			, {9271, 4, 0, 7}, {11215, 4, 0, 27}, {9256, 4, -1, 7}// 46	 47	 48	 
			, {11215, 4, -1, 27}, {9271, 3, 3, 7}, {11215, 3, 3, 27}// 49	 50	 51	 
			, {9254, 2, 3, 7}, {11215, 2, 3, 27}, {11510, 4, -6, 7}// 52	 53	 54	 
			, {11774, 4, -6, 0}, {9272, 3, 2, 7}, {11215, 3, 2, 27}// 55	 56	 57	 
			, {9269, 5, 2, 7}, {11215, 5, 2, 27}, {11507, 6, 0, 7}// 58	 59	 60	 
			, {9270, 6, 0, 7}, {11215, 6, 0, 27}, {11773, 6, 0, 0}// 61	 62	 63	 
			, {9269, 5, 4, 7}, {11215, 5, 4, 27}, {11507, 6, -2, 7}// 64	 65	 66	 
			, {9270, 6, -2, 7}, {11215, 6, -2, 27}, {11773, 6, -2, 0}// 67	 68	 69	 
			, {9271, -1, -5, 7}, {11215, -1, -5, 27}, {9270, -4, -3, 7}// 70	 71	 72	 
			, {11215, -4, -3, 27}, {9271, 1, -5, 7}, {11215, 1, -5, 27}// 73	 74	 75	 
			, {11508, -1, -6, 7}, {11774, -1, -6, 0}, {9270, -4, 2, 7}// 76	 77	 78	 
			, {11215, -4, 2, 27}, {9270, -4, 1, 7}, {11215, -4, 1, 27}// 79	 80	 81	 
			, {9269, -3, 3, 7}, {11215, -3, 3, 27}, {11507, -5, 2, 7}// 82	 83	 84	 
			, {11773, -5, 2, 0}, {9269, -2, 4, 7}, {11215, -2, 4, 27}// 85	 86	 87	 
			, {9254, -2, 3, 7}, {11215, -2, 3, 27}, {9269, 0, 4, 7}// 88	 89	 90	 
			, {11215, 0, 4, 27}, {9272, -1, 2, 7}, {11215, -1, 2, 27}// 91	 92	 93	 
			, {9270, 0, -2, 7}, {11215, 0, -2, 27}, {9271, -1, 0, 7}// 94	 95	 96	 
			, {11215, -1, 0, 27}, {9270, -4, -4, 7}, {11215, -4, -4, 27}// 97	 98	 99	 
			, {9272, -1, -2, 7}, {11215, -1, -2, 27}, {11508, 2, -6, 7}// 100	 101	 102	 
			, {11774, 2, -6, 0}, {11508, 3, -6, 7}, {11774, 3, -6, 0}// 103	 104	 105	 
			, {9270, 1, 1, 7}, {11215, 1, 1, 27}, {9270, 1, 2, 7}// 106	 107	 108	 
			, {11215, 1, 2, 27}, {1979, 0, 6, 0}, {9255, -2, 1, 7}// 109	 110	 111	 
			, {11215, -2, 1, 27}, {9271, -1, -1, 7}, {11215, -1, -1, 27}// 112	 113	 114	 
			, {11510, -2, 5, 7}, {9271, -2, 5, 7}, {11215, -2, 5, 27}// 115	 116	 117	 
			, {11774, -2, 5, 0}, {11508, -3, 5, 7}, {9271, -3, 5, 7}// 118	 119	 120	 
			, {11215, -3, 5, 27}, {11774, -3, 5, 0}, {11508, -4, 5, 7}// 121	 122	 123	 
			, {9254, -4, 5, 7}, {11215, -4, 5, 27}, {11774, -4, 5, 0}// 124	 125	 126	 
			, {11507, -5, 5, 7}, {11773, -5, 5, 0}, {9269, 5, -4, 7}// 127	 128	 129	 
			, {11215, 5, -4, 27}, {9271, 3, -1, 7}, {11215, 3, -1, 27}// 130	 131	 132	 
			, {9271, 3, 0, 7}, {11215, 3, 0, 27}, {11508, 0, -6, 7}// 133	 134	 135	 
			, {11774, 0, -6, 0}, {9271, 0, 5, 7}, {11215, 0, 5, 27}// 136	 137	 138	 
			, {11774, 0, 5, 0}, {11510, -2, -6, 7}, {11774, -2, -6, 0}// 139	 140	 141	 
			, {1812, -1, 6, 0}, {9270, 1, -1, 7}, {11215, 1, -1, 27}// 142	 143	 144	 
			, {9269, -3, -4, 7}, {11215, -3, -4, 27}, {9269, 5, -3, 7}// 145	 146	 147	 
			, {11215, 5, -3, 27}, {9270, 2, -2, 7}, {11215, 2, -2, 27}// 148	 149	 150	 
			, {9255, 2, -3, 7}, {11215, 2, -3, 27}, {9270, 1, -3, 7}// 151	 152	 153	 
			, {11215, 1, -3, 27}, {11507, -5, -2, 7}, {11773, -5, -2, 0}// 154	 155	 156	 
			, {9271, 3, -5, 7}, {11215, 3, -5, 27}, {9255, 2, 1, 7}// 157	 158	 159	 
			, {11215, 2, 1, 27}, {11211, 6, 5, 7}, {9256, 6, 5, 7}// 160	 161	 162	 
			, {11215, 6, 5, 27}, {11771, 6, 5, 0}, {11507, 6, 4, 7}// 163	 164	 165	 
			, {9270, 6, 4, 7}, {11215, 6, 4, 27}, {11773, 6, 4, 0}// 166	 167	 168	 
			, {11511, 6, 3, 7}, {9270, 6, 3, 7}, {11215, 6, 3, 27}// 169	 170	 171	 
			, {11773, 6, 3, 0}, {9269, 5, -1, 7}, {11215, 5, -1, 27}// 172	 173	 174	 
			, {9269, 5, 0, 7}, {11215, 5, 0, 27}, {9270, 4, 2, 7}// 175	 176	 177	 
			, {11215, 4, 2, 27}, {9269, 3, 4, 7}, {11215, 3, 4, 27}// 178	 179	 180	 
			, {9269, 4, 4, 7}, {11215, 4, 4, 27}, {9256, 4, 3, 7}// 181	 182	 183	 
			, {11215, 4, 3, 27}, {11507, 6, -4, 7}, {9270, 6, -4, 7}// 184	 185	 186	 
			, {11215, 6, -4, 27}, {11773, 6, -4, 0}, {11507, 6, -5, 7}// 187	 188	 189	 
			, {9253, 6, -5, 7}, {11215, 6, -5, 27}, {11773, 6, -5, 0}// 190	 191	 192	 
			, {11508, 6, -6, 7}, {11774, 6, -6, 0}, {11507, 6, 1, 7}// 193	 194	 195	 
			, {9270, 6, 1, 7}, {11215, 6, 1, 27}, {11773, 6, 1, 0}// 196	 197	 198	 
			, {11507, 6, -1, 7}, {9270, 6, -1, 7}, {11215, 6, -1, 27}// 199	 200	 201	 
			, {11773, 6, -1, 0}, {9269, -2, -4, 7}, {11215, -2, -4, 27}// 202	 203	 204	 
			, {9269, -3, -2, 7}, {11215, -3, -2, 27}, {9269, 0, -4, 7}// 205	 206	 207	 
			, {11215, 0, -4, 27}, {9270, -4, -1, 7}, {11215, -4, -1, 27}// 208	 209	 210	 
			, {11511, -5, 3, 7}, {11773, -5, 3, 0}, {9269, -3, 2, 7}// 211	 212	 213	 
			, {11215, -3, 2, 27}, {11507, -5, 1, 7}, {11773, -5, 1, 0}// 214	 215	 216	 
			, {9269, -3, 4, 7}, {11215, -3, 4, 27}, {9271, -1, 3, 7}// 217	 218	 219	 
			, {11215, -1, 3, 27}, {9253, 0, 1, 7}, {11215, 0, 1, 27}// 220	 221	 222	 
			, {9269, -3, -3, 7}, {11215, -3, -3, 27}, {9269, -1, -4, 7}// 223	 224	 225	 
			, {11215, -1, -4, 27}, {11507, -5, -5, 7}, {11773, -5, -5, 0}// 226	 227	 228	 
			, {11507, -5, -4, 7}, {11773, -5, -4, 0}, {9271, 0, 0, 7}// 229	 230	 231	 
			, {11215, 0, 0, 27}, {11212, -5, -6, 7}, {11772, -5, -6, 0}// 232	 233	 234	 
			, {9269, 4, -4, 7}, {11215, 4, -4, 27}, {9271, 4, -5, 7}// 235	 236	 237	 
			, {11215, 4, -5, 27}, {9271, 2, 0, 7}, {11215, 2, 0, 27}// 238	 239	 240	 
			, {9254, 2, -1, 7}, {11215, 2, -1, 27}, {9270, -2, 2, 7}// 241	 242	 243	 
			, {11215, -2, 2, 27}, {9271, -2, -5, 7}, {11215, -2, -5, 27}// 244	 245	 246	 
			, {9271, -2, 0, 7}, {11215, -2, 0, 27}, {9253, 0, -3, 7}// 247	 248	 249	 
			, {11215, 0, -3, 27}, {9270, -2, -2, 7}, {11215, -2, -2, 27}// 250	 251	 252	 
			, {9256, 0, -1, 7}, {11215, 0, -1, 27}, {11508, 5, 5, 7}// 253	 254	 255	 
			, {9271, 5, 5, 7}, {11215, 5, 5, 27}, {11774, 5, 5, 0}// 256	 257	 258	 
			, {11510, 3, 5, 7}, {9271, 3, 5, 7}, {11215, 3, 5, 27}// 259	 260	 261	 
			, {11774, 3, 5, 0}, {9253, 4, -3, 7}, {11215, 4, -3, 27}// 262	 263	 264	 
			, {9270, 1, 3, 7}, {11215, 1, 3, 27}, {9269, 1, 4, 7}// 265	 266	 267	 
			, {11215, 1, 4, 27}, {11511, -5, -3, 7}, {11773, -5, -3, 0}// 268	 269	 270	 
			, {9254, -2, -1, 7}, {11215, -2, -1, 27}, {9269, 2, -4, 7}// 271	 272	 273	 
			, {11215, 2, -4, 27}, {9272, 1, 0, 7}, {11215, 1, 0, 27}// 274	 275	 276	 
			, {9271, 3, -3, 7}, {11215, 3, -3, 27}, {9272, 3, -2, 7}// 277	 278	 279	 
			, {11215, 3, -2, 27}, {9269, 2, 4, 7}, {11215, 2, 4, 27}// 280	 281	 282	 
			, {9270, 1, -2, 7}, {11215, 1, -2, 27}, {9271, 3, 1, 7}// 283	 284	 285	 
			, {11215, 3, 1, 27}, {9269, 3, -4, 7}, {11215, 3, -4, 27}// 286	 287	 288	 
			, {11507, 6, 2, 7}, {9270, 6, 2, 7}, {11215, 6, 2, 27}// 289	 290	 291	 
			, {11773, 6, 2, 0}, {9269, 5, 1, 7}, {11215, 5, 1, 27}// 292	 293	 294	 
			, {9253, 4, 1, 7}, {11215, 4, 1, 27}, {9269, 5, 3, 7}// 295	 296	 297	 
			, {11215, 5, 3, 27}, {11508, 5, -6, 7}, {11774, 5, -6, 0}// 298	 299	 300	 
			, {11511, 6, -3, 7}, {9270, 6, -3, 7}, {11215, 6, -3, 27}// 301	 302	 303	 
			, {11773, 6, -3, 0}, {9270, -4, -2, 7}, {11215, -4, -2, 27}// 304	 305	 306	 
			, {11508, 1, -6, 7}, {11774, 1, -6, 0}, {9270, -4, 0, 7}// 307	 308	 309	 
			, {11215, -4, 0, 27}, {9269, -3, 0, 7}, {11215, -3, 0, 27}// 310	 311	 312	 
			, {9269, -3, 1, 7}, {11215, -3, 1, 27}, {11507, -5, 4, 7}// 313	 314	 315	 
			, {11773, -5, 4, 0}, {9270, -4, 4, 7}, {11215, -4, 4, 27}// 316	 317	 318	 
			, {9270, -4, 3, 7}, {11215, -4, 3, 27}, {9270, 0, 2, 7}// 319	 320	 321	 
			, {11215, 0, 2, 27}, {9269, -1, 4, 7}, {11215, -1, 4, 27}// 322	 323	 324	 
			, {9271, -1, 1, 7}, {11215, -1, 1, 27}, {9256, 0, 3, 7}// 325	 326	 327	 
			, {11215, 0, 3, 27}, {9269, -3, -1, 7}, {11215, -3, -1, 27}// 328	 329	 330	 
			, {9269, 1, -4, 7}, {11215, 1, -4, 27}, {10722, 4, -6, 27}// 331	 332	 333	
			, {7620, 0, 0, 7}, {10723, -5, -1, 27}, {7622, 3, 0, 8}// 334	335	336	
			, {7622, -1, 0, 7}, {7621, -2, 0, 7}, {10722, -4, -6, 27}// 338	339	340	
			, {10722, -3, -6, 27}, {10723, -5, 2, 27}, {10723, -5, 4, 27}// 341	342	343	
			, {7621, 3, 1, 19}, {10723, -5, -3, 27}, {10722, 5, -6, 27}// 344	345	346	
			, {10722, 2, -6, 27}, {10723, -5, -4, 27}, {10723, -5, 0, 27}// 347	348	349	
			, {10724, -5, -6, 27}, {10722, 3, -6, 27}, {10722, 1, -6, 27}// 350	351	352	
			, {10723, -5, 3, 27}, {10722, 0, -6, 27}, {10723, -5, 1, 27}// 353	355	356	
			, {7620, 4, 0, 8}, {10722, -2, -6, 27}, {10722, -1, -6, 27}// 357	358	359	
			, {10723, -5, -5, 27}, {10723, -5, -2, 27}, {10722, 1, 5, 27}// 360	361	362	
			, {10722, 0, 5, 27}, {10722, -2, 5, 27}, {10723, -5, 5, 27}// 363	364	365	
			, {10722, 4, 5, 27}, {10722, -4, 5, 27}, {10722, 2, 5, 27}// 366	367	368	
			, {2968, -5, 6, 7}, {10722, 5, 5, 27}, {10722, -1, 5, 27}// 369	370	371	
			, {3026, -5, 6, 7}, {10722, 3, 5, 27}, {10722, -3, 5, 27}// 372	373	374	
			, {10723, 6, -1, 27}, {10723, 6, 0, 27}, {10723, 6, -5, 27}// 375	376	377	
			, {10723, 6, -4, 27}, {10723, 6, 1, 27}, {10723, 6, -2, 27}// 378	379	380	
			, {10723, 6, 4, 27}, {10723, 6, -3, 27}, {10723, 6, 3, 27}// 381	382	383	
			, {10723, 6, 2, 27}, {10722, 6, -6, 27}, {10721, 6, 5, 27}// 384	385	386	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new tanbankAddonDeed();
			}
		}

		[ Constructable ]
		public tanbankAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4632, -1, -1, 7, 2962, -1, "", 1);// 337
			AddComplexComponent( (BaseAddon) this, 4632, 3, -1, 7, 2962, -1, "", 1);// 354

		}

		public tanbankAddon( Serial serial ) : base( serial )
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

	public class tanbankAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new tanbankAddon();
			}
		}

		[Constructable]
		public tanbankAddonDeed()
		{
			Name = "tanbank";
		}

		public tanbankAddonDeed( Serial serial ) : base( serial )
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