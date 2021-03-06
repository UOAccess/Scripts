using System;
using Server.Mobiles;
using Server.Targeting;
namespace Server.Items
{
    public class PetPoisonDamagBonusPotion : Item
    {
        [Constructable]
        public PetPoisonDamagBonusPotion() : base(0x0F04)
        {
            Weight = 1.0;
Name = "Pet Poison Damage Bonus Potion";
            LootType = LootType.Blessed;
            Hue = 2629;
        }
        public override void OnDoubleClick(Mobile from) // Override double click of the deed to call our target
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
            }
            else
            {
                from.SendMessage("Target the pet you with to upgrate");
                from.Target = new PoisonDamage(this);
            }
        }
        public PetPoisonDamagBonusPotion(Serial serial) : base(serial)
        {
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
    public class PoisonDamage : Target
    {
        private PetPoisonDamagBonusPotion m_Potion;
        public PoisonDamage(PetPoisonDamagBonusPotion potion) : base(1, false, TargetFlags.None)
        {
            m_Potion = potion;
        }
        protected override void OnTarget(Mobile from, object target)
        {
            if (m_Potion == null || m_Potion.Deleted || !m_Potion.IsChildOf(from.Backpack))
                    return;
         
            if (target is BaseCreature)
            {
                BaseCreature t = (BaseCreature)target;
                if (t.ControlMaster != from)
                {
                    from.SendLocalizedMessage(1114368); // This is not your pet!
                }
                else
                {
                    if (t.PoisonDamage < 95)
                    {
                        t.PoisonDamage += 1;
                        from.SendMessage("You have reinforced your pet by 1 point of poison damage. Total: [{0}]", t.PoisonDamage);
                        m_Potion.Delete();
                    }
                    else
                    {
                        from.SendMessage("Your pet have a maximum poison damage.");
                        return;
                    }
                }
            }
            else
            {
                from.SendLocalizedMessage(1152924);  // That is not a valid pet.
            }
        }
    }
}