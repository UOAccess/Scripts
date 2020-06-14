using System;
using Server;

namespace Server.Items
{
	public class ExodusPillar : LeatherLegs 
	{
		public override int ArtifactRarity{ get{ return 9; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ExodusPillar()
		{
			Weight = 5.0; 
            		Name = "Exodus' Pillar"; 
            		Hue = 1175;

			Attributes.AttackChance = 5;
			Attributes.BonusStr = 7;
			Attributes.DefendChance = 15;
			Attributes.LowerRegCost = 20;
			Attributes.Luck = 50;
			Attributes.RegenHits = 2;
			Attributes.RegenMana = 2;
			Attributes.WeaponDamage = 5;
			ArmorAttributes.SelfRepair = 3;
			ColdBonus = 4;
			EnergyBonus = 4;
			FireBonus = 4;
			PhysicalBonus = 4;
			PoisonBonus = 7;
			StrRequirement = 0;
		}

		public ExodusPillar( Serial serial ) : base( serial )
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