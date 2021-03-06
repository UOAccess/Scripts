
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
	public class RedBlue1HallRunnerWEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2796, -3, 0, 0}, {2796, -2, 0, 0}, {2796, -1, 0, 0}// 1	2	3	
			, {2796, 0, 0, 0}, {2796, 1, 0, 0}, {2796, 2, 0, 0}// 4	5	6	
			, {2796, 3, 0, 0}, {2796, 4, 0, 0}, {2803, -3, -1, 0}// 7	8	9	
			, {2803, -2, -1, 0}, {2803, -1, -1, 0}, {2803, 0, -1, 0}// 10	11	12	
			, {2803, 1, -1, 0}, {2803, 2, -1, 0}, {2803, 3, -1, 0}// 13	14	15	
			, {2803, 4, -1, 0}, {2805, -3, 1, 0}, {2805, -2, 1, 0}// 16	17	18	
			, {2805, -1, 1, 0}, {2805, 0, 1, 0}, {2805, 1, 1, 0}// 19	20	21	
			, {2805, 2, 1, 0}, {2805, 3, 1, 0}, {2805, 4, 1, 0}// 22	23	24	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new RedBlue1HallRunnerWEAddonDeed();
			}
		}

		[ Constructable ]
		public RedBlue1HallRunnerWEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public RedBlue1HallRunnerWEAddon( Serial serial ) : base( serial )
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

	public class RedBlue1HallRunnerWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new RedBlue1HallRunnerWEAddon();
			}
		}

		[Constructable]
		public RedBlue1HallRunnerWEAddonDeed()
		{
			Name = "RedBlue1HallRunnerWE";
		}

		public RedBlue1HallRunnerWEAddonDeed( Serial serial ) : base( serial )
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