/*
 * Created by SharpDevelop.
 * User: alexanderfb
 * Date: 1/25/2005
 * Time: 10:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using Server;

namespace Server.Items 
{
	[Flipable( 0x12AB, 0x12AC )]
	public class TarotDeck : Item
	{
		private static string GetFortune()
		{
			switch ( Utility.Random( 22 ) )
			{
				default:
				case 0: return "The Fool! Watch your step and use your head.";
				case 1: return "The Mage! You exhibit increased control of your destiny.";
				case 2: return "The High Priestess! Your path will become clear to you.";
				case 3: return "The Empress! Life is running smoothly."; 
				case 4: return "The Emperor! You must fight for what is yours.";
				case 5: return "The Hierophant! You must acknowledge your falliblity.";
				case 6: return "The Lovers! You will be faced with an important choice.";
				case 7: return "The Chariot! You are in a position to defeat your enemies. Strike now!";
				case 8: return "Justice! You will get what you deserve.";
				case 9: return "The Hermit! You will discover a great truth.";
				case 10: return "The Wheel! Your fate is based on the caprice of the gods.";
				case 11: return "Strength! You will face a great test of your endurance.";
				case 12: return "The Hanged Man! You must sacrifice to attain your goal.";
				case 13: return "Death! Your life will change completely soon.";
				case 14: return "Patience! You must be patient!";
				case 15: return "The Devil! Don't take the easy way out, it could mean destruction!";
				case 16: return "The Tower! You've overstepped your bounds.";
				case 17: return "The Star! What you seek is within your grasp.";
				case 18: return "The Moon! Be wary of forces beyond your control lest they control you!";
				case 19: return "The Sun! You've worked hard. Now enjoy the fruits of your labour.";
				case 20: return "Judgement! Your success is assured. Strike while the iron is hot!";
				case 21: return "The World! You have achieved a complete success in your endeavor.";
			}
		}
		
		[Constructable]
		public TarotDeck() : base( 0x12AB )
		{
			Name = "tarot deck";
		}
		
		public TarotDeck( Serial serial ) : base( serial ) 
		{ 
		}
	
		public override void Serialize( GenericWriter writer ) 
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
	
		public override void Deserialize(GenericReader reader) 
		{ 
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	
		public override void OnDoubleClick( Mobile from ) 
		{
			switch ( ((Item)this).ItemID )
			{
				case 0x12AB: // Closed north
					if ( Utility.Random( 2 ) == 0 )
						((Item)this).ItemID = 0x12A5;
					else
						((Item)this).ItemID = 0x12A8;
					break;
				case 0x12AC: // Closed east
					if ( Utility.Random( 2 ) == 0 )
						((Item)this).ItemID = 0x12A6;
					else
						((Item)this).ItemID = 0x12A7;
					break;
				case 0x12A5: from.SendMessage( GetFortune() ); break;
				case 0x12A6: from.SendMessage( GetFortune() ); break;
				case 0x12A8: from.SendMessage( GetFortune() ); break;
				case 0x12A7: from.SendMessage( GetFortune() ); break;
			}
		}
		
		public override void OnAdded(object target)
		{
			switch ( ((Item)this).ItemID )
			{
				case 0x12A5: ((Item)this).ItemID = 0x12AB; break; // Open north
				case 0x12A6: ((Item)this).ItemID = 0x12AC; break; // Open east
				case 0x12A8: ((Item)this).ItemID = 0x12AB; break; // Open north
				case 0x12A7: ((Item)this).ItemID = 0x12AC; break; // Open east
			}
		}
	}
	
	[Flipable( 0x12AB, 0x12AC )]
	public class DecoTarotDeck : Item
	{
		[Constructable]
		public DecoTarotDeck() : base( 0x12AB )
		{
			Name = "tarot deck";
		}
		
		public DecoTarotDeck( Serial serial ) : base( serial ) 
		{ 
		}
	
		public override void Serialize( GenericWriter writer ) 
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
	
		public override void Deserialize(GenericReader reader) 
		{ 
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	
		public override void OnDoubleClick( Mobile from ) 
		{
			switch ( ((Item)this).ItemID )
			{
				case 0x12AB: // Closed north
					if ( Utility.Random( 2 ) == 0 )
						((Item)this).ItemID = 0x12A5;
					else
						((Item)this).ItemID = 0x12A8;
					break;
				case 0x12AC: // Closed east
					if ( Utility.Random( 2 ) == 0 )
						((Item)this).ItemID = 0x12A6;
					else
						((Item)this).ItemID = 0x12A7;
					break;
				case 0x12A5: ((Item)this).ItemID = 0x12AB; break; // Open north
				case 0x12A6: ((Item)this).ItemID = 0x12AC; break; // Open east
				case 0x12A8: ((Item)this).ItemID = 0x12AB; break; // Open north
				case 0x12A7: ((Item)this).ItemID = 0x12AC; break; // Open east
			}
		}
	}
}
