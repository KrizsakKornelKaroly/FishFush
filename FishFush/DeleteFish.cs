using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FishFush
{
    internal class DeleteFish
    {
        public static void RemoveFish()
        {
            DisplayLines("1. Adott hal törlése\n\t\t2. Összes hal törlése\n\t\tx. Vissza");
            string option = Convert.ToString(Console.ReadKey().KeyChar);

            switch (option)
            {
                case "1":
                    Console.Clear();
                    DisplayLines("A funkció még fejlesztés alatt áll!\n\t\tVisszatérés a főmenübe.");
                    Thread.Sleep(2000);
                    Program.MainMenu();
                    return;
                case "2":
                    Console.Clear();
                    DisplayLines("Az összes hal törlése folyamatban...");
                    bool deletion = FileIO.ClearFile();
                    if (deletion)
                    {
                        DisplayLines("Az összes hal törlése sikeresen megtörtént!\n\t\tVisszatérés a főmenübe.");
                    }
                    else
                    {
                        DisplayLines("Hiba történt a halak törlése során!\n\t\tVisszatérés a főmenübe.");
                    }
                    Thread.Sleep(2000);
                    Program.MainMenu();
                    return;
                case "x":
                    Program.MainMenu();
                    return;
                default:
                    Program.MainMenu();
                    return;
            }

        }




        private static void DisplayLines(string customLine)
        {
            Console.Clear();
            Console.WriteLine("\t\t+------- FishFush - Haltörlés -------+");
            Console.WriteLine();
            Console.WriteLine($"\t\t{customLine}");
            Console.WriteLine();
            Console.WriteLine("\t\t+------------------------------------+");
        }
    }
}
