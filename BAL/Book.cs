using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibryManagement.BAL
{
    class Book
    {
        private string bookISBN;
        private string bookName;
        private int pages;
        private static int bookCount;


        public Book(string id,string bookname)
        {
            this.bookISBN = id;
            this.bookName = bookname;
            bookCount += 1;
        }



    }

}
