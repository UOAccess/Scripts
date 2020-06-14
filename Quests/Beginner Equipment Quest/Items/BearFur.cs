using System; 
using Server; 

namespace Server.Items 
{ 
   public class BearFur : Item 
   { 
      [Constructable] 
      public BearFur() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public BearFur( int amount ) : base( 0x1545 ) 
      {
	 Name = "Bear Fur";
	 Stackable = false;
	 Hue = 538;
         Weight = 0.1; 
         Amount = amount; 
      } 

      public BearFur( Serial serial ) : base( serial ) 
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