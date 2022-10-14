using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum Genres { Unknown, Historical, Fiction, Detective, Childrens }

    class Book
    {
        public Author AuthorBook { get; set; }
        public Genres Gentres { get; set; }
        public string NameBook { get; set; }

        public Book(string nameBook, Author authorBook, Genres gentres)
        {
            AuthorBook = authorBook;
            NameBook = nameBook;
            Gentres = gentres;
        }
    }
}
