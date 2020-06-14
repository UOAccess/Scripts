using System; 
using Server; 

namespace Server.Items 
{ 
   public class SavageHead : Item 
   { 
      [Constructable] 
      public SavageHead() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public SavageHead( int amount ) : base( 0x1DA0 ) 
      {
	 Name = "A Savage's Head";
	 Stackable = false;
	 Hue = 1153;
         Weight = 0.1; 
         Amount = amount; 
      } 

      public SavageHead( Serial serial ) : base( serial ) 
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