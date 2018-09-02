using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NSA
{
    class NSA
    {
        static void Main(string[] args)
        {
            DateTime clock = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", null);
            long steps = int.Parse(Console.ReadLine());
            long sec = int.Parse(Console.ReadLine());

            long clockSec = (clock.Hour * 60 * 60) + (clock.Minute * 60) + (clock.Second);
            long secStep = sec * steps;
            long allSeconds = clockSec + secStep;

            long seccEx = allSeconds % 60;
            long minute = allSeconds / 60;
            long minutesEx = minute % 60;
            long hours = minute / 60;
            long hoursEx = (hours % 24);

            Console.Write($"Time Arrival: {hoursEx:D2}:{minutesEx:D2}:{seccEx:D2}");
        }
    }
}