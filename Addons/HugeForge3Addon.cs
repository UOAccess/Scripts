
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
	public class HugeForge3Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {38, 2, 0, 0}, {38, 2, 0, 8}, {38, -1, 0, 0}// 1	2	3	
			, {38, -1, 0, 8}, {38, -1, 0, 16}, {37, 0, 0, 16}// 4	5	6	
			, {37, 1, 0, 16}, {36, 2, 0, 16}, {45, 1, 0, 24}// 7	8	9	
			, {46, 0, 0, 24}, {6757, 1, 0, 8}, {6765, 0, 0, 8}// 10	11	12	
			, {6769, 2, 0, 8}, {14120, 1, 0, 19}, {1180, 2, 0, 24}// 13	14	15	
			, {1180, 0, 0, 24}, {37, 0, 1, 0}, {37, 1, 1, 0}// 16	17	18	
			, {36, 2, 1, 0}, {1180, 0, 1, 8}, {1180, 1, 1, 8}// 19	20	21	
			, {1180, 2, 1, 8}, {7161, 0, 1, 8}, {4021, 2, 1, 8}// 22	23	24	
			, {4028, 1, 1, 8}// 25	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HugeForge3AddonDeed();
			}
		}

		[ Constructable ]
		public HugeForge3Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public HugeForge3Addon( Serial serial ) : base( serial )
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

	public class HugeForge3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HugeForge3Addon();
			}
		}

		[Constructable]
		public HugeForge3AddonDeed()
		{
			Name = "HugeForge3";
		}

		public HugeForge3AddonDeed( Serial serial ) : base( serial )
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