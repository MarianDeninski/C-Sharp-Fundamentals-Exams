namespace _03._AnonymousCache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AnonymousCache
    {
        static void Main(string[] args)
        {
            List<long> array = Console.ReadLine().Split().Select(long.Parse).ToList();

            var result = new List<long>();

            long sum = 0;
            long count;
            while (array.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    result.Add(array[0]);
                    count = array[0];
                    array[0] = array[array.Count() - 1];
                }

                else if (index >= array.Count)
                {
                    result.Add(array[array.Count - 1]);
                    count = array[array.Count() - 1];
                    array[array.Count() - 1] = array[0];

                }
                else
                {
                    result.Add(array[index]);
                    count = array[index];
                    array.RemoveAt(index);
                }

                sum += count;
                for (int i = 0; i < array.Count(); i++)

                {
                    if (count >= array[i])
                    {
                        array[i] += count;

                    }
                    else
                    {
                        array[i] -= count;
                    }
                }
                count = 0;

            }
            Console.WriteLine(result.Sum());
        }
    }
}