//Created with Script Creator By Marak & Rockstar
//Oh, and Kevin Evans was here :P
using System;
using Server.Network;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Engines.CannedEvil;
using System.Collections;
using System.Collections.Generic;
using Server;

namespace Server.Mobiles
{
[CorpseName("Corpse of WraithKing")]
public class WraithKing:Lich
{

[Constructable]
public WraithKing() : base()
{

Name = "WraithKing";
SetStr (500) ;
SetDex (150) ;
SetInt (150) ;

SetDamage (30) ;

SetDamageType( ResistanceType.Physical,10) ;
SetDamageType( ResistanceType.Cold,10) ;
SetDamageType( ResistanceType.Fire,10) ;
SetDamageType( ResistanceType.Energy,10) ;
SetDamageType( ResistanceType.Poison,10) ;


SetResistance( ResistanceType.Physical,50) ;
SetResistance( ResistanceType.Cold,50) ;
SetResistance( ResistanceType.Fire,50) ;
SetResistance( ResistanceType.Energy,50) ;
SetResistance( ResistanceType.Poison,50) ;



VirtualArmor = 100;




}



		public WraithKing( Serial serial ) : base( serial )
		{
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
	        public override bool OnBeforeDeath()	
	        {	
	            	
		
	            if (!NoKillAwards)	
	            {	
		
	                Map map = this.Map;	
		
	                if (map != null)	
	                {	
	                    for (int x = -12; x <= 12; ++x)	
	                    {	
	                        for (int y = -12; y <= 12; ++y)	
	                        {	
	                            double dist = Math.Sqrt(x * x + y * y);	
		
	                            if (dist <= 12)	
	                                new GoodiesTimer(map, X + x, Y + y).Start();	
	                        }	
	                    }	
	                }	
	            }	
		
	            return base.OnBeforeDeath();	
	        }	
		
		    /*
	        public override void OnDeath(Container c)	
	        {	
	            if (Map == Map.Felucca)	
	            {	
	                //TODO: Confirm SE change or AoS one too?	
	                List<DamageStore> rights = BaseCreature.GetDamagerFrom(this.DamageEntries, this.HitsMax);	
	                List<Mobile> toGive = new List<Mobile>();	
		
	                for (int i = rights.Count - 1; i >= 0; --i)	
	                {	
	                    DamageStore ds = rights[i];	
		
	                    if (ds.m_HasRight)	
	                        toGive.Add(ds.m_Mobile);	
	                }	
		
	            }	
		
	            base.OnDeath(c);	
	        }	*/
		
		
	        private class GoodiesTimer : Timer	
	        {	
	            private Map m_Map;	
	            private int m_X, m_Y;	
		
	            public GoodiesTimer(Map map, int x, int y)	
	                : base(TimeSpan.FromSeconds(Utility.RandomDouble() * 10.0))	
	            {	
	                m_Map = map;	
	                m_X = x;	
	                m_Y = y;	
	            }	
		
	            protected override void OnTick()	
	            {	
	                int z = m_Map.GetAverageZ(m_X, m_Y);	
	                bool canFit = m_Map.CanFit(m_X, m_Y, z, 6, false, false);	
		
	                for (int i = -3; !canFit && i <= 3; ++i)	
	                {	
	                    canFit = m_Map.CanFit(m_X, m_Y, z + i, 6, false, false);	
		
	                    if (canFit)	
	                        z += i;	
	                }	
		
	                if (!canFit)	
	                    return;	
		
	                Tokens g = new Tokens(1000, 2000);	
		
	                g.MoveToWorld(new Point3D(m_X, m_Y, z), m_Map);	
		
	                if (0.5 >= Utility.RandomDouble())	
	                {	
	                    switch (Utility.Random(3))	
	                    {	
	                        case 0: // Fire column	
	                            {	
	                                Effects.SendLocationParticles(EffectItem.Create(g.Location, g.Map, EffectItem.DefaultDuration), 0x3709, 10, 30, 5052);	
	                                Effects.PlaySound(g, g.Map, 0x208);	
		
	                                break;	
	                            }	
	                        case 1: // Explosion	
	                            {	
	                                Effects.SendLocationParticles(EffectItem.Create(g.Location, g.Map, EffectItem.DefaultDuration), 0x36BD, 20, 10, 5044);	
	                                Effects.PlaySound(g, g.Map, 0x307);	
		
	                                break;	
	                            }	
	                        case 2: // Ball of fire	
	                            {	
	                                Effects.SendLocationParticles(EffectItem.Create(g.Location, g.Map, EffectItem.DefaultDuration), 0x36FE, 10, 10, 5052);	
		
	                                break;	
	                            }	
	                    }	
	                }	
	            }	
	        }	
	}
}
