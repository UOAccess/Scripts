using System;
using Server;

namespace Server.Items
{
	public class ExodusSigil : GoldNecklace 
	{
		public override int ArtifactRarity{ get{ return 9; } }

		[Constructable]
		public ExodusSigil()
		{
			Weight = 0; 
            		Name = "Exodus' Sigil"; 
            		Hue = 1175;
			Attributes.BonusDex = 3;
			Attributes.BonusInt = 3;
			Attributes.BonusStr = 3;
			Attributes.DefendChance = 7;
			Attributes.LowerManaCost = 5;
			Attributes.LowerRegCost = 20;
			Attributes.Luck = 50;
			Attributes.ReflectPhysical = 25;
			Attributes.WeaponDamage = 10;
			Resistances.Cold = 10;
			Resistances.Energy = 10;
			Resistances.Fire = 10;
			Resistances.Physical = 10;
			Resistances.Poison = 10;
		}

		public ExodusSigil( Serial serial ) : base( serial )
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