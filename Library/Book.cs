using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public Author AuthorBook { get; set; }
        public string NameBook { get; set; }

        public Book(string nameBook, Author authorBook )
        {
            AuthorBook = authorBook;
            NameBook = nameBook;
            
        }


       

    }
}
