﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems4B
{
    internal class RowMatrix
    {
        public static void SumOfRowMatrix()
        {
            int i, j, n;
            int[,] arr1 = new int[10, 10];
            int[] rsum = new int[10];
            int[] csum = new int[10];
            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}  ", arr1[i, j]);
                    Console.Write("\n");

                }
            }
            for (i = 0; i < n; i++)
            {
                rsum[i] = 0;
                for (j = 0; j < n; j++)
                    rsum[i] = rsum[i] + arr1[i, j];
            }
            for (i = 0; i < n; i++)
            {
                csum[i] = 0;
                for (j = 0; j < n; j++)
                    csum[i] = csum[i] + arr1[j, i];
            }

            Console.Write("The sum of row and column of the matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}    ", arr1[i, j]);
                Console.Write("{0}    ", rsum[i]);
                Console.Write("\n");
            }
            Console.Write("\n");
            for (j = 0; j < n; j++)
            {
                Console.Write("{0}   ", csum[j]);
            }
            Console.Write("\n\n");




        }
    }
}
