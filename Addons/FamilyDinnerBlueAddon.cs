
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
	public class FamilyDinnerBlueAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2523, 1, 1, 6}, {11515, 1, 0, 0}, {11513, 0, 0, 0}// 2	4	5	
			, {11515, 0, 0, 0}, {2950, 1, 1, 0}, {11513, 0, 2, 0}// 6	7	8	
			, {4161, 1, 1, 2}, {11515, 3, 0, 0}, {2945, 2, 1, 0}// 9	14	15	
			, {11675, -2, -2, 0}, {2949, 0, 1, 0}, {11515, 2, 0, 0}// 18	23	24	
			, {5644, 0, 1, 1}, {11513, 0, 1, 0}, {11513, 0, 3, 0}// 32	33	38	
			, {7187, 0, 1, 6}, {2451, 3, 2, 0}// 45	51	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FamilyDinnerBlueAddonDeed();
			}
		}

		[ Constructable ]
		public FamilyDinnerBlueAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2766, 0, -1, 0, 2280, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2760, 1, 2, 0, 2280, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2767, 3, 2, 0, 2280, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2767, 3, 1, 0, 2280, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2766, 1, -1, 0, 2280, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2762, -1, -1, 0, 2280, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2760, 2, 0, 0, 2280, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2768, 0, 3, 0, 2280, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 11676, 0, 3, 0, 2258, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2760, 0, 2, 0, 2280, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2768, 1, 3, 0, 2280, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2761, 3, 3, 0, 2280, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 7189, 2, 1, 6, 0, 1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2768, 2, 3, 0, 2280, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2765, -1, 2, 0, 2280, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2760, 1, 0, 0, 2280, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2760, 0, 1, 0, 2280, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2765, -1, 0, 0, 2280, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2765, -1, 1, 0, 2280, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2760, 1, 1, 0, 2280, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2767, 3, 0, 0, 2280, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2760, 2, 1, 0, 2280, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 11676, 3, 0, 0, 2258, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2760, 0, 0, 0, 2280, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 2760, 2, 2, 0, 2280, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 2900, 0, 2, 0, 2258, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 2763, -1, 3, 0, 2280, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 2764, 3, -1, 0, 2280, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 2766, 2, -1, 0, 2280, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2899, 0, 0, 0, 2258, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2900, 2, 2, 0, 2258, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2900, 1, 2, 0, 2258, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 2899, 1, 0, 0, 2258, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 2899, 2, 0, 0, 2258, -1, "", 1);// 50

		}

		public FamilyDinnerBlueAddon( Serial serial ) : base( serial )
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

	public class FamilyDinnerBlueAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FamilyDinnerBlueAddon();
			}
		}

		[Constructable]
		public FamilyDinnerBlueAddonDeed()
		{
			Name = "FamilyDinnerBlue";
		}

		public FamilyDinnerBlueAddonDeed( Serial serial ) : base( serial )
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