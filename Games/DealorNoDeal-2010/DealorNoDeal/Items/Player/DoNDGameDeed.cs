using System;
using Server.Mobiles;

namespace Server.Items
{
	public class DoNDGameDeed : Item
	{
		private bool m_DealOrNot = false; //Override for deal or nodeal system
		private bool m_GameStart = false; //Game Start
		private bool m_GameOver = false; //Game Over
		private bool m_CaseSel = false; //Case Selection
		private bool m_OfferSel = false; //Offer Selection
		private bool m_Deal = false; //Deal
		private bool m_NoDeal = true; //No Deal
		private bool m_Trade = false; //Trade
		private bool m_NoTrade = false; //No Trade
		private bool m_Help = false; //Help Menu
		private bool m_CloseCase = false; //Case Closing Trigger
		private bool m_Commercial = false; //Commercial Closing Trigger

		private int m_CA1 = 0; //Case Amount 
		private int m_CA2 = 1; 
		private int m_CA3 = 5; 
		private int m_CA4 = 10; 
		private int m_CA5 = 25; 
		private int m_CA6 = 50; 
		private int m_CA7 = 75; 
		private int m_CA8 = 100; 
		private int m_CA9 = 200; 
		private int m_CA10 = 300; 
		private int m_CA11 = 400; 
		private int m_CA12 = 500; 
		private int m_CA13 = 750; 
		private int m_CA14 = 1000; 
		private int m_CA15 = 5000; 
		private int m_CA16 = 10000; 
		private int m_CA17 = 25000; 
		private int m_CA18 = 50000; 
		private int m_CA19 = 75000; 
		private int m_CA20 = 100000; 
		private int m_CA21 = 200000; 
		private int m_CA22 = 300000; 
		private int m_CA23 = 400000; 
		private int m_CA24 = 500000; 
		private int m_CA25 = 750000; 
		private int m_CA26 = 1000000; 

		private int m_DA1; //1 Deal Amount // Deal Level
		private int m_DA2; //2 
		private int m_DA3; //3 
		private int m_DA4; //4 
		private int m_DA5; //5 
		private int m_DA6; //6 
		private int m_DA7; //7 
		private int m_DA8; //8 
		private int m_DA9; //9 

        	private int m_PO = 0; //Pick Order / Case's Left
        	private int m_GO = 0; //Girl Order / Girl's Left
		private int m_PA = 0; //Pick Amount / First Case
		private int m_PC = 0; //Pick Amount / Any Case
		private int m_TL = 0; //Time Left
		private int m_Replay = 0; //Replay Time (hours)
		
		private bool m_One = false; // Stage Level
		private bool m_Two = false;
		private bool m_Three = false;
		private bool m_Four = false;
		private bool m_Five = false;
		private bool m_Six = false;
		private bool m_Seven = false;
		private bool m_Eight = false;
		private bool m_Nine = false;
		private bool m_Ten = false;

		private bool ms_One = false; // Sub Stage Level 1
		private bool ms_Two = false;
		private bool ms_Three = false;
		private bool ms_Four = false;
		private bool ms_Five = false;
		private bool ms_Six = false;
		private bool ms_Banker = false;

		private bool ms_One2 = false; // Sub Stage Level 2
		private bool ms_Two2 = false;
		private bool ms_Three2 = false;
		private bool ms_Four2 = false;
		private bool ms_Five2 = false;

		private bool ms_One3 = false; // Sub Stage Level 3
		private bool ms_Two3 = false;
		private bool ms_Three3 = false;
		private bool ms_Four3 = false;

		private bool ms_One4 = false; // Sub Stage Level 4
		private bool ms_Two4 = false;
		private bool ms_Three4 = false;

		private bool ms_One5 = false; // Sub Stage Level 5
		private bool ms_Two5 = false;

		private bool ms_One6 = false; // Sub Stage Level 6

		private bool ms_One7 = false; // Sub Stage Level 7

		private bool ms_One8 = false; // Sub Stage Level 8

		private bool ms_One9 = false; // Sub Stage Level 9

		private bool m_onemil = true; // VV $$$ right VV
		private bool m_sevfiveht = true;
		private bool m_fiveht = true;
		private bool m_fourht = true;
		private bool m_threeht = true;
		private bool m_twoht = true;
		private bool m_oneht = true;
		private bool m_sevfiveth = true;
		private bool m_fiftyth = true;
		private bool m_twefiveth = true;
		private bool m_tenth = true; 
		private bool m_fiveth = true;
		private bool m_oneth = true; // ^^ $$$ right ^^

		private bool m_sevfiveh = true; // VV $$$ left VV
		private bool m_fiveh = true;
		private bool m_fourh = true;
		private bool m_threeh = true;
		private bool m_twoh = true;
		private bool m_oneh = true;
		private bool m_sevfive = true;
		private bool m_fifty = true;
		private bool m_twefive = true;
		private bool m_ten = true; 
		private bool m_five = true;
		private bool m_one = true;
		private bool m_zero = true; // ^^ $$$ left ^^

		public bool DealOn
		{
			get{ return m_DealOrNot; }
			set{ m_DealOrNot = value; }
		}

		public bool GameStart
		{
			get{ return m_GameStart; }
			set{ m_GameStart = value; }
		}

		public bool GameOver
		{
			get{ return m_GameOver; }
			set{ m_GameOver = value; }
		}

		public bool CaseSel
		{
			get{ return m_CaseSel; }
			set{ m_CaseSel = value; }
		}

		public bool OfferSel
		{
			get{ return m_OfferSel; }
			set{ m_OfferSel = value; }
		}

		public bool Deal
		{
			get{ return m_Deal; }
			set{ m_Deal = value; }
		}

		public bool NoDeal
		{
			get{ return m_NoDeal; }
			set{ m_NoDeal = value; }
		}

		public bool Trade
		{
			get{ return m_Trade; }
			set{ m_Trade = value; }
		}

		public bool NoTrade
		{
			get{ return m_NoTrade; }
			set{ m_NoTrade = value; }
		}

		public bool DHelp
		{
			get{ return m_Help; }
			set{ m_Help = value; }
		}

		public bool CloseCase
		{
			get{ return m_CloseCase; }
			set{ m_CloseCase = value; }
		}

		public bool Commercial
		{
			get{ return m_Commercial; }
			set{ m_Commercial = value; }
		}

		public int CA1
		{
			get{ return m_CA1; }
			set{ m_CA1 = value; }
		}

		public int CA2
		{
			get{ return m_CA2; }
			set{ m_CA2 = value; }
		}

		public int CA3
		{
			get{ return m_CA3; }
			set{ m_CA3 = value; }
		}

		public int CA4
		{
			get{ return m_CA4; }
			set{ m_CA4 = value; }
		}

		public int CA5
		{
			get{ return m_CA5; }
			set{ m_CA5 = value; }
		}

		public int CA6
		{
			get{ return m_CA6; }
			set{ m_CA6 = value; }
		}

		public int CA7
		{
			get{ return m_CA7; }
			set{ m_CA7 = value; }
		}

		public int CA8
		{
			get{ return m_CA8; }
			set{ m_CA8 = value; }
		}

		public int CA9
		{
			get{ return m_CA9; }
			set{ m_CA9 = value; }
		}

		public int CA10
		{
			get{ return m_CA10; }
			set{ m_CA10 = value; }
		}

		public int CA11
		{
			get{ return m_CA11; }
			set{ m_CA11 = value; }
		}

		public int CA12
		{
			get{ return m_CA12; }
			set{ m_CA12 = value; }
		}

		public int CA13
		{
			get{ return m_CA13; }
			set{ m_CA13 = value; }
		}

		public int CA14
		{
			get{ return m_CA14; }
			set{ m_CA14 = value; }
		}

		public int CA15
		{
			get{ return m_CA15; }
			set{ m_CA15 = value; }
		}

		public int CA16
		{
			get{ return m_CA16; }
			set{ m_CA16 = value; }
		}

		public int CA17
		{
			get{ return m_CA17; }
			set{ m_CA17 = value; }
		}

		public int CA18
		{
			get{ return m_CA18; }
			set{ m_CA18 = value; }
		}

		public int CA19
		{
			get{ return m_CA19; }
			set{ m_CA19 = value; }
		}

		public int CA20
		{
			get{ return m_CA20; }
			set{ m_CA20 = value; }
		}

		public int CA21
		{
			get{ return m_CA21; }
			set{ m_CA21 = value; }
		}

		public int CA22
		{
			get{ return m_CA22; }
			set{ m_CA22 = value; }
		}

		public int CA23
		{
			get{ return m_CA23; }
			set{ m_CA23 = value; }
		}

		public int CA24
		{
			get{ return m_CA24; }
			set{ m_CA24 = value; }
		}

		public int CA25
		{
			get{ return m_CA25; }
			set{ m_CA25 = value; }
		}

		public int CA26
		{
			get{ return m_CA26; }
			set{ m_CA26 = value; }
		}

		public int DA1
		{
			get{ return m_DA1; }
			set{ m_DA1 = value; }
		}

		public int DA2
		{
			get{ return m_DA2; }
			set{ m_DA2 = value; }
		}

		public int DA3
		{
			get{ return m_DA3; }
			set{ m_DA3 = value; }
		}

		public int DA4
		{
			get{ return m_DA4; }
			set{ m_DA4 = value; }
		}

		public int DA5
		{
			get{ return m_DA5; }
			set{ m_DA5 = value; }
		}

		public int DA6
		{
			get{ return m_DA6; }
			set{ m_DA6 = value; }
		}

		public int DA7
		{
			get{ return m_DA7; }
			set{ m_DA7 = value; }
		}

		public int DA8
		{
			get{ return m_DA8; }
			set{ m_DA8 = value; }
		}

		public int DA9
		{
			get{ return m_DA9; }
			set{ m_DA9 = value; }
		}

        	public int PO
        	{
            		get { return m_PO; }
            		set { m_PO = value; }
        	}

        	public int GO
        	{
            		get { return m_GO; }
            		set { m_GO = value; }
        	}

        	public int PA
        	{
            		get { return m_PA; }
            		set { m_PA = value; }
        	}

        	public int PC
        	{
            		get { return m_PC; }
            		set { m_PC = value; }
        	}

        	public int TL
        	{
            		get { return m_TL; }
            		set { m_TL = value; }
        	}

        	public int DReplay
        	{
            		get { return m_Replay; }
            		set { m_Replay = value; }
        	}

		public bool StageOne
		{
			get{ return m_One; }
			set{ m_One = value; }
		}

		public bool StageTwo
		{
			get{ return m_Two; }
			set{ m_Two = value; }
		}

		public bool StageThree
		{
			get{ return m_Three; }
			set{ m_Three = value; }
		}

		public bool StageFour
		{
			get{ return m_Four; }
			set{ m_Four = value; }
		}

		public bool StageFive
		{
			get{ return m_Five; }
			set{ m_Five = value; }
		}

		public bool StageSix
		{
			get{ return m_Six; }
			set{ m_Six = value; }
		}

		public bool StageSeven
		{
			get{ return m_Seven; }
			set{ m_Seven = value; }
		}

		public bool StageEight
		{
			get{ return m_Eight; }
			set{ m_Eight = value; }
		}

		public bool StageNine
		{
			get{ return m_Nine; }
			set{ m_Nine = value; }
		}

		public bool StageTen
		{
			get{ return m_Ten; }
			set{ m_Ten = value; }
		}

		public bool SubStageOne
		{
			get{ return ms_One; }
			set{ ms_One = value; }
		}

		public bool SubStageTwo
		{
			get{ return ms_Two; }
			set{ ms_Two = value; }
		}

		public bool SubStageThree
		{
			get{ return ms_Three; }
			set{ ms_Three = value; }
		}

		public bool SubStageFour
		{
			get{ return ms_Four; }
			set{ ms_Four = value; }
		}

		public bool SubStageFive
		{
			get{ return ms_Five; }
			set{ ms_Five = value; }
		}

		public bool SubStageSix
		{
			get{ return ms_Six; }
			set{ ms_Six = value; }
		}

		public bool Banker
		{
			get{ return ms_Banker; }
			set{ ms_Banker = value; }
		}

		public bool SubStageOne2
		{
			get{ return ms_One2; }
			set{ ms_One2 = value; }
		}

		public bool SubStageTwo2
		{
			get{ return ms_Two2; }
			set{ ms_Two2 = value; }
		}

		public bool SubStageThree2
		{
			get{ return ms_Three2; }
			set{ ms_Three2 = value; }
		}

		public bool SubStageFour2
		{
			get{ return ms_Four2; }
			set{ ms_Four2 = value; }
		}

		public bool SubStageFive2
		{
			get{ return ms_Five2; }
			set{ ms_Five2 = value; }
		}

		public bool SubStageOne3
		{
			get{ return ms_One3; }
			set{ ms_One3 = value; }
		}

		public bool SubStageTwo3
		{
			get{ return ms_Two3; }
			set{ ms_Two3 = value; }
		}

		public bool SubStageThree3
		{
			get{ return ms_Three3; }
			set{ ms_Three3 = value; }
		}

		public bool SubStageFour3
		{
			get{ return ms_Four3; }
			set{ ms_Four3 = value; }
		}

		public bool SubStageOne4
		{
			get{ return ms_One4; }
			set{ ms_One4 = value; }
		}

		public bool SubStageTwo4
		{
			get{ return ms_Two4; }
			set{ ms_Two4 = value; }
		}

		public bool SubStageThree4
		{
			get{ return ms_Three4; }
			set{ ms_Three4 = value; }
		}

		public bool SubStageOne5
		{
			get{ return ms_One5; }
			set{ ms_One5 = value; }
		}

		public bool SubStageTwo5
		{
			get{ return ms_Two5; }
			set{ ms_Two5 = value; }
		}

		public bool SubStageOne6
		{
			get{ return ms_One6; }
			set{ ms_One6 = value; }
		}

		public bool SubStageOne7
		{
			get{ return ms_One7; }
			set{ ms_One7 = value; }
		}

		public bool SubStageOne8
		{
			get{ return ms_One8; }
			set{ ms_One8 = value; }
		}

		public bool SubStageOne9
		{
			get{ return ms_One9; }
			set{ ms_One9 = value; }
		}

		public bool OneMil
		{
			get{ return m_onemil; }
			set{ m_onemil = value; }
		}

		public bool SevFiveHT
		{
			get{ return m_sevfiveht; }
			set{ m_sevfiveht = value; }
		}

		public bool FiveHT
		{
			get{ return m_fiveht; }
			set{ m_fiveht = value; }
		}

		public bool FourHT
		{
			get{ return m_fourht; }
			set{ m_fourht = value; }
		}

		public bool ThreeHT
		{
			get{ return m_threeht; }
			set{ m_threeht = value; }
		}

		public bool TwoHT
		{
			get{ return m_twoht; }
			set{ m_twoht = value; }
		}

		public bool OneHT
		{
			get{ return m_oneht; }
			set{ m_oneht = value; }
		}

		public bool SevFiveTH
		{
			get{ return m_sevfiveth; }
			set{ m_sevfiveth = value; }
		}

		public bool FiftyTH
		{
			get{ return m_fiftyth; }
			set{ m_fiftyth = value; }
		}

		public bool TweFiveTH
		{
			get{ return m_twefiveth; }
			set{ m_twefiveth = value; }
		}

		public bool TenTH
		{
			get{ return m_tenth; }
			set{ m_tenth = value; }
		}

		public bool FiveTH
		{
			get{ return m_fiveth; }
			set{ m_fiveth = value; }
		}

		public bool OneTH
		{
			get{ return m_oneth; }
			set{ m_oneth = value; }
		}

		public bool SevFiveH
		{
			get{ return m_sevfiveh; }
			set{ m_sevfiveh = value; }
		}

		public bool FiveH
		{
			get{ return m_fiveh; }
			set{ m_fiveh = value; }
		}

		public bool FourH
		{
			get{ return m_fourh; }
			set{ m_fourh = value; }
		}

		public bool ThreeH
		{
			get{ return m_threeh; }
			set{ m_threeh = value; }
		}

		public bool TwoH
		{
			get{ return m_twoh; }
			set{ m_twoh = value; }
		}

		public bool OneH
		{
			get{ return m_oneh; }
			set{ m_oneh = value; }
		}

		public bool SevFive
		{
			get{ return m_sevfive; }
			set{ m_sevfive = value; }
		}

		public bool Fifty
		{
			get{ return m_fifty; }
			set{ m_fifty = value; }
		}

		public bool TweFive
		{
			get{ return m_twefive; }
			set{ m_twefive = value; }
		}

		public bool Ten
		{
			get{ return m_ten; }
			set{ m_ten = value; }
		}

		public bool Five
		{
			get{ return m_five; }
			set{ m_five = value; }
		}

		public bool One
		{
			get{ return m_one; }
			set{ m_one = value; }
		}

		public bool Zero
		{
			get{ return m_zero; }
			set{ m_zero = value; }
		}

		[Constructable]
		public DoNDGameDeed( Mobile m, Mobile b ) : base( 0x14EF )
		{
			PlayerMobile pm = m as PlayerMobile;

			if ( pm == null )
				return;

			Howey hm = b as Howey;

			if ( hm == null )
				return;

			DReplay = hm.MReplay;

			Name = "DoND Game Deed for : " + pm.Name;
			LootType = LootType.Blessed;
			Weight = 0.0;

			Visible = false;
			Movable = false;
		}

		public override bool DisplayLootType{ get{ return false; } }

		public DoNDGameDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

			writer.Write( (bool)m_DealOrNot);
			writer.Write( (bool)m_GameStart);
			writer.Write( (bool)m_GameOver);
			writer.Write( (bool)m_CaseSel);
			writer.Write( (bool)m_OfferSel);
			writer.Write( (bool)m_Deal);
			writer.Write( (bool)m_NoDeal);
			writer.Write( (bool)m_Trade);
			writer.Write( (bool)m_NoTrade);
			writer.Write( (bool)m_Help);
			writer.Write( (bool)m_CloseCase);
			writer.Write( (bool)m_Commercial);

			writer.Write( (int)m_CA1 );
			writer.Write( (int)m_CA2 );
			writer.Write( (int)m_CA3 );
			writer.Write( (int)m_CA4 );
			writer.Write( (int)m_CA5 );
			writer.Write( (int)m_CA6 );
			writer.Write( (int)m_CA7 );
			writer.Write( (int)m_CA8 );
			writer.Write( (int)m_CA9 );
			writer.Write( (int)m_CA10 );
			writer.Write( (int)m_CA11 );
			writer.Write( (int)m_CA12 );
			writer.Write( (int)m_CA13 );
			writer.Write( (int)m_CA14 );
			writer.Write( (int)m_CA15 );
			writer.Write( (int)m_CA16 );
			writer.Write( (int)m_CA17 );
			writer.Write( (int)m_CA18 );
			writer.Write( (int)m_CA19 );
			writer.Write( (int)m_CA20 );
			writer.Write( (int)m_CA21 );
			writer.Write( (int)m_CA22 );
			writer.Write( (int)m_CA23 );
			writer.Write( (int)m_CA24 );
			writer.Write( (int)m_CA25 );
			writer.Write( (int)m_CA26 );

			writer.Write( (int)m_DA1 );
			writer.Write( (int)m_DA2 );
			writer.Write( (int)m_DA3 );
			writer.Write( (int)m_DA4 );
			writer.Write( (int)m_DA5 );
			writer.Write( (int)m_DA6 );
			writer.Write( (int)m_DA7 );
			writer.Write( (int)m_DA8 );
			writer.Write( (int)m_DA9 );

            		writer.Write( (int)m_PO);
            		writer.Write( (int)m_GO);
			writer.Write( (int)m_PA);
			writer.Write( (int)m_PC);
			writer.Write( (int)m_TL);
			writer.Write( (int)m_Replay);

			writer.Write( (bool)m_One);
			writer.Write( (bool)m_Two);
			writer.Write( (bool)m_Three);
			writer.Write( (bool)m_Four);
			writer.Write( (bool)m_Five);
			writer.Write( (bool)m_Six);
			writer.Write( (bool)m_Seven);
			writer.Write( (bool)m_Eight);
			writer.Write( (bool)m_Nine);
			writer.Write( (bool)m_Ten);

			writer.Write( (bool)ms_One);
			writer.Write( (bool)ms_Two);
			writer.Write( (bool)ms_Three);
			writer.Write( (bool)ms_Four);
			writer.Write( (bool)ms_Five);
			writer.Write( (bool)ms_Six);
			writer.Write( (bool)ms_Banker);

			writer.Write( (bool)ms_One2);
			writer.Write( (bool)ms_Two2);
			writer.Write( (bool)ms_Three2);
			writer.Write( (bool)ms_Four2);
			writer.Write( (bool)ms_Five2);

			writer.Write( (bool)ms_One3);
			writer.Write( (bool)ms_Two3);
			writer.Write( (bool)ms_Three3);
			writer.Write( (bool)ms_Four3);

			writer.Write( (bool)ms_One4);
			writer.Write( (bool)ms_Two4);
			writer.Write( (bool)ms_Three4);

			writer.Write( (bool)ms_One5);
			writer.Write( (bool)ms_Two5);

			writer.Write( (bool)ms_One6);

			writer.Write( (bool)ms_One7);

			writer.Write( (bool)ms_One8);

			writer.Write( (bool)ms_One9);

			writer.Write( (bool)m_onemil);
			writer.Write( (bool)m_sevfiveht);
			writer.Write( (bool)m_fiveht);
			writer.Write( (bool)m_fourht);
			writer.Write( (bool)m_threeht);
			writer.Write( (bool)m_twoht);
			writer.Write( (bool)m_oneht);
			writer.Write( (bool)m_sevfiveth);
			writer.Write( (bool)m_fiftyth);
			writer.Write( (bool)m_twefiveth);
			writer.Write( (bool)m_tenth);
			writer.Write( (bool)m_fiveth);
			writer.Write( (bool)m_oneth);

			writer.Write( (bool)m_sevfiveh);
			writer.Write( (bool)m_fiveh);
			writer.Write( (bool)m_fourh);
			writer.Write( (bool)m_threeh);
			writer.Write( (bool)m_twoh);
			writer.Write( (bool)m_oneh);
			writer.Write( (bool)m_sevfive);
			writer.Write( (bool)m_fifty);
			writer.Write( (bool)m_twefive);
			writer.Write( (bool)m_ten);
			writer.Write( (bool)m_five);
			writer.Write( (bool)m_one);
			writer.Write( (bool)m_zero);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 0:
				{
					m_DealOrNot = (bool)reader.ReadBool();
					m_GameStart = (bool)reader.ReadBool();
					m_GameOver = (bool)reader.ReadBool();
					m_CaseSel = (bool)reader.ReadBool();
					m_OfferSel = (bool)reader.ReadBool();
					m_Deal = (bool)reader.ReadBool();
					m_NoDeal = (bool)reader.ReadBool();
					m_Trade = (bool)reader.ReadBool();
					m_NoTrade = (bool)reader.ReadBool();
					m_Help = (bool)reader.ReadBool();
					m_CloseCase = (bool)reader.ReadBool();
					m_Commercial = (bool)reader.ReadBool();

					m_CA1 = (int)reader.ReadInt();
					m_CA2 = (int)reader.ReadInt();
					m_CA3 = (int)reader.ReadInt();
					m_CA4 = (int)reader.ReadInt();
					m_CA5 = (int)reader.ReadInt();
					m_CA6 = (int)reader.ReadInt();
					m_CA7 = (int)reader.ReadInt();
					m_CA8 = (int)reader.ReadInt();
					m_CA9 = (int)reader.ReadInt();
					m_CA10 = (int)reader.ReadInt();
					m_CA11 = (int)reader.ReadInt();
					m_CA12 = (int)reader.ReadInt();
					m_CA13 = (int)reader.ReadInt();
					m_CA14 = (int)reader.ReadInt();
					m_CA15 = (int)reader.ReadInt();
					m_CA16 = (int)reader.ReadInt();
					m_CA17 = (int)reader.ReadInt();
					m_CA18 = (int)reader.ReadInt();
					m_CA19 = (int)reader.ReadInt();
					m_CA20 = (int)reader.ReadInt();
					m_CA21 = (int)reader.ReadInt();
					m_CA22 = (int)reader.ReadInt();
					m_CA23 = (int)reader.ReadInt();
					m_CA24 = (int)reader.ReadInt();
					m_CA25 = (int)reader.ReadInt();
					m_CA26 = (int)reader.ReadInt();

					m_DA1 = (int)reader.ReadInt();
					m_DA2 = (int)reader.ReadInt();
					m_DA3 = (int)reader.ReadInt();
					m_DA4 = (int)reader.ReadInt();
					m_DA5 = (int)reader.ReadInt();
					m_DA6 = (int)reader.ReadInt();
					m_DA7 = (int)reader.ReadInt();
					m_DA8 = (int)reader.ReadInt();
					m_DA9 = (int)reader.ReadInt();

                    			m_PO = (int)reader.ReadInt();
                    			m_GO = (int)reader.ReadInt();
					m_PA = (int)reader.ReadInt();
					m_PC = (int)reader.ReadInt();
					m_TL = (int)reader.ReadInt();
					m_Replay = (int)reader.ReadInt();
					
					m_One = (bool)reader.ReadBool();
					m_Two = (bool)reader.ReadBool();
					m_Three = (bool)reader.ReadBool();
					m_Four = (bool)reader.ReadBool();
					m_Five = (bool)reader.ReadBool();
					m_Six = (bool)reader.ReadBool();
					m_Seven = (bool)reader.ReadBool();
					m_Eight = (bool)reader.ReadBool();
					m_Nine = (bool)reader.ReadBool();
					m_Ten = (bool)reader.ReadBool();

					ms_One = (bool)reader.ReadBool();
					ms_Two = (bool)reader.ReadBool();
					ms_Three = (bool)reader.ReadBool();
					ms_Four = (bool)reader.ReadBool();
					ms_Five = (bool)reader.ReadBool();
					ms_Six = (bool)reader.ReadBool();
					ms_Banker = (bool)reader.ReadBool();

					ms_One2 = (bool)reader.ReadBool();
					ms_Two2 = (bool)reader.ReadBool();
					ms_Three2 = (bool)reader.ReadBool();
					ms_Four2 = (bool)reader.ReadBool();
					ms_Five2 = (bool)reader.ReadBool();

					ms_One3 = (bool)reader.ReadBool();
					ms_Two3 = (bool)reader.ReadBool();
					ms_Three3 = (bool)reader.ReadBool();
					ms_Four3 = (bool)reader.ReadBool();

					ms_One4 = (bool)reader.ReadBool();
					ms_Two4 = (bool)reader.ReadBool();
					ms_Three4 = (bool)reader.ReadBool();

					ms_One5 = (bool)reader.ReadBool();
					ms_Two5 = (bool)reader.ReadBool();

					ms_One6 = (bool)reader.ReadBool();

					ms_One7 = (bool)reader.ReadBool();

					ms_One8 = (bool)reader.ReadBool();

					ms_One9 = (bool)reader.ReadBool();

					m_onemil = (bool)reader.ReadBool();
					m_sevfiveht = (bool)reader.ReadBool();
					m_fiveht = (bool)reader.ReadBool();
					m_fourht = (bool)reader.ReadBool();
					m_threeht = (bool)reader.ReadBool();
					m_twoht = (bool)reader.ReadBool();
					m_oneht = (bool)reader.ReadBool();
					m_sevfiveth = (bool)reader.ReadBool();
					m_fiftyth = (bool)reader.ReadBool();
					m_twefiveth = (bool)reader.ReadBool();
					m_tenth = (bool)reader.ReadBool();
					m_fiveth = (bool)reader.ReadBool();
					m_oneth = (bool)reader.ReadBool();

					m_sevfiveh = (bool)reader.ReadBool();
					m_fiveh = (bool)reader.ReadBool();
					m_fourh = (bool)reader.ReadBool();
					m_threeh = (bool)reader.ReadBool();
					m_twoh = (bool)reader.ReadBool();
					m_oneh = (bool)reader.ReadBool();
					m_sevfive = (bool)reader.ReadBool();
					m_fifty = (bool)reader.ReadBool();
					m_twefive = (bool)reader.ReadBool();
					m_ten = (bool)reader.ReadBool();
					m_five = (bool)reader.ReadBool();
					m_one = (bool)reader.ReadBool();
					m_zero = (bool)reader.ReadBool();
					break;
				}
			}
		}
	}
}