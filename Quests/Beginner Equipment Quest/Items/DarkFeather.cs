using System; 
using Server; 

namespace Server.Items 
{ 
   public class DarkFeather : Item 
   { 
      [Constructable] 
      public DarkFeather() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public DarkFeather( int amount ) : base( 0x1BD1 ) 
      {
	 Name = "Dark Feather";
	 Stackable = false;
	 Hue = 952;
         Weight = 0.1; 
         Amount = amount; 
      } 

      public DarkFeather( Serial serial ) : base( serial ) 
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