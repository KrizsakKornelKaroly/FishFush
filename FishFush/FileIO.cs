using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFush
{
    internal class FileIO
    {
        public static List<string> Read()
        {
            try
            {
                List<string> rows = new List<string>();
                StreamReader reader = new StreamReader("fishdata.txt", Encoding.UTF8);
                while (!reader.EndOfStream)
                {
                    rows.Add(reader.ReadLine());
                }

                return rows;
            }
            catch (Exception)
            {
                return new List<string>() {"Hiba történt a beolvasás során!"};
            }

        }


        public static bool Write(string row)
        {
            try
            {
                StreamWriter writer = new StreamWriter("fishdata.txt", true, Encoding.UTF8);
                writer.WriteLine(row);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
        public static bool ClearFile()
        {
            try
            {
                StreamWriter writer = new StreamWriter("fishdata.txt", false, Encoding.UTF8);
                writer.WriteLine("");
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
