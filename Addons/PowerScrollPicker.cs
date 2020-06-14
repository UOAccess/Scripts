// 
//		Originally by: Methril
//			Last Edited:
//
//		Version 1.0.1
//
using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Commands;
using Server.Mobiles;
using Server.Prompts;
using Server.Items;
using Server.Targeting;

namespace Server.Items
{
	public class ChampionPowerScroll : Item
	{
		[Constructable]
		public ChampionPowerScroll() : base( 0x14F0 )
		{
			Name = "Champion Power Scroll";
			Weight = 1.0;
			Hue = 88;
			ItemID = 8707;
		}
		
		public ChampionPowerScroll( Serial serial ) : base( serial ) { }

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) ) from.SendLocalizedMessage( 1042001 );
			else from.SendGump( new PowerScrollPicker( from, this ) );
		}
		
		private class PowerScrollPicker : Gump
		{
			private Mobile m_From;
			private ChampionPowerScroll m_Deed;

			public PowerScrollPicker(Mobile from , ChampionPowerScroll deed) : base( 50, 50 )
			{
				m_From = from;
				m_Deed = deed;
				
				from.CloseGump( typeof( PowerScrollPicker ) );
				
				// this.Closable=false;
				this.Disposable=true;
				this.Dragable=true;
				this.Resizable=false;

				AddPage(0);
				AddBackground(0, 0, 475, 596, 9270);
				AddLabel(128, 17, 52, @"Choose  a  120  Power  Scroll");
				AddButton(27, 58, 11410, 11400, 1, GumpButtonType.Reply, 0);
				AddLabel(51, 57, 52, @"Alchemy");
				AddButton(27, 85, 11410, 11400, 2, GumpButtonType.Reply, 0);
				AddLabel(51, 84, 52, @"Anatomy");
				AddButton(27, 112, 11410, 11400, 3, GumpButtonType.Reply, 0);
				AddLabel(51, 111, 52, @"AnimalLore");
				AddButton(27, 139, 11410, 11400, 4, GumpButtonType.Reply, 0);
				AddLabel(51, 138, 52, @"AnimalTaming");
				AddButton(27, 166, 11410, 11400, 5, GumpButtonType.Reply, 0);
				AddLabel(51, 165, 52, @"Archery");
				AddButton(27, 193, 11410, 11400, 6, GumpButtonType.Reply, 0);
				AddLabel(51, 192, 52, @"ArmsLore");
				AddButton(27, 220, 11410, 11400, 7, GumpButtonType.Reply, 0);
				AddLabel(51, 219, 52, @"Begging");
				AddButton(27, 247, 11410, 11400, 8, GumpButtonType.Reply, 0);
				AddLabel(51, 246, 52, @"Blacksmith");
				AddButton(27, 274, 11410, 11400, 9, GumpButtonType.Reply, 0);
				AddLabel(51, 273, 52, @"Bushido");
				AddButton(27, 301, 11410, 11400, 10, GumpButtonType.Reply, 0);
				AddLabel(51, 300, 52, @"Camping");
				AddButton(27, 328, 11410, 11400, 11, GumpButtonType.Reply, 0);
				AddLabel(51, 327, 52, @"Carpentry");
				AddButton(27, 355, 11410, 11400, 12, GumpButtonType.Reply, 0);
				AddLabel(51, 354, 52, @"Cartography");
				AddButton(27, 382, 11410, 11400, 13, GumpButtonType.Reply, 0);
				AddLabel(51, 381, 52, @"Chivalry");
				AddButton(27, 409, 11410, 11400, 14, GumpButtonType.Reply, 0);
				AddLabel(51, 408, 52, @"Cooking");
				AddButton(27, 436, 11410, 11400, 15, GumpButtonType.Reply, 0);
				AddLabel(51, 435, 52, @"DetectHidden");
				AddButton(27, 463, 11410, 11400, 16, GumpButtonType.Reply, 0);
				AddLabel(51, 462, 52, @"Discordance");
				AddButton(27, 490, 11410, 11400, 17, GumpButtonType.Reply, 0);
				AddLabel(51, 489, 52, @"EvalInt");
				AddButton(27, 517, 11410, 11400, 18, GumpButtonType.Reply, 0);
				AddLabel(51, 516, 52, @"Fencing");
				AddButton(185, 58, 11410, 11400, 19, GumpButtonType.Reply, 0);
				AddLabel(209, 57, 52, @"Fletching");
				AddButton(185, 85, 11410, 11400, 20, GumpButtonType.Reply, 0);
				AddLabel(209, 84, 52, @"Focus");
				AddButton(185, 112, 11410, 11400, 21, GumpButtonType.Reply, 0);
				AddLabel(209, 111, 52, @"Forensics");
				AddButton(185, 139, 11410, 11400, 22, GumpButtonType.Reply, 0);
				AddLabel(209, 138, 52, @"Healing");
				AddButton(185, 166, 11410, 11400, 23, GumpButtonType.Reply, 0);
				AddLabel(209, 165, 52, @"Herding");
				AddButton(185, 193, 11410, 11400, 24, GumpButtonType.Reply, 0);
				AddLabel(209, 192, 52, @"Hiding");
				AddButton(185, 220, 11410, 11400, 25, GumpButtonType.Reply, 0);
				AddLabel(209, 219, 52, @"Inscribe");
				AddButton(185, 247, 11410, 11400, 26, GumpButtonType.Reply, 0);
				AddLabel(209, 246, 52, @"ItemID");
				AddButton(185, 274, 11410, 11400, 27, GumpButtonType.Reply, 0);
				AddLabel(209, 273, 52, @"Lockpicking");
				AddButton(185, 301, 11410, 11400, 28, GumpButtonType.Reply, 0);
				AddLabel(209, 300, 52, @"Lumberjacking");
				AddButton(185, 328, 11410, 11400, 29, GumpButtonType.Reply, 0);
				AddLabel(209, 327, 52, @"Macing");
				AddButton(185, 355, 11410, 11400, 30, GumpButtonType.Reply, 0);
				AddLabel(209, 354, 52, @"Magery");
				AddButton(185, 382, 11410, 11400, 31, GumpButtonType.Reply, 0);
				AddLabel(209, 381, 52, @"MagicResist");
				AddButton(185, 409, 11410, 11400, 32, GumpButtonType.Reply, 0);
				AddLabel(209, 408, 52, @"Meditation");
				AddButton(185, 436, 11410, 11400, 33, GumpButtonType.Reply, 0);
				AddLabel(209, 435, 52, @"Mining");
				AddButton(185, 463, 11410, 11400, 34, GumpButtonType.Reply, 0);
				AddLabel(209, 462, 52, @"Musicianship");
				AddButton(185, 490, 11410, 11400, 35, GumpButtonType.Reply, 0);
				AddLabel(209, 489, 52, @"Fishing");
				AddButton(185, 517, 11410, 11400, 36, GumpButtonType.Reply, 0);
				AddLabel(209, 516, 52, @"Necromancy");
				AddButton(344, 58, 11410, 11400, 37, GumpButtonType.Reply, 0);
				AddLabel(368, 57, 52, @"Ninjitsu");
				AddButton(344, 85, 11410, 11400, 38, GumpButtonType.Reply, 0);
				AddLabel(368, 84, 52, @"Parry");
				AddButton(344, 112, 11410, 11400, 39, GumpButtonType.Reply, 0);
				AddLabel(368, 111, 52, @"Peacemaking");
				AddButton(344, 139, 11410, 11400, 40, GumpButtonType.Reply, 0);
				AddLabel(368, 138, 52, @"Poisoning");
				AddButton(344, 166, 11410, 11400, 41, GumpButtonType.Reply, 0);
				AddLabel(368, 165, 52, @"Provocation");
				AddButton(344, 193, 11410, 11400, 42, GumpButtonType.Reply, 0);
				AddLabel(368, 192, 52, @"RemoveTrap");
				AddButton(344, 220, 11410, 11400, 43, GumpButtonType.Reply, 0);
				AddLabel(368, 219, 52, @"Snooping");
				AddButton(344, 247, 11410, 11400, 44, GumpButtonType.Reply, 0);
				AddLabel(368, 246, 52, @"Spellweaving");
				AddButton(344, 274, 11410, 11400, 45, GumpButtonType.Reply, 0);
				AddLabel(368, 273, 52, @"SpiritSpeak");
				AddButton(344, 301, 11410, 11400, 46, GumpButtonType.Reply, 0);
				AddLabel(368, 300, 52, @"Stealing");
				AddButton(344, 328, 11410, 11400, 47, GumpButtonType.Reply, 0);
				AddLabel(368, 327, 52, @"Stealth");
				AddButton(344, 355, 11410, 11400, 48, GumpButtonType.Reply, 0);
				AddLabel(368, 354, 52, @"Swords");
				AddButton(344, 382, 11410, 11400, 49, GumpButtonType.Reply, 0);
				AddLabel(368, 381, 52, @"Tactics");
				AddButton(344, 409, 11410, 11400, 50, GumpButtonType.Reply, 0);
				AddLabel(368, 408, 52, @"Tailoring");
				AddButton(344, 436, 11410, 11400, 51, GumpButtonType.Reply, 0);
				AddLabel(368, 435, 52, @"TasteID");
				AddButton(344, 463, 11410, 11400, 52, GumpButtonType.Reply, 0);
				AddLabel(368, 462, 52, @"Tinkering");
				AddButton(344, 490, 11410, 11400, 53, GumpButtonType.Reply, 0);
				AddLabel(368, 489, 52, @"Tracking");
				AddButton(344, 517, 11410, 11400, 54, GumpButtonType.Reply, 0);
				AddLabel(368, 516, 52, @"Veterinary");
				AddButton(344, 544, 11410, 11400, 55, GumpButtonType.Reply, 0);
				AddLabel(368, 543, 52, @"Wrestling");
				AddButton(15, 557, 4017, 4018, 56, GumpButtonType.Reply, 0);
				AddLabel(51, 559, 10, @"CLOSE  GUMP");
			}

			public override void OnResponse(NetState sender, RelayInfo info)
			{
				if ( m_Deed.Deleted ) return;

				PowerScroll scroll = null;
				
				switch(info.ButtonID)
				{
					case 0: return;
					case 1: scroll = new PowerScroll(SkillName.Alchemy, 120.0) ; break;
					case 2: scroll = new PowerScroll(SkillName.Anatomy, 120.0) ; break;
					case 3: scroll = new PowerScroll(SkillName.AnimalLore, 120.0) ; break;
					case 4: scroll = new PowerScroll(SkillName.AnimalTaming, 120.0) ; break;
					case 5: scroll = new PowerScroll(SkillName.Archery, 120.0) ; break;
					case 6: scroll = new PowerScroll(SkillName.ArmsLore, 120.0) ; break;
					case 7: scroll = new PowerScroll(SkillName.Begging, 120.0) ; break;
					case 8: scroll = new PowerScroll(SkillName.Blacksmith, 120.0) ; break;
					case 9: scroll = new PowerScroll(SkillName.Bushido, 120.0) ; break;
					case 10: scroll = new PowerScroll(SkillName.Camping, 120.0) ; break;
					case 11: scroll = new PowerScroll(SkillName.Carpentry, 120.0) ; break;
					case 12: scroll = new PowerScroll(SkillName.Cartography, 120.0) ; break;
					case 13: scroll = new PowerScroll(SkillName.Chivalry, 120.0) ; break;
					case 14: scroll = new PowerScroll(SkillName.Cooking, 120.0) ; break;
					case 15: scroll = new PowerScroll(SkillName.DetectHidden, 120.0) ; break;
					case 16: scroll = new PowerScroll(SkillName.Discordance, 120.0) ; break;
					case 17: scroll = new PowerScroll(SkillName.EvalInt, 120.0) ; break;
					case 18: scroll = new PowerScroll(SkillName.Fencing, 120.0) ; break;
					case 19: scroll = new PowerScroll(SkillName.Fletching, 120.0) ; break;
					case 20: scroll = new PowerScroll(SkillName.Focus, 120.0) ; break;
					case 21: scroll = new PowerScroll(SkillName.Forensics, 120.0) ; break;
					case 22: scroll = new PowerScroll(SkillName.Healing, 120.0) ; break;
					case 23: scroll = new PowerScroll(SkillName.Herding, 120.0) ; break;
					case 24: scroll = new PowerScroll(SkillName.Hiding, 120.0) ; break;
					case 25: scroll = new PowerScroll(SkillName.Inscribe, 120.0) ; break;
					case 26: scroll = new PowerScroll(SkillName.ItemID, 120.0) ; break;
					case 27: scroll = new PowerScroll(SkillName.Lockpicking, 120.0) ; break;
					case 28: scroll = new PowerScroll(SkillName.Lumberjacking, 120.0) ; break;
					case 29: scroll = new PowerScroll(SkillName.Macing, 120.0) ; break;
					case 30: scroll = new PowerScroll(SkillName.Magery, 120.0) ; break;
					case 31: scroll = new PowerScroll(SkillName.MagicResist, 120.0) ; break;
					case 32: scroll = new PowerScroll(SkillName.Meditation, 120.0) ; break;
					case 33: scroll = new PowerScroll(SkillName.Mining, 120.0) ; break;
					case 34: scroll = new PowerScroll(SkillName.Musicianship, 120.0) ; break;
					case 35: scroll = new PowerScroll(SkillName.Fishing, 120.0) ; break;
					case 36: scroll = new PowerScroll(SkillName.Necromancy, 120.0) ; break;
					case 37: scroll = new PowerScroll(SkillName.Ninjitsu, 120.0) ; break;
					case 38: scroll = new PowerScroll(SkillName.Parry, 120.0) ; break;
					case 39: scroll = new PowerScroll(SkillName.Peacemaking, 120.0) ; break;
					case 40: scroll = new PowerScroll(SkillName.Poisoning, 120.0) ; break;
					case 41: scroll = new PowerScroll(SkillName.Provocation, 120.0) ; break;
					case 42: scroll = new PowerScroll(SkillName.RemoveTrap, 120.0) ; break;
					case 43: scroll = new PowerScroll(SkillName.Snooping, 120.0) ; break;
					case 44: scroll = new PowerScroll(SkillName.Spellweaving, 120.0) ; break;
					case 45: scroll = new PowerScroll(SkillName.SpiritSpeak, 120.0) ; break;
					case 46: scroll = new PowerScroll(SkillName.Stealing, 120.0) ; break;
					case 47: scroll = new PowerScroll(SkillName.Stealth, 120.0) ; break;
					case 48: scroll = new PowerScroll(SkillName.Swords, 120.0) ; break;
					case 49: scroll = new PowerScroll(SkillName.Tactics, 120.0) ; break;
					case 50: scroll = new PowerScroll(SkillName.Tailoring, 120.0) ; break;
					case 51: scroll = new PowerScroll(SkillName.TasteID, 120.0) ; break;
					case 52: scroll = new PowerScroll(SkillName.Tinkering, 120.0) ; break;
					case 53: scroll = new PowerScroll(SkillName.Tracking, 120.0) ; break;
					case 54: scroll = new PowerScroll(SkillName.Veterinary, 120.0) ; break;
					case 55: scroll = new PowerScroll(SkillName.Wrestling, 120.0) ; break;
					case 56: return;
				}
				
				if ( scroll != null )
				{
					m_From.Backpack.DropItem( scroll );
					m_From.SendMessage( "A Powerscroll has been added to your backpack!" );
					m_Deed.Delete();
				}
			}
		}
		
		public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
	}

	public class PowerScrollChoice : Item
	{
		private double m_DeedLevel = 120.0;
		
		[CommandProperty( AccessLevel.GameMaster )]
        public double DeedLevel
        {
            get { return m_DeedLevel; }
            set { m_DeedLevel = value; InvalidateProperties(); }
        }
		
		[Constructable]
		public PowerScrollChoice() : this ( 120.0 )
		{
		}
		
		[Constructable]
		public PowerScrollChoice(double SkillLvl) : base( 0x14F0 )
		{
			m_DeedLevel = SkillLvl;
			
			Name = "Champion Power Scroll";
			Weight = 1.0;
			Hue = 88;
			ItemID = 8707;
		}
		
		public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);
			list.Add(String.Format("Scroll: +" + m_DeedLevel));
        }
		
		public PowerScrollChoice( Serial serial ) : base( serial ) { }

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) ) from.SendLocalizedMessage( 1042001 );
			else from.SendGump( new PowerScrollPicker( from, this, m_DeedLevel ) );
		}
		
		private class PowerScrollPicker : Gump
		{
			private Mobile m_From;
			private PowerScrollChoice m_Deed;
			private double m_DeedLevel;

			public PowerScrollPicker(Mobile from , PowerScrollChoice deed, double DeedLevel) : base( 50, 50 )
			{
				m_From = from;
				m_Deed = deed;
				m_DeedLevel = DeedLevel;
				
				from.CloseGump( typeof( PowerScrollPicker ) );
				
				this.Disposable=true;
				this.Dragable=true;
				this.Resizable=false;

				AddPage(0);
				AddBackground(0, 0, 475, 596, 9270);
				AddLabel(128, 17, 52, @"Choose  a "  + m_DeedLevel +  " Power  Scroll");
				AddButton(27, 58, 11410, 11400, 1, GumpButtonType.Reply, 0);
				AddLabel(51, 57, 52, @"Alchemy");
				AddButton(27, 85, 11410, 11400, 2, GumpButtonType.Reply, 0);
				AddLabel(51, 84, 52, @"Anatomy");
				AddButton(27, 112, 11410, 11400, 3, GumpButtonType.Reply, 0);
				AddLabel(51, 111, 52, @"AnimalLore");
				AddButton(27, 139, 11410, 11400, 4, GumpButtonType.Reply, 0);
				AddLabel(51, 138, 52, @"AnimalTaming");
				AddButton(27, 166, 11410, 11400, 5, GumpButtonType.Reply, 0);
				AddLabel(51, 165, 52, @"Archery");
				AddButton(27, 193, 11410, 11400, 6, GumpButtonType.Reply, 0);
				AddLabel(51, 192, 52, @"ArmsLore");
				AddButton(27, 220, 11410, 11400, 7, GumpButtonType.Reply, 0);
				AddLabel(51, 219, 52, @"Begging");
				AddButton(27, 247, 11410, 11400, 8, GumpButtonType.Reply, 0);
				AddLabel(51, 246, 52, @"Blacksmith");
				AddButton(27, 274, 11410, 11400, 9, GumpButtonType.Reply, 0);
				AddLabel(51, 273, 52, @"Bushido");
				AddButton(27, 301, 11410, 11400, 10, GumpButtonType.Reply, 0);
				AddLabel(51, 300, 52, @"Camping");
				AddButton(27, 328, 11410, 11400, 11, GumpButtonType.Reply, 0);
				AddLabel(51, 327, 52, @"Carpentry");
				AddButton(27, 355, 11410, 11400, 12, GumpButtonType.Reply, 0);
				AddLabel(51, 354, 52, @"Cartography");
				AddButton(27, 382, 11410, 11400, 13, GumpButtonType.Reply, 0);
				AddLabel(51, 381, 52, @"Chivalry");
				AddButton(27, 409, 11410, 11400, 14, GumpButtonType.Reply, 0);
				AddLabel(51, 408, 52, @"Cooking");
				AddButton(27, 436, 11410, 11400, 15, GumpButtonType.Reply, 0);
				AddLabel(51, 435, 52, @"DetectHidden");
				AddButton(27, 463, 11410, 11400, 16, GumpButtonType.Reply, 0);
				AddLabel(51, 462, 52, @"Discordance");
				AddButton(27, 490, 11410, 11400, 17, GumpButtonType.Reply, 0);
				AddLabel(51, 489, 52, @"EvalInt");
				AddButton(27, 517, 11410, 11400, 18, GumpButtonType.Reply, 0);
				AddLabel(51, 516, 52, @"Fencing");
				AddButton(185, 58, 11410, 11400, 19, GumpButtonType.Reply, 0);
				AddLabel(209, 57, 52, @"Fletching");
				AddButton(185, 85, 11410, 11400, 20, GumpButtonType.Reply, 0);
				AddLabel(209, 84, 52, @"Focus");
				AddButton(185, 112, 11410, 11400, 21, GumpButtonType.Reply, 0);
				AddLabel(209, 111, 52, @"Forensics");
				AddButton(185, 139, 11410, 11400, 22, GumpButtonType.Reply, 0);
				AddLabel(209, 138, 52, @"Healing");
				AddButton(185, 166, 11410, 11400, 23, GumpButtonType.Reply, 0);
				AddLabel(209, 165, 52, @"Herding");
				AddButton(185, 193, 11410, 11400, 24, GumpButtonType.Reply, 0);
				AddLabel(209, 192, 52, @"Hiding");
				AddButton(185, 220, 11410, 11400, 25, GumpButtonType.Reply, 0);
				AddLabel(209, 219, 52, @"Inscribe");
				AddButton(185, 247, 11410, 11400, 26, GumpButtonType.Reply, 0);
				AddLabel(209, 246, 52, @"ItemID");
				AddButton(185, 274, 11410, 11400, 27, GumpButtonType.Reply, 0);
				AddLabel(209, 273, 52, @"Lockpicking");
				AddButton(185, 301, 11410, 11400, 28, GumpButtonType.Reply, 0);
				AddLabel(209, 300, 52, @"Lumberjacking");
				AddButton(185, 328, 11410, 11400, 29, GumpButtonType.Reply, 0);
				AddLabel(209, 327, 52, @"Macing");
				AddButton(185, 355, 11410, 11400, 30, GumpButtonType.Reply, 0);
				AddLabel(209, 354, 52, @"Magery");
				AddButton(185, 382, 11410, 11400, 31, GumpButtonType.Reply, 0);
				AddLabel(209, 381, 52, @"MagicResist");
				AddButton(185, 409, 11410, 11400, 32, GumpButtonType.Reply, 0);
				AddLabel(209, 408, 52, @"Meditation");
				AddButton(185, 436, 11410, 11400, 33, GumpButtonType.Reply, 0);
				AddLabel(209, 435, 52, @"Mining");
				AddButton(185, 463, 11410, 11400, 34, GumpButtonType.Reply, 0);
				AddLabel(209, 462, 52, @"Musicianship");
				AddButton(185, 490, 11410, 11400, 35, GumpButtonType.Reply, 0);
				AddLabel(209, 489, 52, @"Fishing");
				AddButton(185, 517, 11410, 11400, 36, GumpButtonType.Reply, 0);
				AddLabel(209, 516, 52, @"Necromancy");
				AddButton(344, 58, 11410, 11400, 37, GumpButtonType.Reply, 0);
				AddLabel(368, 57, 52, @"Ninjitsu");
				AddButton(344, 85, 11410, 11400, 38, GumpButtonType.Reply, 0);
				AddLabel(368, 84, 52, @"Parry");
				AddButton(344, 112, 11410, 11400, 39, GumpButtonType.Reply, 0);
				AddLabel(368, 111, 52, @"Peacemaking");
				AddButton(344, 139, 11410, 11400, 40, GumpButtonType.Reply, 0);
				AddLabel(368, 138, 52, @"Poisoning");
				AddButton(344, 166, 11410, 11400, 41, GumpButtonType.Reply, 0);
				AddLabel(368, 165, 52, @"Provocation");
				AddButton(344, 193, 11410, 11400, 42, GumpButtonType.Reply, 0);
				AddLabel(368, 192, 52, @"RemoveTrap");
				AddButton(344, 220, 11410, 11400, 43, GumpButtonType.Reply, 0);
				AddLabel(368, 219, 52, @"Snooping");
				AddButton(344, 247, 11410, 11400, 44, GumpButtonType.Reply, 0);
				AddLabel(368, 246, 52, @"Spellweaving");
				AddButton(344, 274, 11410, 11400, 45, GumpButtonType.Reply, 0);
				AddLabel(368, 273, 52, @"SpiritSpeak");
				AddButton(344, 301, 11410, 11400, 46, GumpButtonType.Reply, 0);
				AddLabel(368, 300, 52, @"Stealing");
				AddButton(344, 328, 11410, 11400, 47, GumpButtonType.Reply, 0);
				AddLabel(368, 327, 52, @"Stealth");
				AddButton(344, 355, 11410, 11400, 48, GumpButtonType.Reply, 0);
				AddLabel(368, 354, 52, @"Swords");
				AddButton(344, 382, 11410, 11400, 49, GumpButtonType.Reply, 0);
				AddLabel(368, 381, 52, @"Tactics");
				AddButton(344, 409, 11410, 11400, 50, GumpButtonType.Reply, 0);
				AddLabel(368, 408, 52, @"Tailoring");
				AddButton(344, 436, 11410, 11400, 51, GumpButtonType.Reply, 0);
				AddLabel(368, 435, 52, @"TasteID");
				AddButton(344, 463, 11410, 11400, 52, GumpButtonType.Reply, 0);
				AddLabel(368, 462, 52, @"Tinkering");
				AddButton(344, 490, 11410, 11400, 53, GumpButtonType.Reply, 0);
				AddLabel(368, 489, 52, @"Tracking");
				AddButton(344, 517, 11410, 11400, 54, GumpButtonType.Reply, 0);
				AddLabel(368, 516, 52, @"Veterinary");
				AddButton(344, 544, 11410, 11400, 55, GumpButtonType.Reply, 0);
				AddLabel(368, 543, 52, @"Wrestling");
				AddButton(15, 557, 4017, 4018, 56, GumpButtonType.Reply, 0);
				AddLabel(51, 559, 10, @"CLOSE  GUMP");
			}

			public override void OnResponse(NetState sender, RelayInfo info)
			{
				if ( m_Deed.Deleted ) return;

				PowerScroll scroll = null;
				
				switch(info.ButtonID)
				{
					case 0: return;
					case 1: scroll = new PowerScroll(SkillName.Alchemy, m_DeedLevel) ; break;
					case 2: scroll = new PowerScroll(SkillName.Anatomy, m_DeedLevel) ; break;
					case 3: scroll = new PowerScroll(SkillName.AnimalLore, m_DeedLevel) ; break;
					case 4: scroll = new PowerScroll(SkillName.AnimalTaming, m_DeedLevel) ; break;
					case 5: scroll = new PowerScroll(SkillName.Archery, m_DeedLevel) ; break;
					case 6: scroll = new PowerScroll(SkillName.ArmsLore, m_DeedLevel) ; break;
					case 7: scroll = new PowerScroll(SkillName.Begging, m_DeedLevel) ; break;
					case 8: scroll = new PowerScroll(SkillName.Blacksmith, m_DeedLevel) ; break;
					case 9: scroll = new PowerScroll(SkillName.Bushido, m_DeedLevel) ; break;
					case 10: scroll = new PowerScroll(SkillName.Camping, m_DeedLevel) ; break;
					case 11: scroll = new PowerScroll(SkillName.Carpentry, m_DeedLevel) ; break;
					case 12: scroll = new PowerScroll(SkillName.Cartography, m_DeedLevel) ; break;
					case 13: scroll = new PowerScroll(SkillName.Chivalry, m_DeedLevel) ; break;
					case 14: scroll = new PowerScroll(SkillName.Cooking, m_DeedLevel) ; break;
					case 15: scroll = new PowerScroll(SkillName.DetectHidden, m_DeedLevel) ; break;
					case 16: scroll = new PowerScroll(SkillName.Discordance, m_DeedLevel) ; break;
					case 17: scroll = new PowerScroll(SkillName.EvalInt, m_DeedLevel) ; break;
					case 18: scroll = new PowerScroll(SkillName.Fencing, m_DeedLevel) ; break;
					case 19: scroll = new PowerScroll(SkillName.Fletching, m_DeedLevel) ; break;
					case 20: scroll = new PowerScroll(SkillName.Focus, m_DeedLevel) ; break;
					case 21: scroll = new PowerScroll(SkillName.Forensics, m_DeedLevel) ; break;
					case 22: scroll = new PowerScroll(SkillName.Healing, m_DeedLevel) ; break;
					case 23: scroll = new PowerScroll(SkillName.Herding, m_DeedLevel) ; break;
					case 24: scroll = new PowerScroll(SkillName.Hiding, m_DeedLevel) ; break;
					case 25: scroll = new PowerScroll(SkillName.Inscribe, m_DeedLevel) ; break;
					case 26: scroll = new PowerScroll(SkillName.ItemID, m_DeedLevel) ; break;
					case 27: scroll = new PowerScroll(SkillName.Lockpicking, m_DeedLevel) ; break;
					case 28: scroll = new PowerScroll(SkillName.Lumberjacking, m_DeedLevel) ; break;
					case 29: scroll = new PowerScroll(SkillName.Macing, m_DeedLevel) ; break;
					case 30: scroll = new PowerScroll(SkillName.Magery, m_DeedLevel) ; break;
					case 31: scroll = new PowerScroll(SkillName.MagicResist, m_DeedLevel) ; break;
					case 32: scroll = new PowerScroll(SkillName.Meditation, m_DeedLevel) ; break;
					case 33: scroll = new PowerScroll(SkillName.Mining, m_DeedLevel) ; break;
					case 34: scroll = new PowerScroll(SkillName.Musicianship, m_DeedLevel) ; break;
					case 35: scroll = new PowerScroll(SkillName.Fishing, m_DeedLevel) ; break;
					case 36: scroll = new PowerScroll(SkillName.Necromancy, m_DeedLevel) ; break;
					case 37: scroll = new PowerScroll(SkillName.Ninjitsu, m_DeedLevel) ; break;
					case 38: scroll = new PowerScroll(SkillName.Parry, m_DeedLevel) ; break;
					case 39: scroll = new PowerScroll(SkillName.Peacemaking, m_DeedLevel) ; break;
					case 40: scroll = new PowerScroll(SkillName.Poisoning, m_DeedLevel) ; break;
					case 41: scroll = new PowerScroll(SkillName.Provocation, m_DeedLevel) ; break;
					case 42: scroll = new PowerScroll(SkillName.RemoveTrap, m_DeedLevel) ; break;
					case 43: scroll = new PowerScroll(SkillName.Snooping, m_DeedLevel) ; break;
					case 44: scroll = new PowerScroll(SkillName.Spellweaving, m_DeedLevel) ; break;
					case 45: scroll = new PowerScroll(SkillName.SpiritSpeak, m_DeedLevel) ; break;
					case 46: scroll = new PowerScroll(SkillName.Stealing, m_DeedLevel) ; break;
					case 47: scroll = new PowerScroll(SkillName.Stealth, m_DeedLevel) ; break;
					case 48: scroll = new PowerScroll(SkillName.Swords, m_DeedLevel) ; break;
					case 49: scroll = new PowerScroll(SkillName.Tactics, m_DeedLevel) ; break;
					case 50: scroll = new PowerScroll(SkillName.Tailoring, m_DeedLevel) ; break;
					case 51: scroll = new PowerScroll(SkillName.TasteID, m_DeedLevel) ; break;
					case 52: scroll = new PowerScroll(SkillName.Tinkering, m_DeedLevel) ; break;
					case 53: scroll = new PowerScroll(SkillName.Tracking, m_DeedLevel) ; break;
					case 54: scroll = new PowerScroll(SkillName.Veterinary, m_DeedLevel) ; break;
					case 55: scroll = new PowerScroll(SkillName.Wrestling, m_DeedLevel) ; break;
					case 56: return;
				}
				
				if ( scroll != null )
				{
					m_From.Backpack.DropItem( scroll );
					m_From.SendMessage( "A" + m_DeedLevel + " Powerscroll has been added to your backpack!" );
					m_Deed.Delete();
				}
			}
		}
		
		public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
			writer.Write(m_DeedLevel);
        }
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
			m_DeedLevel = reader.ReadInt();
        }
	}
}