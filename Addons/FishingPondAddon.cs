
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
	public class FishingPondAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4955, 0, -5, 0}, {4953, 0, -4, 0}, {3384, 1, -6, 0}// 1	2	3	
			, {4944, 2, -4, 0}, {13422, -1, -3, 0}, {6005, -1, 6, 1}// 4	5	6	
			, {13422, 1, 3, 0}, {3269, 1, 5, 1}, {4956, 1, -3, 5}// 7	8	9	
			, {4958, 2, 3, 0}, {3384, -3, -2, 0}, {3521, 0, 1, 0}// 10	11	12	
			, {6039, 2, -1, 0}, {3232, -4, 3, 5}, {4959, 1, -3, 0}// 13	14	15	
			, {6039, 2, 0, 0}, {6039, 2, 1, 0}, {6039, 2, -3, 0}// 16	17	18	
			, {6005, -3, 4, 0}, {6039, 2, 2, 0}, {3379, 1, 4, 0}// 19	20	21	
			, {3517, 0, 0, 0}, {4965, 0, -3, 0}, {6039, -3, 1, 0}// 22	23	24	
			, {6039, -3, 2, 0}, {6039, -4, 2, 1}, {6039, 1, 3, 0}// 25	26	27	
			, {6004, -4, 2, 0}, {4957, 1, 4, 0}, {6039, 1, 2, 0}// 28	29	30	
			, {4957, -2, 6, 0}, {6039, 1, 1, 0}, {6039, 1, 0, 0}// 31	32	33	
			, {6039, 1, -1, 0}, {6039, 1, -2, 0}, {6039, 1, -3, 0}// 34	35	36	
			, {6039, 0, 4, 0}, {4962, 0, 5, 0}, {6065, 2, 2, 0}// 37	38	39	
			, {6039, 0, 3, 0}, {6039, 0, 2, 0}, {6039, 0, 1, 0}// 40	41	42	
			, {6039, 0, 0, 0}, {6039, 0, -1, 0}, {4949, 2, 3, 0}// 43	44	45	
			, {4962, -4, 4, 0}, {6039, 0, -2, 0}, {4950, 2, 2, 0}// 46	47	48	
			, {6039, 0, -3, 0}, {6003, -2, -2, 0}, {6039, -1, 5, 0}// 49	50	51	
			, {4962, 1, -3, 0}, {4946, -2, -2, 0}, {4960, -4, 3, 0}// 52	53	54	
			, {4958, -3, 1, 5}, {4945, -3, -1, 0}, {4952, -4, 2, 0}// 55	56	57	
			, {4948, -1, -3, 0}, {4954, -4, 1, 0}, {4943, -4, 0, 0}// 58	59	60	
			, {6039, -1, 4, 0}, {6039, -1, 3, 0}, {6039, -1, 2, 0}// 61	62	63	
			, {6039, -1, 1, 0}, {6008, 2, -3, 2}, {6039, -1, 0, 0}// 64	65	66	
			, {3332, 2, 3, 0}, {6039, -1, -1, 0}, {6039, -1, -2, 0}// 67	68	69	
			, {13422, 2, 2, 0}, {13422, 0, 3, 0}, {6039, -1, -3, 0}// 70	71	72	
			, {6039, -3, 3, 0}, {3377, 0, 6, 0}, {6039, -2, 5, 0}// 73	74	75	
			, {6039, -2, 4, 0}, {6039, -2, 3, 0}, {6039, -2, 2, 0}// 76	77	78	
			, {6039, -2, 1, 0}, {6039, -2, 0, 0}, {6011, 0, 6, 2}// 79	80	81	
			, {3383, 0, -3, 0}, {6039, -2, -1, 0}, {6039, -2, -2, 0}// 82	83	84	
			, {6039, -2, -3, 0}, {6010, -2, -1, 0}, {6039, 0, 3, 0}// 85	86	87	
			, {3516, 0, 1, 0}, {3366, -5, 2, 0}, {4963, -3, -1, 0}// 88	89	90	
			, {6039, 1, 3, 0}, {3379, 2, 4, 4}, {6003, -3, 0, 0}// 91	92	93	
			, {4959, -5, 3, 0}, {4959, 0, 4, 0}, {6039, 2, -2, 0}// 94	95	96	
			, {13347, 0, -2, 0}, {6039, 2, 0, 0}, {6039, 1, 0, 0}// 97	98	99	
			, {6039, 0, 0, 0}, {6039, -1, 0, 0}, {6039, -2, 0, 0}// 100	101	102	
			, {3376, -3, 6, 0}, {6039, -3, 0, 0}, {6039, -4, 0, 0}// 103	104	105	
			, {13447, -2, 2, 0}, {4956, -3, 6, 0}, {6010, -4, 5, 0}// 106	107	108	
			, {3231, -1, -2, 0}, {6039, -3, 4, 0}, {6009, 3, -4, 0}// 109	110	111	
			, {4947, 3, -4, 0}, {3365, 4, -4, 0}, {4945, 4, -5, 0}// 112	113	114	
			, {4944, 3, -4, 0}, {6039, 3, -4, 0}, {13422, 4, -2, 0}// 115	116	117	
			, {6039, 3, -1, 0}, {3368, 4, 2, 0}, {3234, 4, 1, 0}// 118	119	120	
			, {13422, 4, -1, 0}, {3269, 4, -3, 0}, {3378, 3, 3, 4}// 121	122	123	
			, {3270, 3, 2, 0}, {6008, 3, 2, 0}, {4943, 4, -1, 0}// 124	125	126	
			, {4961, 3, -3, 0}, {4945, 5, -2, 0}, {6039, 3, -3, 0}// 127	128	129	
			, {4946, 3, -2, 0}, {6039, 4, -1, 0}, {4948, 4, -3, 0}// 130	131	132	
			, {13422, 4, 0, 0}, {4952, 5, 0, 0}, {4951, 4, 1, 0}// 133	134	135	
			, {6039, 4, -1, 0}, {4959, 4, 0, 0}, {6039, 3, 0, 0}// 136	137	138	
			, {6039, 3, -3, 0}, {6039, 3, 2, 0}, {6039, 3, 1, 0}// 139	140	141	
			, {6007, 4, 1, 0}, {6039, 3, 0, 0}, {6039, 3, -1, 0}// 142	143	144	
			, {6039, 4, 0, 0}, {6039, 3, 1, 0}, {3270, 5, 1, 1}// 145	146	147	
			, {3370, 5, -1, 0}, {6039, 3, -2, 0}, {4962, 3, 2, 0}// 148	149	150	
			, {3236, 4, -1, 19}, {6039, 4, 0, 0}, {6039, 3, 0, 0}// 151	152	153	
			, {4961, 3, -1, 0}, {4959, 4, 0, 0}, {3270, 3, 3, 7}// 154	155	156	
			, {3255, 3, 2, 2}// 157	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FishingPondAddonDeed();
			}
		}

		[ Constructable ]
		public FishingPondAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public FishingPondAddon( Serial serial ) : base( serial )
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

	public class FishingPondAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FishingPondAddon();
			}
		}

		[Constructable]
		public FishingPondAddonDeed()
		{
			Name = "FishingPond";
		}

		public FishingPondAddonDeed( Serial serial ) : base( serial )
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