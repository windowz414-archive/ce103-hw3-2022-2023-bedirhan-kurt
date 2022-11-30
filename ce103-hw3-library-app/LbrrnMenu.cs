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
    internal class LbrrnMain
    {
        public void LbrrnMenu()
        {
            string mainPromptIcon = "?";
            string mainPrompt = "What will you work with?";
            string[] mainOptions = { "Book Categories", "Books", "People", "Log out" };
            LbrrnMenuCnstrctr lbrrnMenu = new LbrrnMenuCnstrctr(mainPromptIcon, mainPrompt, mainOptions);

            int pointedIndex = lbrrnMenu.Choose();
            if (pointedIndex == 0)
            {
                LbrrnBookCategories();
            }
            else if (pointedIndex == 1)
            {
                LbrrnBooks();
            }
            else if (pointedIndex == 2)
            {
                LbrrnPeople();

            }
            else if (pointedIndex == 3)
            {
                // Clear screen first for privacy.
                Clear();

                // Return back to login.
                Lbrrn lbrrn = new Lbrrn();
                lbrrn.LbrrnLogin();
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void LbrrnBookCategories()
        {
            string ctgryPromptIcon = "?";
            string ctgryPrompt = "What will you do about book categories?";
            string[] ctgryOptions = { "Add a new category", "Edit an existing category", "Delete an existing category", "Go back" };
            LbrrnMenuCnstrctr lbrrnBookCtgry = new LbrrnMenuCnstrctr(ctgryPromptIcon, ctgryPrompt, ctgryOptions);

            int pointedIndex = lbrrnBookCtgry.Choose();
            if (pointedIndex == 0)
            {
                // TODO: Code an add menu with text edit functionalities and assign its variables here.
                throw new NotImplementedException();
            }
            else if (pointedIndex == 1)
            {
                // TODO: Code an edit menu with selection and edit functionalities and assign its variables here.
                throw new NotImplementedException();
            }
            else if (pointedIndex == 2)
            {
                // TODO: Code a selection menu with categories and the options to delete, choose something else or return from there and assign its variables here.
                throw new NotImplementedException();
            }
            else if (pointedIndex == 3)
            {
                LbrrnMenu();
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        private void LbrrnBooks()
        {
            string booksPromptIcon = "?";
            string booksPrompt = "What will you do about books?";
            string[] booksOptions = { "Add a new book", "Edit an exinsting book", "Delete an existing book", "List all books", "Search a specific book", "Go back" };
            LbrrnMenuCnstrctr lbrrnBooks = new LbrrnMenuCnstrctr(booksPromptIcon, booksPrompt, booksOptions);

            int pointedIndex = lbrrnBooks.Choose();
            if (pointedIndex == 0)
            {
                // TODO: Code an add menu with text edit functionalities and assign its variables here.
                throw new NotImplementedException();
            }
            else if (pointedIndex == 1)
            {
                // TODO: Code an edit menu with selection and edit functionalities and assign its variables here.
                throw new NotImplementedException();
            }
            else if (pointedIndex == 2)
            {
                // TODO: Code a selection menu with categories and the options to delete, choose something else or return from there and assign its variables here.
                throw new NotImplementedException();
            }
            else if (pointedIndex == 3)
            {
                // TODO: Code a list menu that reads the file and lists whatever it reads, along with a back button.
                throw new NotImplementedException();
            }
            else if (pointedIndex == 4)
            {
                // TODO: Code a search menu that asks search method - ID, author and name.
                throw new NotImplementedException();
            }
            else if (pointedIndex == 5)
            {
                LbrrnMenu();
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void LbrrnPeople()
        {
            string peoplePromptIcon = "?";
            string peoplePrompt = "What will you do about people?";
            string[] peopleOptions = { "Add a person borrowing book and what book they borrowed", "Update a previous person's status", "List people borrowed books from this library", "Go back" };
            LbrrnMenuCnstrctr lbrrnPeople = new LbrrnMenuCnstrctr(peoplePromptIcon, peoplePrompt, peopleOptions);

            int pointedIndex = lbrrnPeople.Choose();
            if (pointedIndex == 0)
            {
                // TODO: Code an add menu with text edit functionalities and assign its variables here.
                throw new NotImplementedException() ;
            }
            else if (pointedIndex == 1)
            {
                // TODO: Code a selection menu with updating options.
                throw new NotImplementedException();
            }
            else if (pointedIndex == 2)
            {
                // TODO: Code a list menu that reads the file and lists whatever it reads, along with a back button.
                throw new NotImplementedException();
            }
            else if (pointedIndex == 3)
            {
                LbrrnMenu();
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
