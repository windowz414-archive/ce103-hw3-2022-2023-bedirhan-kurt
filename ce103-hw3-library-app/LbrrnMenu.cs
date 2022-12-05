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
    public class LbrrnMain
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
                LbrrnInputReader lbrrnNewBookCtgry = new LbrrnInputReader();
                string[] lbrrnNewBookCtgryPrompt = { "Enter the name of the category you want: " };
                string[] inputs = lbrrnNewBookCtgry.ReadInputs(1, lbrrnNewBookCtgryPrompt);
                // We didn't implement a file writer just yet.
                throw new NotImplementedException();
                LbrrnBookCategories();
            }
            else if (pointedIndex == 1)
            {
                string ctgryEditPromptIcon = "?";
                string ctgryEditPrompt = "Select a category to edit:";
                string[] ctgryEditOptions = { "Action and Adventure", "Classics", "Comic Book or Graphic Novel", "Detective and Mystery", "Fantasy", "Historical Fiction", "Horror", "Literary Fiction" };
                LbrrnMenuCnstrctr lbrrnBookCtgryToEdit = new LbrrnMenuCnstrctr(ctgryEditPromptIcon, ctgryEditPrompt, ctgryEditOptions);
                string[] lbrrnBookCtgryNewNamePrompt = { $"[{lbrrnBookCtgryToEdit}] Enter the new name of the category: " };
                LbrrnInputReader lbrrnBookCtgryNewNameFunc = new LbrrnInputReader();
                string[] lbrrnBookCtgryNewName = lbrrnBookCtgryNewNameFunc.ReadInputs(1, lbrrnBookCtgryNewNamePrompt);
                // This is a prototype. We didn't actually implement a function for editing yet.
                throw new NotImplementedException();
            }
            else if (pointedIndex == 2)
            {
                string ctgryDelPromptIcon = "!";
                string ctgryDelPrompt = "Select a category to delete:";
                string[] ctgryDelOptions = { "Action and Adventure", "Classics", "Comic Book or Graphic Novel", "Detective and Mystery", "Fantasy", "Historical Fiction", "Horror", "Literary Fiction" };
                LbrrnMenuCnstrctr lbrrnBookCtgryDel = new LbrrnMenuCnstrctr(ctgryDelPromptIcon, ctgryDelPrompt, ctgryDelOptions);
                // This is a prototype. We didn't actually implement a function for deletion yet.
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
