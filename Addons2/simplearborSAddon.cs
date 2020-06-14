
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
	public class simplearborSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {11514, -1, 0, 0}, {11514, 3, 0, 4}, {11514, 3, 0, 0}// 21	22	23	
			, {3204, 3, 0, 0}, {3210, 3, 0, 0}, {3210, -2, 0, 0}// 24	25	26	
			, {3204, -2, 0, 0}, {3205, 3, 1, 4}, {3205, -2, 1, 4}// 27	28	29	
			, {3208, -2, 1, 0}, {3208, 3, 1, 0}, {3212, -2, -1, 0}// 30	31	32	
			, {3211, 3, -1, 0}, {9036, 3, 0, 0}, {3149, 3, 1, 0}// 33	34	35	
			, {3149, -2, 1, 0}, {3149, -2, 0, 0}, {3149, 3, 0, 0}// 36	37	38	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new simplearborSAddonDeed();
			}
		}

		[ Constructable ]
		public simplearborSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2861, -1, 0, 0, 2962, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2861, 0, 0, 0, 2962, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2861, 1, 0, 0, 2962, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2861, 2, 0, 0, 2962, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 321, -1, 0, 20, 2962, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 321, 0, 0, 20, 2962, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 321, 1, 0, 20, 2962, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 321, 2, 0, 20, 2962, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 322, -1, -1, 20, 2962, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 322, 0, -1, 20, 2962, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 322, 1, -1, 20, 2962, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 322, 2, -1, 20, 2962, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 323, -2, 0, 20, 2962, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 324, -2, -1, 20, 2962, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 10079, 2, 0, 0, 2962, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 10079, -2, 0, 0, 2962, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 7949, -1, 0, 23, 2810, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 7950, 0, 0, 23, 2810, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 7952, 1, 0, 23, 2810, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 7951, 2, 0, 23, 2810, -1, "", 1);// 20

		}

		public simplearborSAddon( Serial serial ) : base( serial )
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

	public class simplearborSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new simplearborSAddon();
			}
		}

		[Constructable]
		public simplearborSAddonDeed()
		{
			Name = "simplearborS";
		}

		public simplearborSAddonDeed( Serial serial ) : base( serial )
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