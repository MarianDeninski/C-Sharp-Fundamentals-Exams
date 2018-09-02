using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.SoftUni_Coffee_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());

            var list = new List<string>();
            decimal countt = 0.0M;
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] output = input.Split(' ');

                string name = output[0];
                decimal siteVisits = decimal.Parse(output[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(output[2]);

                list.Add(name);

                countt += siteVisits * siteCommercialPricePerVisit;

            }
            BigInteger key = BigInteger.Pow(securityKey, count);

            Console.WriteLine(String.Join("\n",list));
            Console.WriteLine($"Total Loss: {countt:F20}");
            Console.WriteLine($"Security Token: {key}");

        }
    }
}