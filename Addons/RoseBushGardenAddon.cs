
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
	public class RoseBushGardenAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6017, -6, 1, 0}, {6017, -4, -1, 0}, {6017, -1, -4, 0}// 1	2	3	
			, {6017, -2, -2, 0}, {6017, 4, -1, 0}, {6017, 0, -4, 0}// 4	5	6	
			, {6017, -3, -2, 0}, {6017, 1, -4, 0}, {6017, -5, -1, 0}// 7	8	9	
			, {6017, -1, -3, 0}, {6017, 2, -5, 0}, {6017, 0, -3, 0}// 10	11	12	
			, {6017, 3, -1, 0}, {6017, 0, -2, 0}, {6017, -5, -5, 0}// 13	14	15	
			, {3217, -5, -2, 0}, {3263, -5, -2, 6}, {3217, -4, -3, 0}// 16	17	18	
			, {3263, -4, -3, 6}, {3217, -3, -3, 0}, {3263, -3, -3, 6}// 19	20	21	
			, {3217, -2, -3, 0}, {3263, -2, -3, 6}, {3217, -1, -3, 0}// 22	23	24	
			, {3263, -1, -3, 6}, {3217, 1, -3, 0}, {3263, 1, -3, 6}// 25	26	27	
			, {3217, 2, -3, 0}, {3263, 2, -3, 6}, {3217, 3, -3, 0}// 28	29	30	
			, {3263, 3, -3, 6}, {3217, 4, -3, 0}, {3263, 4, -3, 6}// 31	32	33	
			, {3217, 5, -3, 0}, {3263, 5, -3, 6}, {3217, 6, -3, 0}// 34	35	36	
			, {3263, 6, -3, 6}, {3217, 0, -3, 0}, {3263, 0, -3, 6}// 37	38	39	
			, {3217, -5, -1, 0}, {3263, -5, -1, 6}, {3217, 7, -3, 0}// 40	41	42	
			, {3263, 7, -3, 6}, {3217, 7, -1, 0}, {3263, 7, -1, 6}// 43	44	45	
			, {3217, 7, -2, 0}, {3263, 7, -2, 6}, {3217, -5, -3, 0}// 46	47	48	
			, {3263, -5, -3, 6}, {6017, -4, 2, 0}, {6017, -1, 2, 0}// 49	50	51	
			, {6017, 1, 1, 0}, {6017, 1, 3, 0}, {6017, -3, 3, 0}// 52	53	54	
			, {6017, -1, 0, 0}, {6017, -4, 3, 0}, {6017, 4, 1, 0}// 55	56	57	
			, {6017, -5, 3, 0}, {6017, -1, 3, 0}, {6017, -3, 1, 0}// 58	59	60	
			, {6017, -4, 0, 0}, {3217, -5, 0, 0}, {3263, -5, 0, 6}// 61	62	63	
			, {3217, -5, 1, 0}, {3263, -5, 1, 6}, {3217, -5, 2, 0}// 64	65	66	
			, {3263, -5, 2, 6}, {3217, -5, 3, 0}, {3263, -5, 3, 6}// 67	68	69	
			, {3217, -5, 4, 0}, {3263, -5, 4, 6}, {3217, -5, 5, 0}// 70	71	72	
			, {3263, -5, 5, 6}, {3217, 7, 0, 0}, {3263, 7, 0, 6}// 73	74	75	
			, {3217, 7, 3, 0}, {3263, 7, 3, 6}, {3217, 7, 4, 0}// 76	77	78	
			, {3263, 7, 4, 6}, {3217, 7, 5, 0}, {3263, 7, 5, 6}// 79	80	81	
			, {3217, 6, 6, 0}, {3263, 6, 6, 6}, {3217, 5, 6, 0}// 82	83	84	
			, {3263, 5, 6, 6}, {3217, 3, 6, 0}, {3263, 3, 6, 6}// 85	86	87	
			, {3217, 1, 6, 0}, {3263, 1, 6, 6}, {3217, -1, 6, 0}// 88	89	90	
			, {3263, -1, 6, 6}, {3217, -3, 6, 0}, {3263, -3, 6, 6}// 91	92	93	
			, {3217, -4, 6, 0}, {3263, -4, 6, 6}, {3217, -2, 6, 0}// 94	95	96	
			, {3263, -2, 6, 6}, {3217, 2, 6, 0}, {3263, 2, 6, 6}// 97	98	99	
			, {3217, 4, 6, 0}, {3263, 4, 6, 6}, {3217, 0, 6, 0}// 100	101	102	
			, {3263, 0, 6, 6}, {3217, 7, 6, 0}, {3263, 7, 6, 6}// 103	104	105	
			, {3217, -5, 6, 0}, {3263, -5, 6, 6}// 106	107	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new RoseBushGardenAddonDeed();
			}
		}

		[ Constructable ]
		public RoseBushGardenAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public RoseBushGardenAddon( Serial serial ) : base( serial )
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

	public class RoseBushGardenAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new RoseBushGardenAddon();
			}
		}

		[Constructable]
		public RoseBushGardenAddonDeed()
		{
			Name = "RoseBushGarden";
		}

		public RoseBushGardenAddonDeed( Serial serial ) : base( serial )
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