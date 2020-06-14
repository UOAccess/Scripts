using System; 
using Server; 

namespace Server.Items 
{ 
   public class RodentBlood : Item 
   { 
      [Constructable] 
      public RodentBlood() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public RodentBlood( int amount ) : base( 0xF7D ) 
      {
	 Name = "Rodent's Blood";
	 Stackable = false;
	 Weight = 0.1; 
         Amount = amount; 
      } 

      public RodentBlood( Serial serial ) : base( serial ) 
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
   } 
}