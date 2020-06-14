using System;
using Server;

namespace Server.Items
{
	public class ApprenticeGargoyleRing : SilverRing
	{
        public override Race RequiredRace{ get { return Race.Gargoyle; } }
		public override bool CanBeWornByGargoyles{ get{ return true; } }

		[Constructable]
		public ApprenticeGargoyleRing()
		{
			Name = "Hero Apprentice Gargoyle Ring";
            ItemID = 16914;
						
			Attributes.BonusStr = 2;
			Attributes.RegenHits = 2;
			Attributes.NightSight = 1;
            LootType = LootType.Blessed;
			
		}

		public ApprenticeGargoyleRing( Serial serial ) : base( serial )
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