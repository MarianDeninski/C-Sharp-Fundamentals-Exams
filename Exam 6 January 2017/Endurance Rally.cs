using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

class AnonymousCache
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Split();
        string[] road = Console.ReadLine().Split();
        string[] cheackPoints = Console.ReadLine().Split();

        for (int i = 0; i < names.Length; i++)
        {
            double fuel = (double)Convert.ToChar(names[i][0]);

            for (int j = 0; j < road.Length; j++)
            {
                bool yes = false;

                for (int o = 0; o < cheackPoints.Length; o++)
                {
                    if (j == int.Parse(cheackPoints[o]))
                    {
                        fuel += double.Parse(road[j]);
                        yes = true;
                        break;
                    }
                }
                if (!yes)
                {
                    fuel -= double.Parse(road[j]);
                }
                if (fuel <= 0)
                {
                    Console.WriteLine($"{names[i]} - reached {j}");

                    break;
                }
            }
            if (fuel > 0)
            {

                Console.WriteLine($"{names[i]} - fuel left {fuel:F2}");

            }
        }
    }
}