using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems4B
{
    internal class Pattern
    {
        public static void PrintPatternt()
        {
            int i, j;
            int n = 8;

            for (i = 1; i <= n; i++)
            {
                for (j = i; j <= n; j++)
                {
                    Console.Write("*");

                }

                Console.WriteLine("");
            }
        }
    }
}
