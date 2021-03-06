
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
	public class SandstoneOutBldgAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {365, 4, -5, 5}, {368, -4, -5, 5}, {353, -5, -5, 5}// 1	2	3	
			, {1900, -4, -4, 0}, {1900, -4, -3, 0}, {1900, -4, -2, 0}// 4	5	6	
			, {1900, -4, -1, 0}, {1900, -4, 0, 0}, {1900, -4, 1, 0}// 7	8	9	
			, {1900, -3, -4, 0}, {1900, -3, -3, 0}, {1900, -3, -2, 0}// 10	11	12	
			, {1900, -3, -1, 0}, {1900, -3, 0, 0}, {1900, -3, 1, 0}// 13	14	15	
			, {1900, -2, -4, 0}, {1900, -2, -3, 0}, {1900, -2, -2, 0}// 16	17	18	
			, {1900, -2, -1, 0}, {1900, -2, 0, 0}, {1900, -2, 1, 0}// 19	20	21	
			, {1900, -1, -4, 0}, {1900, -1, -3, 0}, {1900, -1, -2, 0}// 22	23	24	
			, {1900, -1, -1, 0}, {1900, -1, 0, 0}, {1900, -1, 1, 0}// 25	26	27	
			, {1900, 0, -4, 0}, {1900, 0, -3, 0}, {1900, 0, -2, 0}// 28	29	30	
			, {1900, 0, -1, 0}, {1900, 0, 0, 0}, {1900, 0, 1, 0}// 31	32	33	
			, {1900, 1, -4, 0}, {1900, 1, -3, 0}, {1900, 1, -2, 0}// 34	35	36	
			, {1900, 1, -1, 0}, {1900, 1, 0, 0}, {1900, 1, 1, 0}// 37	38	39	
			, {1900, 2, -4, 0}, {1900, 2, -3, 0}, {1900, 2, -2, 0}// 40	41	42	
			, {1900, 2, -1, 0}, {1900, 2, 0, 0}, {1900, 2, 1, 0}// 43	44	45	
			, {1900, 3, -4, 0}, {1900, 3, -3, 0}, {1900, 3, -2, 0}// 46	47	48	
			, {1900, 3, -1, 0}, {1900, 3, 0, 0}, {1900, 3, 1, 0}// 49	50	51	
			, {1900, 4, -4, 0}, {1900, 4, -3, 0}, {1900, 4, -2, 0}// 52	53	54	
			, {1900, 4, -1, 0}, {1900, 4, 0, 0}, {1900, 4, 1, 0}// 55	56	57	
			, {1900, -4, 2, 0}, {1900, -3, 2, 0}, {1900, -2, 2, 0}// 58	59	60	
			, {1900, -1, 2, 0}, {1900, 0, 2, 0}, {1900, 1, 2, 0}// 61	62	63	
			, {1900, 2, 2, 0}, {1900, 3, 2, 0}, {1900, 4, 2, 0}// 64	65	66	
			, {1900, -4, 3, 0}, {1900, -4, 4, 0}, {1900, -3, 3, 0}// 67	68	69	
			, {1900, -3, 4, 0}, {1900, -2, 3, 0}, {1900, -2, 4, 0}// 70	71	72	
			, {1900, -1, 3, 0}, {1900, -1, 4, 0}, {1900, 0, 3, 0}// 73	74	75	
			, {1900, 0, 4, 0}, {1900, 1, 3, 0}, {1900, 1, 4, 0}// 76	77	78	
			, {1900, 2, 3, 0}, {1900, 2, 4, 0}, {1900, 3, 3, 0}// 79	80	81	
			, {1900, 3, 4, 0}, {1900, 4, 3, 0}, {1900, 4, 4, 0}// 82	83	84	
			, {1901, -3, 5, 0}, {1901, -2, 5, 0}, {1901, -1, 5, 0}// 85	86	87	
			, {1901, 0, 5, 0}, {1901, 1, 5, 0}, {1901, 2, 5, 0}// 88	89	90	
			, {1901, 3, 5, 0}, {1906, 4, 5, 0}, {1908, -4, 5, 0}// 91	92	93	
			, {364, 4, 4, 5}, {366, -5, 4, 5}, {367, 4, -4, 5}// 94	95	96	
			, {368, -4, 4, 5}, {367, -5, -4, 5}, {9180, 4, -4, 25}// 97	98	99	
			, {9180, 4, -3, 25}, {9180, 4, -2, 25}, {9180, 4, -1, 25}// 100	101	102	
			, {9180, 4, 0, 25}, {9180, 4, 1, 25}, {9180, 4, 2, 25}// 103	104	105	
			, {9180, 4, 3, 25}, {9180, 4, 4, 25}, {9180, 3, -4, 28}// 106	107	108	
			, {9180, 3, -3, 28}, {9180, 3, -2, 28}, {9180, 3, -1, 28}// 109	110	111	
			, {9180, 3, 0, 28}, {9180, 3, 1, 28}, {9180, 3, 2, 28}// 112	113	114	
			, {9180, 3, 3, 28}, {9180, 3, 4, 28}, {9180, 2, -4, 31}// 115	116	117	
			, {9180, 2, -3, 31}, {9180, 2, -2, 31}, {9180, 2, -1, 31}// 118	119	120	
			, {9180, 2, 0, 31}, {9180, 2, 1, 31}, {9180, 2, 2, 31}// 121	122	123	
			, {9180, 2, 3, 31}, {9180, 2, 4, 31}, {9181, 5, -4, 22}// 124	125	126	
			, {9181, 5, -3, 22}, {9181, 5, -2, 22}, {9181, 5, -1, 22}// 127	128	129	
			, {9181, 5, 0, 22}, {9181, 5, 1, 22}, {9181, 5, 2, 22}// 130	131	132	
			, {9181, 5, 3, 22}, {9181, 5, 4, 22}, {9183, -5, -4, 22}// 133	134	135	
			, {9183, -5, -3, 22}, {9183, -5, -2, 22}, {9183, -5, -1, 22}// 136	137	138	
			, {9183, -5, 0, 22}, {9183, -5, 1, 22}, {9183, -5, 2, 22}// 139	140	141	
			, {9183, -5, 3, 22}, {9183, -5, 4, 22}, {9182, -4, -4, 25}// 142	143	144	
			, {9182, -4, -3, 25}, {9182, -4, -2, 25}, {9182, -4, -1, 25}// 145	146	147	
			, {9182, -4, 0, 25}, {9182, -4, 1, 25}, {9182, -4, 2, 25}// 148	149	150	
			, {9182, -4, 3, 25}, {9182, -4, 4, 25}, {9182, -3, -4, 28}// 151	152	153	
			, {9182, -3, -3, 28}, {9182, -3, -2, 28}, {9182, -3, -1, 28}// 154	155	156	
			, {9182, -3, 0, 28}, {9182, -3, 1, 28}, {9182, -3, 2, 28}// 157	158	159	
			, {9182, -3, 3, 28}, {9182, -3, 4, 28}, {9182, -2, -4, 31}// 160	161	162	
			, {9182, -2, -3, 31}, {9182, -2, -2, 31}, {9182, -2, -1, 31}// 163	164	165	
			, {9182, -2, 0, 31}, {9182, -2, 1, 31}, {9182, -2, 2, 31}// 166	167	168	
			, {9182, -2, 3, 31}, {9182, -2, 4, 31}, {9172, -1, -4, 34}// 169	170	171	
			, {9172, -1, -3, 34}, {9172, -1, -2, 34}, {9172, -1, -1, 34}// 172	173	174	
			, {9172, -1, 0, 34}, {9172, -1, 1, 34}, {9172, -1, 2, 34}// 175	176	177	
			, {9172, -1, 3, 34}, {9172, -1, 4, 34}, {9172, 0, -4, 34}// 178	179	180	
			, {9172, 0, -3, 34}, {9172, 0, -2, 34}, {9172, 0, -1, 34}// 181	182	183	
			, {9172, 0, 0, 34}, {9172, 0, 1, 34}, {9172, 0, 2, 34}// 184	185	186	
			, {9172, 0, 3, 34}, {9172, 0, 4, 34}, {9172, 1, -4, 34}// 187	188	189	
			, {9172, 1, -3, 34}, {9172, 1, -2, 34}, {9172, 1, -1, 34}// 190	191	192	
			, {9172, 1, 0, 34}, {9172, 1, 1, 34}, {9172, 1, 2, 34}// 193	194	195	
			, {9172, 1, 3, 34}, {9172, 1, 4, 34}// 196	197	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SandstoneOutBldgAddonDeed();
			}
		}

		[ Constructable ]
		public SandstoneOutBldgAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public SandstoneOutBldgAddon( Serial serial ) : base( serial )
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

	public class SandstoneOutBldgAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SandstoneOutBldgAddon();
			}
		}

		[Constructable]
		public SandstoneOutBldgAddonDeed()
		{
			Name = "SandstoneOutBldg";
		}

		public SandstoneOutBldgAddonDeed( Serial serial ) : base( serial )
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