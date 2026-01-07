using System;
using System.Threading;

namespace FishFush
{
    public class AddFish
    {
        public static void AddFishInterface()
        {
            //nev, szín, hossz, élettartam

            Console.Clear();

            DisplayLines("Adja meg a hal nevét:\n\t\t- Mégsem: x");
            string fishName = Console.ReadLine();

            if (fishName == "x")
            {
                Program.MainMenu();
                return;
            }

            DisplayLines($"Adja meg a {fishName} színét:\n\t\t- Mégsem: x");
            string fishColor = Console.ReadLine();
            if (fishColor == "x")
            {
                Program.MainMenu();
                return;
            }

        HalHossz:
            DisplayLines($"Adja meg a {fishName} hosszát (cm):\n\t\t- Mégsem: x");
            double fishLength = 0;
            try
            {
                fishLength = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                goto HalHossz;
            }
        HalElet:
            DisplayLines($"Adja meg a {fishName} élettartamát (év):\n\t\t- Mégsem: x");
            int fishLifespan = 0;
            try
            {
                fishLifespan = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                goto HalElet;
            }

            string fishType = AddFishDiet();
            if (fishType == null)
            {
                Program.MainMenu();
                return;
            }

            string habitatType = "";
            if (fishType.StartsWith("Növényevő") || fishType.StartsWith("Húsevő"))
            {
                habitatType = AddHabitat();
                if (habitatType == null)
                {
                    Program.MainMenu();
                    return;
                }
            }


            bool resp = FileIO.Write($"{fishName};{fishColor};{fishLength};{fishLifespan};{fishType};{habitatType}");
            if (!resp)
            {
                DisplayLines("Hiba történt a fájlírás során! Nyomjon meg egy gombot a visszatéréshez a főmenübe.");
            }
            else
            {
                DisplayLines($"Sikeresen hozzáadta a(z) {fishName} halat! Visszatérés a főmenübe.");
                Thread.Sleep(2000);
                Program.MainMenu();
                return;


            }
            //saving: első oszlop - típus - kiíratás ez alapján
            Console.ReadKey();
            Program.MainMenu();
            return;
        }

        private static string AddFishDiet()
        {
            DisplayLines("Válassza ki a hal életmódját:\n\t\t1. Növényevő\n\t\t2. Húsevő\n\t\t3. Díszhal\n\t\tx. Hozzáadás megszakítása");
            int fishDiet = Console.ReadKey().KeyChar;
            switch (fishDiet)
            {
                case '1':
                    return "Növényevő";
                case '2':
                    return "Húsevő";
                case '3':
                    return AddOrnamentalFish();
                case 'x':
                    return null;
                default:
                    return AddFishDiet();
            }
        }

        private static string AddOrnamentalFish()
        {
        NeededSpace:
            DisplayLines("Adja meg a szükéges élettér méretét (liter):\n\t\t- Mégsem: x");
            int tankSize = 0;
            try
            {
                string tankInput = Console.ReadLine();
                if (tankInput == "x")
                {
                    return null;
                }
                tankSize = Convert.ToInt32(tankInput);
            }
            catch (Exception)
            {
                goto NeededSpace;
            }

        Price:
            DisplayLines("Adja meg a hal árát (Ft):\n\t\t- Mégsem: x");
            int price = 0;
            try
            {
                string priceInput = Console.ReadLine();
                if (priceInput == "x")
                {
                    return null;
                }
                price = Convert.ToInt32(priceInput);
            }
            catch (Exception)
            {
                goto Price;
            }

            return $"Díszhal;{tankSize};{price}";
        }

        private static string AddHabitat()
        {
            DisplayLines("Válassza ki a hal élőhelyét:\n\t\t1. Édesvízi\n\t\t2. Sósvízi\n\t\tx. Hozzáadás megszakítása");
            int habitatType = Console.ReadKey().KeyChar;
            switch (habitatType)
            {
                case '1':
                    return AddHabitat_Freshwater();
                case '2':
                    return AddHabitat_Sea();
                case 'x':
                    return null;
                default:
                    return AddHabitat();
            }
        }

        private static string AddHabitat_Sea()
        {
            string migratory = isMigratoryFish();
            if (migratory == null)
            {
                return null;
            }
        HalSotartalom:
            DisplayLines("Élőhelyének optimális sótartalma? (%)");
            try
            {
                string salinityInput = Console.ReadLine();
                if (salinityInput == "x")
                {
                    return null;
                }

                int salinity = Convert.ToInt32(salinityInput);
                return $"Sósvízi;{migratory};{salinity}";
            }
            catch (Exception)
            {
                goto HalSotartalom;
            }

        }

        private static string AddHabitat_Freshwater()
        {
            string migratory = isMigratoryFish();
            if (migratory == null)
            {
                return null;
            }
        HalTolerancia:
            DisplayLines("Sótűrése? (0-10)");
            try
            {
                string saltToleranceInput = Console.ReadLine();
                if (saltToleranceInput == "x")
                {
                    return null;
                }
                int saltTolerance = Convert.ToInt32(saltToleranceInput);
                if (saltTolerance < 0 || saltTolerance > 10)
                {
                    goto HalTolerancia;
                }
                return $"Édesvízi;{migratory};{saltTolerance}";
            }
            catch (Exception)
            {
                goto HalTolerancia;
            }
        }

        private static string isMigratoryFish()
        {
            DisplayLines("Vándorló hal?\n\t\t1. Igen\n\t\t2. Nem\n\t\tx. Hozzáadás megszakítása");
            int migratoryType = Console.ReadKey().KeyChar;
            switch (migratoryType)
            {
                case '1':
                    return "Vándorló";
                case '2':
                    return "Nem vándorló";
                case 'x':
                    return null;
                default:
                    return isMigratoryFish();
            }
        }


        private static void DisplayLines(string customLine)
        {
            Console.Clear();
            Console.WriteLine("\t\t+----- FishFush - Hal hozzáadás -----+");
            Console.WriteLine();
            Console.WriteLine($"\t\t- {customLine}");
            Console.WriteLine();
            Console.WriteLine("\t\t+------------------------------------+");
        }
    }
}
