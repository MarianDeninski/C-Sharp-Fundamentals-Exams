using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> beehives = Console.ReadLine().Split(' ').ToList();
            List<string> hornetsPower = Console.ReadLine().Split(' ').ToList();
            var list = new List<long>();
            long sum = 0;

            for (int i = 0; i < hornetsPower.Count(); i++)
            {

                sum += long.Parse(hornetsPower[i]);
            }
            long power = long.Parse(hornetsPower[0]);
            for (int j = 0; j < beehives.Count(); j++)
            {
                long quantity = long.Parse(beehives[j]);
                if (hornetsPower.Count() == 0)
                {
                    int left1 = int.Parse(beehives[j]);
                    list.Add(left1);
                    continue;
                }

                if (quantity >= sum)
                {
                    long left = quantity - sum;
                    sum -= long.Parse(hornetsPower[0]);
                    hornetsPower.Remove(hornetsPower[0]);
                    list.Add(left);
                    //if(hornetsPower.Count() ==0)
                    //{
                    //    break;
                    //}
                }

            }
            if (list.Sum() == 0)
            {
                for (int i = 0; i < hornetsPower.Count(); i++)
                {
                    if(hornetsPower[i] == "0"){
                        hornetsPower.Remove(hornetsPower[i]);
                    }
                }
                Console.WriteLine(String.Join(" ", hornetsPower));
            }
            else
            {
                if (list[0] == 0)
                {
                    list.Remove(list[0]);
                }
                if (list.Last() == 0)
                {
                    list.Remove(list.Last());
                }
                for (int i = 0; i < list.Count(); i++)
                {
                    if (list[i] == 0)
                    {
                        list.Remove(list[i]);
                    }
					if (list.Last() == 0)
					{
						list.Remove(list.Last());
					}
					
                }
				Console.Write(String.Join(" ", list));
            }
        }

    }
}