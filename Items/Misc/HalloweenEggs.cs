//Created by Durant of GOP//
//based off of a pile of snow//
using System; 
using System.Collections; 
using Server.Network; 
using Server.Items; 
using Server.Targeting; 

namespace Server.Items 
{ 

   public class HalloweenEggs : Item 
   { 
      
		[Constructable]
		public HalloweenEggs() : base( 2485 )
		{
			Hue = 1150;
			Weight = 1.0;
			//LootType = LootType.Blessed;
                        Name = "Halloween Throwing Eggs";
		}

      public HalloweenEggs( Serial serial ) : base( serial ) 
      { 
      } 
private DateTime m_NextAbilityTime;
      public override void Serialize( GenericWriter writer ) 
      { 
         base.Serialize( writer ); 

         writer.Write( (int) 0 ); // version 
       
      } 

      public override void Deserialize( GenericReader reader ) 
      { 
         base.Deserialize( reader ); 

         int version = reader.ReadInt(); 
      	m_NextAbilityTime = DateTime.Now;
      } 
      
      public override void OnDoubleClick( Mobile from ) 
      { 
         if (!IsChildOf(from.Backpack)) 
         { 
            from.SendLocalizedMessage( 1042010 );  
            return; 
         } 
         else 
         { 
            
            if ( DateTime.Now >= m_NextAbilityTime )
			{
               from.Target = new EggTarget( from, this ); 
               from.SendMessage( "You hide the egg in your hand and prepare to throw" );    
            } 
            else 
            { 
               from.SendMessage( "You are not ready to throw the egg yet" ); 
            } 

         } 
			
    
      } 
       
      private class EggTarget : Target 
      { 
         private Mobile m_Thrower; 
		private HalloweenEggs m_Egg;

         public EggTarget( Mobile thrower, HalloweenEggs egg ) : base ( 10, false, TargetFlags.None ) 
         { 
         	m_Thrower = thrower;
			m_Egg=egg;
         } 
          
         protected override void OnTarget( Mobile from, object target ) 
         { 
            if( target == from ) 
               from.SendLocalizedMessage( 1005576 ); 
             
            else if( target is Mobile) 
            { 
               Mobile m = (Mobile)target; 
               from.PlaySound( 0x145 ); 
               from.Animate( 9, 1, 1, true, false, 0 ); 
               from.SendMessage( "You throw the eggs and strike your target" );    
               m.SendMessage( "The eggs splatter as they hit you" );  
               Effects.SendMovingEffect( from, m, 0x36E4, 7, 0, false, true, 1259, 0 ); 
               m_Egg.m_NextAbilityTime = DateTime.Now + TimeSpan.FromSeconds( 2.0 ) ;
        } 

            else 
            { 
               from.SendMessage( "You cannot throw more eggs yet" ); 
            } 
         } 
          
      } 
   } 
    

       
       
} 

