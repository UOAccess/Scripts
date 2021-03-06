
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
	public class DarkStaneTrainingAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {13883, -2, -2, 0}, {13883, -2, 2, 0}, {13883, -1, 2, 0}// 1	2	3	
			, {13883, 1, 2, 0}, {13883, -1, -2, 0}, {13883, 1, -2, 0}// 4	5	6	
			, {13883, 2, -2, 0}, {13882, 2, -1, 0}, {13882, 2, 2, 0}// 7	8	9	
			, {13883, 2, 2, 0}, {13839, 2, 1, 0}// 10	11	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DarkStaneTrainingAddonDeed();
			}
		}

		[ Constructable ]
		public DarkStaneTrainingAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 13885, 0, 2, 0, 0, 1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 13885, 2, 0, 22, 0, 1, "", 1);// 13

		}

		public DarkStaneTrainingAddon( Serial serial ) : base( serial )
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

	public class DarkStaneTrainingAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DarkStaneTrainingAddon();
			}
		}

		[Constructable]
		public DarkStaneTrainingAddonDeed()
		{
			Name = "DarkStaneTraining";
		}

		public DarkStaneTrainingAddonDeed( Serial serial ) : base( serial )
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