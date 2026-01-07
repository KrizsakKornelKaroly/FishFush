using System;
using System.Collections.Generic;

namespace FishFush
{
    internal class FishProcessor
    {
        public static List<Fish> ProcessFish(List<string> rows)
        {
            List<Fish> fishList = new List<Fish>();
            for (int i = 0; i < rows.Count; i++)
            {
                string[] row = rows[i].Split(';');
                switch (row[4])
                {
                    case "Díszhal":
                        fishList.Add(new Ornamental(
                            row[0], 
                            row[1], 
                            Convert.ToDouble(row[2]), 
                            Convert.ToInt32(row[3]), 
                            "Díszhal",
                            Convert.ToInt32(row[5]), 
                            Convert.ToInt32(row[6])));
                        break;
                    case "Növényevő":
                        if (row[5] == "Sósvizi")
                        {
                            fishList.Add(new SeaHerbivore(
                                row[0],
                                row[1],
                                Convert.ToDouble(row[2]),
                                Convert.ToInt32(row[3]),
                                "Sósvizi növényevő",
                                Convert.ToDouble(row[7]),
                                row[6] == "Vándorló" ? true : false
                                ));
                            break;
                        }
                        else
                        {
                            fishList.Add(new FreshwaterHerbivore(
                                row[0],
                                row[1],
                                Convert.ToDouble(row[2]),
                                Convert.ToInt32(row[3]),
                                "Édesvízi növényevő",
                                Convert.ToInt32(row[7]),
                                row[6] == "Vándorló" ? true : false
                                ));
                            break;
                        }
                    case "Húsevő":
                        if ((row[5] == "Sósvizi"))
                        {
                            fishList.Add(new SeaCarnivore(
                                row[0],
                                row[1],
                                Convert.ToDouble(row[2]),
                                Convert.ToInt32(row[3]),
                                "Sósvizi húsevő",
                                Convert.ToDouble(row[7]),
                                row[6] == "Vándorló" ? true : false
                                ));
                            break;
                        }
                        else
                        {
                            fishList.Add(new FreshwaterCarnivore(
                                row[0],
                                row[1],
                                Convert.ToDouble(row[2]),
                                Convert.ToInt32(row[3]),
                                "Édesvízi húsevő",
                                Convert.ToInt32(row[7]),
                                row[6] == "Vándorló" ? true : false
                                ));
                            break;
                        }
                    default:
                        break;
                }
            }
            return fishList;
        }
    }
}