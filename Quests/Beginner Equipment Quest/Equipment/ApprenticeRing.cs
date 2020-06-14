using System;
using Server;

namespace Server.Items
{
	public class ApprenticeRing : SilverRing
	{

		[Constructable]
		public ApprenticeRing()
		{
			Name = "Hero Apprentice Ring";
						
			Attributes.BonusStr = 2;
			Attributes.RegenHits = 2;
			Attributes.NightSight = 1;
			LootType = LootType.Blessed;
		}

		public ApprenticeRing( Serial serial ) : base( serial )
		{
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