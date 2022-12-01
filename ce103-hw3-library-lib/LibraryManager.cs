/* 
 * Copyright (C) 2022 Bushra KURT. All Rights Reserved.
 * 
 * SPDX-License-Identifier: GPL-2.0-only
 * 
 */

using System.Collections;

namespace ce103_hw3_lib
{
    public class LibraryManager
    {
        private ArrayList bookList;
        LibraryManager() {
            bookList = new ArrayList();
        }

        public void AddBook(Book book)
        {
            bookList.Add(book);
        }
    }
}
