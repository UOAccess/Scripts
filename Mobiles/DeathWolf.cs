
using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Mobiles
{
    [CorpseName( "Death Wolf" )]
    public class DeathWolf : BaseCreature
    {
        [Constructable]
        public DeathWolf() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
        {
            this.Name = "Death Wolf";
            this.Hue = 1175;
            this.Body = 23;
            this.BaseSoundID = 229;

            this.SetStr( 560 );
            this.SetDex( 565 );
            this.SetInt( 1250 );
            this.SetHits( 100000 );
            this.SetDamage( 175, 255 );
            this.SetDamageType( ResistanceType.Physical, 75 );
            this.SetDamageType( ResistanceType.Cold, 75 );
            this.SetDamageType( ResistanceType.Fire, 85 );
            this.SetDamageType( ResistanceType.Energy, 75 );
            this.SetDamageType( ResistanceType.Poison, 95 );
            this.SetResistance( ResistanceType.Physical, 75 );
            this.SetResistance( ResistanceType.Cold, 75 );
            this.SetResistance( ResistanceType.Fire, 75 );
            this.SetResistance( ResistanceType.Energy, 75 );
            this.SetResistance( ResistanceType.Poison, 75 );
            this.Fame = 50000;
            this.Karma = 50000;
            this.VirtualArmor = 255;
        }

		public override bool HasBreath{ get{ return true; } }
        public override bool AutoDispel{ get{ return true; } }
        public override bool BardImmune{ get{ return true; } }
		public override bool Uncalmable{ get{ return true; } }
        public override bool CanRummageCorpses{ get{ return true; } }
        public override bool Unprovokable{ get{ return true; } }
        public override Poison HitPoison{ get{ return Poison.Lethal; } }
        public override bool AlwaysMurderer{ get{ return true; } }
        public override FoodType FavoriteFood{ get{ return FoodType.Fish; } }

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );

            c.DropItem( new Gold(69950));
            c.DropItem( new Bandage(2500));
        }

		public override WeaponAbility GetWeaponAbility()
		{
			switch ( Utility.Random(3 ) )
			{
				default:
                case 0: return WeaponAbility.ArmorIgnore;
                case 1: return WeaponAbility.BleedAttack;
                case 2: return WeaponAbility.Dismount;
            }
        }

        public DeathWolf( Serial serial ) : base( serial )
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