// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class KCounterSAddon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new KCounterSAddonDeed();}}
		[ Constructable ]
		public KCounterSAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 1173 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 1, 7 );

			ac = new AddonComponent( 1801 );
			ac.Hue = 1153;
			ac.Name = "washer";
			AddComponent( ac, 0, 1, 2 );

			ac = new AddonComponent( 677 );
			ac.Hue = 1150;
			ac.Name = "oven";
			AddComponent( ac, 0, 0, 7 );

			ac = new AddonComponent( 676 );
			ac.Hue = 1150;
			ac.Name = "Oven";
			AddComponent( ac, 0, 0, 0 );


		}
		public KCounterSAddon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class KCounterSAddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new KCounterSAddon();}}
		[Constructable]
		public KCounterSAddonDeed(){Name = "KCounterS";}
		public KCounterSAddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}