//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 4/19/2019 1:33:48 PM
//=================================================

using System;
using Server;

namespace Server.Items
{
	public class WraithStunner : Crossbow
	{
		public override int ArtifactRarity{ get{ return 5; } }
		public override int InitMinHits{ get{ return 75; } }
		public override int InitMaxHits{ get{ return 100; } }

		[Constructable]
		public WraithStunner()
		{
			Name = "Wraith Stunner";
			Weight = 5;
			Attributes.BonusStr = 25;
			Attributes.WeaponDamage = 25;
			Attributes.ReflectPhysical = 20;
			Attributes.WeaponSpeed = 25;
			Attributes.RegenHits = 10;
			Attributes.RegenStam = 10;
			WeaponAttributes.HitLeechHits = 75;
		}

		public WraithStunner( Serial serial ) : base( serial )
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
