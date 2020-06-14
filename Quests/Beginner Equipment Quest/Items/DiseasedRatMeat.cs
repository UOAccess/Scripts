using System; 
using Server; 

namespace Server.Items 
{ 
   public class DiseasedRatMeat : Item 
   { 
      [Constructable] 
      public DiseasedRatMeat() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public DiseasedRatMeat( int amount ) : base( 0x9C9 ) 
      {
	 Name = "Diseased Rat Meat";
	 Stackable = false;
	 Hue = 903;
         Weight = 0.1; 
         Amount = amount; 
      } 

      public DiseasedRatMeat( Serial serial ) : base( serial ) 
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