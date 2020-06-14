using System;
using Server;

namespace Server.Items
{
	public class IrishDrinkingMug : GlassMug
	{
		[Constructable]
		public IrishDrinkingMug() : base( BeverageType.Ale )
		{
			Hue = 64;
			Name = "irish drinking mug";
			LootType = LootType.Blessed;
		}

		public IrishDrinkingMug( Serial serial ) : base( serial )
		{
		}

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( 1060662, "St. Patrick's Day\t2005" );
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}