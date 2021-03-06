
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
	public class MummificationCenterAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7233, 0, -1, 0}, {7234, 1, -1, 0}, {7235, 2, -1, 0}// 1	2	3	
			, {7235, 2, -1, 3}, {7234, 1, -1, 3}, {7233, 0, -1, 3}// 4	5	6	
			, {3137, -1, -1, 0}, {7562, 1, 2, 0}, {7563, 2, 2, 0}// 8	9	10	
			, {7450, 2, 0, 0}, {7451, 1, 0, 0}, {7452, 0, 0, 0}// 11	12	13	
			, {7239, 0, 1, 0}, {7240, 1, 1, 0}, {7241, 2, 1, 0}// 14	15	16	
			, {3133, -1, 0, 0}, {3131, -1, 1, 0}// 23	24	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MummificationCenterAddonDeed();
			}
		}

		[ Constructable ]
		public MummificationCenterAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9245, -1, -1, 0, 0, -1, "Canopic Jar", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3617, 0, 2, 0, 2402, -1, "Mummy Wrapping", 2);// 17
			AddComplexComponent( (BaseAddon) this, 9245, -1, 0, 0, 0, -1, "Canopic Jar", 1);// 18
			AddComplexComponent( (BaseAddon) this, 4102, -1, 1, 0, 0, -1, "Salt", 1);// 19
			AddComplexComponent( (BaseAddon) this, 3621, 0, 2, 4, 0, -1, "Annointing Oils", 1);// 20
			AddComplexComponent( (BaseAddon) this, 3625, 0, 2, 4, 0, -1, "Annointing Oils", 1);// 21
			AddComplexComponent( (BaseAddon) this, 4135, -1, 2, 0, 2785, -1, "Ritual Inscense", 1);// 22

		}

		public MummificationCenterAddon( Serial serial ) : base( serial )
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

	public class MummificationCenterAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MummificationCenterAddon();
			}
		}

		[Constructable]
		public MummificationCenterAddonDeed()
		{
			Name = "MummificationCenter";
		}

		public MummificationCenterAddonDeed( Serial serial ) : base( serial )
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