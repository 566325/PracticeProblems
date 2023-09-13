using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems4B
{
    internal class MaxAndMinElement
    {
        public static void FindMaxAndMinElement()
        {
            int[] Arr = { 20, -10, -70, 0, 15, 10, 30 };
            Console.WriteLine("Maximum Element : " + Arr.Max());
            Console.WriteLine("Minimum Element : " + Arr.Min());
        }
    }
}
