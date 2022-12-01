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
        public string[] ReadInputs(int maxInputs, string prompt)
        {
            Clear();
            string[] inputs = new string[maxInputs];
            int inputIndex = 0;

            while (true)
            {
                Console.Write(prompt);

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

            Console.WriteLine($"List of {listType}:");
            
            #region Feat. OpenAI ChatGPT Free Research Preview
            foreach (string member in stringArray)
            {
                Console.WriteLine(member);
            }
            #endregion

            Console.WriteLine("\nTip: Press ESC key whenever you want to go a menu up!");

            #region Feat. OpenAI ChatGPT Free Research Preview
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
