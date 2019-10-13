/*
Author: Torin Tashima
Date:   10/10/2019
CTEC 135: Microsoft Software Development with C#

Module 2, Programming Assignment 1, Problem 2

   Iteration Constructs

1. Print numbers 1-5 separated by spaces using a for loop.
2. Do the same thing using a while loop.
3. Do the same thing using a do/while loop.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    // Class program: Where assignment code is written
    class Program
    {
        /*
        Method: Main
        Input: An array of strings (commands)
        Output: N/A
        Behavior: Acts like a command line interface
         */
        static void Main(string[] args)
        {
            #region for loop
            Console.Write("1-5 using for loop: ");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
            #endregion

            #region while loop
            Console.Write("1-5 using while loop: ");
            int count = 1;

            while (count <= 5)
            {
                Console.Write("{0} ", count);
                count++;
            }

            Console.WriteLine();
            #endregion

            #region do/while loop
            Console.Write("1-5 using do/while loop: ");
            count = 0;

            do
            {
                count++;
                Console.Write("{0} ", count);
            } while (count < 5);

            Console.WriteLine();
            #endregion
        }
    }
}
