namespace _02._AnonymousVox
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    class AnonymousVox
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            List<string> input2 = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();

			string pattern = @"([a-zA-Z]+)(.+)\1";

            Regex pattern1 = new Regex(pattern);

            MatchCollection matches = pattern1.Matches(input1);
            int placeholder = 0;

            foreach (Match part in matches)
            {
                input1 = NewMethod(input1, part.Groups[2].Value.ToString(), input2[placeholder].ToString());
                placeholder++;
            }
            Console.WriteLine(input1);
        }
        private static string NewMethod(string input1, string oldValue, string newValue)
        {
            string moveToPattern = input1.Substring(0, input1.IndexOf(oldValue) + oldValue.Length);
            string changePlaceholder = moveToPattern.Replace(oldValue, newValue);
            return changePlaceholder + input1.Substring(moveToPattern.Length);
        }
    }
}