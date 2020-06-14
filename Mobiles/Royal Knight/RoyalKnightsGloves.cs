
using System;
using Server;

namespace Server.Items
{
	public class Royalknightsgloves : PlateGloves 
	{
		public override int ArtifactRarity{ get{ return 20; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public Royalknightsgloves()
		{
			Weight = 2.0; 
            		Name = "Royal Knights Gloves"; 
            		Hue = 2056;

			Attributes.BonusHits = 5;
			Attributes.DefendChance = 5;
			Attributes.Luck = 100;
			Attributes.SpellDamage = 10;
			Attributes.WeaponSpeed = 5;

			ArmorAttributes.SelfRepair = 10;

			ColdBonus = 15;
			EnergyBonus = 15;
			FireBonus = 15;
			PhysicalBonus = 15;
			PoisonBonus = 15;
			StrRequirement = 50;

		}

		public Royalknightsgloves( Serial serial ) : base( serial )
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