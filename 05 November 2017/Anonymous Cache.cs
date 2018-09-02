using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;
namespace _04.SoftUni_Coffee_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dictFinal = new Dictionary<string, Dictionary<string, long>>();
            var cashe = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                string[] output = input.Split(new[] { "->", "|", " " }, StringSplitOptions.RemoveEmptyEntries);

                if (output.Count() == 1)
                {
                    string dataSet = output[0];

                    if (cashe.ContainsKey(dataSet))
                    {
                        dictFinal.Add(dataSet, new Dictionary<string, long>());
                        dictFinal[dataSet] = cashe[dataSet];
                        cashe.Remove(dataSet);

                    }
                    else
                    {
                        dictFinal.Add(dataSet, new Dictionary<string, long>());
                    }
                }
                else
                {
                    string dataSet = output[2];
                    string dataKey = output[0];
                    long dataSize = long.Parse(output[1]);

                    if (dictFinal.ContainsKey(dataSet))
                    {
                        if (!dictFinal[dataSet].ContainsKey(dataKey))
                        {
                            dictFinal[dataSet].Add(dataKey, 0);
                        }
                        dictFinal[dataSet][dataKey] += dataSize;
                    }
                    else
                    {
                        if (!cashe.ContainsKey(dataSet))
                        {
                            cashe.Add(dataSet, new Dictionary<string, long>());
                        }
                        if (!cashe[dataSet].ContainsKey(dataKey))
                        {
                            cashe[dataSet].Add(dataKey, 0);
                        }
                        cashe[dataSet][dataKey] += dataSize;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var part in dictFinal.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Data Set: {part.Key}, Total Size: {part.Value.Values.Sum()}");

                foreach(var part2 in part.Value){
                    Console.WriteLine($"$.{part2.Key}");
                }
                break;
            }
        }
    }
}