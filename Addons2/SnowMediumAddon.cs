
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
	public class SnowMediumAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6077, 0, 0, 0}, {6077, 0, 1, 0}, {6077, 1, 0, 0}// 1	2	3	
			, {6077, 1, 1, 0}, {6085, -1, -1, 0}, {6086, 2, -1, 0}// 4	5	6	
			, {6087, 2, 2, 0}, {6088, -1, 2, 0}, {6089, 1, 2, 0}// 7	8	9	
			, {6089, 0, 2, 0}, {6090, -1, 1, 0}, {6090, -1, 0, 0}// 10	11	12	
			, {6091, 0, -1, 0}, {6091, 1, -1, 0}, {6092, 2, 0, 0}// 13	14	15	
			, {6092, 2, 1, 0}// 16	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SnowMediumAddonDeed();
			}
		}

		[ Constructable ]
		public SnowMediumAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public SnowMediumAddon( Serial serial ) : base( serial )
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

	public class SnowMediumAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SnowMediumAddon();
			}
		}

		[Constructable]
		public SnowMediumAddonDeed()
		{
			Name = "SnowMedium";
		}

		public SnowMediumAddonDeed( Serial serial ) : base( serial )
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