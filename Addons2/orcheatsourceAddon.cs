
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
	public class orcheatsourceAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2876, 1, 1, 0}, {1060, 0, 1, 0}, {1060, 1, 1, 0}// 1	2	3	
			, {1059, 1, 0, 0}, {1059, 1, 1, 0}, {7979, 1, 1, 8}// 4	5	6	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new orcheatsourceAddonDeed();
			}
		}

		[ Constructable ]
		public orcheatsourceAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public orcheatsourceAddon( Serial serial ) : base( serial )
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

	public class orcheatsourceAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new orcheatsourceAddon();
			}
		}

		[Constructable]
		public orcheatsourceAddonDeed()
		{
			Name = "orcheatsource";
		}

		public orcheatsourceAddonDeed( Serial serial ) : base( serial )
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