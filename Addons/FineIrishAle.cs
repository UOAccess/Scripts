using System;
using Server;

namespace Server.Items
{
	public class FineIrishAle : BeverageBottle
	{
		[Constructable]
		public FineIrishAle() : base( BeverageType.Ale )
		{
			Hue = Utility.RandomList( 1436 );
			Name = "fine irish ale";
			LootType = LootType.Blessed;
		}

		public FineIrishAle( Serial serial ) : base( serial )
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