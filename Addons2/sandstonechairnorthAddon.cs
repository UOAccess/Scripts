
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
	public class sandstonechairnorthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1900, -1, 0, 0}, {1900, -1, 1, 0}, {1900, 0, 1, 0}// 1	2	3	
			, {1900, 1, 0, 0}, {1900, 1, 1, 0}, {1115, 0, 0, 0}// 4	5	6	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new sandstonechairnorthAddonDeed();
			}
		}

		[ Constructable ]
		public sandstonechairnorthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public sandstonechairnorthAddon( Serial serial ) : base( serial )
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

	public class sandstonechairnorthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new sandstonechairnorthAddon();
			}
		}

		[Constructable]
		public sandstonechairnorthAddonDeed()
		{
			Name = "sandstonechairnorth";
		}

		public sandstonechairnorthAddonDeed( Serial serial ) : base( serial )
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