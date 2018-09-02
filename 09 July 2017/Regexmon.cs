namespace _03.Regexmon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string patternDidi = @"[^A-Za-z-]+";
            string patternBojo = @"[A-Za-z]+-[A-Za-z]+";

            Regex didi = new Regex(patternDidi);
            Regex bojo = new Regex(patternBojo);

            while (true){
                Match didiMatch = didi.Match(input);

                if(didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value);
                }
                else
                {
                    return;
                }
                int border = didiMatch.Index;
                input = input.Substring(border + didiMatch.Length);

                Match bojoMatch = bojo.Match(input);

                if (bojoMatch.Success)
				{
                    Console.WriteLine(bojoMatch.Value);
				}
				else
				{
					return;
				}
                int border1 = bojoMatch.Index;
                input = input.Substring(border1 + bojoMatch.Length);
            }
        }
    }
}