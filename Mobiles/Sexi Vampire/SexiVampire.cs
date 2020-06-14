// Created by Neptune

using System;
using Server.Items;

namespace Server.Mobiles

{
    [CorpseName(" corpse of Sexi Vampire")]
    public class SexiVampire : ChaosDaemon
    {
        [Constructable]
        public SexiVampire() : base()
        {
            Name = "Sexi Vampire";
            Hue = 33918;
            Body = 745;
            BodyMod = 0x2E8;
            BaseSoundID = 679;
            SetStr(1500);
            SetDex(1500);
            SetInt(2000);
            SetHits(65000);
            SetDamage(10, 20);
            SetDamageType(ResistanceType.Physical, 65);
            SetDamageType(ResistanceType.Cold, 65);
            SetDamageType(ResistanceType.Fire, 65);
            SetDamageType(ResistanceType.Energy, 65);
            SetDamageType(ResistanceType.Poison, 65);

            SetResistance(ResistanceType.Physical, 60);
            SetResistance(ResistanceType.Cold, 60);
            SetResistance(ResistanceType.Fire, 60);
            SetResistance(ResistanceType.Energy, 60);
            SetResistance(ResistanceType.Poison, 60);
            Fame = 12000;
            Karma = -1000;
            VirtualArmor = 50;

            PackGold(5000);

            SexiChest Chest = new SexiChest();
            Chest.Movable = false;
            AddItem(Chest);

            SexiSkirt Legs = new SexiSkirt();
            Legs.Movable = false;
            AddItem(Legs);

            SexiEyes Eyes = new SexiEyes();
            Eyes.Movable = false;
            AddItem(Eyes);

            SexiSandals Sandals = new SexiSandals();
            Sandals.Movable = false;
            AddItem(Sandals);

            BloodyKatana Weapon = new BloodyKatana();
            Weapon.Movable = false;
            AddItem(Weapon);

        }
        public override void GenerateLoot()
        {
            
            AddLoot(LootPack.Rich, 2);

            switch (Utility.Random(60))
            {
                case 0: PackItem(new BloodyKatana()); break;
                case 1: PackItem(new SexiSkirt()); break;
                case 2: PackItem(new SexiChest()); break;
                case 3: PackItem(new SexiSandals()); break;
                case 4: PackItem(new SexiEyes()); break;

            }
        }

        public override bool HasBreath { get { return true; } }
        public override int BreathFireDamage { get { return 3; } }
        public override int BreathColdDamage { get { return 3; } }
        //public override bool IsScaryToPets { get { return true; } }
        public override bool AutoDispel { get { return true; } }
        public override bool BardImmune { get { return true; } }
        public override bool Unprovokable { get { return true; } }
        public override Poison HitPoison { get { return Poison.Deadly; } }
        public override bool AlwaysMurderer { get { return true; } }

        public SexiVampire(Serial serial) : base(serial)
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
    }
}
