
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
	public class FallFountainAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3178, 0, 1, 0}, {3179, 0, 1, 0}, {3180, 0, 1, 0}// 6	7	8	
			, {3179, 0, 1, 0}, {3178, 1, 1, 1}, {3179, 1, 1, 3}// 9	10	11	
			, {3180, 1, 1, 2}, {3178, 1, 0, 0}, {3179, 1, 0, 0}// 12	13	14	
			, {3180, 1, 0, 0}// 15	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FallFountainAddonDeed();
			}
		}

		[ Constructable ]
		public FallFountainAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9243, 0, 0, 0, 1908, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 9242, 0, 0, 14, 1908, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2594, 1, 1, 10, 0, 10, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2581, 1, 1, 13, 0, 10, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2581, 0, 1, 8, 0, 10, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3224, 0, 0, 6, 1908, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 3224, 0, 0, 17, 1908, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 6814, 0, -1, 0, 2331, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 6816, -1, 0, 0, 2331, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 14138, 1, 1, 17, 2331, -1, "", 1);// 20

		}

		public FallFountainAddon( Serial serial ) : base( serial )
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

	public class FallFountainAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FallFountainAddon();
			}
		}

		[Constructable]
		public FallFountainAddonDeed()
		{
			Name = "FallFountain";
		}

		public FallFountainAddonDeed( Serial serial ) : base( serial )
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