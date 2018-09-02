using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
class Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {

			Regex regular = new Regex(@"([\@]{6,}|[\#]{6,}|[\$]{6,}|[\^]{6,})");
			//var ticketsCol = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			string line = Console.ReadLine();
			var ticketsCol = Regex.Split(line, @"[\,|\s]+");
			foreach (var ticket in ticketsCol)
			{
				string curTicket = ticket;//.Trim();
				if (curTicket.Length != 20)
				{
					Console.WriteLine("invalid ticket");
					continue;
				}
				string leftHalf = curTicket.Substring(0, 10);
				Match leftMatch = regular.Match(leftHalf);
				if (!leftMatch.Success)
				{
					Console.WriteLine($"ticket \"{curTicket}\" - no match");
					continue;
				}

				string rightHalf = curTicket.Substring(10, 10);
				Match rightMatch = regular.Match(rightHalf);
				if (!rightMatch.Success)
				{
					Console.WriteLine($"ticket \"{curTicket}\" - no match");
					continue;
				}

				string lM = leftMatch.ToString();
				string rM = rightMatch.ToString();

				if (lM[0] != rM[0])
				{
					Console.WriteLine($"ticket \"{curTicket}\" - no match");
					continue;
				}
				if (lM.Length == 10 && rM.Length == 10)
				{
					Console.WriteLine($"ticket \"{curTicket}\" - 10{lM[0]} Jackpot!");
					continue;
				}
				else
				{
					Console.WriteLine($"ticket \"{curTicket}\" - {Math.Min(lM.Length, rM.Length)}{lM[0]}");
					continue;
				}
			}
		}
	}
}