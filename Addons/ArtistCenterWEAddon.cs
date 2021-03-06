
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
	public class ArtistCenterWEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7620, 1, 0, 0}, {7622, 0, 0, 0}, {7622, -1, 0, 0}// 1	2	3	
			, {7621, -2, 0, 0}, {1113, -1, 1, 0}, {4643, -2, 1, 0}// 4	5	6	
			, {4811, -2, 1, 12}, {6009, -2, 0, 6}, {4787, -1, 0, 6}// 7	8	9	
			, {5021, 0, 0, 6}, {4033, 1, 0, 6}, {3942, 2, 0, 0}// 10	11	12	
			, {3750, 2, 1, 0}, {3746, 1, 1, 0}// 13	14	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ArtistCenterWEAddonDeed();
			}
		}

		[ Constructable ]
		public ArtistCenterWEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public ArtistCenterWEAddon( Serial serial ) : base( serial )
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

	public class ArtistCenterWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ArtistCenterWEAddon();
			}
		}

		[Constructable]
		public ArtistCenterWEAddonDeed()
		{
			Name = "ArtistCenterWE";
		}

		public ArtistCenterWEAddonDeed( Serial serial ) : base( serial )
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