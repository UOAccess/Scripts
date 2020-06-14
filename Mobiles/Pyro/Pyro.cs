//Pyro And Changes By Home Wrecker aka Amon////////////
//////////////////////////////////////////////////////

using System;
using Server.Mobiles;
using Server.Items;
using Server.Misc;
using Server.Multis;
using Server.Network;
using Server.Targeting;
using System.Collections;

namespace Server.Mobiles
{
	[CorpseName( "Pyro" )]
	public class Pyro : BaseCreature
	{
		[Constructable]
		public Pyro() : base( AIType.AI_Melee, FightMode.Closest, 10, 5, 1.5, 0.75 )
		{		
			Name = "Pyro";
			Title = "The Fire Breather";
			Body = 401;
			Hue = 1161;
			Kills = 50;

			SetStr( 100, 150 );
			SetDex( 90, 100 );
			SetInt( 90, 110 );

			SetHits( 2000, 2500 );

			SetDamage( 30, 80 );

			SetDamageType( ResistanceType.Physical, 35 );
			SetDamageType( ResistanceType.Fire, 100 );
			SetDamageType( ResistanceType.Cold, 50 );
			SetDamageType( ResistanceType.Energy, 35 );
			SetDamageType( ResistanceType.Poison, 10 );

			SetResistance( ResistanceType.Physical, 40, 40 );
			SetResistance( ResistanceType.Fire, 40, 40 );
			SetResistance( ResistanceType.Cold, 40, 40 );
			SetResistance( ResistanceType.Energy, 40, 40 );
			SetResistance( ResistanceType.Poison, 20, 60 );

            SetSkill( SkillName.Tactics, 100.1, 120.0 );
			SetSkill( SkillName.Wrestling, 100.1, 120.0 );

			Fame = 0;
			Karma = 0;

			VirtualArmor = 100;
            PackGold( 800, 850 );
             
            Item hair = new Item( Utility.RandomList( 8265 ) );
			hair.Hue = 1159;
			hair.Layer = Layer.Hair;
			hair.Movable = false;
			AddItem( hair );

			Bandana hat = new Bandana();
			hat.Name = "Pyro Head Band";
			hat.Hue = 1159;
			hat.Movable = false;
			AddItem( hat );

			LeatherBustierArms chest = new LeatherBustierArms();
			chest.Name = "Pyro Chest";
			chest.Hue = 1159;
			chest.Movable = false;
			AddItem( chest );

			LeatherGorget gorget = new LeatherGorget();
			gorget.Name = "Pyro Choker";
			gorget.Hue = 1159;
			gorget.Movable = false;
			AddItem( gorget );

			LeatherGloves gloves = new LeatherGloves();
			gloves.Name = "Pryo Gloves";
			gloves.Hue = 1159;
			gloves.Movable = false;
			AddItem( gloves );

			LeatherSkirt skirt = new LeatherSkirt();
			skirt.Name = "Pyro Skirt";
			skirt.Hue = 1159;
			skirt.Movable = false;
			AddItem( skirt );

		

			Sandals sandals = new Sandals();
			sandals.Name = "Pyro Nikes";
			sandals.Hue = 1159;
			sandals.Movable = false;
			AddItem( sandals );
                        
                        new PyroSteed().Rider = this; 
                        switch ( Utility.Random( 2 ) )

			{
				case 0: PackItem( new Luckyscharm() ); break;
				
                 }
		}

		public override void GenerateLoot()
		{
			switch( Utility.Random( 3 ) )
			{
				case 0: AddLoot( LootPack.Average );
					  AddLoot( LootPack.Average );
					  break;

				case 1: AddLoot( LootPack.Rich );
					  AddLoot( LootPack.Rich );
					  break;

				case 2: AddLoot( LootPack.FilthyRich );
					  break;

				case 3: AddLoot( LootPack.Average );
					  AddLoot( LootPack.Rich );
					  AddLoot( LootPack.FilthyRich );
					  break;
			}
                         
		}
                public override bool HasBreath{ get{ return true; } }

		public Pyro( Serial serial ) : base( serial )
		{
		}
              
                
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
