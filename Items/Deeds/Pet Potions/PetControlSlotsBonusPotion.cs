using System;
using Server.Mobiles;
using Server.Targeting;
namespace Server.Items
{
    public class PetControlSlotsBonusPotion : Item
    {
        [Constructable]
        public PetControlSlotsBonusPotion() : base(0x0F04)
        {
            Weight = 1.0;
Name = "Pet Control Slots Reduce Potion";
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
                from.Target = new ControlSlots(this);
            }
        }
        public PetControlSlotsBonusPotion(Serial serial) : base(serial)
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
    public class ControlSlots : Target
    {
        private PetControlSlotsBonusPotion m_Potion;
        public ControlSlots(PetControlSlotsBonusPotion potion) : base(1, false, TargetFlags.None)
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
                    if (t.ControlSlots > 10)
                    {
                        t.ControlSlots -= 1;
                        from.SendMessage("You have reduce your pet by 1 point of Control Slots . Total: [{0}]", t.ControlSlots);
                        m_Potion.Delete();
                    }
                    else
                    {
                        from.SendMessage("Your pet slots can't get any lower.");
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