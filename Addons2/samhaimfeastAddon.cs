
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
	public class samhaimfeastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4075, 2, -1, 0}, {2444, 2, 0, 1}, {3160, -1, -1, 1}// 1	2	3	
			, {3157, 0, -1, 1}, {3197, -1, 0, 1}, {3180, 1, 2, 1}// 5	6	8	
			, {11599, 1, 1, 1}, {3160, -1, 0, 1}, {11599, 0, 1, 1}// 9	10	12	
			, {4070, 0, 0, 0}, {3178, 2, -1, 1}, {3197, -1, 1, 2}// 13	14	15	
			, {2416, 1, 0, 9}, {3158, 1, -2, 1}, {4074, 1, 0, 0}// 16	17	18	
			, {3179, 1, 2, 1}, {3158, 0, -2, 1}, {3179, 2, -1, 1}// 19	21	22	
			, {2421, 1, 0, 1}, {2503, 2, 1, 8}, {4073, 0, 1, 0}// 23	24	25	
			, {3180, 2, -1, 1}, {4077, 2, 1, 0}, {11599, 0, 2, 1}// 26	27	28	
			, {3160, -1, 1, 1}, {3158, 2, -2, 1}, {4076, 1, 1, 0}// 29	30	31	
			, {2503, 2, 0, 1}, {4078, 2, 0, 0}, {4072, 1, -1, 0}// 32	33	34	
			, {4071, 0, -1, 0}, {3197, -1, -1, 2}// 36	37	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new samhaimfeastAddonDeed();
			}
		}

		[ Constructable ]
		public samhaimfeastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 7733, -2, -1, 1, 0, -1, "Scarecrow", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2458, 2, 1, 3, 38, -1, "a champagne glass", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2458, 2, 0, 0, 38, -1, "a champagne glass", 1);// 11
			AddComplexComponent( (BaseAddon) this, 4012, 1, 0, 1, 0, 0, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2458, 2, 1, 5, 38, -1, "a champagne glass", 1);// 35

		}

		public samhaimfeastAddon( Serial serial ) : base( serial )
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

	public class samhaimfeastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new samhaimfeastAddon();
			}
		}

		[Constructable]
		public samhaimfeastAddonDeed()
		{
			Name = "samhaimfeast";
		}

		public samhaimfeastAddonDeed( Serial serial ) : base( serial )
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