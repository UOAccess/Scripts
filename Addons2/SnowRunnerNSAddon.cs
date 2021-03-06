
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
	public class SnowRunnerNSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6085, 0, -2, 0}, {6086, 1, -2, 0}, {6087, 1, 3, 0}// 1	2	3	
			, {6088, 0, 3, 0}, {6090, 0, -1, 0}, {6090, 0, 0, 0}// 4	5	6	
			, {6090, 0, 1, 0}, {6090, 0, 2, 0}, {6092, 1, -1, 0}// 7	8	9	
			, {6092, 1, 0, 0}, {6092, 1, 1, 0}, {6092, 1, 2, 0}// 10	11	12	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SnowRunnerNSAddonDeed();
			}
		}

		[ Constructable ]
		public SnowRunnerNSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public SnowRunnerNSAddon( Serial serial ) : base( serial )
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

	public class SnowRunnerNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SnowRunnerNSAddon();
			}
		}

		[Constructable]
		public SnowRunnerNSAddonDeed()
		{
			Name = "SnowRunnerNS";
		}

		public SnowRunnerNSAddonDeed( Serial serial ) : base( serial )
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