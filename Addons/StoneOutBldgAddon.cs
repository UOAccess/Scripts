
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
	public class StoneOutBldgAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1822, -3, -4, 0}, {1822, -3, -3, 0}, {1822, -3, -2, 0}// 1	2	3	
			, {1822, -3, -1, 0}, {1822, -3, 0, 0}, {1822, -3, 1, 0}// 4	5	6	
			, {1822, -3, 2, 0}, {1822, -3, 3, 0}, {1822, -3, 4, 0}// 7	8	9	
			, {206, -4, 4, 5}, {204, -4, -5, 5}, {208, -4, -4, 5}// 10	11	12	
			, {9157, -4, -4, 20}, {9157, -4, -3, 20}, {9157, -4, -2, 20}// 13	14	15	
			, {9157, -4, -1, 20}, {9157, -4, 0, 20}, {9157, -4, 1, 20}// 16	17	18	
			, {9157, -4, 2, 20}, {9157, -4, 3, 20}, {9157, -4, 4, 20}// 19	20	21	
			, {1869, -3, 5, 0}, {209, -3, -5, 5}, {209, -3, 4, 5}// 22	23	24	
			, {9157, -3, -4, 23}, {9157, -3, -3, 23}, {9157, -3, -2, 23}// 25	26	27	
			, {9157, -3, -1, 23}, {9157, -3, 0, 23}, {9157, -3, 1, 23}// 28	29	30	
			, {9157, -3, 2, 23}, {9157, -3, 3, 23}, {9157, -3, 4, 23}// 31	32	33	
			, {9157, -4, -5, 20}, {9157, -3, -5, 23}, {1822, -2, -4, 0}// 34	35	36	
			, {1822, -2, -3, 0}, {1822, -2, -2, 0}, {1822, -2, -1, 0}// 37	38	39	
			, {1822, -2, 0, 0}, {1822, -2, 1, 0}, {1822, -2, 2, 0}// 40	41	42	
			, {1822, -2, 3, 0}, {1822, -1, -4, 0}, {1822, -1, -3, 0}// 43	44	45	
			, {1822, -1, -2, 0}, {1822, -1, -1, 0}, {1822, -1, 0, 0}// 46	47	48	
			, {1822, -1, 1, 0}, {1822, -1, 2, 0}, {1822, -1, 3, 0}// 49	50	51	
			, {1822, 0, -4, 0}, {1822, 0, -3, 0}, {1822, 0, -2, 0}// 52	53	54	
			, {1822, 0, -1, 0}, {1822, 0, 0, 0}, {1822, 0, 1, 0}// 55	56	57	
			, {1822, 0, 2, 0}, {1822, 0, 3, 0}, {1822, 1, -4, 0}// 58	59	60	
			, {1822, 1, -3, 0}, {1822, 1, -2, 0}, {1822, 1, -1, 0}// 61	62	63	
			, {1822, 1, 0, 0}, {1822, 1, 1, 0}, {1822, 1, 2, 0}// 64	65	66	
			, {1822, 1, 3, 0}, {1822, 2, -4, 0}, {1822, 2, -3, 0}// 67	68	69	
			, {1822, 2, -2, 0}, {1822, 2, -1, 0}, {1822, 2, 0, 0}// 70	71	72	
			, {1822, 2, 1, 0}, {1822, 2, 2, 0}, {1822, 2, 3, 0}// 73	74	75	
			, {1822, 3, -4, 0}, {1822, 3, -3, 0}, {1822, 3, -2, 0}// 76	77	78	
			, {1822, 3, -1, 0}, {1822, 3, 0, 0}, {1822, 3, 1, 0}// 79	80	81	
			, {1822, 3, 2, 0}, {1822, 3, 3, 0}, {1822, 4, -4, 0}// 82	83	84	
			, {1822, 4, -3, 0}, {1822, 4, -2, 0}, {1822, 4, -1, 0}// 85	86	87	
			, {1822, 4, 0, 0}, {1822, 4, 1, 0}, {1822, 4, 2, 0}// 88	89	90	
			, {1822, 4, 3, 0}, {1822, 5, -4, 0}, {1822, 5, -3, 0}// 91	92	93	
			, {1822, 5, -2, 0}, {1822, 5, -1, 0}, {1822, 5, 0, 0}// 94	95	96	
			, {1822, 5, 1, 0}, {1822, 5, 2, 0}, {1822, 5, 3, 0}// 97	98	99	
			, {1822, -2, 4, 0}, {1822, -1, 4, 0}, {1822, 0, 4, 0}// 100	101	102	
			, {1822, 1, 4, 0}, {1822, 2, 4, 0}, {1822, 3, 4, 0}// 103	104	105	
			, {1822, 4, 4, 0}, {1822, 5, 4, 0}, {1823, -2, 5, 0}// 106	107	108	
			, {1823, -1, 5, 0}, {1823, 0, 5, 0}, {1823, 1, 5, 0}// 109	110	111	
			, {1823, 2, 5, 0}, {1823, 3, 5, 0}, {1823, 4, 5, 0}// 112	113	114	
			, {207, 5, -5, 5}, {208, 5, -4, 5}, {205, 5, 4, 5}// 115	116	117	
			, {222, 1, 1, 0}, {222, 2, 1, 0}, {9155, 5, -3, 20}// 118	119	120	
			, {9155, 5, -2, 20}, {9155, 5, -1, 20}, {9155, 5, 0, 20}// 121	122	123	
			, {9155, 5, 1, 20}, {9155, 5, 2, 20}, {9155, 5, 3, 20}// 124	125	126	
			, {9155, 5, 4, 20}, {9155, 5, -4, 20}, {9155, 4, -4, 23}// 127	128	129	
			, {9155, 4, -3, 23}, {9155, 4, -2, 23}, {9155, 4, -1, 23}// 130	131	132	
			, {9155, 4, 0, 23}, {9155, 4, 1, 23}, {9155, 4, 2, 23}// 133	134	135	
			, {9155, 4, 3, 23}, {9155, 4, 4, 23}, {9157, -2, -4, 26}// 136	137	138	
			, {9157, -2, -3, 26}, {9157, -2, -2, 26}, {9157, -2, -1, 26}// 139	140	141	
			, {9157, -2, 0, 26}, {9157, -2, 1, 26}, {9157, -2, 2, 26}// 142	143	144	
			, {9157, -2, 3, 26}, {9157, -2, 4, 26}, {9157, -1, -4, 29}// 145	146	147	
			, {9157, -1, -3, 29}, {9157, -1, -2, 29}, {9157, -1, -1, 29}// 148	149	150	
			, {9157, -1, 0, 29}, {9157, -1, 1, 29}, {9157, -1, 2, 29}// 151	152	153	
			, {9157, -1, 3, 29}, {9157, -1, 4, 29}, {9155, 3, -4, 26}// 154	155	156	
			, {9155, 3, -3, 26}, {9155, 3, -2, 26}, {9155, 3, -1, 26}// 157	158	159	
			, {9155, 3, 0, 26}, {9155, 3, 1, 26}, {9155, 3, 2, 26}// 160	161	162	
			, {9155, 3, 3, 26}, {9155, 3, 4, 26}, {9155, 2, -4, 29}// 163	164	165	
			, {9155, 2, -3, 29}, {9155, 2, -2, 29}, {9155, 2, -1, 29}// 166	167	168	
			, {9155, 2, 0, 29}, {9155, 2, 1, 29}, {9155, 2, 2, 29}// 169	170	171	
			, {9155, 2, 3, 29}, {9155, 2, 4, 29}, {9152, 0, -4, 32}// 172	173	174	
			, {9152, 0, -3, 32}, {9152, 0, -2, 32}, {9152, 0, -1, 32}// 175	176	177	
			, {9152, 0, 0, 32}, {9152, 0, 1, 32}, {9152, 0, 2, 32}// 178	179	180	
			, {9152, 0, 3, 32}, {1867, 5, 5, 0}, {9155, 5, -5, 20}// 181	182	183	
			, {9155, 4, -5, 23}, {9155, 3, -5, 26}, {9155, 2, -5, 29}// 184	185	186	
			, {9157, -2, -5, 26}, {9157, -1, -5, 29}, {9151, 0, 4, 32}// 187	188	189	
			, {9151, 1, 4, 32}, {9150, 0, -5, 32}, {9150, 1, -5, 32}// 190	191	192	
			, {9150, 1, -4, 32}, {9150, 1, -3, 32}, {9150, 1, -2, 32}// 193	194	195	
			, {9150, 1, -1, 32}, {9150, 1, 0, 32}, {9150, 1, 1, 32}// 196	197	198	
			, {9150, 1, 2, 32}, {9150, 1, 3, 32}// 199	200	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new StoneOutBldgAddonDeed();
			}
		}

		[ Constructable ]
		public StoneOutBldgAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public StoneOutBldgAddon( Serial serial ) : base( serial )
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

	public class StoneOutBldgAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new StoneOutBldgAddon();
			}
		}

		[Constructable]
		public StoneOutBldgAddonDeed()
		{
			Name = "StoneOutBldg";
		}

		public StoneOutBldgAddonDeed( Serial serial ) : base( serial )
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