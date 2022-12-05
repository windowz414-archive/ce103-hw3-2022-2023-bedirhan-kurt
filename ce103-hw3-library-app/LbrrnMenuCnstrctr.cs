/*
 * Copyright (C) 2022 Bushra "Bedirhan" KURT. All Rights Reserved.
 * 
 * SPDX-License-Identifier: GPL-2.0-only
 * 
 * Reference-Link: https://www.youtube.com/watch?v=qAWhGEPMlS8
 * 
 */

using System;
using static System.Console;

namespace ce103_hw3
{
    public class LbrrnMenuCnstrctr
    {
        // First things first, variables.
        private int pointedIndex;
        private string[] Options;
        private string PromptIcon;
        private string Prompt;

        // Now let's construct our menu.
        public LbrrnMenuCnstrctr(string promptIcon, string prompt, string[] options)
        {
            PromptIcon = promptIcon;
            Prompt = prompt;
            Options = options;
            pointedIndex = 0;
        }

        // Let's draw the menu now, shall we?
        private void CRT()
        {
            WriteLine($@"// Librarian Console //

({PromptIcon}) {Prompt}");
            for (int i = 0; i < Options.Length; i++)
            {
                string selectedOption = Options[i];
                string prefix;

                if (i == pointedIndex)
                {
                    prefix = ">";
                    ForegroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    prefix = " ";
                    ResetColor();
                }
                WriteLine($"{prefix} {selectedOption}");
                // HACK: Do ResetColor() twice to avoid title being colored while cycling through.
                ResetColor();
            }
        }

        // And now choices controller
        public int Choose()
        {
            ConsoleKey consoleKey;
            do
            {
                Clear();
                CRT();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                consoleKey = keyInfo.Key;
                if (consoleKey == ConsoleKey.UpArrow)
                {
                    pointedIndex--;
                    if (pointedIndex == -1)
                    {
                        pointedIndex = Options.Length - 1;
                    }
                }
                else if (consoleKey == ConsoleKey.DownArrow)
                {
                    pointedIndex++;
                    if (pointedIndex == Options.Length)
                    {
                        pointedIndex = 0;
                    }
                }
            } while (consoleKey != ConsoleKey.Enter);
            return pointedIndex;
        }
    }

    #region Feat. OpenAI ChatGPT Free Research Preview
    public class LbrrnInputReader
    {
        public string[] ReadInputs(int maxInputs, string[] prompts)
        {
            Clear();
            string[] inputs = new string[maxInputs];
            int inputIndex = 0;
            int promptIndex = 0;

            while (true)
            {
                Console.Write(prompts[promptIndex]);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }

                string input = Console.ReadLine();
                inputs[inputIndex] = input;
                inputIndex++;

                if (inputIndex == maxInputs)
                {
                    break;
                }

                promptIndex++;

                if (promptIndex == prompts.Length)
                {
                    promptIndex = 0;
                }
            }

            return inputs;
        }

    }
    #endregion

    public class LbrrnLister
    {
        public void LbrrnLst(string listType, string[] stringArray)
        {
            Clear();
            if (stringArray == null)
            {
                Console.WriteLine($"{listType} is empty.\n");
            }
            else
            {

                #region Feat. OpenAI ChatGPT Free Research Preview
                // Set the console foreground color to green
                Console.ForegroundColor = ConsoleColor.Green;
                
                // Set the console font style to bold
                Console.Write("\x1B[1m");
                
                // Write the heading
                Console.WriteLine($"List of {listType}:");
                
                // Reset the console font style to its default value
                Console.Write("\x1B[0m");
                
                // Reset color for the list
                ResetColor();

                foreach (string member in stringArray)
                {
                    Console.WriteLine(member);
                }
            }

            // Set the console font style to italic
            Console.Write("\x1B[3m");

            // Write the footer
            Console.WriteLine("\nTip: Press ESC key whenever you want to go a menu up!");

            // Reset the console font style to its default value
            Console.Write("\x1B[0m");

            while (true)
            {
                // Read the user's input.
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // Check if the user has pressed the Esc key.
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    // If the user has pressed the Esc key, exit the loop.
                    break;
                }
            }
            #endregion
        }
    }
}
