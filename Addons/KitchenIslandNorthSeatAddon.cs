
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
	public class KitchenIslandNorthSeatAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1848, -1, 0, 0}, {1848, 0, 0, 0}, {1848, 0, 1, 0}// 1	2	3	
			, {1848, 1, 0, 0}, {1848, 1, 1, 0}, {1848, -1, 0, 2}// 4	5	6	
			, {1848, 0, 0, 2}, {1848, 1, 0, 2}, {1294, -1, 0, 7}// 7	8	9	
			, {1294, 0, 0, 7}, {1294, 1, 0, 7}, {1294, 1, 1, 5}// 10	11	12	
			, {2602, -1, -1, 0}, {2602, 0, -1, 0}, {2602, 1, -1, 0}// 14	15	16	
			, {2882, -1, 1, 2}, {4100, -1, 1, 10}, {2520, -1, 0, 7}// 17	18	19	
			, {2520, 0, 0, 7}, {2520, 1, 0, 7}, {2494, 1, 0, 7}// 20	21	22	
			, {2494, 0, 0, 7}, {2494, -1, 0, 7}, {2495, 1, 1, 11}// 23	24	25	
			, {1294, 0, 1, 5}, {2495, 0, 1, 11}, {11599, 1, 1, 5}// 26	27	28	
			, {5638, 0, 1, 5}, {1848, 2, 0, 0}, {1848, 2, 1, 0}// 29	30	31	
			, {1848, 2, 0, 2}, {1294, 2, 0, 7}, {1294, 2, 1, 5}// 32	33	34	
			, {2602, 2, -1, 0}, {2520, 2, 0, 7}, {2494, 2, 0, 7}// 35	36	37	
			, {2495, 2, 1, 11}, {2450, 2, 1, 5}// 38	39	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KitchenIslandNorthSeatAddonDeed();
			}
		}

		[ Constructable ]
		public KitchenIslandNorthSeatAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1981, -1, 1, 0, 1848, -1, "", 1);// 13

		}

		public KitchenIslandNorthSeatAddon( Serial serial ) : base( serial )
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

	public class KitchenIslandNorthSeatAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KitchenIslandNorthSeatAddon();
			}
		}

		[Constructable]
		public KitchenIslandNorthSeatAddonDeed()
		{
			Name = "KitchenIslandNorthSeat";
		}

		public KitchenIslandNorthSeatAddonDeed( Serial serial ) : base( serial )
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