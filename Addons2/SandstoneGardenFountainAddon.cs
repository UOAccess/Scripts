
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
	public class SandstoneGardenFountainAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6595, -1, 2, 0}, {6596, 0, 2, 0}, {6605, 0, 1, 0}// 1	2	3	
			, {6606, -1, 1, 0}, {6607, -1, 0, 0}, {6608, 0, 0, 0}// 4	5	6	
			, {6609, 0, -1, 0}, {6611, -1, -1, 0}, {7038, -3, -3, 0}// 7	8	9	
			, {7038, -3, 4, 0}, {3272, -3, -2, 0}, {3272, -3, 3, 0}// 10	11	12	
			, {3272, -2, 4, 0}, {3272, -2, -3, 0}, {3237, -2, -2, 0}// 13	14	15	
			, {3237, -2, 3, 0}, {7627, 0, 4, 0}, {7627, 0, -3, 0}// 16	17	18	
			, {7624, -3, 0, 0}, {7623, -3, 1, 0}, {3223, -1, 4, 0}// 19	20	21	
			, {3223, -1, -3, 0}, {3223, -3, 2, 0}, {3223, -3, -1, 0}// 22	23	24	
			, {6597, 1, 2, 0}, {6598, 2, 2, 0}, {6599, 2, 1, 0}// 25	26	27	
			, {6600, 2, 0, 0}, {6601, 2, -1, 0}, {6602, 1, -1, 0}// 28	29	30	
			, {6603, 1, 0, 0}, {6604, 1, 1, 0}, {7038, 4, -3, 0}// 31	32	33	
			, {7038, 4, 4, 0}, {3272, 3, 4, 0}, {3272, 4, 3, 0}// 34	35	36	
			, {3272, 4, -2, 0}, {3272, 3, -3, 0}, {3237, 3, -2, 0}// 37	38	39	
			, {3237, 3, 3, 0}, {7626, 1, 4, 0}, {7626, 1, -3, 0}// 40	41	42	
			, {7624, 4, 0, 0}, {7623, 4, 1, 0}, {3223, 2, 4, 0}// 43	44	45	
			, {3223, 4, 2, 0}, {3223, 4, -1, 0}, {3223, 2, -3, 0}// 46	47	48	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SandstoneGardenFountainAddonDeed();
			}
		}

		[ Constructable ]
		public SandstoneGardenFountainAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public SandstoneGardenFountainAddon( Serial serial ) : base( serial )
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

	public class SandstoneGardenFountainAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SandstoneGardenFountainAddon();
			}
		}

		[Constructable]
		public SandstoneGardenFountainAddonDeed()
		{
			Name = "SandstoneGardenFountain";
		}

		public SandstoneGardenFountainAddonDeed( Serial serial ) : base( serial )
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