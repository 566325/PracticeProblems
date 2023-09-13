using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems4B
{
    internal class SumOfDigits
    {
        public static void SumOfAllDigits()
        {
            int num, sum = 0, firstDigit, lastDigit;

            // Reading number
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            lastDigit = num % 10;

            firstDigit = num;

            while (num >= 10)
            {
                num = num / 10;
            }
            firstDigit = num;

            //Finding sum of first and last digit
            sum = firstDigit + lastDigit;

            Console.WriteLine("Sum of first and last digit: " + sum);
        }
    }
}
