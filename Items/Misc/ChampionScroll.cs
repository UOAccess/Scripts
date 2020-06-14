using System;
using Server;

namespace Server.Items
{

	public class ChampionScroll : BaseDecorationArtifact
	{
		public override int ArtifactRarity{ get{ return 5; } }

		[Constructable]
		public ChampionScroll() : base( 0xEF3 )
		{
			Name = "Champion Scroll";
			Hue = 1175;
			Weight = .01;
			Stackable = true;
		}

		public ChampionScroll( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}
