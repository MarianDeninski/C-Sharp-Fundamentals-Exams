using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            string[] songs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            string input = Console.ReadLine();
            var dict = new Dictionary<string, List<string>>();
            while (input != "dawn")
            {
                string[] output = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();

                string name = output[0];
                string song = output[1];
                string award = output[2];

                if (!names.Any(a => a == name) || !songs.Any(a => a == song))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<string>());
                }
                dict[name].Add(award);

                input = Console.ReadLine();
            }
            if(dict.Count==0){
                Console.WriteLine("No awards");
                return;
            }
            foreach (KeyValuePair<string, List<string>> pair in dict.OrderByDescending(a => a.Value.Distinct().ToList().Count)
                     .ThenBy(n => n.Key))
            {
                
                List<string> award = pair.Value.Distinct().ToList(); 
                Console.WriteLine($"{pair.Key}: {award.Count} awards");

                foreach(string listed in award.OrderBy(a=>a)){
                    Console.WriteLine($"--{listed}");
                }
            }

        }
    }
}