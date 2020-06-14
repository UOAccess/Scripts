
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
	public class HonestyShrineAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {5283, 0, -1, 0}, {5284, 0, 0, 0}, {5285, 1, 0, 0}// 1	2	3	
			, {5286, 1, -1, 0}, {4, 0, -2, 0}, {5, 1, -2, 0}// 4	5	6	
			, {7187, 0, 2, 5}, {2886, -1, -1, 0}, {2886, 2, -1, 0}// 8	9	10	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HonestyShrineAddonDeed();
			}
		}

		[ Constructable ]
		public HonestyShrineAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 11595, 0, 2, 0, 0, -1, "Podium", 1);// 7
			AddComplexComponent( (BaseAddon) this, 6377, 2, -1, 5, 0, -1, "a long stem rose", 1);// 11
			AddComplexComponent( (BaseAddon) this, 6377, -1, -1, 5, 0, -1, "a long stem rose", 1);// 12
			AddComplexComponent( (BaseAddon) this, 3206, 1, 1, 0, 0, -1, "Roses", 1);// 13
			AddComplexComponent( (BaseAddon) this, 3206, 0, 1, 0, 0, -1, "Roses", 1);// 14
			AddComplexComponent( (BaseAddon) this, 8759, 2, -1, 9, 2450, -1, "Lance of Honesty", 1);// 15

		}

		public HonestyShrineAddon( Serial serial ) : base( serial )
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

	public class HonestyShrineAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HonestyShrineAddon();
			}
		}

		[Constructable]
		public HonestyShrineAddonDeed()
		{
			Name = "HonestyShrine";
		}

		public HonestyShrineAddonDeed( Serial serial ) : base( serial )
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