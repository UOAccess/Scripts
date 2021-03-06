
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
	public class cornercouchSWAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4555, -2, 2, 5}// 34	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new cornercouchSWAddonDeed();
			}
		}

		[ Constructable ]
		public cornercouchSWAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1824, -3, 3, 0, 492, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1824, -2, 3, 0, 492, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1824, -1, 3, 0, 492, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1824, 1, 3, 0, 492, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1824, 0, 3, 0, 492, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1824, 2, 3, 0, 492, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1824, -3, -3, 0, 492, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1824, 3, 3, 0, 492, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1824, 3, 2, 0, 492, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1824, -2, -3, 0, 492, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1824, -3, -2, 0, 492, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1824, -3, -1, 0, 492, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1824, -3, 0, 0, 492, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1824, -3, 1, 0, 492, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1824, -3, 2, 0, 492, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1824, -2, 2, 0, 492, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2860, -2, -2, 0, 492, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2860, -2, -1, 0, 492, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2860, -2, 0, 0, 492, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2860, -2, 1, 0, 492, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2861, -1, 2, 0, 492, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2861, 0, 2, 0, 492, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2861, 1, 2, 0, 492, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2861, 2, 2, 0, 492, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 2845, -3, 3, 5, 0, 10, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 5028, -3, 1, 5, 1153, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 5028, -3, 0, 5, 1153, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 5028, -3, -1, 5, 1153, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 5028, -3, -2, 5, 1153, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 5028, -3, 2, 5, 1153, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 5029, -2, -3, 5, 1153, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 5029, -2, 3, 5, 1153, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 5028, 3, 2, 5, 1153, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 5032, -3, -3, 5, 1153, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 5032, 3, 3, 5, 1153, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 5029, -1, 3, 5, 1153, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 5029, 0, 3, 5, 1153, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 5029, 1, 3, 5, 1153, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 5029, 2, 3, 5, 1153, -1, "", 1);// 40

		}

		public cornercouchSWAddon( Serial serial ) : base( serial )
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

	public class cornercouchSWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new cornercouchSWAddon();
			}
		}

		[Constructable]
		public cornercouchSWAddonDeed()
		{
			Name = "cornercouchSW";
		}

		public cornercouchSWAddonDeed( Serial serial ) : base( serial )
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