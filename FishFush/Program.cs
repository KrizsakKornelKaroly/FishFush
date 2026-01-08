using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FishFush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }




        public static void MainMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t+----- FishFush - Halnyilvántartó -----+");
            Console.WriteLine("\t\t|                                      |");
            Console.WriteLine("\t\t|          1. Hal hozzáadása           |");
            Console.WriteLine("\t\t|          2. Halak listázása          |");
            Console.WriteLine("\t\t|          3. Hal törlése              |");
            Console.WriteLine("\t\t|             4. Kilépés               |");
            Console.WriteLine("\t\t|                                      |");
            Console.WriteLine("\t\t+--------------------------------------+");
            Console.WriteLine("\nKérem válasszon a menüpontok közül (1-4): ");
            string opcio = Convert.ToString(Console.ReadKey().KeyChar);
            switch (opcio)
            {
                case "1":
                    AddFish.AddFishInterface();
                    break;
                case "2":
                    ListFish.ListAllFish();
                    break;
                case "3":
                    DeleteFish.RemoveFish();
                    break;
                case "4":
                    break;
                default:
                    MainMenu();
                    break;
            }
        }
    }
}
