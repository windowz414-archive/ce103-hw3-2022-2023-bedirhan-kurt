using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                // TODO: Make a student management submenu and call it here.
                throw new NotImplementedException();

            }
            else if (pointedIndex == 3)
            {
                // Clear screen first for privacy.
                Clear();

                // Return back to login.
                Lbrrn lbrrn = new Lbrrn();
                lbrrn.LbrrnLogin();
            }
        }

        private void LbrrnBookCategories()
        {
            string ctgryPromptIcon = "?";
            string ctgryPrompt = "What will you do about book categories?";
            string[] ctgryOptions = { "Add a new category", "Edit an existing category", "Delete an existing category" };
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
        }
        private void LbrrnBooks()
        {
            string booksPromptIcon = "?";
            string booksPrompt = "What will you do about books?";
            string[] booksOptions = { "Add a new book", "Edit an exinsting book", "Delete an existing book" };
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
        }
    }
}
