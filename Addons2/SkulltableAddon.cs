
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
	public class SkulltableAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4650, -1, -1, 6}, {4651, 1, 1, 6}, {4652, 1, -1, 6}// 19	20	21	
			, {4654, -1, 1, 6}// 22	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SkulltableAddonDeed();
			}
		}

		[ Constructable ]
		public SkulltableAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4610, -1, -1, 0, 1, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 4611, -1, 0, 0, 1, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4609, -1, 1, 0, 1, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4610, 0, -1, 0, 1, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4611, 0, 0, 0, 1, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4609, 0, 1, 0, 1, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 4610, 1, -1, 0, 1, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 4611, 1, 0, 0, 1, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4609, 1, 1, 0, 1, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 4629, -1, 0, 7, 2747, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 4630, 0, 0, 7, 2747, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 4628, -1, 1, 7, 2747, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 4627, 0, 1, 7, 2747, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 4625, 1, 0, 7, 2747, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 4626, 1, 1, 7, 2747, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 4622, -1, -1, 7, 2747, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 4623, 0, -1, 7, 2747, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 4624, 1, -1, 7, 2747, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 8707, 0, 0, 11, 2852, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 6228, 1, 1, 11, 0, 1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 6228, -1, 1, 8, 0, 1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 6228, 1, -1, 8, 0, 1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 6228, -1, -1, 6, 0, 1, "", 1);// 27

		}

		public SkulltableAddon( Serial serial ) : base( serial )
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

	public class SkulltableAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SkulltableAddon();
			}
		}

		[Constructable]
		public SkulltableAddonDeed()
		{
			Name = "Skulltable";
		}

		public SkulltableAddonDeed( Serial serial ) : base( serial )
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