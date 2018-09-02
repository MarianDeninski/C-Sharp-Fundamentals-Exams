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
            int number = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, long>();
            var dict1 = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { "=", "->", ":", " " }, StringSplitOptions.RemoveEmptyEntries);

                long lastActivity =long.Parse(input[0]);
                string legionNmae = input[1];
                string solgierType = input[2];
                long solgierCount = long.Parse(input[3]);

                if(!dict.ContainsKey(legionNmae))
                {
                    dict.Add(legionNmae,lastActivity);
                }else{
                    if(dict[legionNmae]<lastActivity){
                        dict[legionNmae] = lastActivity;
                    }
                }
                if(!dict1.ContainsKey(legionNmae)){
                    dict1.Add(legionNmae, new Dictionary<string, long>());
                }
                if(!dict1[legionNmae].ContainsKey(solgierType)){
                    dict1[legionNmae].Add(solgierType, 0);
                }
                dict1[legionNmae][solgierType] += solgierCount;
            }
            string[] input2 = Console.ReadLine().Split('\\').ToArray();

            if(input2.Count() >1)
            {
                long activity =long.Parse(input2[0]);
                string solgierType = input2[1];

                foreach (var part in dict1.Where(Legion => Legion.Value.ContainsKey(solgierType)).OrderByDescending(x => x.Value[solgierType]))
                {
                    foreach(var part2 in part.Value){

                        if (solgierType == part2.Key && activity>dict[part.Key]){

                            Console.WriteLine($"{part.Key} -> {part2.Value}");
                        }
                    }

                }

            }else{
                string solgierType = input2[0];

                foreach(var type in dict.OrderByDescending(x=>x.Value))
                {
                    if(dict1[type.Key].ContainsKey(solgierType)){

                        Console.WriteLine($"{type.Value} : {type.Key}");
                    }
                }
            }


        }
    }
}