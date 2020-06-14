using System;
using Server;

namespace Server.Items
{
	public class ExodusValor : LeatherChest 
	{
		public override int ArtifactRarity{ get{ return 9; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ExodusValor()
		{
			Weight = 0; 
            		Name = "Exodus' Valor"; 
            		Hue = 1175;
			Attributes.AttackChance = 5;
			Attributes.BonusMana = 7;
			Attributes.CastRecovery = 1;
			Attributes.LowerManaCost = 4;
			Attributes.LowerRegCost = 20;
			Attributes.Luck = 50;
			Attributes.SpellDamage = 5;
			Attributes.WeaponDamage = 5;
			ArmorAttributes.SelfRepair = 3;
			ColdBonus = 5;
			EnergyBonus = 3;
			FireBonus = 5;
			PhysicalBonus = 7;
			PoisonBonus = 3;
			StrRequirement = 0;

		}

		public ExodusValor( Serial serial ) : base( serial )
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