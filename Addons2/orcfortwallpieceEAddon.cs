
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
	public class orcfortwallpieceEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2877, 1, 1, 0}, {2879, 1, 2, 0}, {2877, 1, -1, 0}// 1	2	3	
			, {2877, 1, 0, 0}, {2879, 1, -2, 0}, {1191, 1, -2, 7}// 4	5	6	
			, {1191, 1, -1, 7}, {1191, 1, 0, 7}, {1191, 1, 1, 7}// 7	8	9	
			, {1191, 1, 2, 7}, {1057, 0, -2, 0}, {1057, 0, -1, 0}// 10	11	12	
			, {1057, 0, 0, 0}, {1057, 0, 1, 0}, {1057, 0, 2, 0}// 13	14	15	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new orcfortwallpieceEAddonDeed();
			}
		}

		[ Constructable ]
		public orcfortwallpieceEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public orcfortwallpieceEAddon( Serial serial ) : base( serial )
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

	public class orcfortwallpieceEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new orcfortwallpieceEAddon();
			}
		}

		[Constructable]
		public orcfortwallpieceEAddonDeed()
		{
			Name = "orcfortwallpieceE";
		}

		public orcfortwallpieceEAddonDeed( Serial serial ) : base( serial )
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