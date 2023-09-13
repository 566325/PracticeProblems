using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems4B
{
    internal class Pattern2
    {
        public static void PrintPattern2()
        {
            int number = 7;

            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == 6)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (i >= 1 && i <= 5)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (j == 0 || j == 6)
                        {
                            Console.Write("*");
                        }
                        else if (j >= 1 && j <= 5)
                        {
                            Console.Write(" ");
                        }
                    }



                }
            }
        }
    }
}
