using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI();
        }




        public static void UI()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t+----- FishFush - Halnyilvántartó -----+");
            Console.WriteLine("\t\t|                                      |");
            Console.WriteLine("\t\t|          1. Hal hozzáadása           |");
            Console.WriteLine("\t\t|          2. Halak listázása          |");
            Console.WriteLine("\t\t|          3. Hal módosítása           |");
            Console.WriteLine("\t\t|             4. Kilépés               |");
            Console.WriteLine("\t\t|                                      |");
            Console.WriteLine("\t\t+--------------------------------------+");
        }
    }
}
