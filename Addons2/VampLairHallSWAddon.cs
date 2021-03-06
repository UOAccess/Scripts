
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
	public class VampLairHallSWAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1173, -1, 0, 0}, {1173, -1, 1, 0}, {1173, -1, 2, 0}// 1	2	3	
			, {1173, 0, 0, 0}, {1173, 0, 1, 0}, {1173, 0, 2, 0}// 4	5	6	
			, {1173, 1, 0, 0}, {1173, 1, 1, 0}, {1173, 1, 2, 0}// 7	8	9	
			, {28, 1, 2, 0}, {28, 0, 2, 0}, {28, -1, 2, 0}// 10	11	12	
			, {27, -2, 2, 0}, {27, -2, 1, 0}, {27, -2, 0, 0}// 13	14	15	
			, {1173, 2, 0, 0}, {1173, 2, 1, 0}, {1173, 2, 2, 0}// 16	17	18	
			, {28, 2, 2, 0}, {1173, -1, -1, 0}, {1173, 0, -1, 0}// 19	20	21	
			, {1173, 1, -1, 0}, {1173, 2, -1, 0}, {27, -2, -1, 0}// 22	23	24	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new VampLairHallSWAddonDeed();
			}
		}

		[ Constructable ]
		public VampLairHallSWAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public VampLairHallSWAddon( Serial serial ) : base( serial )
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

	public class VampLairHallSWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new VampLairHallSWAddon();
			}
		}

		[Constructable]
		public VampLairHallSWAddonDeed()
		{
			Name = "VampLairHallSW";
		}

		public VampLairHallSWAddonDeed( Serial serial ) : base( serial )
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