using System;
using Server;

namespace Server.Items
{
	public class ChaosBoots : Sandals
	{
	 	public override int ArtifactRarity{ get{ return 666; } }

	 	[Constructable]
	 	public ChaosBoots()  
	 	{
	 	 	Name = "Boots of Chaos";
			ItemID = 9903;
	 	 	Attributes.AttackChance = 20;
	 	 	Attributes.BonusHits = 40;
	 	 	Attributes.DefendChance = 20;
			Attributes.WeaponSpeed = 15;
			Attributes.WeaponDamage = 15;
			Attributes.ReflectPhysical = 20;
			
	 	}

	 	public ChaosBoots(Serial serial) : base( serial )
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
