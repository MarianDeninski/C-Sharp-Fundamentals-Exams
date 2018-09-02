using System;
using System.Collections.Generic;
using System.Linq;

class Evolution
{
    public string evolName { get; set; }
    public int evolIndex { get; set; }
}
namespace AppendLists
{

    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<string, List<Evolution>>();

            while (input != "wubbalubbadubdub")
            {

                string[] output = input.Split("        ->      ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string name = output[0];
                if (output.Length > 1)
                {
                    Evolution sort = new Evolution();
                    sort.evolName = output[1];
                    sort.evolIndex = int.Parse(output[2]);


                    if (!dict.ContainsKey(name))
                    {
                        dict[name] = new List<Evolution>();

                    }
                    dict[name].Add(sort);
                }
                else
                {
                    if (dict.ContainsKey(name))
                    {


                        Console.WriteLine($"# {name}");
                        foreach (var exit in dict[name])
                        {
                            Console.WriteLine($"{exit.evolName} <-> {exit.evolIndex}");

                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach(var name in dict)
            {
                Console.WriteLine($"# {name.Key}");
                foreach(var sort in name.Value.OrderByDescending(x=>x.evolIndex))
                {
                    Console.WriteLine($"{sort.evolName} <-> {sort.evolIndex}");
                }
            }
        }
    }
}