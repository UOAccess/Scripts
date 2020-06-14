
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
	public class ReadingParkAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9966, -5, -3, 0}, {9968, -5, -3, 0}, {9968, -6, -1, 0}// 1	2	3	
			, {9966, -6, -1, 0}, {9968, -5, 1, 0}, {9966, -5, 1, 0}// 4	5	6	
			, {10082, -1, -3, 0}, {1301, -1, -2, 0}, {1301, 0, -2, 0}// 7	8	9	
			, {1301, 1, -2, 0}, {1301, 4, -2, 0}, {1301, 5, -2, 0}// 10	11	12	
			, {1301, 5, -3, 0}, {1301, 6, -3, 0}, {1301, 6, -4, 0}// 13	14	15	
			, {7630, -1, -2, 0}, {9166, 0, -2, 20}, {9168, -1, -2, 19}// 16	17	18	
			, {4029, -1, -2, 1}, {9966, -2, -5, 0}, {9968, -2, -5, 0}// 19	20	21	
			, {9968, -4, -4, 0}, {9966, -4, -4, 0}, {3207, 0, -4, 0}// 22	23	24	
			, {9036, 0, -3, 0}, {3214, 3, -3, 0}, {10082, -1, 0, 0}// 25	26	27	
			, {1301, -1, -1, 0}, {1301, -1, 0, 0}, {1301, 0, -1, 0}// 28	29	30	
			, {1301, 0, 0, 0}, {1301, 1, -1, 0}, {1301, 1, 0, 0}// 31	32	33	
			, {1301, 2, -1, 0}, {1301, 3, -1, 0}, {1301, 4, -1, 0}// 34	35	36	
			, {7629, -1, -1, 0}, {9156, 0, -1, 20}, {9158, -1, -1, 20}// 37	38	39	
			, {9158, -1, 0, 20}, {9156, 0, 0, 20}, {9162, 0, 1, 21}// 40	41	42	
			, {9164, -1, 1, 20}, {3308, -1, 1, 0}, {9966, -3, 3, 0}// 43	44	48	
			, {9968, -3, 3, 0}, {3207, -2, 5, 0}, {3262, 4, 3, 0}// 49	50	51	
			, {9037, 3, 1, 0}, {3214, 1, 2, 0}// 52	53	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ReadingParkAddonDeed();
			}
		}

		[ Constructable ]
		public ReadingParkAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3195, -1, 1, 6, 2972, -1, "Rose", 1);// 45
			AddComplexComponent( (BaseAddon) this, 3195, -1, 1, 16, 2972, -1, "Rose", 1);// 46
			AddComplexComponent( (BaseAddon) this, 3196, -1, 1, 14, 2972, -1, "Rose", 1);// 47

		}

		public ReadingParkAddon( Serial serial ) : base( serial )
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

	public class ReadingParkAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ReadingParkAddon();
			}
		}

		[Constructable]
		public ReadingParkAddonDeed()
		{
			Name = "ReadingPark";
		}

		public ReadingParkAddonDeed( Serial serial ) : base( serial )
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