using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems4B
{
    internal class ReverseString
    {
        public static void PrintReverseOfAString()
        {
            string Str, rev;
            Str = "Hello World";
            rev = "";
            Console.WriteLine("Value of given String is: {0}", Str);
            // find string length
            int a;
            a = Str.Length - 1;
            while (a >= 0)
            {
                rev = rev + Str[a];
                a--;
            }
            Console.WriteLine("Reversed string is: {0}", rev);
            Console.ReadLine();



        }
    }
}
