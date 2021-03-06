
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace FireworksStandSouth
{
	public class FireworksStandSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1824, -3, 0, 11}, {1824, -2, 0, 11}, {1824, -1, 0, 11}// 2	3	4	
			, {1824, 0, 0, 11}, {1824, 1, 0, 11}, {1824, 2, 0, 16}// 5	6	7	
			, {1824, -3, 0, 16}, {1824, -2, 0, 16}, {1824, -1, 0, 16}// 8	9	10	
			, {1824, 0, 0, 16}, {1824, 1, 0, 16}, {1824, 3, 0, 12}// 11	12	13	
			, {1825, 2, 0, 11}, {1825, 3, 0, 12}, {1825, 4, 0, 11}// 16	17	18	
			, {1825, 4, 0, 16}, {1825, 3, 0, 16}, {3570, -2, 0, 21}// 19	27	31	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FireworksStandSouthAddonDeed();
			}
		}

		[ Constructable ]
		public FireworksStandSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4483, 4, 0, 21, 2461, -1, "An automatic fireworks stand", 1);// 1
			AddComplexComponent( (BaseAddon) this, 4845, -1, 1, 0, 2466, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 4845, 2, 1, 0, 2461, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 4845, 4, 1, 0, 1262, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 18666, -3, 0, 16, 2466, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 18666, -2, 0, 17, 2461, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 18666, -1, 0, 18, 1261, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 18666, 0, 0, 19, 2466, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 18666, 1, 0, 20, 2461, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 18666, 2, 0, 20, 1261, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 18666, 3, 0, 20, 2466, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 18666, 4, 0, 20, 2461, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 6238, -3, 0, 21, 0, -1, "Pyro Technic Kit", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2579, -1, 0, 21, 1281, 0, "a Ginseng Firework", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2579, 0, 0, 21, 1269, 0, "a Mandrake Root Firework", 1);// 33
			AddComplexComponent( (BaseAddon) this, 6812, 1, 0, 21, 1154, -1, "a large sparkler", 1);// 34
			AddComplexComponent( (BaseAddon) this, 4327, 2, 0, 21, 2466, -1, "a small sparkler", 1);// 35

		}

		public FireworksStandSouthAddon( Serial serial ) : base( serial )
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

	public class FireworksStandSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FireworksStandSouthAddon();
			}
		}

		[Constructable]
		public FireworksStandSouthAddonDeed()
		{
			Name = "FireworksStandSouth";
		}

		public FireworksStandSouthAddonDeed( Serial serial ) : base( serial )
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