
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
	public class HolidayyardgatensAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9180, 2, -1, 20}, {9182, -1, 0, 18}, {9182, -1, -1, 18}// 14	30	39	
			, {9180, 2, 1, 20}, {9180, 1, -1, 22}, {9182, 0, 1, 21}// 41	46	48	
			, {9180, 1, 0, 22}, {9182, -1, 1, 18}, {9182, 0, -1, 21}// 49	50	52	
			, {9182, 0, 0, 21}, {9180, 1, 1, 22}, {9180, 2, 0, 20}// 60	61	66	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HolidayyardgatensAddonDeed();
			}
		}

		[ Constructable ]
		public HolidayyardgatensAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4966, 2, 1, 12, 33, -1, "pillar", 1);// 1
			AddComplexComponent( (BaseAddon) this, 4966, -1, -1, 12, 33, -1, "pillar", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4966, -1, -1, 6, 1153, -1, "pillar", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1981, 0, 1, 0, 1153, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4966, -1, -1, 8, 33, -1, "pillar", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4966, 2, -1, 20, 33, -1, "pillar", 1);// 6
			AddComplexComponent( (BaseAddon) this, 4966, 2, -1, 0, 33, -1, "pillar", 1);// 7
			AddComplexComponent( (BaseAddon) this, 4966, -1, 1, 14, 1153, -1, "pillar", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4966, -1, -1, 20, 33, -1, "SmallFireRock", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1981, 2, 1, 0, 1153, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1981, -1, -1, 0, 1153, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1981, 2, 0, 0, 1153, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 4966, -1, -1, 0, 33, -1, "pillar", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1981, 0, -1, 0, 1153, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 4966, 2, -1, 14, 1153, -1, "pillar", 1);// 16
			AddComplexComponent( (BaseAddon) this, 4966, -1, -1, 16, 33, -1, "pillar", 1);// 17
			AddComplexComponent( (BaseAddon) this, 4966, 2, 1, 0, 33, -1, "pillar", 1);// 18
			AddComplexComponent( (BaseAddon) this, 4966, 2, 1, 14, 1153, -1, "pillar", 1);// 19
			AddComplexComponent( (BaseAddon) this, 4966, -1, 1, 4, 33, -1, "pillar", 1);// 20
			AddComplexComponent( (BaseAddon) this, 4966, -1, 1, 0, 33, -1, "pillar", 1);// 21
			AddComplexComponent( (BaseAddon) this, 4966, 2, 1, 4, 33, -1, "pillar", 1);// 22
			AddComplexComponent( (BaseAddon) this, 4966, -1, -1, 2, 1153, -1, "pillar", 1);// 23
			AddComplexComponent( (BaseAddon) this, 4966, 2, -1, 18, 1153, -1, "pillar", 1);// 24
			AddComplexComponent( (BaseAddon) this, 4966, -1, 1, 18, 1153, -1, "pillar", 1);// 25
			AddComplexComponent( (BaseAddon) this, 4966, -1, -1, 10, 1153, -1, "pillar", 1);// 26
			AddComplexComponent( (BaseAddon) this, 4966, 2, 1, 16, 33, -1, "pillar", 1);// 27
			AddComplexComponent( (BaseAddon) this, 4966, 2, -1, 16, 33, -1, "pillar", 1);// 28
			AddComplexComponent( (BaseAddon) this, 4966, -1, -1, 18, 1153, -1, "pillar", 1);// 29
			AddComplexComponent( (BaseAddon) this, 4966, 2, 1, 8, 33, -1, "pillar", 1);// 31
			AddComplexComponent( (BaseAddon) this, 4966, 2, 1, 2, 1153, -1, "pillar", 1);// 32
			AddComplexComponent( (BaseAddon) this, 4966, -1, 1, 6, 1153, -1, "pillar", 1);// 33
			AddComplexComponent( (BaseAddon) this, 4966, 2, -1, 6, 1153, -1, "pillar", 1);// 34
			AddComplexComponent( (BaseAddon) this, 4966, -1, -1, 14, 1153, -1, "pillar", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1981, -1, 1, 0, 1153, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 4966, 2, 1, 6, 1153, -1, "pillar", 1);// 37
			AddComplexComponent( (BaseAddon) this, 4966, -1, 1, 10, 1153, -1, "pillar", 1);// 38
			AddComplexComponent( (BaseAddon) this, 4966, 2, 1, 10, 1153, -1, "pillar", 1);// 40
			AddComplexComponent( (BaseAddon) this, 4966, 2, 1, 20, 33, -1, "pillar", 1);// 42
			AddComplexComponent( (BaseAddon) this, 4966, 2, -1, 4, 33, -1, "pillar", 1);// 43
			AddComplexComponent( (BaseAddon) this, 4966, -1, 1, 20, 33, -1, "pillar", 1);// 44
			AddComplexComponent( (BaseAddon) this, 4966, -1, -1, 4, 33, -1, "pillar", 1);// 45
			AddComplexComponent( (BaseAddon) this, 4966, -1, 1, 8, 33, -1, "pillar", 1);// 47
			AddComplexComponent( (BaseAddon) this, 4966, 2, -1, 8, 33, -1, "pillar", 1);// 51
			AddComplexComponent( (BaseAddon) this, 4966, -1, 1, 2, 1153, -1, "pillar", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1981, 2, -1, 0, 1153, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 4966, -1, 1, 16, 33, -1, "pillar", 1);// 55
			AddComplexComponent( (BaseAddon) this, 4966, 2, -1, 10, 1153, -1, "pillar", 1);// 56
			AddComplexComponent( (BaseAddon) this, 1981, -1, 0, 0, 1153, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 4966, 2, -1, 2, 1153, -1, "pillar", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1981, 1, 1, 0, 1153, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1981, 1, -1, 0, 1153, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 4966, 2, -1, 12, 33, -1, "pillar", 1);// 63
			AddComplexComponent( (BaseAddon) this, 4966, 2, 1, 18, 1153, -1, "pillar", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1981, 0, 0, 0, 1153, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1981, 1, 0, 0, 1153, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 4966, -1, 1, 12, 33, -1, "pillar", 1);// 68

		}

		public HolidayyardgatensAddon( Serial serial ) : base( serial )
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

	public class HolidayyardgatensAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HolidayyardgatensAddon();
			}
		}

		[Constructable]
		public HolidayyardgatensAddonDeed()
		{
			Name = "Holidayyardgatens";
		}

		public HolidayyardgatensAddonDeed( Serial serial ) : base( serial )
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