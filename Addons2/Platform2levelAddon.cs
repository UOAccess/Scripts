
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
	public class Platform2levelAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2149, 1, 2, 0}, {2252, 2, -1, 31}, {2186, 3, 2, 16}// 1	2	3	
			, {2149, -2, -1, 18}, {1244, -1, 0, 31}, {2149, 3, 2, 6}// 4	5	6	
			, {2149, 3, 2, 12}, {1244, 0, 1, 31}, {2149, 3, -1, 24}// 7	8	9	
			, {1244, 0, 0, 31}, {2149, -2, 3, 12}, {2186, -1, 3, 12}// 10	11	12	
			, {1244, 1, 1, 31}, {2186, 0, 3, 12}, {2252, -2, 3, 22}// 13	14	15	
			, {2146, 3, 2, 32}, {2149, -2, -1, 12}, {1244, -1, -1, 31}// 16	17	18	
			, {2210, -1, 2, 21}, {2149, 3, -1, 0}, {2149, -2, 3, 0}// 19	20	21	
			, {2252, -2, -1, 31}, {1244, -1, 3, 22}, {1244, 2, 0, 31}// 22	23	24	
			, {1244, 2, -1, 31}, {2186, 2, 2, 32}, {2149, 1, 3, 12}// 25	26	27	
			, {1244, 1, -1, 31}, {2254, -1, -2, 31}, {2252, -2, 1, 31}// 28	29	30	
			, {2254, 0, 2, 22}, {2252, 2, 0, 31}, {2209, 3, 3, 0}// 31	32	33	
			, {2253, 2, 1, 31}, {2254, 0, -2, 31}, {2149, -2, 3, 6}// 34	35	36	
			, {1244, 2, 1, 31}, {2149, 3, 2, 30}, {2149, 3, -1, 12}// 37	38	39	
			, {2149, 3, -1, 6}, {2187, 3, 0, 32}, {2254, 0, 1, 31}// 40	41	42	
			, {2187, 3, 2, 16}, {2186, 1, 2, 32}, {2149, 3, -1, 6}// 43	44	45	
			, {1244, 0, -1, 31}, {2207, 2, 3, 12}, {2149, 3, -1, 18}// 46	47	48	
			, {2149, 1, 3, 0}, {2186, 1, 3, 12}, {2254, 1, -2, 31}// 49	50	51	
			, {2187, 3, 1, 16}, {2149, -2, -1, 0}, {2187, 3, 0, 16}// 52	53	54	
			, {2254, 1, 1, 31}, {2186, 2, 2, 15}, {1244, -1, 3, 22}// 55	56	57	
			, {2149, 3, 2, 0}, {1238, 0, 3, 22}, {2149, 1, 2, 6}// 58	59	60	
			, {1244, -1, 1, 31}, {2149, 3, -1, 30}, {2149, 1, 2, 12}// 61	62	63	
			, {2254, 2, -2, 31}, {1244, 1, 3, 22}, {2187, 3, 1, 32}// 64	65	66	
			, {2149, 1, 3, 6}, {2149, 3, 2, 18}, {2254, 1, 2, 22}// 67	68	69	
			, {2149, 3, 2, 24}, {2149, -2, -1, 6}, {1244, 1, 0, 31}// 70	71	72	
			, {2252, -2, 0, 31}// 73	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Platform2levelAddonDeed();
			}
		}

		[ Constructable ]
		public Platform2levelAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public Platform2levelAddon( Serial serial ) : base( serial )
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

	public class Platform2levelAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Platform2levelAddon();
			}
		}

		[Constructable]
		public Platform2levelAddonDeed()
		{
			Name = "Platform2level";
		}

		public Platform2levelAddonDeed( Serial serial ) : base( serial )
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