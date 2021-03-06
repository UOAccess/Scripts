
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
	public class MarbleFireplaceEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1176, 1, -1, 0}, {279, 0, 2, 0}, {1176, 1, 0, 0}// 1	2	3	
			, {1176, -1, 3, 0}, {262, -1, -1, 0}, {281, 0, 0, 0}// 5	7	8	
			, {1176, -1, 0, 0}, {1176, 0, 3, 0}, {7138, -1, 3, 0}// 10	11	12	
			, {7137, -1, 0, 2}, {277, -1, 1, 0}, {1176, 1, 1, 0}// 14	15	16	
			, {1176, -1, -1, 0}, {11631, 0, -1, 0}, {261, -1, -2, 0}// 17	18	20	
			, {280, 0, -2, 0}, {260, -1, 2, 0}, {1176, -1, 2, 0}// 21	22	23	
			, {11631, 0, 2, 0}, {1176, 1, 3, 0}, {1173, 0, -2, 0}// 26	28	30	
			, {1176, -1, 1, 0}, {1176, 0, -1, 0}, {281, 0, -1, 0}// 31	32	33	
			, {1176, 0, 2, 0}, {279, -1, 3, 0}, {278, -1, 0, 0}// 35	36	37	
			, {281, 0, 1, 0}, {1176, 0, 0, 0}, {1176, 0, 1, 0}// 38	39	40	
			, {1173, 1, -2, 0}, {1173, -1, -2, 0}, {1176, 1, 2, 0}// 41	42	43	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MarbleFireplaceEastAddonDeed();
			}
		}

		[ Constructable ]
		public MarbleFireplaceEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1981, 0, 2, 0, 1108, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1981, -1, -1, 0, 1108, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1981, -1, 2, 0, 1108, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2559, 0, -1, 14, 0, 1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2559, 0, 2, 14, 0, 1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 6572, -1, 0, 7, 0, 1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1981, 0, 1, 0, 1108, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1981, -1, 1, 0, 1108, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1981, 0, 0, 0, 1108, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1981, 0, -1, 0, 1108, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1981, -1, 0, 0, 1108, -1, "", 1);// 44

		}

		public MarbleFireplaceEastAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class MarbleFireplaceEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MarbleFireplaceEastAddon();
			}
		}

		[Constructable]
		public MarbleFireplaceEastAddonDeed()
		{
			Name = "MarbleFireplaceEast";
		}

		public MarbleFireplaceEastAddonDeed( Serial serial ) : base( serial )
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