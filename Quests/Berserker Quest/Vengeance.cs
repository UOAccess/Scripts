using System;
using Server;

namespace Server.Items
{
	public class Vengeance : Spellbook
	{
		public override int LabelNumber { get { return 1070971; } } // Tome of Lost Knowledge

		[Constructable]
		public Vengeance() : base()
		{
			Name = "Vengeance";
			LootType = LootType.Blessed;
			Hue = 1161;

			SkillBonuses.SetValues( 0, SkillName.Magery, 10.0 );
			Attributes.BonusInt = 15;
			Attributes.CastRecovery = 3;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 30;
			Attributes.SpellDamage = 15;
		}

		public Vengeance( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}