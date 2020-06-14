//Base Script By Lucid Nagual - Admin of The Conjuring//
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
	[CorpseName( "a pyro steed corpse" )]
	 
	public class PyroSteed : BaseWarHorse
	{
		

		[Constructable]
		public PyroSteed() :  base( 0x78, 0x3EAF, AIType.AI_Melee, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			int random = Utility.Random( 4 );
                        
                        Name = "A Pyro Steed";
			Hue = 1161;
			BaseSoundID = 0xA8;

			SetStr( 22, 98 );
			SetDex( 56, 75 );
			SetInt( 378, 500 );

			SetHits( 975, 1250 );
			SetMana( 500 );

			SetDamage( 30, 40 );

			SetDamageType( ResistanceType.Physical, 90 );

			SetResistance( ResistanceType.Physical, 75, 90 );
                        SetDamageType( ResistanceType.Fire, 100 );

			SetSkill( SkillName.MagicResist, 85.1, 90.0 );
			SetSkill( SkillName.Tactics, 99.3, 104.0 );
			SetSkill( SkillName.Wrestling, 109.3, 104.0 );

			Fame = 300;
			Karma = 300;

			Tamable = true;
			ControlSlots = 5;
			MinTameSkill = 92.1;
	
		Timer PondTimer = new InternalTimer(this);
		PondTimer.Start();
		}

		public override int Meat{ get{ return 3; } }
		public override int Hides{ get{ return 10; } }
		public override FoodType FavoriteFood{ get{ return FoodType.FruitsAndVegies | FoodType.GrainsAndHay; } }

		public PyroSteed( Serial serial ) : base( serial )
		{
		}

		public class InternalTimer: Timer
		{
			private PyroSteed Mare;
			//Line Below This: (TimeSpan.FromSeconds (this is where u adjust how long it takes the horse to poop)
			public InternalTimer(Mobile p): base( TimeSpan.FromSeconds( 5.0), TimeSpan.FromSeconds( 10.0))
		{
			Priority = TimerPriority.FiftyMS;
			Mare = ((PyroSteed) p);
		}

		protected override void OnTick()
		{
			object Fire = new Fire();
			Fire spawn = (Fire) Activator.CreateInstance(Fire.GetType() );
			spawn.Map = Mare.Map;
			spawn.Location = Mare.Location;
			Effects.PlaySound( spawn.Location, spawn.Map, 0x208);
		}
	}
				
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}





