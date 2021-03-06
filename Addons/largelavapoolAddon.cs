
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
	public class largelavapoolAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4897, 2, -1, 0}, {4927, -2, -1, 0}, {4894, 2, 0, 0}// 1	2	3	
			, {4915, -1, 2, 0}, {4936, -2, 0, 0}, {4930, -2, 1, 0}// 4	5	6	
			, {4918, 0, 2, 0}, {4906, 2, 1, 0}, {4924, 1, -2, 0}// 7	8	9	
			, {12962, -2, -2, 0}, {4912, 1, 2, 0}, {12965, 2, -2, 0}// 10	11	12	
			, {12964, 2, 2, 0}, {4921, 0, -2, 0}, {12963, -2, 2, 0}// 13	14	15	
			, {4924, -1, -2, 0}, {13390, 0, 1, 0}, {13371, 0, -1, 0}// 16	23	24	
			, {13383, 0, 0, 0}, {6773, 0, 0, 0}// 25	26	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new largelavapoolAddonDeed();
			}
		}

		[ Constructable ]
		public largelavapoolAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4858, -1, -1, 0, 0, 1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 4858, -1, 0, 0, 0, 1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 4858, -1, 1, 0, 0, 1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 4882, 1, 0, 0, 0, 1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 4870, 1, -1, 0, 0, 1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 4888, 1, 1, 0, 0, 1, "", 1);// 22

		}

		public largelavapoolAddon( Serial serial ) : base( serial )
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

	public class largelavapoolAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new largelavapoolAddon();
			}
		}

		[Constructable]
		public largelavapoolAddonDeed()
		{
			Name = "largelavapool";
		}

		public largelavapoolAddonDeed( Serial serial ) : base( serial )
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