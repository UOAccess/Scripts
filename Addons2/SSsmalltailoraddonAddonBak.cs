
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace SSmalltailoraddon
{
	public class SSsmalltailoraddonAddonBak : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1298, 1, -1, 0}, {1298, 0, 2, 0}, {4194, 1, 0, 0}// 1	2	3	
			, {1298, 1, 1, 0}, {1298, 2, -1, 0}, {1298, 2, 0, 0}// 4	5	6	
			, {1298, 2, 2, 0}, {1298, -1, 1, 0}, {1298, -1, 2, 0}// 7	8	9	
			, {4193, 0, 0, 0}, {4117, 2, 0, 0}, {1298, 0, 1, 0}// 10	11	12	
			, {1298, -1, 0, 0}, {1298, 0, -1, 0}, {1298, 1, 0, 0}// 13	14	15	
			, {1298, 1, 2, 0}, {1298, 0, 0, 0}, {1298, 2, 1, 0}// 16	17	18	
			, {1298, -1, -1, 0}// 19	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SSsmalltailoraddonAddonBakDeed();
			}
		}

		[ Constructable ]
		public SSsmalltailoraddonAddonBak()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public SSsmalltailoraddonAddonBak( Serial serial ) : base( serial )
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

	public class SSsmalltailoraddonAddonBakDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SSsmalltailoraddonAddonBak();
			}
		}

		[Constructable]
		public SSsmalltailoraddonAddonBakDeed()
		{
			Name = "SSsmalltailoraddon";
		}

		public SSsmalltailoraddonAddonBakDeed( Serial serial ) : base( serial )
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