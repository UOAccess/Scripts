
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
	public class RoseBushesWEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3217, -8, 0, 0}, {3263, -8, 0, 6}, {3217, -7, 0, 0}// 1	2	3	
			, {3263, -7, 0, 6}, {3217, -6, 0, 0}, {3263, -6, 0, 6}// 4	5	6	
			, {3217, -5, 0, 0}, {3263, -5, 0, 6}, {3217, -4, 0, 0}// 7	8	9	
			, {3263, -4, 0, 6}, {3217, -3, 0, 0}, {3263, -3, 0, 6}// 10	11	12	
			, {3217, -2, 0, 0}, {3263, -2, 0, 6}, {3217, -1, 0, 0}// 13	14	15	
			, {3263, -1, 0, 6}, {3217, 0, 0, 0}, {3263, 0, 0, 6}// 16	17	18	
			, {3217, 0, 0, 0}, {3263, 0, 0, 6}, {3217, 1, 0, 0}// 19	20	21	
			, {3263, 1, 0, 6}, {3217, 2, 0, 0}, {3263, 2, 0, 6}// 22	23	24	
			, {3217, 3, 0, 0}, {3263, 3, 0, 6}, {3217, 4, 0, 0}// 25	26	27	
			, {3263, 4, 0, 6}, {3217, 5, 0, 0}, {3263, 5, 0, 6}// 28	29	30	
			, {3217, 6, 0, 0}, {3263, 6, 0, 6}, {3217, 7, 0, 0}// 31	32	33	
			, {3263, 7, 0, 6}, {3217, 8, 0, 0}, {3263, 8, 0, 6}// 34	35	36	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new RoseBushesWEAddonDeed();
			}
		}

		[ Constructable ]
		public RoseBushesWEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public RoseBushesWEAddon( Serial serial ) : base( serial )
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

	public class RoseBushesWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new RoseBushesWEAddon();
			}
		}

		[Constructable]
		public RoseBushesWEAddonDeed()
		{
			Name = "RoseBushesWE";
		}

		public RoseBushesWEAddonDeed( Serial serial ) : base( serial )
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