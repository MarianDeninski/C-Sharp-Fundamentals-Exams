using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using System.Resources;
using System.Linq;
public class Example
{
    public static void Main()
    {
        int nPokePower = int.Parse(Console.ReadLine());
        int mDistanceBetweenTarget = int.Parse(Console.ReadLine());
        int yExsoutionPower = int.Parse(Console.ReadLine());

        int counter = 0;
        int n = nPokePower;
        double divaidedbytwo = nPokePower / 2.0;
        while (true)
        {
            if(n<mDistanceBetweenTarget){
                break;
            }
            if(n == divaidedbytwo && yExsoutionPower>0 ){
                n =n/ yExsoutionPower;
            }
            if (n >= mDistanceBetweenTarget)
            {
                n -= mDistanceBetweenTarget;
                counter++;
            }
        
        }
        Console.WriteLine(n);
        Console.WriteLine(counter);
    }
}