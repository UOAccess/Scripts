
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
	public class xmaspicnicAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3249, -2, 1, 3}, {6085, -2, -1, 3}, {3251, -1, 0, 3}// 1	2	3	
			, {6077, -1, 0, 3}, {6091, -1, -1, 3}, {6089, -1, 2, 3}// 5	6	7	
			, {6082, -2, 1, 3}, {3251, -1, 0, 3}, {6085, -3, 0, 3}// 8	9	10	
			, {6088, -2, 2, 3}, {6088, -3, 1, 3}, {6083, -2, 0, 3}// 11	15	17	
			, {6077, -1, 1, 3}, {6077, 2, 0, 3}, {6087, 3, 2, 3}// 20	21	22	
			, {6091, 2, -1, 3}, {3253, 3, 0, 3}, {6077, 1, 0, 3}// 28	30	31	
			, {3253, 3, 1, 3}, {6077, 0, 1, 3}, {3253, 0, 1, 3}// 38	40	41	
			, {3251, 2, 1, 3}, {6091, 0, -1, 3}, {6089, 1, 2, 3}// 42	43	44	
			, {6077, 2, 1, 3}, {6086, 3, -1, 3}, {3251, 0, 1, 3}// 45	46	49	
			, {6091, 1, -1, 3}, {3250, 0, 0, 3}, {3252, 1, 1, 3}// 51	52	56	
			, {3251, 2, 1, 3}, {6077, 0, 0, 3}, {3253, 2, -1, 3}// 58	59	60	
			, {6077, 1, 1, 3}, {6089, 0, 2, 3}, {6084, 3, 0, 3}// 61	62	63	
			, {6081, 3, 1, 3}, {6089, 2, 2, 3}, {7137, 1, 1, 9}// 65	66	71	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new xmaspicnicAddonDeed();
			}
		}

		[ Constructable ]
		public xmaspicnicAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4179, -1, 0, 3, 237, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4180, -1, 1, 3, 237, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 5171, -2, 1, 3, 2890, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 5171, -2, 0, 5, 2895, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 4180, -1, 0, 4, 237, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 4179, -2, 1, 3, 237, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 5035, -1, 0, 0, 253, -1, "a tagged pillow", 1);// 19
			AddComplexComponent( (BaseAddon) this, 5037, 2, 1, 10, 241, -1, "a floor pillow", 1);// 23
			AddComplexComponent( (BaseAddon) this, 5171, 2, -1, 2, 1174, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 5171, 0, -1, 3, 467, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 5690, 0, 1, 10, 230, -1, "Large Square Pillow", 1);// 26
			AddComplexComponent( (BaseAddon) this, 4179, 0, 0, 3, 237, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 5037, 0, 0, 7, 237, -1, "a floor pillow", 1);// 29
			AddComplexComponent( (BaseAddon) this, 5691, 2, 1, 12, 237, -1, "Medium Square Pillow", 1);// 32
			AddComplexComponent( (BaseAddon) this, 4180, 2, -1, 3, 237, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 5171, 1, 1, 1, 2633, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 5691, 0, 0, 7, 241, -1, "Medium Square Pillow", 1);// 35
			AddComplexComponent( (BaseAddon) this, 5171, 2, 1, 3, 237, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 4179, 3, 1, 3, 237, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 5171, 0, 2, 7, 2896, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 4179, 0, 1, 3, 237, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 5171, 3, 1, 3, 472, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 4180, 1, 1, 3, 237, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 4179, 3, 0, 3, 237, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 5171, 1, -1, 2, 497, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 5035, 1, 1, 4, 253, -1, "a tagged pillow", 1);// 55
			AddComplexComponent( (BaseAddon) this, 4180, 1, 1, 3, 237, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 4179, 0, 0, 3, 237, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 5171, 3, 0, 3, 2896, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 4179, 2, 1, 3, 237, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 4180, 2, 2, 3, 237, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 6571, 1, 1, 13, 0, 29, "", 1);// 70

		}

		public xmaspicnicAddon( Serial serial ) : base( serial )
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

	public class xmaspicnicAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new xmaspicnicAddon();
			}
		}

		[Constructable]
		public xmaspicnicAddonDeed()
		{
			Name = "xmaspicnic";
		}

		public xmaspicnicAddonDeed( Serial serial ) : base( serial )
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