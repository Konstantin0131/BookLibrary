using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum Grades { historical, fiction, detective, childrens }
    class Book
    {
        public Author AuthorBook { get; set; }
        public Grades Grade { get; set; }

        public string NameBook { get; set; }

        public Book(string nameBook, Author authorBook, Grades grades)
        {
            AuthorBook = authorBook;
            NameBook = nameBook;
            Grade = grades;
        }
    }
}
