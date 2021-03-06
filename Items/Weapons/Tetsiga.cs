using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x27A2, 0x27ED )]
	public class Tetsiga : BaseSword
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.CrushingBlow; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }

		public override int AosStrengthReq{ get{ return 40; } }
		public override int AosMinDamage{ get{ return 16; } }
		public override int AosMaxDamage{ get{ return 18; } }
		public override int AosSpeed{ get{ return 35; } }
		public override float MlSpeed{ get{ return 3.50f; } }

		public override int OldStrengthReq{ get{ return 40; } }
		public override int OldMinDamage{ get{ return 16; } }
		public override int OldMaxDamage{ get{ return 18; } }
		public override int OldSpeed{ get{ return 35; } }

		public override int DefHitSound{ get{ return 0x23B; } }
		public override int DefMissSound{ get{ return 0x23A; } }

		public override int InitMinHits{ get{ return 250; } }
		public override int InitMaxHits{ get{ return 250; } }

        private Mobile m_Owner;

		[Constructable]
		public Tetsiga() : base( 0x27A2 )
		{
            this.Name = "-Tetsiga-";
            this.Hue = 1153;
			this.Weight = 10.0;
			this.Layer = Layer.OneHanded;
            this.Attributes.WeaponSpeed = 75;
            this.Attributes.SpellChanneling = 1;
            this.Attributes.WeaponDamage = 75;
            this.AosElementDamages.Chaos = 100;
            this.WeaponAttributes.HitLightning = 50;
		}
        public override void OnDoubleClick(Mobile from)
        {
            if (this.IsChildOf(from.Backpack))
            {
                // set owner if not already set -- this is only done the first time.
                if (m_Owner == null)
                {
                    m_Owner = from;
                    this.Name = m_Owner.Name.ToString() + "'s Sword";
                    from.SendMessage("You feel the sword grow fond of you.");
                }
                else
                {
                    if (m_Owner != from)
                    {
                        from.SendMessage("Sorry but this sword does not belong to you.");
                        return;
                    }
                }
            }
            else
            {
                from.SendMessage(1173, "This sword must be in your pack to use.");
            }
        }

        public override bool OnEquip(Mobile from)
        {
            // set owner if not already set -- this is only done the first time.
            if (m_Owner == null)
            {
                m_Owner = from;
                this.Name = m_Owner.Name.ToString() + "'s Sword";
                from.SendMessage("You feel the sword grow fond of you.");
                return base.OnEquip(from);
            }
            else
            {
                if (m_Owner != from)
                {
                    from.SendMessage("Sorry but this Sword does not belong to you.");
                    return false;
                }

                return base.OnEquip(from);
            }
        }
		public Tetsiga( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version

            writer.Write(m_Owner); // Version 1
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

            switch (version)
            {
                case 1:
                    m_Owner = reader.ReadMobile();
                    break;
            }
		}
	}
}