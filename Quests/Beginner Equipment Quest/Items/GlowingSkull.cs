using System; 
using Server; 

namespace Server.Items 
{ 
   public class GlowingSkull : Item 
   { 
      [Constructable] 
      public GlowingSkull() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public GlowingSkull( int amount ) : base( 0x1AE4 ) 
      {
	 Name = "A Glowing Skull";
	 Stackable = false;
	 Hue = 1161;
         Weight = 0.1; 
         Amount = amount; 
      } 

      public GlowingSkull( Serial serial ) : base( serial ) 
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