using System;
using Server;

namespace Server.Items
{
	public class ExodusFury : LeatherGloves 
	{
		public override int ArtifactRarity{ get{ return 9; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ExodusFury()
		{
			Weight = 0; 
            		Name = "Exodus' Fury"; 
            		Hue = 1161;

			Attributes.AttackChance = 5;

			Attributes.DefendChance = 7;
			Attributes.LowerManaCost = 5;
			Attributes.LowerRegCost = 17;
			Attributes.Luck = 50;
			Attributes.RegenHits = 1;
			Attributes.RegenMana = 3;
			Attributes.RegenStam = 1;
			Attributes.WeaponDamage = 5;
			ArmorAttributes.SelfRepair = 3;
			ColdBonus = 3;
			EnergyBonus = 7;
			FireBonus = 5;		
			PhysicalBonus = 5;
			PoisonBonus = 3;
			StrRequirement = 0;

		}

		public ExodusFury( Serial serial ) : base( serial )
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