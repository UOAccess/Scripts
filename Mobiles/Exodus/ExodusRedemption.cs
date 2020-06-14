using System;
using Server;

namespace Server.Items
{
	public class ExodusRedemption : Katana
	{
		public override int ArtifactRarity{ get{ return 9; } } 
		public override int InitMinHits{ get{ return 255; } } 
		public override int InitMaxHits{ get{ return 255; } } 

		[Constructable]
		public ExodusRedemption() 
		{
			Weight = 0; 
            		Name = "Exodus' Redemption";
            		Hue = 1161;
			WeaponAttributes.HitFireball = 33;
			WeaponAttributes.HitLeechHits = 25;
			WeaponAttributes.SelfRepair = 3;
			WeaponAttributes.UseBestSkill = 1;
			Attributes.AttackChance = 15;
			Attributes.DefendChance = 15;
			Attributes.Luck = 50;
			Attributes.SpellChanneling = 1;
			Attributes.WeaponDamage = 50;
			Attributes.WeaponSpeed = 20;
			StrRequirement = 0;

		}

		public ExodusRedemption( Serial serial ) : base( serial ) // your name of weapon(no spaces)
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