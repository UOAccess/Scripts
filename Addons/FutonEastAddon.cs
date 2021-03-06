
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
	public class FutonEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {10374, -2, 1, 1}, {10296, 2, 2, 3}, {10591, 0, 0, 0}// 2	29	38	
			, {10466, 2, -2, 8}// 41	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FutonEastAddonDeed();
			}
		}

		[ Constructable ]
		public FutonEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9255, -2, -2, 0, 1741, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 9254, -2, 2, 0, 1741, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 9253, 2, -2, 0, 1741, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 9256, 2, 2, 0, 1741, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 9265, 0, 2, 0, 1741, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 9267, 0, -2, 0, 1741, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 9266, -2, 0, 0, 1741, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 9268, 2, 0, 0, 1741, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 9269, 1, 1, 0, 1741, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 9269, 1, -1, 0, 1741, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 9269, -1, -1, 0, 1741, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 9269, -1, 1, 0, 1741, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 9270, -2, 1, 0, 1741, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 9270, -2, -1, 0, 1741, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 9270, 2, 1, 0, 1741, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 9270, 2, -1, 0, 1741, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 9270, 0, 1, 0, 1741, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 9270, 0, -1, 0, 1741, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 9271, -1, 2, 0, 1741, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 9271, 1, 2, 0, 1741, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 9271, -1, -2, 0, 1741, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 9271, -1, 0, 0, 1741, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 9271, 1, -2, 0, 1741, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1825, 2, -2, 0, 1741, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 9271, 1, 0, 0, 1741, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 16144, 2, 2, 3, 0, -1, "Mini Stone Fountain", 1);// 27
			AddComplexComponent( (BaseAddon) this, 9272, 0, 0, 0, 1741, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 9424, 1, -2, 0, 1149, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 9424, 0, -2, 0, 1149, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 9424, -1, -2, 0, 1149, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 9424, -2, -2, 0, 1149, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 9424, -2, 3, 0, 1149, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 9424, -1, 3, 0, 1149, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 9424, 0, 3, 0, 1149, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 9424, 1, 3, 0, 1149, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 9405, -2, -2, 0, 0, 1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 9417, -2, -2, 5, 0, 1, "", 1);// 40

		}

		public FutonEastAddon( Serial serial ) : base( serial )
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

	public class FutonEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FutonEastAddon();
			}
		}

		[Constructable]
		public FutonEastAddonDeed()
		{
			Name = "FutonEast";
		}

		public FutonEastAddonDeed( Serial serial ) : base( serial )
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