
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
	public class BCRugNSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2796, -3, -4, 0}, {2796, -2, -4, 0}, {2796, -1, -4, 0}// 1	2	3	
			, {2796, 0, -4, 0}, {2796, 1, -4, 0}, {2796, 2, -4, 0}// 4	5	6	
			, {2796, 3, -4, 0}, {2796, 3, -3, 0}, {2796, 3, -2, 0}// 7	8	9	
			, {2796, -3, -3, 0}, {2796, -3, -2, 0}, {2796, -2, -3, 0}// 10	11	12	
			, {2796, -2, -2, 0}, {2796, -1, -3, 0}, {2796, -1, -2, 0}// 13	14	15	
			, {2796, 0, -3, 0}, {2796, 0, -2, 0}, {2796, 1, -3, 0}// 16	17	18	
			, {2796, 1, -2, 0}, {2796, 2, -3, 0}, {2796, 2, -2, 0}// 19	20	21	
			, {2799, -4, -5, 0}, {2801, 4, -5, 0}, {2802, -4, -4, 0}// 22	23	24	
			, {2802, -4, -3, 0}, {2802, -4, -2, 0}, {2803, -3, -5, 0}// 25	26	27	
			, {2803, -2, -5, 0}, {2803, -1, -5, 0}, {2803, 0, -5, 0}// 28	29	30	
			, {2803, 1, -5, 0}, {2803, 2, -5, 0}, {2803, 3, -5, 0}// 31	32	33	
			, {2804, 4, -4, 0}, {2804, 4, -3, 0}, {2804, 4, -2, 0}// 34	35	36	
			, {2796, 3, -1, 0}, {2796, -3, -1, 0}, {2796, -2, -1, 0}// 37	38	39	
			, {2796, -1, -1, 0}, {2796, 0, -1, 0}, {2796, 1, -1, 0}// 40	41	42	
			, {2796, 2, -1, 0}, {2802, -4, -1, 0}, {2804, 4, -1, 0}// 43	44	45	
			, {2796, 3, 0, 0}, {2796, -3, 0, 0}, {2796, -2, 0, 0}// 46	47	48	
			, {2796, -1, 0, 0}, {2796, 0, 0, 0}, {2796, 1, 0, 0}// 49	50	51	
			, {2796, 2, 0, 0}, {2802, -4, 0, 0}, {2804, 4, 0, 0}// 52	53	54	
			, {2796, 3, 1, 0}, {2796, -3, 1, 0}, {2796, -2, 1, 0}// 55	56	57	
			, {2796, -1, 1, 0}, {2796, 0, 1, 0}, {2796, 1, 1, 0}// 58	59	60	
			, {2796, 2, 1, 0}, {2802, -4, 1, 0}, {2804, 4, 1, 0}// 61	62	63	
			, {2796, 3, 2, 0}, {2796, -3, 2, 0}, {2796, -2, 2, 0}// 64	65	66	
			, {2796, -1, 2, 0}, {2796, 0, 2, 0}, {2796, 1, 2, 0}// 67	68	69	
			, {2796, 2, 2, 0}, {2802, -4, 2, 0}, {2804, 4, 2, 0}// 70	71	72	
			, {2796, 3, 3, 0}, {2796, -3, 3, 0}, {2796, -2, 3, 0}// 73	74	75	
			, {2796, -1, 3, 0}, {2796, 0, 3, 0}, {2796, 1, 3, 0}// 76	77	78	
			, {2796, 2, 3, 0}, {2802, -4, 3, 0}, {2804, 4, 3, 0}// 79	80	81	
			, {2796, 3, 4, 0}, {2796, -3, 4, 0}, {2796, -2, 4, 0}// 82	83	84	
			, {2796, -1, 4, 0}, {2796, 0, 4, 0}, {2796, 1, 4, 0}// 85	86	87	
			, {2796, 2, 4, 0}, {2802, -4, 4, 0}, {2804, 4, 4, 0}// 88	89	90	
			, {2798, 4, 5, 0}, {2800, -4, 5, 0}, {2805, -3, 5, 0}// 91	92	93	
			, {2805, -2, 5, 0}, {2805, -1, 5, 0}, {2805, 0, 5, 0}// 94	95	96	
			, {2805, 1, 5, 0}, {2805, 2, 5, 0}, {2805, 3, 5, 0}// 97	98	99	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BCRugNSAddonDeed();
			}
		}

		[ Constructable ]
		public BCRugNSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public BCRugNSAddon( Serial serial ) : base( serial )
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

	public class BCRugNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BCRugNSAddon();
			}
		}

		[Constructable]
		public BCRugNSAddonDeed()
		{
			Name = "BCRugNS";
		}

		public BCRugNSAddonDeed( Serial serial ) : base( serial )
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