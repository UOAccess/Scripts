   
  /*Created by Hammerhand*/
 
using System;
using System.Text;
using System.Collections;
using Server;
using Server.Prompts;
using Server.Gumps;
using Server.Network;
using Server.Items;
using Server.Misc;
using Server.Targeting;
using Server.Commands;


namespace Server.Items
{
    public class SwordOfInsults : BaseSword
    {
        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.ArmorIgnore; } }

        public override int ArtifactRarity { get { return 1405; } }
        public override int InitMinHits { get { return 250; } }
        public override int InitMaxHits { get { return 255; } }
        public override int AosSpeed { get { return 33; } }

        public override int AosStrengthReq { get { return 50; } }
        public override int AosMinDamage { get { return 25; } }
        public override int AosMaxDamage { get { return 35; } }

        private DateTime timeTalk = DateTime.Now;

        [Constructable]
        public SwordOfInsults()
            : base(0xF5E)
        {
            Name = "Sword Of Insults";
            Hue = 1167;
            Attributes.SpellChanneling = 1;
            Attributes.BonusStr = 10;
            Attributes.BonusDex = 10;
            Attributes.Luck = 100;
            Attributes.AttackChance = 10;
            Attributes.WeaponSpeed = 25;

            WeaponAttributes.HitDispel = 5;
            WeaponAttributes.HitLightning = 15;
            WeaponAttributes.HitFireball = 10;
            WeaponAttributes.SelfRepair = 5;

        }

        public SwordOfInsults(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }

        public override void OnHit(Mobile attacker, IDamageable defender, double damageBonus)
        {
            base.OnHit(attacker, defender, damageBonus);

            if (DateTime.Now >= timeTalk)
            {
                switch (Utility.Random(40))
                {
                    case 0: attacker.Say("If you try really hard, you just might hurt me.."); break;
                    case 1: attacker.Say("Are you trying to kill me, or dance with me?"); break;
                    case 2: attacker.Say("What are you doing? Fanning me because I look hot?"); break;
                    case 3: attacker.Say("My grandma hits harder than that!"); break;
                    case 4: attacker.Say("What was THAT? A LOVE tap?"); break;
                    case 5: attacker.Say("Armor ignore? How about MONSTER ignore?"); break;
                    case 6: attacker.Say("You look like you're swatting flies!"); break;
                    case 7: attacker.Say("What is this? A dance contest??"); break;
                    case 8: attacker.Say("Yaaawwwnnn.. Wake me up later, will you?"); break;
                    case 9: attacker.Say("Ohhhh Did that hurt??"); break;

                }
                timeTalk = DateTime.Now + TimeSpan.FromSeconds(2.5);  // To set delay time for sword speech
            }
        }
    }
}
	
