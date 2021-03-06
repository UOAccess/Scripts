
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
	public class pondandbridgeAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6060, -7, -3, 0}, {6039, -6, -3, 0}, {6047, -6, -4, 0}// 1	2	3	
			, {3224, -8, -2, 0}, {3204, -6, -3, 0}, {3332, -7, -2, 1}// 4	5	6	
			, {3225, -7, -3, 0}, {6047, -8, -3, 0}, {6039, -6, -2, 0}// 7	8	9	
			, {6039, -7, -2, 0}, {6039, -8, -2, 0}, {3223, -9, -1, 0}// 10	11	12	
			, {3209, -9, -1, 0}, {6052, -9, -1, 0}, {6039, -8, -1, 0}// 13	14	15	
			, {6039, -7, -1, 0}, {6039, -6, -1, 0}, {3334, -6, -1, 3}// 16	17	18	
			, {6064, -8, 2, 0}, {6051, -9, 0, 0}, {6059, -7, 2, 0}// 19	20	21	
			, {6064, -7, 3, 0}, {6039, -7, 0, 0}, {6039, -6, 0, 0}// 22	23	24	
			, {6039, -6, 2, 0}, {6049, -6, 3, 0}, {3220, -8, 2, 0}// 25	26	27	
			, {3255, -8, 1, 0}, {9037, -7, 3, 0}, {3239, -9, 0, 0}// 28	29	30	
			, {3239, -8, 3, 0}, {3208, -7, 3, 6}, {3225, -9, 1, 0}// 31	32	33	
			, {6039, -8, 0, 0}, {6039, -6, 1, 0}, {6039, -7, 1, 0}// 34	35	36	
			, {6059, -8, 1, 0}, {3209, -6, 4, 0}, {6039, -3, -1, 0}// 37	38	39	
			, {6039, -2, -1, 0}, {6039, -1, -1, 0}, {6039, 0, -1, 0}// 40	41	42	
			, {6039, 1, -1, 0}, {6039, 2, -1, 0}, {6039, 3, -1, 0}// 43	44	45	
			, {6039, 4, -1, 0}, {6047, 4, -2, 0}, {6047, 2, -2, 0}// 46	47	48	
			, {6047, -2, -2, 0}, {6048, 3, -2, 0}, {6048, -3, -2, 0}// 49	50	51	
			, {6048, -1, -2, 0}, {6048, 1, -2, 0}, {6039, -4, -1, 0}// 52	53	54	
			, {6047, 0, -2, 0}, {6057, 6, -1, 0}, {6066, 7, -1, 0}// 55	56	57	
			, {6066, 6, -2, 0}, {6039, -5, -3, 0}, {6048, -5, -4, 0}// 58	59	60	
			, {6047, 5, -2, 0}, {6039, 5, -1, 0}, {1851, -1, -2, 0}// 61	62	63	
			, {1851, 0, -2, 0}, {1997, -1, -1, 5}, {2000, 0, -1, 5}// 64	65	66	
			, {2182, 1, -1, 5}, {2183, -1, -1, 5}, {1997, 1, -1, 5}// 67	68	69	
			, {3338, -5, -2, 1}, {3334, -5, -2, 4}, {3336, 2, -1, 0}// 70	71	72	
			, {3211, -2, -2, 0}, {3212, 2, -2, 0}, {1851, 1, -2, 0}// 73	74	75	
			, {3207, -5, -3, 0}, {3231, 4, -2, 0}, {6811, 4, -2, 3}// 76	77	78	
			, {3204, 5, -2, 1}, {3237, -3, -2, 0}, {3239, 6, -2, 0}// 79	80	81	
			, {3239, -4, -3, 0}, {3208, 7, -1, 6}, {3223, 3, -2, 0}// 82	83	84	
			, {3225, 8, -1, 0}, {6047, 7, -1, 0}, {6053, 8, -1, 0}// 85	86	87	
			, {6039, -5, -2, 0}, {6039, -5, -1, 0}, {6053, -4, -4, 0}// 88	89	90	
			, {6057, -4, -2, 0}, {6039, -3, 0, 0}, {6039, -2, 0, 0}// 91	92	93	
			, {6039, -1, 0, 0}, {6039, 0, 0, 0}, {6039, 1, 0, 0}// 94	95	96	
			, {6039, 2, 0, 0}, {6039, 3, 0, 0}, {6039, 4, 0, 0}// 97	98	99	
			, {6039, -4, 0, 0}, {6039, -3, 3, 0}, {6039, -2, 3, 0}// 100	101	102	
			, {6039, -1, 3, 0}, {6039, 0, 3, 0}, {6039, 1, 3, 0}// 103	104	105	
			, {6039, 2, 3, 0}, {6039, 6, 2, 0}, {6039, -4, 3, 0}// 106	107	108	
			, {6039, 3, 3, 0}, {6039, 4, 3, 0}, {6046, 8, 2, 0}// 109	110	111	
			, {6049, -4, 4, 0}, {6049, -2, 4, 0}, {6050, -3, 4, 0}// 112	113	114	
			, {6049, 0, 4, 0}, {6050, 1, 4, 0}, {6050, -1, 4, 0}// 115	116	117	
			, {6049, 2, 4, 0}, {6049, 4, 4, 0}, {6050, 3, 4, 0}// 118	119	120	
			, {6058, 6, 3, 0}, {6065, 7, 3, 0}, {6065, 6, 4, 0}// 121	122	123	
			, {6045, 8, 1, 0}, {6046, 8, 0, 0}, {6039, 6, 1, 0}// 124	125	126	
			, {6039, 6, 0, 0}, {6039, -4, 1, 0}, {6039, -4, 2, 0}// 127	128	129	
			, {6039, -3, 1, 0}, {6039, -3, 2, 0}, {6039, -2, 1, 0}// 130	131	132	
			, {6039, -2, 2, 0}, {6039, -1, 1, 0}, {6039, -1, 2, 0}// 133	134	135	
			, {6039, 0, 1, 0}, {6039, 0, 2, 0}, {6039, 1, 1, 0}// 136	137	138	
			, {6039, 1, 2, 0}, {6039, 2, 1, 0}, {6039, 2, 2, 0}// 139	140	141	
			, {6039, 3, 1, 0}, {6039, 3, 2, 0}, {6039, 4, 1, 0}// 142	143	144	
			, {6039, 4, 2, 0}, {6039, -5, 0, 0}, {6039, -5, 1, 0}// 145	146	147	
			, {6050, -5, 3, 0}, {6049, 5, 4, 0}, {6039, 5, 0, 0}// 148	149	150	
			, {6039, 5, 1, 0}, {6039, 5, 2, 0}, {6039, 5, 3, 0}// 151	152	153	
			, {1849, -1, 5, 0}, {1849, 0, 5, 0}, {1997, -1, 1, 5}// 154	155	156	
			, {1997, -1, 3, 5}, {1997, 0, 0, 5}, {1997, 0, 2, 5}// 157	158	159	
			, {1997, 0, 4, 5}, {2000, -1, 4, 5}, {2000, -1, 2, 5}// 160	161	162	
			, {2000, -1, 0, 5}, {2000, 0, 3, 5}, {2000, 0, 1, 5}// 163	164	165	
			, {2182, 1, 0, 5}, {2182, 1, 1, 5}, {2182, 1, 2, 5}// 166	167	168	
			, {2182, 1, 3, 5}, {2182, 1, 4, 5}, {2183, -1, 0, 5}// 169	170	171	
			, {2183, -1, 1, 5}, {2183, -1, 2, 5}, {2183, -1, 3, 5}// 172	173	174	
			, {2183, -1, 4, 5}, {1997, 1, 1, 5}, {1997, 1, 3, 5}// 175	176	177	
			, {2000, 1, 4, 5}, {2000, 1, 2, 5}, {2000, 1, 0, 5}// 178	179	180	
			, {1849, 1, 5, 0}, {3339, 4, 1, 1}, {3517, -4, 1, 1}// 181	182	183	
			, {3336, 4, 3, 0}, {3212, 2, 5, 0}, {3211, -2, 5, 0}// 184	185	186	
			, {3224, 7, 4, 0}, {3207, 9, 0, 0}, {3207, 3, 5, 0}// 187	188	189	
			, {3255, 5, 4, 0}, {3231, -5, 3, 0}, {6811, -5, 3, 3}// 190	191	192	
			, {3204, 8, 2, 1}, {3204, -4, 4, 1}, {3237, 9, 1, 0}// 193	194	195	
			, {3239, 4, 4, 0}, {3239, -3, 4, 0}, {3332, 5, 3, 1}// 196	197	198	
			, {3223, 9, 2, 0}, {3223, -5, 4, 0}, {3223, 3, 5, 0}// 199	200	201	
			, {3209, 5, 5, 0}, {3225, 8, 3, 0}, {6049, 7, 3, 0}// 202	203	204	
			, {6039, 7, 0, 0}, {6039, 7, 1, 0}, {6039, 7, 2, 0}// 205	206	207	
			, {9036, 8, 0, 1}, {6039, -5, 2, 0}// 208	209	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new pondandbridgeAddonDeed();
			}
		}

		[ Constructable ]
		public pondandbridgeAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public pondandbridgeAddon( Serial serial ) : base( serial )
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

	public class pondandbridgeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new pondandbridgeAddon();
			}
		}

		[Constructable]
		public pondandbridgeAddonDeed()
		{
			Name = "pondandbridge";
		}

		public pondandbridgeAddonDeed( Serial serial ) : base( serial )
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