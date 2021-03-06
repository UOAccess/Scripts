
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
	public class JollyRogerShipAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {16020, -7, -1, 0}, {16016, -6, -1, 0}, {16017, -7, 1, 0}// 1	2	3	
			, {16019, -7, 0, 0}, {16021, -8, 0, 0}, {16014, -6, 1, 0}// 4	5	6	
			, {16015, -6, 0, 0}, {15995, 8, -1, 0}, {15997, 7, -1, 0}// 7	8	9	
			, {15999, 6, -1, 0}, {16001, 5, -1, 0}, {16001, 2, -1, 0}// 10	11	12	
			, {16001, -2, -1, 0}, {16011, -3, -1, 0}, {16011, -4, -1, 0}// 13	14	15	
			, {16011, -1, -1, 0}, {16011, 1, -1, 0}, {16013, -5, -1, 0}// 16	17	18	
			, {16005, 4, -1, 0}, {16005, 3, -1, 0}, {16011, 3, -1, 0}// 19	20	21	
			, {16011, 4, -1, 0}, {16005, 1, -1, 0}, {16005, -1, -1, 0}// 22	23	24	
			, {16005, -3, -1, 0}, {16005, -4, -1, 0}, {16005, 0, -1, 0}// 25	26	27	
			, {16011, 0, -1, 0}, {15981, -3, -1, 0}, {15981, 1, -1, 0}// 28	29	30	
			, {15981, 5, -1, 0}, {15982, -2, -2, 0}, {15982, 2, -2, 0}// 31	32	33	
			, {15982, 6, -2, 0}, {15990, 9, 0, 0}, {15993, 8, 1, 0}// 34	36	37	
			, {15994, 8, 0, 0}, {15996, 7, 1, 0}, {15998, 6, 1, 0}// 38	39	40	
			, {16000, 5, 1, 0}, {16005, 4, 2, 0}, {16000, 2, 1, 0}// 41	42	43	
			, {16005, 3, 2, 0}, {16005, -1, 2, 0}, {16005, -3, 2, 0}// 44	45	46	
			, {16000, -2, 1, 0}, {16007, -4, 2, 0}, {16011, 7, 0, 0}// 47	48	49	
			, {16011, 6, 0, 0}, {16011, 5, 0, 0}, {16011, 3, 0, 0}// 50	51	52	
			, {16011, 2, 0, 0}, {16011, 1, 0, 0}, {16011, -1, 0, 0}// 53	54	55	
			, {16011, -2, 0, 0}, {16011, -5, 0, 0}, {16011, 4, 1, 0}// 56	57	58	
			, {16011, 3, 1, 0}, {16011, 1, 1, 0}, {16011, -1, 1, 0}// 59	60	61	
			, {16011, -3, 1, 0}, {16011, -4, 1, 0}, {16012, -5, 1, 0}// 62	63	64	
			, {16011, 0, 1, 0}, {16005, 0, 2, 0}, {15980, 4, 0, 0}// 65	66	67	
			, {15980, 0, 0, 0}, {15980, -4, 0, 0}, {15979, 0, 2, 0}// 68	69	70	
			, {15979, -4, 2, 0}, {15979, 4, 2, 0}, {15978, -5, 2, 0}// 71	72	73	
			, {15978, -1, 2, 0}, {15978, 3, 2, 0}, {16011, -3, 0, 0}// 74	75	76	
			, {499, 4, 0, 60}, {499, 4, 0, 75}// 77	78	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new JollyRogerShipAddonDeed();
			}
		}

		[ Constructable ]
		public JollyRogerShipAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 8339, 4, -1, 78, 2615, -1, "Jolly Roger Flag", 1);// 35

		}

		public JollyRogerShipAddon( Serial serial ) : base( serial )
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

	public class JollyRogerShipAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new JollyRogerShipAddon();
			}
		}

		[Constructable]
		public JollyRogerShipAddonDeed()
		{
			Name = "JollyRogerShip";
		}

		public JollyRogerShipAddonDeed( Serial serial ) : base( serial )
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