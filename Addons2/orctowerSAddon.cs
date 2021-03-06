
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
	public class orctowerSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {147, -2, -4, 0}, {147, 3, -4, 0}, {1193, 0, -4, 20}// 1	2	3	
			, {1193, 1, -3, 20}, {1193, 0, -2, 20}, {1193, -1, -1, 20}// 4	5	6	
			, {1193, 0, 0, 20}, {1193, 0, 1, 20}, {1193, 3, -4, 20}// 7	8	9	
			, {1193, 3, -3, 20}, {1193, 3, -2, 20}, {1193, 3, -1, 20}// 10	11	12	
			, {1193, 3, 0, 20}, {1193, 3, 1, 20}, {1193, 2, -4, 20}// 13	14	15	
			, {1193, 2, -3, 20}, {1193, 2, -2, 20}, {1193, 2, -1, 20}// 16	17	18	
			, {1193, 2, 0, 20}, {1193, 2, 1, 20}, {1193, 1, -2, 20}// 19	20	21	
			, {1193, 1, -4, 20}, {1193, 1, 0, 20}, {1193, 1, 1, 20}// 22	23	24	
			, {1193, 0, -1, 20}, {1193, 1, -1, 20}, {1193, -1, -4, 20}// 25	26	27	
			, {1193, 0, -3, 20}, {1193, -1, -2, 20}, {1193, -1, -3, 20}// 28	29	30	
			, {1193, -1, 0, 20}, {1193, -1, 1, 20}, {1193, -2, -4, 20}// 31	32	33	
			, {1193, -2, -3, 20}, {1193, -2, -2, 20}, {1193, -2, -1, 20}// 34	35	36	
			, {1193, -2, 0, 20}, {1193, -2, 1, 20}, {1060, 3, 1, 20}// 37	38	39	
			, {1057, 3, 0, 20}, {1057, 3, -1, 20}, {1060, 3, -2, 20}// 40	41	42	
			, {1057, 3, -3, 20}, {8590, 3, -5, 20}, {8590, 1, -5, 20}// 43	44	45	
			, {8590, 0, -5, 20}, {8590, -2, -5, 20}, {8598, -1, -5, 20}// 46	47	48	
			, {8598, 2, -5, 20}, {8588, -3, -4, 20}, {8588, -3, -2, 20}// 49	50	51	
			, {8588, -3, -1, 20}, {8588, -3, 1, 20}, {1060, -3, 0, 20}// 52	53	54	
			, {1060, -3, -3, 20}, {1057, 3, -4, 20}, {8586, 4, -4, 0}// 55	56	57	
			, {8586, 4, -3, 0}, {8586, 4, -2, 0}, {8586, 4, -1, 0}// 58	59	60	
			, {8586, 4, 0, 0}, {8586, 4, 1, 0}, {1066, 4, -1, 20}// 61	62	63	
			, {1067, 4, 0, 20}, {147, -2, 2, 0}, {147, 3, 2, 0}// 64	65	66	
			, {1193, 0, 2, 20}, {1193, 3, 2, 20}, {1193, 2, 2, 20}// 67	68	69	
			, {1193, 1, 2, 20}, {1193, -1, 2, 20}, {1193, -2, 2, 20}// 70	71	72	
			, {1061, 3, 2, 20}, {8590, 3, 2, 24}, {8598, -2, 2, 20}// 73	74	75	
			, {8588, -3, 2, 20}, {2213, -1, 3, 0}, {1059, 2, 2, 20}// 76	77	78	
			, {1058, 1, 2, 20}, {1058, 0, 2, 20}, {1058, -2, 2, 20}// 79	80	81	
			, {8588, 3, 2, 22}, {8584, -2, 3, 0}, {8584, -1, 3, 0}// 82	83	84	
			, {8584, 0, 3, 0}, {8584, 1, 3, 0}, {8584, 2, 3, 0}// 85	86	87	
			, {8584, 3, 3, 0}, {8586, 4, 2, 0}, {1057, 0, 4, 0}// 88	89	90	
			, {1057, 0, 5, 0}, {8597, -3, 2, 0}, {1066, 2, 5, 9}// 91	92	93	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new orctowerSAddonDeed();
			}
		}

		[ Constructable ]
		public orctowerSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public orctowerSAddon( Serial serial ) : base( serial )
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

	public class orctowerSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new orctowerSAddon();
			}
		}

		[Constructable]
		public orctowerSAddonDeed()
		{
			Name = "orctowerS";
		}

		public orctowerSAddonDeed( Serial serial ) : base( serial )
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