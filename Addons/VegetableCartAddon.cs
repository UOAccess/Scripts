
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
	public class VegetableCartAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3197, 0, -1, 0}, {3197, -1, -1, 0}, {3898, 1, 1, 5}// 2	3	6	
			, {3386, 0, 0, 6}, {3181, 1, 1, 15}, {15644, 1, 1, 16}// 8	11	12	
			, {7869, -1, 0, 0}// 13	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new VegetableCartAddonDeed();
			}
		}

		[ Constructable ]
		public VegetableCartAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6790, 0, -1, 0, 0, -1, "Vegetable Cart", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6786, 0, 1, 0, 0, -1, "Vegetable Cart", 1);// 4
			AddComplexComponent( (BaseAddon) this, 6787, 0, 0, 0, 0, -1, "Vegetable Cart", 1);// 5
			AddComplexComponent( (BaseAddon) this, 9557, 1, 1, 9, 0, -1, "Gardening Hoe", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3191, 1, 1, 18, 0, -1, "", 2);// 9
			AddComplexComponent( (BaseAddon) this, 3185, 0, 0, 8, 0, -1, "", 2);// 10

		}

		public VegetableCartAddon( Serial serial ) : base( serial )
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

	public class VegetableCartAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new VegetableCartAddon();
			}
		}

		[Constructable]
		public VegetableCartAddonDeed()
		{
			Name = "VegetableCart";
		}

		public VegetableCartAddonDeed( Serial serial ) : base( serial )
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