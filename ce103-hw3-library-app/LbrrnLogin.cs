/*
 * Copyright (C) 2022 Bushra "Bedirhan" KURT. All Rights Reserved.
 * 
 * SPDX-License-Identifier: GPL-2.0-only
 * 
 * Reference-Link: https://www.youtube.com/watch?v=qAWhGEPMlS8
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ce103_hw3
{
    internal class Lbrrn
    {
        public void LbrrnLogin()
        {
            WriteLine(@"Welcome, Librarian.

Press ENTER to unlock.");

            ConsoleKeyInfo keyInfo = ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                LbrrnMain lbrrnMain= new LbrrnMain();
                lbrrnMain.LbrrnMenu();
            }
            else
            {
                WriteLine("You pressed another key. Verification failed. Exiting...");
            }
        }
    }
}
