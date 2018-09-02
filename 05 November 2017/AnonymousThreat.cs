namespace _04._AnonymousThreat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] divides = input.Split().ToArray();

                string type = divides[0];

                if(type == "merge")
                {
                    int index = int.Parse(divides[1]);
                    int lenth = int.Parse(divides[2]);

                    names = Merge(names, index, lenth);
                    input = Console.ReadLine();
                    
                }
                if(type == "divide")
                {
                    int index = int.Parse(divides[1]);
                    int devision = int.Parse(divides[2]);

                    names = Divide(names, index, devision);
                    input = Console.ReadLine();
                    
                }
        
            }
            Console.WriteLine(String.Join(" ",names));

        }

        private static List<string> Divide(List<string> names, int index, int devision)
        {
            string word = names[index];

            int devisionLenth = word.Length / devision;

            var list = new List<string>();


            for (int i = 0; i <devision ; i++)
            {
                if(i == devision-1)
                {
                    list.Add(word.Substring(i*devisionLenth));
                    
                }
                else
                {
                    list.Add(word.Substring(i*devisionLenth,devisionLenth));
            
                }
            }
            names.Remove(names[index]);
            names.InsertRange(index,list);

            return names;
        }

        private static List<string> Merge(List<string> names, int index, int lenth)
        {
            index = ValidIndex(index, names.Count());
            lenth = ValidIndex(lenth, names.Count());

            var list = new List<string>();

            for (int i = 0; i <index ; i++)
            {
                list.Add(names[i]);
            }
            StringBuilder sb = new StringBuilder();

            for (int i = index; i <=lenth ; i++)
            {
                sb.Append(names[i]);

            }
               list.Add(sb.ToString()); 
            
            for (int i = lenth+1; i < names.Count(); i++)
            {
                list.Add(names[i]);

            }

            return list;
        }
        private static int ValidIndex(int index, int v)
        {
            if(index<0)
            {
                index = 0;
            }
            if(index>=v)
            {
                index = v - 1;
            }

            return index;
        }
    }
}