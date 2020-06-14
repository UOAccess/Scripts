using System;
using Server.Mobiles;
using Server.Targeting;
namespace Server.Items
{
    public class PetHitsPointBonusPotion : Item
    {
        [Constructable]
        public PetHitsPointBonusPotion() : base(0x0F04)
        {
            Weight = 1.0;
Name = "Pet Hits Point Bonus Potion";
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
                from.Target = new HitsMaxSeed(this);
            }
        }
        public PetHitsPointBonusPotion(Serial serial) : base(serial)
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
    public class HitsMaxSeed : Target
    {
        private PetHitsPointBonusPotion m_Potion;
        public HitsMaxSeed(PetHitsPointBonusPotion potion) : base(1, false, TargetFlags.None)
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
                    if (t.HitsMaxSeed < 5000)
                    {
                        t.HitsMaxSeed += 1;
                        from.SendMessage("You have reinforced your pet by 1 point of hits point. Total: [{0}]", t.HitsMaxSeed);
                        m_Potion.Delete();
                    }
                    else
                    {
                        from.SendMessage("Your pet have a maximum hits point.");
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