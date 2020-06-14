using System;
using Server;

namespace Server.Items
{
	public class ApprenticeEarrings : SilverEarrings
	{

		[Constructable]
		public ApprenticeEarrings()
		{
			Name = "Hero Apprentice Earrings";
						
			Attributes.BonusInt = 3;
			Attributes.RegenMana = 2;
			Attributes.SpellDamage = 5;
                         LootType = LootType.Blessed;
			
		}

		public ApprenticeEarrings( Serial serial ) : base( serial )
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