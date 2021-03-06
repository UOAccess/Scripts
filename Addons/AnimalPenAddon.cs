
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
	public class AnimalPenAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2142, -3, -2, 0}, {2142, -3, 0, 0}, {2142, -3, 2, 0}// 1	2	3	
			, {2145, -3, 3, 0}, {2145, -3, 1, 0}, {2145, -3, -1, 0}// 4	5	6	
			, {2145, -3, -3, 0}, {2143, -3, -4, 0}, {2144, -2, -4, 0}// 7	8	9	
			, {2141, -1, -4, 0}, {9, -3, -2, 0}, {9, -3, -4, 0}// 10	11	12	
			, {9964, -3, -4, 12}, {9964, -2, -4, 12}, {9964, -1, -4, 12}// 13	14	15	
			, {9964, -3, -3, 15}, {9964, -2, -3, 15}, {9964, -1, -3, 15}// 16	17	18	
			, {9964, -3, -2, 18}, {9964, -2, -2, 18}, {9964, -1, -2, 18}// 19	20	21	
			, {9964, -3, -1, 20}, {9964, -2, -1, 20}, {9964, -1, -1, 20}// 22	23	24	
			, {4151, -2, -2, 0}, {4151, -1, 2, 0}, {2141, -1, 4, 0}// 27	28	29	
			, {2144, -2, 4, 0}, {2142, -3, 4, 0}, {2143, 3, 3, 0}// 30	31	32	
			, {2144, 0, -4, 0}, {2144, 3, -4, 0}, {2145, 3, -3, 0}// 33	34	35	
			, {2143, 3, -4, 0}, {2145, 3, -1, 0}, {2142, 3, -2, 0}// 36	37	38	
			, {2142, 3, 0, 0}, {2141, 1, -4, 0}, {2144, 2, -4, 0}// 39	40	41	
			, {9, 1, -2, 0}, {9, 1, -4, 0}, {9964, 0, -4, 12}// 42	43	44	
			, {9964, 1, -4, 12}, {9964, 2, -4, 12}, {9964, 0, -3, 15}// 45	46	47	
			, {9964, 1, -3, 15}, {9964, 2, -3, 15}, {9964, 0, -2, 18}// 48	49	50	
			, {9964, 1, -2, 18}, {9964, 2, -2, 18}, {9964, 0, -1, 20}// 51	52	53	
			, {9964, 1, -1, 20}, {9964, 2, -1, 20}, {2881, 2, -3, 0}// 54	55	56	
			, {2882, 2, -2, 0}, {2860, 4, -1, 0}, {4090, 4, -2, 0}// 57	58	59	
			, {4014, 4, -3, 0}, {4151, 1, -3, 0}, {4151, 0, -1, 0}// 60	61	62	
			, {4151, 2, 3, 0}, {4151, 2, 0, 0}, {2140, 3, 4, 0}// 63	64	65	
			, {2141, 1, 4, 0}, {2144, 2, 4, 0}, {2144, 0, 4, 0}// 66	67	68	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AnimalPenAddonDeed();
			}
		}

		[ Constructable ]
		public AnimalPenAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 7869, -2, -3, 0, 0, -1, "", 2);// 25
			AddComplexComponent( (BaseAddon) this, 4165, -1, -3, 0, 0, -1, "Feed", 2);// 26

		}

		public AnimalPenAddon( Serial serial ) : base( serial )
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

	public class AnimalPenAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AnimalPenAddon();
			}
		}

		[Constructable]
		public AnimalPenAddonDeed()
		{
			Name = "AnimalPen";
		}

		public AnimalPenAddonDeed( Serial serial ) : base( serial )
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