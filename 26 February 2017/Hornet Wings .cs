using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Defoult
{
    public static void Main()
    {
        int flintapsToDo = int.Parse(Console.ReadLine());
        double distanceTravelFor1000meters = double.Parse(Console.ReadLine());
        int endurance = int.Parse(Console.ReadLine());

        double distance = (flintapsToDo / 1000) * distanceTravelFor1000meters;
        int rest = (flintapsToDo / endurance) * 5;
        int normal = flintapsToDo / 100;
        int seconds = rest + normal;

        Console.WriteLine($"{distance:F2} m.");
        Console.WriteLine($"{seconds} s.");

    }
}