using System;

namespace FishFush
{
    public class AddFish
    {
        public static void AddFishInterface()
        {
            //nev, szín, hossz, élettartam

            Console.Clear();

            DisplayLines("Adja meg a hal nevét:");
            string fishName = Console.ReadLine();
            if (fishName == "x")
            {
                Program.MainMenu();
            }

            DisplayLines($"Adja meg a {fishName} színét:");
            string fishColor = Console.ReadLine();
            if (fishColor == "x")
            {
                Program.MainMenu();
            }

            DisplayLines($"Adja meg a {fishName} hosszát (cm):");
            double fishLength = 0;
            try
            {
                fishLength = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Program.MainMenu();
            }

            DisplayLines($"Adja meg a {fishName} élettartamát (év):");
            int fishLifespan = 0;
            try
            {
                fishLifespan = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Program.MainMenu();
            }

            bool resp = FileIO.Write($"{fishName};{fishColor};{fishLength};{fishLifespan}");
            if (!resp)
            {
                DisplayLines("Hiba történt a fájlírás során! Nyomjon meg egy gombot a visszatéréshez a főmenübe.");
            }
            //saving: első oszlop - típus - kiíratás ez alapján
            Console.ReadKey();
            Program.MainMenu();
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
