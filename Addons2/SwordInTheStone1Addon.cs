
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
	public class SwordInTheStone1Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SwordInTheStone1AddonDeed();
			}
		}

		[ Constructable ]
		public SwordInTheStone1Addon()
		{



			AddComplexComponent( (BaseAddon) this, 4237, 0, -1, 3, 1153, -1, "Sword in the Stone", 1);// 1
			AddComplexComponent( (BaseAddon) this, 4971, 0, -1, 2, 903, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4970, 0, -1, 2, 903, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4973, 1, -1, 4, 903, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4965, 1, -1, 5, 903, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4963, 0, -1, 0, 903, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 4967, 0, 0, 4, 903, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 4963, 1, 1, 11, 903, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4970, 0, 0, 4, 903, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 4973, 1, 0, 6, 903, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 4967, 1, 0, 9, 903, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2468, 1, 0, 15, 1153, -1, "Sword in the Stone", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2550, 1, 0, 15, 1153, -1, "Sword in the Stone", 1);// 13
			AddComplexComponent( (BaseAddon) this, 4031, 1, 0, 18, 1153, -1, "Sword in the Stone", 1);// 14

		}

		public SwordInTheStone1Addon( Serial serial ) : base( serial )
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

	public class SwordInTheStone1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SwordInTheStone1Addon();
			}
		}

		[Constructable]
		public SwordInTheStone1AddonDeed()
		{
			Name = "SwordInTheStone1";
		}

		public SwordInTheStone1AddonDeed( Serial serial ) : base( serial )
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