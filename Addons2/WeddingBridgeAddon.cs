
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
	public class WeddingBridgeAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2234, 3, 2, 5}, {2229, -2, 2, 5}, {2231, -1, 2, 5}// 37	38	39	
			, {2231, 0, 2, 5}, {2231, 1, 2, 5}, {2231, 2, 2, 5}// 40	41	42	
			, {2231, -1, -2, 5}, {2231, 0, -2, 5}, {2231, 1, -2, 5}// 43	44	45	
			, {2231, 2, -2, 5}, {2229, -2, -2, 5}, {2234, 3, -2, 5}// 46	47	48	
			, {4553, 5, 2, 0}, {4553, 5, -1, 0}, {4553, -4, 2, 0}// 49	50	51	
			, {4553, -4, -1, 0}, {4555, 4, 2, 8}, {4555, 4, -1, 8}// 52	53	54	
			, {4555, -3, 2, 8}, {4555, -3, -1, 8}, {4554, -3, 3, 0}// 55	56	57	
			, {4554, 4, 3, 0}, {9035, 3, 2, 7}, {9035, 3, -2, 7}// 58	59	60	
			, {9035, -3, 2, 9}, {9035, -3, -2, 7}, {3149, -4, 2, 11}// 61	62	63	
			, {3149, -4, -1, 11}, {3149, 5, 2, 11}, {9035, 0, 2, 7}// 64	65	67	
			, {9035, 0, -2, 8}// 68	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WeddingBridgeAddonDeed();
			}
		}

		[ Constructable ]
		public WeddingBridgeAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1801, 4, 2, 0, 1153, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1801, 4, -1, 0, 1153, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1803, 4, 0, 0, 1153, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1803, 4, 1, 0, 1153, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1801, -3, 2, 0, 1153, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1801, -3, -1, 0, 1153, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1805, -3, 0, 0, 1153, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1805, -3, 1, 0, 1153, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1173, -2, -1, 5, 1153, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1173, -2, 0, 5, 1153, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1173, -2, 1, 5, 1153, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1173, -2, 2, 5, 1153, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1173, -1, -1, 5, 1153, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1173, -1, 0, 5, 1153, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1173, -1, 1, 5, 1153, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1173, -1, 2, 5, 1153, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1173, 0, -1, 5, 1153, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1173, 0, 0, 5, 1153, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1173, 0, 1, 5, 1153, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1173, 0, 2, 5, 1153, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1173, 1, -1, 5, 1153, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1173, 1, 0, 5, 1153, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1173, 1, 1, 5, 1153, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1173, 1, 2, 5, 1153, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1173, 2, -1, 5, 1153, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1173, 2, 0, 5, 1153, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1173, 2, 1, 5, 1153, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1173, 2, 2, 5, 1153, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1173, 3, -1, 5, 1153, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1173, 3, 0, 5, 1153, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1173, 3, 1, 5, 1153, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1173, 3, 2, 5, 1153, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1173, 4, 2, 5, 1153, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1173, 4, -1, 5, 1153, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1173, -3, 2, 5, 1153, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1173, -3, -1, 5, 1153, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 3149, 5, -1, 11, 1278, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 6946, 3, 1, 5, 1278, -1, "Rose Petals", 1);// 69
			AddComplexComponent( (BaseAddon) this, 6946, 2, 0, 5, 1278, -1, "Rose Petals", 1);// 70
			AddComplexComponent( (BaseAddon) this, 6946, 1, 1, 5, 1278, -1, "Rose Petals", 1);// 71
			AddComplexComponent( (BaseAddon) this, 6946, 0, 0, 5, 1278, -1, "Rose Petals", 1);// 72
			AddComplexComponent( (BaseAddon) this, 6946, -1, 1, 5, 1278, -1, "Rose Petals", 1);// 73
			AddComplexComponent( (BaseAddon) this, 6946, -2, 0, 5, 1278, -1, "Rose Petals", 1);// 74

		}

		public WeddingBridgeAddon( Serial serial ) : base( serial )
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

	public class WeddingBridgeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WeddingBridgeAddon();
			}
		}

		[Constructable]
		public WeddingBridgeAddonDeed()
		{
			Name = "WeddingBridge";
		}

		public WeddingBridgeAddonDeed( Serial serial ) : base( serial )
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