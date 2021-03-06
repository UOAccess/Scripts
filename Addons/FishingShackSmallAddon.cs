
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
	public class FishingShackSmallAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {27, 2, -1, 1}, {28, 0, -2, 1}, {6459, 0, 3, 27}// 1	2	3	
			, {6459, 0, -1, 27}, {6457, 3, -1, 21}, {29, -3, -2, 1}// 4	5	6	
			, {6459, 0, 2, 27}, {2508, -1, -1, 7}, {6459, 0, 1, 27}// 7	8	10	
			, {1284, 1, 1, 1}, {2880, 0, -1, 1}, {6457, 2, -1, 24}// 11	13	14	
			, {6457, 3, 0, 21}, {27, -3, 2, 1}, {26, 2, 2, 1}// 15	16	17	
			, {6459, -1, 2, 24}, {7843, -2, 3, 1}, {6459, -1, -1, 24}// 18	19	20	
			, {1284, -2, 2, 1}, {6459, -2, -1, 21}, {6459, -2, 3, 21}// 21	22	23	
			, {6457, 1, -1, 27}, {6459, -1, 1, 24}, {2880, -1, -1, 1}// 24	25	26	
			, {28, -2, 2, 1}, {1284, 2, 0, 1}, {6457, 3, 1, 21}// 27	28	29	
			, {6459, 0, 0, 27}, {28, 2, -1, 1}, {1284, 0, -1, 1}// 30	31	32	
			, {1284, -2, 0, 1}, {1284, -1, 2, 1}, {1284, 2, 2, 1}// 33	34	35	
			, {1284, -2, -1, 1}, {6457, 1, 1, 27}, {6457, 2, 3, 24}// 36	37	38	
			, {1284, 2, -1, 1}, {28, -1, -2, 0}, {6459, -1, 3, 24}// 39	40	41	
			, {3780, -2, -1, 9}, {1284, 1, 2, 1}, {28, -2, -2, 1}// 42	43	44	
			, {1284, -1, -1, 1}, {1284, -1, 0, 1}, {1284, 1, -1, 1}// 45	46	47	
			, {28, 2, -2, 1}, {2880, 1, -1, 1}, {6459, -2, 1, 21}// 48	49	51	
			, {6457, 3, 3, 21}, {1284, 1, 0, 1}, {6457, 1, 0, 27}// 52	53	54	
			, {6457, 2, 1, 24}, {6457, 2, 2, 24}, {6457, 3, 2, 21}// 55	56	57	
			, {1284, 0, 1, 1}, {1284, 2, 1, 1}, {6457, 1, 2, 27}// 58	59	60	
			, {2510, 0, -1, 7}, {1284, 0, 2, 1}, {6459, -2, 2, 21}// 61	62	63	
			, {27, -3, -1, 1}, {7778, 0, -1, 5}, {6459, -2, 0, 21}// 64	65	67	
			, {28, 1, -2, 1}, {1284, 0, 0, 1}, {1284, -2, 1, 1}// 68	69	70	
			, {6457, 2, 0, 24}, {6457, 1, 3, 27}, {7843, 2, 3, 1}// 71	72	75	
			, {1284, -1, 1, 1}, {6459, -1, 0, 24}, {2880, -2, -1, 1}// 76	77	78	
			, {7843, -2, 0, 1}// 79	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FishingShackSmallAddonDeed();
			}
		}

		[ Constructable ]
		public FishingShackSmallAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 35, -3, 1, 1, 0, 0, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 35, -3, 0, 1, 0, 1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 35, 2, 0, 1, 0, 0, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 34, 1, 2, 1, 0, 1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 34, -1, 2, 1, 0, 1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 35, 2, 1, 1, 0, 0, "", 1);// 74

		}

		public FishingShackSmallAddon( Serial serial ) : base( serial )
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

	public class FishingShackSmallAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FishingShackSmallAddon();
			}
		}

		[Constructable]
		public FishingShackSmallAddonDeed()
		{
			Name = "FishingShackSmall";
		}

		public FishingShackSmallAddonDeed( Serial serial ) : base( serial )
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