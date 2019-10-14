/*
Author: Torin Tashima
Date:   10/10/2019
CTEC 135: Microsoft Software Development with C#

Module 2, Programming Assignment 1, Problem 3

   Decision Constructs

Create a program that prints out all the recommended actions based on these
conditions: Printer prints, red light flashing, printer recognized by computer.
Use one region for nested for loops and another for the switch statement.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
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
            #region region 1 - nested for loops
            Console.WriteLine("Printing actions - Nested for loops");
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        // Convert for loop counts to boolean conditions
                        bool canPrint = i == 1 ? true : false;
                        bool hasRedLight = j == 1 ? true : false;
                        bool isRecognized = k == 1 ? true : false;

                        // Print conditions
                        Console.WriteLine("prints: {0}, flashing light: {1}, " +
                            "printer recognized: {2}",
                            canPrint, hasRedLight, isRecognized);

                        // Conditions key: prints, red light flashes, computer recognizes
                        // Conditions: NO, NO, NO
                        if (!canPrint && !hasRedLight && !isRecognized)
                        {
                            ActionPowerCable();
                            ActionComputerCable();
                            ActionInstallSoftware();
                        }

                        // Conditions: NO, NO, YES
                        if (!canPrint && !hasRedLight && isRecognized)
                        {
                            ActionPaperJam();
                        }

                        // Conditions: NO, YES, NO
                        if (!canPrint && hasRedLight && !isRecognized)
                        {
                            ActionComputerCable();
                            ActionInstallSoftware();
                            ActionCheckInk();
                        }

                        // Conditions: NO, YES, YES
                        if (!canPrint && hasRedLight && isRecognized)
                        {
                            ActionCheckInk();
                            ActionPaperJam();
                        }

                        // Conditions: YES, NO, NO
                        if (canPrint && !hasRedLight && !isRecognized)
                        {
                            ActionInstallSoftware();
                        }

                        // Conditions: YES, NO, YES
                        if (canPrint && !hasRedLight && isRecognized)
                        {
                            Console.WriteLine("\tNo action required.");
                        }

                        // Conditions: YES, YES, NO
                        if (canPrint && hasRedLight && !isRecognized)
                        {
                            ActionInstallSoftware();
                        }

                        // Conditions: YES, YES, YES
                        if (canPrint && hasRedLight && isRecognized)
                        {
                            ActionCheckInk();
                        }

                        Console.WriteLine();
                    }
                }
            }
            #endregion

            #region region 2 - switch
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Printing actions - Switch statement");
            Console.WriteLine();

            // Iterate through possible condition combinations to summarize
            // necessary actions.
            for (int i = 0; i < 8; i++)
            {
                // Boolean conditions will be represented as digits in an
                // imaginary binary number.

                // Variables
                int j = i;
                bool canPrint = false;
                bool hasRedLight = false;
                bool isRecognized = false;

                // 100 is binary for 4, first digit represents if printer can
                // print.
                if (j >= 4)
                {
                    canPrint = true;
                    j -= 4;
                }

                // 010 is binary for 2, second digit represents if red light
                // is flashing.
                if (j >= 2)
                {
                    hasRedLight = true;
                    j -= 2;
                }

                // 001 is binary for 1, third digit represents if computer
                // can recognize printer.
                if (j >= 1)
                {
                    isRecognized = true;
                    j -= 1;
                }

                // Print conditions
                Console.WriteLine("prints: {0}, flashing light: {1}, " +
                            "printer recognized: {2}",
                            canPrint, hasRedLight, isRecognized);

                // Conditions key: prints, red light flashes, computer recognizes
                switch (i) {
                    // Conditions: NO, NO, NO
                    case 0:
                        ActionPowerCable();
                        ActionComputerCable();
                        ActionInstallSoftware();
                        break;
                    // Conditions: NO, NO, YES
                    case 1:
                        ActionPaperJam();
                        break;
                    // Conditions: NO, YES, NO
                    case 2:
                        ActionComputerCable();
                        ActionInstallSoftware();
                        ActionCheckInk();
                        break;
                    // Conditions: NO, YES, YES
                    case 3:
                        ActionCheckInk();
                        ActionPaperJam();
                        break;
                    // Conditions: YES, NO, NO
                    case 4:
                        ActionInstallSoftware();
                        break;
                    // Conditions: YES, NO, YES
                    case 5:
                        Console.WriteLine("\tNo action required.");
                        break;
                    // Conditions: YES, YES, NO
                    case 6:
                        ActionInstallSoftware();
                        break;
                    // Conditions: YES, YES, YES
                    case 7:
                        ActionCheckInk();
                        break;
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
            #endregion
        }

        /*
        Method: ActionPowerCable
        Input: N/A
        Output: Prints statement asking user to check the power cable
        Behavior: See output
         */
        static void ActionPowerCable()
        {
            Console.WriteLine("\tCheck the power cable.");
        }

        /*
        Method: ActionComputerCable
        Input: N/A
        Output: Prints statement asking user to check the printer-computer
            cable
        Behavior: See output
         */
        static void ActionComputerCable()
        {
            Console.WriteLine("\tCheck the printer-computer cable.");
        }

        /*
        Method: ActionInstallSoftware
        Input: N/A
        Output: Prints statement asking user to check if printer software is
            installed
        Behavior: See output
         */
        static void ActionInstallSoftware()
        {
            Console.WriteLine("\tEnsure printer software is installed.");
        }

        /*
        Method: ActionCheckInk
        Input: N/A
        Output: Prints statement asking user to check/replace printer ink
        Behavior: See output
         */
        static void ActionCheckInk()
        {
            Console.WriteLine("\tCheck/replace ink.");
        }

        /*
        Method: ActionPaperJam
        Input: N/A
        Output: Prints statement asking user to check for paper jam
        Behavior: See output
         */
        static void ActionPaperJam()
        {
            Console.WriteLine("\tCheck for paper jam.");
        }
    }
}
