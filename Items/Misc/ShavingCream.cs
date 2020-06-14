//Created by Durant of GOP//
//based off of a pile of snow//
using System; 
using System.Collections; 
using Server.Network; 
using Server.Items; 
using Server.Targeting; 

namespace Server.Items 
{ 

   public class ShavingCream : Item 
   { 
      
		[Constructable]
		public ShavingCream() : base( 4102 )
		{
			Hue = 1153;
			Weight = 1.0;
                        Name = "Shaving Cream";
		}

      public ShavingCream( Serial serial ) : base( serial ) 
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
               from.Target = new CreamTarget( from, this ); 
               from.SendMessage( "You hide the can of shaving cream as you get closer" );    
            } 
            else 
            { 
               from.SendMessage( "You are not ready to shoot the shaving cream yet" ); 
            } 

         } 
			
    
      } 
       
      private class CreamTarget : Target 
      { 
         private Mobile m_Thrower; 
		private ShavingCream m_Cream;

         public CreamTarget( Mobile thrower, ShavingCream cream ) : base ( 10, false, TargetFlags.None ) 
         { 
         	m_Thrower = thrower;
			m_Cream=cream;
         } 
          
         protected override void OnTarget( Mobile from, object target ) 
         { 
            if( target == from ) 
               from.SendLocalizedMessage( 1005576 ); 
             
            else if( target is Mobile) 
            { 
               Mobile m = (Mobile)target; 
               from.PlaySound( 0x1DE ); 
               //from.Animate( 9, 1, 1, true, false, 0 ); 
               from.SendMessage( "You shoot the shaving cream" );    
               m.SendMessage( "The shaving cream covers your face" );  
               Effects.SendMovingEffect( from, m, 0x36F4, 7, 0, false, true, 1149, 0 ); 
               m_Cream.m_NextAbilityTime = DateTime.Now + TimeSpan.FromSeconds( 2.0 ) ;
        } 

            else 
            { 
               from.SendMessage( "You cannot shoot more shaving cream yet" ); 
            } 
         } 
          
      } 
   } 
    

       
       
} 

