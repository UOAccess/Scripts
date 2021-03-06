
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
	public class zencornersandstoneAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4554, -1, 3, 5}, {961, -2, 3, 3}, {3309, 0, -1, 2}// 1	2	3	
			, {1006, 3, -1, 1}, {3309, -1, 3, 4}, {1006, 3, -1, 3}// 4	5	7	
			, {1007, 1, -1, 0}, {993, 2, -2, 1}, {1006, -1, 3, 1}// 9	11	12	
			, {970, -2, -2, 2}, {994, -2, -1, 2}, {993, -1, -2, 1}// 13	14	15	
			, {1007, 2, -1, 0}, {1006, -1, -1, 1}, {1006, -1, 3, 3}// 16	18	20	
			, {1008, -1, 0, 0}, {3312, -1, 0, 2}, {1008, -1, 1, 0}// 21	24	26	
			, {1008, -1, 2, 0}, {994, -2, 2, 1}, {1007, 0, -1, 0}// 27	28	30	
			, {4554, 3, -1, 5}, {3310, 2, -1, 2}, {960, 3, -2, 3}// 31	35	36	
			, {1013, 3, -2, 1}, {1014, -2, 3, 1}// 37	38	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new zencornersandstoneAddonDeed();
			}
		}

		[ Constructable ]
		public zencornersandstoneAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 990, 1, -2, 1, 0, 1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2861, 2, -1, 1, 2660, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2860, -1, 1, 1, 2660, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2860, -1, 0, 1, 2660, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 991, -2, 0, 2, 0, 1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 991, -2, 1, 1, 0, 1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2860, -1, 2, 1, 2660, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 990, 0, -2, 1, 0, 1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 6377, -2, -2, 2, 2797, -1, "Hand-Blown Crystal Rose", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2861, 0, -1, 1, 2660, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2861, 1, -1, 1, 2660, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 11534, -1, -1, 8, 0, -1, "ArcanistStatueEast", 1);// 34

		}

		public zencornersandstoneAddon( Serial serial ) : base( serial )
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

	public class zencornersandstoneAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new zencornersandstoneAddon();
			}
		}

		[Constructable]
		public zencornersandstoneAddonDeed()
		{
			Name = "zencornersandstone";
		}

		public zencornersandstoneAddonDeed( Serial serial ) : base( serial )
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