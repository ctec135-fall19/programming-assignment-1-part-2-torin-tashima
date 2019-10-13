/*
Author: Torin Tashima
Date:   10/10/2019
CTEC 135: Microsoft Software Development with C#

Module 2, Programming Assignment 1, Problem 3

   Decision Constructs

Create a program that prints out all the recommended actions based on these
conditions: Printer prints, red light flashing, printer recognized by computer.

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

        /*
        Method: Main
        Input: An array of strings (commands)
        Output: N/A
        Behavior: Acts like a command line interface
         */
        static void Main(string[] args)
        {
            #region region 1 - print conditions
            /*
            Method: PrintConditions
            Input: Three booleans, canPrint, hasRedLight, isRecognizable
            Output: Prints conditions of if:
                1. The printer can print
                2. The printer has a red light flashing
                3. The printer is recognized by the computer
            Behavior: Takes the input of the three booleans and arranges
                conditions into a single printed line
             */                                                             
            void PrintConditions(bool canPrint, bool hasRedLight, bool isRecognizable)
            {
                // Check if printer can print
                Console.Write("prints: ");
                if (canPrint)
                {
                    Console.Write(true);
                } else
                {
                    Console.Write(false);
                }

                // Check if red light is flashing
                Console.Write(", red light: ");
                if (hasRedLight)
                {
                    Console.Write(true);
                }
                else
                {
                    Console.Write(false);
                }

                // Check if printer is recognized
                Console.Write(", printer recognized: ");
                if (isRecognizable)
                {
                    Console.Write(true);
                }
                else
                {
                    Console.Write(false);
                }

                Console.WriteLine();
            }
            #endregion

            #region region 2 - print actions
            // Iterate through possible condition combinations to summarize
            // necessary actions.
            for (int i = 0; i < 8; i++)
            {
                // Conditions key: prints, red light flashes, computer recognizes
                switch (i) {
                    // Conditions: NO, NO, NO
                    case 0:
                        PrintConditions(false, false, false);

                        ActionPowerCable();
                        ActionComputerCable();
                        ActionInstallSoftware();

                        Console.WriteLine();
                        break;
                    // Conditions: NO, NO, YES
                    case 1:
                        PrintConditions(false, false, true);

                        ActionPaperJam();

                        Console.WriteLine();
                        break;
                    // Conditions: NO, YES, NO
                    case 2:
                        PrintConditions(false, true, false);

                        ActionComputerCable();
                        ActionInstallSoftware();
                        ActionCheckInk();

                        Console.WriteLine();
                        break;
                    // Conditions: NO, YES, YES
                    case 3:
                        PrintConditions(false, true, true);

                        ActionCheckInk();
                        ActionPaperJam();

                        Console.WriteLine();
                        break;
                    // Conditions: YES, NO, NO
                    case 4:
                        PrintConditions(true, false, false);

                        ActionInstallSoftware();

                        Console.WriteLine();
                        break;
                    // Conditions: YES, NO, YES
                    case 5:
                        PrintConditions(true, false, true);

                        Console.WriteLine("\tNo action required.");

                        Console.WriteLine();
                        break;
                    // Conditions: YES, YES, NO
                    case 6:
                        PrintConditions(true, true, false);

                        ActionInstallSoftware();

                        Console.WriteLine();
                        break;
                    // Conditions: YES, YES, YES
                    case 7:
                        PrintConditions(true, true, true);

                        ActionCheckInk();

                        Console.WriteLine();
                        break;
                    // Obligatory default
                    default:
                        Console.WriteLine("\tNo action required.");

                        Console.WriteLine();
                        break;
                }
            }
            #endregion
        }
    }
}
