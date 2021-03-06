
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
	public class drkstoneNSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {13854, -2, -1, 0}, {13854, 2, -1, 0}, {13854, -2, -2, 0}// 1	2	3	
			, {13854, 2, -2, 0}, {13854, -2, 0, 0}, {13854, -2, 1, 0}// 4	11	12	
			, {13854, -2, 2, 0}, {13854, -2, 3, 0}, {13854, 2, 0, 0}// 13	14	15	
			, {13854, 2, 1, 0}, {13854, 2, 2, 0}, {13854, 2, 3, 0}// 16	17	18	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new drkstoneNSAddonDeed();
			}
		}

		[ Constructable ]
		public drkstoneNSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 13850, 1, -2, 0, 2999, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 13850, 1, -1, 0, 2999, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 13850, -1, -2, 0, 2999, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 13850, -1, -1, 0, 2999, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 13850, 0, -2, 0, 2999, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 13850, 0, -1, 0, 2999, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 13850, 1, 0, 0, 2999, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 13850, 1, 1, 0, 2999, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 13850, 1, 2, 0, 2999, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 13850, 1, 3, 0, 2999, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 13850, -1, 0, 0, 2999, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 13850, -1, 1, 0, 2999, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 13850, -1, 2, 0, 2999, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 13850, -1, 3, 0, 2999, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 13850, 0, 0, 0, 2999, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 13850, 0, 1, 0, 2999, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 13850, 0, 2, 0, 2999, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 13850, 0, 3, 0, 2999, -1, "", 1);// 30

		}

		public drkstoneNSAddon( Serial serial ) : base( serial )
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

	public class drkstoneNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new drkstoneNSAddon();
			}
		}

		[Constructable]
		public drkstoneNSAddonDeed()
		{
			Name = "drkstoneNS";
		}

		public drkstoneNSAddonDeed( Serial serial ) : base( serial )
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