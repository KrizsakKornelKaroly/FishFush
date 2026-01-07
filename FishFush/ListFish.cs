using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFush
{
    internal class ListFish
    {
        public static void ListAllFish()
        {
        List:
            Console.Clear();
            List<string> rows = FileIO.Read();
            List<Fish> fish = FishProcessor.ProcessFish(rows);

            Console.WriteLine("\t\t+----- Halak listázása -----+\n");

            for (int i = 0; i < fish.Count; i++)
            {
                Console.WriteLine(fish[i].ToString());
            }

            Console.WriteLine("\n\t\t+---------------------------+");

            Console.WriteLine("\n\n\tVissza a főmenübe: x\n\tÚjratöltés: bármilyen gomb");

            char back = Console.ReadKey().KeyChar;
            if (back == 'x')
            {
                Program.MainMenu();
            }
            else 
            {
                goto List;
            }
        }
    }
}
