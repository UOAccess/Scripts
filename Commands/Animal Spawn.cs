using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Commands;
using System.Collections;
using System.Collections.Generic;

namespace Server
{
    public class AnimalSpawnGenerator
    {
        public static Mobile player;

        private static Rectangle2D[] m_BritRegions = new Rectangle2D[]
            {
                //new Rectangle2D( new Point2D( 0, 0 ), new Point2D( 5119, 4094 ) ),
                new Rectangle2D( new Point2D( 0, 0 ), new Point2D( 6142, 4094 ) ),
            };

        /*
		private static XmlSpawner.SpawnObject spawnAnimal01;
		private static XmlSpawner.SpawnObject spawnAnimal02;
		private static XmlSpawner.SpawnObject spawnAnimal03;
		private static XmlSpawner.SpawnObject spawnAnimal04;
		private static XmlSpawner.SpawnObject spawnAnimal05;
		private static XmlSpawner.SpawnObject spawnAnimal06;
		private static XmlSpawner.SpawnObject spawnAnimal07;
		private static XmlSpawner.SpawnObject spawnAnimal08;
		private static XmlSpawner.SpawnObject spawnAnimal09;
		private static XmlSpawner.SpawnObject spawnAnimal10;
		private static XmlSpawner.SpawnObject spawnAnimal11;
		private static XmlSpawner.SpawnObject spawnAnimal12;
        */
        private static XmlSpawner.SpawnObject[] spawnOres = new XmlSpawner.SpawnObject[12];

        private static int[] m_Criterion = new int[]
            {
			  //Trees
				0xC9E, 0xCA8, 0xCAA, 0xCCA, 0xCCB, 0xCCC, 0xCCD, 0xCD0, 0xCD3, 0xCD6, 0xCD8, 0xCDA, 0xCDD, 0xCE0, 0xCE3,
                0xCE6, 0xCF8, 0xCFB, 0xCFE, 0xD01, 0xD43, 0xD59, 0xD70, 0xD85, 0xD94, 0xD98, 0xD9C, 0xDA0, 0xDA4, 0xDA8,
				
				//Rocks
        4943, 4944, 4945, 4946, 4947, 4948, 4949, 4950, 4951, 4951, 4953, 4954, 4955, 4956, 4957, 4958, 4959,
        4960, 4961, 4962, 4963, 4964, 4965, 4966, 4967, 4968, 4969, 4970, 4971, 4972, 4973, 6001, 6002, 6003,
        6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 13121, 13122, 13123, 13124, 13125, 13126, 13127,
        13128, 13129, 13130, 13131, 13132, 13133, 13134, 13135, 13136, 13137, 13354, 13355, 13361, 13362, 13363,
        13364, 13365, 13366, 13367, 13368, 13369, 13625, 13626, 13627, 13628,
				//0x12B9,
			};

        public static void Initialize()
        {
            CommandSystem.Register("AnimalSpawnGen", AccessLevel.Administrator, new CommandEventHandler(AnimalSpawnGen_OnCommand));
            CommandSystem.Register("AnimalSpawnRem", AccessLevel.Administrator, new CommandEventHandler(AnimalSpawnRem_OnCommand));

            //spawnOreVain = new XmlSpawner.SpawnObject("RandomOreVain", 4);
            //spawnOreVain.SpawnsPerTick = 1;
            //spawnOres[0] = spawnOreVain;

        }

        [Usage("AnimalSpawnGen")]
        [Description("Generates Animal spawners by analyzing the map. Slow.")]
        public static void AnimalSpawnGen_OnCommand( CommandEventArgs e )
        {
            player = e.Mobile;
            Generate();
        }

        [Usage("AnimalSpawnRem")]
        [Description("Removes Animal spawners by analyzing the map. Slow.")]
        public static void AnimalSpawnRem_OnCommand( CommandEventArgs e )
        {
            player = e.Mobile;
            Remove();
        }

        private static Map m_Map;
        private static int m_Count;

        public static void Generate()
        {
            //World.Broadcast(252, true, "Generating Animal spawners, please wait.");
            player.SendMessage(252, "Generating Animal spawners...");

            Network.NetState.FlushAll();
            Network.NetState.Pause();

            m_Map = player.Map;
            m_Count = 0;

            for ( int i = 0; i < m_BritRegions.Length; ++i )
                Generate(m_BritRegions[i]);

            int ArseneCount = m_Count;

            Network.NetState.Resume();

            //World.Broadcast(252, true, "Animal spawner generation complete. {0}", ArseneCount);
            player.SendMessage(252, String.Format("{0} Animals Spawners have been Generated", ArseneCount));
        }

        public static bool IsRock( int id )
        {
            if ( id > m_Criterion[m_Criterion.Length - 1] )
                return false;

            for ( int i = 0; i < m_Criterion.Length; ++i )
            {
                int delta = id - m_Criterion[i];

                if ( delta < 0 )
                    return false;
                else if ( delta == 0 )
                    return true;
            }

            return false;
        }

        private static void AddAnimalSpawner( int x, int y, int z )
        {
            if ( Utility.RandomDouble() < 0.9750 )
                return;

            Map map = player.Map;
            IPooledEnumerable eable = map.GetItemsInRange(new Point3D(x, y, z), 20);

            foreach ( Item item in eable )
            {
                if ( item is XmlSpawner )
                {
                    if ( item.Hue == 346 )
                    {
                        return;
                    }
                }
            }

            if ( !m_Map.CanFit(x, y, z, 1, false, false) )
                return;

            //XmlSpawner(int amount, int minDelay, int maxDelay, int team, int homeRange, int spawnrange, string creatureName)
            XmlSpawner spawner = null;
            int MaxSpawn = 0;
            int Counter = 0;
            switch ( Utility.Random(6) )
            {
                case 0:
                    spawner = new XmlSpawner(10, 1, 3, 0, 0, Utility.RandomMinMax(22, 30), "Bird");
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Chicken", 4));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Eagle", 2));
                    MaxSpawn = 12;
                    Counter = 3;
                    break;
                case 1:
                    spawner = new XmlSpawner(4, 2, 5, 0, 0, Utility.RandomMinMax(8, 10), "BrownBear");
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("BlackBear", 4));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("GrizzlyBear", 2));
                    MaxSpawn = 6;
                    Counter = 3;
                    break;
                case 2:
                    spawner = new XmlSpawner(4, 1, 3, 0, 0, Utility.RandomMinMax(18, 24), "Dog");
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Cat", 4));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("GiantRat", 2));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("SewerRat", 4));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("JackRabbit", 4));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Rabbit", 4));
                    MaxSpawn = 10;
                    Counter = 6;
                    break;
                case 3:
                    spawner = new XmlSpawner(2, 1, 3, 0, 0, Utility.RandomMinMax(26, 30), "Bull");
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Cow", 4));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Goat", 2));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("MountainGoat", 2));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Boar", 2));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Pig", 4));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("GreatHart", 2));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Hind", 6));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Sheep", 6));
                    MaxSpawn = 14;
                    Counter = 8;
                    break;
                case 4:
                    spawner = new XmlSpawner(2, 2, 5, 0, 0, Utility.RandomMinMax(8, 10), "DireWolf");
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("GreyWolf", 4));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("TimberWolf", 4));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Panther", 2));
                    MaxSpawn = 6;
                    Counter = 4;
                    break;
                case 5:
                    spawner = new XmlSpawner(6, 3, 7, 0, 0, Utility.RandomMinMax(8, 10), "Gorilla");
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Alligator", 3));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("GiantSerpent", 2));
                    spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Raptor", 1));
                    MaxSpawn = 6;
                    Counter = 4;
                    break;
                    /*
                    case 0:
                        spawner = new XmlSpawner(10, 1, 3, 0, 0, Utility.RandomMinMax(22, 30), "Bird");
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Chicken", 4));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Eagle", 2));
                        MaxSpawn = 12;
                        Counter = 3;
                        break;
                    case 1:
                        spawner = new XmlSpawner(4, 2, 5, 0, 0, Utility.RandomMinMax(8, 10), "BrownBear");
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("BlackBear", 4));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("GrizzlyBear", 2));
                        MaxSpawn = 6;
                        Counter = 3;
                        break;
                    case 2:
                        spawner = new XmlSpawner(4, 1, 3, 0, 0, Utility.RandomMinMax(18, 24), "Dog");
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Cat", 4));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("GiantRat", 2));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("SewerRat", 4));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("JackRabbit", 4));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Rabbit", 4));
                        MaxSpawn = 10;
                        Counter = 6;
                        break;
                    case 3:
                        spawner = new XmlSpawner(2, 1, 3, 0, 0, Utility.RandomMinMax(26, 30), "Bull");
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Cow", 4));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Goat", 2));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("MountainGoat", 2));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Boar", 2));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Pig", 4));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("GreatHart", 2));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Hind", 6));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Sheep", 6));
                        MaxSpawn = 14;
                        Counter = 8;
                        break;
                    case 4:
                        spawner = new XmlSpawner(2, 2, 5, 0, 0, Utility.RandomMinMax(8, 10), "DireWolf");
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("GreyWolf", 4));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("TimberWolf", 4));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Panther", 2));
                        MaxSpawn = 6;
                        Counter = 4;
                        break;
                    case 5:
                        spawner = new XmlSpawner(6, 3, 7, 0, 0, Utility.RandomMinMax(8, 10), "Gorilla");
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Alligator", 3));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("GiantSerpent", 2));
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Raptor", 1));
                        MaxSpawn = 6;
                        Counter = 4;
                        break;
                        */
            }

            //Spawn Orcs ( 30% )
            if ( spawner != null )
            {
                switch ( Utility.Random(10) )
                {
                    case 0:
                    case 1: // 20%
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("Orc", 2));
                        break;
                    case 2: // 10%
                        spawner.m_SpawnObjects.Add(new XmlSpawner.SpawnObject("OrcChopper", 2));
                        break;
                    default:
                        break;
                }
            }

            if ( spawner != null )
            {
                for ( int i = 0; i < Counter; i++ )
                {
                    spawner.SpawnObjects[i].SpawnsPerTick = 1;
                }

                spawner.Name = "Animal Spawner #" + m_Count;
                spawner.MoveToWorld(new Point3D(x, y, z), player.Map);
                spawner.MaxCount = MaxSpawn;
                spawner.Hue = 346;
            }

            ++m_Count;
        }

        public static void Generate( Rectangle2D region )
        {
            int OakTree = 0x12B9;

            for ( int rx = 0; rx < region.Width; ++rx )
            {
                for ( int ry = 0; ry < region.Height; ++ry )
                {
                    int vx = rx + region.X;
                    int vy = ry + region.Y;

                    StaticTile[] tiles = m_Map.Tiles.GetStaticTiles( vx, vy );

                    for ( int i = 0; i < tiles.Length; ++i )
                    {
                        StaticTile tile = tiles[i];

                        int id = tile.ID;
                        id &= 0x3FFF;
                        int z = tile.Z;

                        if ( IsRock(id) )
                        {
                            AddAnimalSpawner(vx + 1, vy, z);
                        }
                    }
                }
            }
        }

        public static void Remove()
        {
            player.SendMessage(252, "Removing Animal Spawners...");

            List<Item> itemList = new List<Item>( World.Items.Values );

            List<Item> AnimalSpawner = new List<Item>();

            foreach ( Item item in itemList )
            {
                if ( item is XmlSpawner )
                {
                    XmlSpawner spawner = item as XmlSpawner;
                    if ( spawner.SpawnObjects.Length > 0 )
                    {
                        if ( spawner.SpawnObjects[0].TypeName.ToUpper() == "BROWNBEAR" )
                        {
                            AnimalSpawner.Add(item);
                        }
                        else if ( spawner.SpawnObjects[0].TypeName.ToUpper() == "BLACKBEAR" )
                        {
                            AnimalSpawner.Add(item);
                        }
                        else if ( spawner.SpawnObjects[0].TypeName.ToUpper() == "GRIZZLYBEAR" )
                        {
                            AnimalSpawner.Add(item);
                        }
                        else if ( spawner.SpawnObjects[0].TypeName.ToUpper() == "POLARBEAR" )
                        {
                            AnimalSpawner.Add(item);
                        }
                        else if ( spawner.SpawnObjects[0].TypeName.ToUpper() == "BIRD" )
                        {
                            AnimalSpawner.Add(item);
                        }
                        else if ( spawner.SpawnObjects[0].TypeName.ToUpper() == "CHICKEN" )
                        {
                            AnimalSpawner.Add(item);
                        }
                        else if ( spawner.SpawnObjects[0].TypeName.ToUpper() == "EAGLE" )
                        {
                            AnimalSpawner.Add(item);
                        }
                        else if ( spawner.SpawnObjects[0].TypeName.ToUpper() == "DOG" )
                        {
                            AnimalSpawner.Add(item);
                        }
                        else if ( spawner.SpawnObjects[0].TypeName.ToUpper() == "BULL" )
                        {
                            AnimalSpawner.Add(item);
                        }
                        else if ( spawner.SpawnObjects[0].TypeName.ToUpper() == "DIREWOLF" )
                        {
                            AnimalSpawner.Add(item);
                        }
                        else if ( spawner.SpawnObjects[0].TypeName.ToUpper() == "GORILLA" )
                        {
                            AnimalSpawner.Add(item);
                        }
                    }
                }
            }

            player.SendMessage(252, String.Format("{0} Animals Spawners have been Removed", AnimalSpawner.Count));
            Console.WriteLine("{0} Animals Spawners have been Removed", AnimalSpawner.Count);

            foreach ( Item item in AnimalSpawner )
                item.Delete();
        }
    }
}
