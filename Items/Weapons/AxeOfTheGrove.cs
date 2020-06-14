using System;
using Server;

namespace Server.Items
{
	public class AxeOfTheGrove : DoubleAxe
	{
	
		public override int ArtifactRarity{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

        private Mobile m_Owner;

		[Constructable]
		public AxeOfTheGrove()
		{
		    Name = "Axe of the Grove";
			Hue = 1366;
			Attributes.WeaponDamage = 15;
			Attributes.SpellChanneling = 1;
			WeaponAttributes.HitLightning = 55;
			Attributes.AttackChance = 5;
			Attributes.DefendChance = 5;
			WeaponAttributes.HitPhysicalArea = 15;
			WeaponAttributes.HitPoisonArea = 10;
			WeaponAttributes.HitLeechHits = 40;
            LootType = LootType.Blessed;
			
		}


        public override void OnDoubleClick(Mobile from)
        {
            if (this.IsChildOf(from.Backpack))
            {
                // set owner if not already set -- this is only done the first time.
                if (m_Owner == null)
                {
                    m_Owner = from;
                    this.Name = m_Owner.Name.ToString() + "'s Axe of the Grove";
                    from.SendMessage("You feel the axe grow fond of you.");
                }
                else
                {
                    if (m_Owner != from)
                    {
                        from.SendMessage("Sorry but this axe does not belong to you.");
                        return;
                    }
                }
            }
            else
            {
                from.SendMessage(1173, "This axe must be in your pack to use.");
            }
        }

        public override bool OnEquip(Mobile from)
        {
            // set owner if not already set -- this is only done the first time.
            if (m_Owner == null)
            {
                m_Owner = from;
                this.Name = m_Owner.Name.ToString() + "'s Axe of the Grove";
                from.SendMessage("You feel the axe grow fond of you.");
                return base.OnEquip(from);
            }
            else
            {
                if (m_Owner != from)
                {
                    from.SendMessage("Sorry but this axe does not belong to you.");
                    return false;
                }

                return base.OnEquip(from);
            }
        }

               

		public AxeOfTheGrove( Serial serial ) : base( serial )
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