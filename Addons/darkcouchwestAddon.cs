
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
	public class darkcouchwestAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1848, 0, 2, 0}, {1848, 0, -2, 0}, {1848, 1, 2, 0}// 1	2	3	
			, {1848, 1, 1, 0}, {1848, 1, 0, 0}, {1848, 1, -1, 0}// 4	5	6	
			, {1848, 1, -2, 0}, {2860, 0, -1, 0}, {2860, 0, 0, 0}// 7	8	9	
			, {2860, 0, 1, 0}// 10	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new darkcouchwestAddonDeed();
			}
		}

		[ Constructable ]
		public darkcouchwestAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public darkcouchwestAddon( Serial serial ) : base( serial )
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

	public class darkcouchwestAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new darkcouchwestAddon();
			}
		}

		[Constructable]
		public darkcouchwestAddonDeed()
		{
			Name = "darkcouchwest";
		}

		public darkcouchwestAddonDeed( Serial serial ) : base( serial )
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