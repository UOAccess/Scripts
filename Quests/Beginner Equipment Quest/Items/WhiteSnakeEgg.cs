using System; 
using Server; 

namespace Server.Items 
{ 
   public class WhiteSnakeEgg : Item 
   { 
      [Constructable] 
      public WhiteSnakeEgg() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public WhiteSnakeEgg( int amount ) : base( 0x1726 ) 
      {
	 Name = "A White Snake's Egg";
	 Stackable = false;
	 Hue = 1153;
         Weight = 0.1; 
         Amount = amount; 
      } 

      public WhiteSnakeEgg( Serial serial ) : base( serial ) 
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