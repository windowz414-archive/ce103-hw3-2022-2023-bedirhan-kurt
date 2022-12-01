using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
