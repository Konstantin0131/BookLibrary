using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        public List<Book> books;
        public List<Author> authors;

        public Library()
        {
            books = new List<Book>();
            FillBooks();
            authors = new List<Author>();
          
        }

        public void AddBook()
        {
            Console.WriteLine( "Введите название книги, а затем автора : ");
            string namebook = Console.ReadLine();
            string firstName = Console.ReadLine();
            string sekondName = Console.ReadLine();

            books.Add(new Book(namebook, new Author(firstName, sekondName)));
        }

        public void RemoveBook()
        {
            Console.WriteLine("Какую книгу вы хотите удалить : ");
            string a = Console.ReadLine();
            foreach (var name in books)
            {
                if (name.NameBook.ToLower().Equals(a.ToLower()))
                {
                    books.Remove(name);
                    return;
                }
            }
           
            {
                Console.WriteLine("В Библиотеке нет такой книги");
            }

        }
        public void AlphabeticalContentByAuthorFirstName()
        {
            var sorteBookAuthor = books.OrderBy(p => p.AuthorBook.firstName);
            foreach(var p in sorteBookAuthor)
            {
                Console.WriteLine( p.AuthorBook.firstName +"  " + p.AuthorBook.sekondName +" : "+p.NameBook);
            }


        }

        public void AlphabeticalContentByAuthorSekondName()
        {
            var sorteBookAuthor = books.OrderBy(p => p.AuthorBook.sekondName);
            foreach (var p in sorteBookAuthor)
            {
                Console.WriteLine(p.AuthorBook.sekondName + "-" + p.AuthorBook.firstName+" : "+p.NameBook);
            }


        }

        public void AlphabeticalContentByTitle()
        {
            var sorteBookAuthor = books.OrderBy(b => b.NameBook);
            foreach (var b in sorteBookAuthor)
            {
                Console.WriteLine(b.NameBook + " : "+ b.AuthorBook.firstName +" " + b.AuthorBook.sekondName);
            }


        }
        public void AuthorBookList()
        {
            Console.WriteLine("Введите автора :  ");
            string _authorlist = Console.ReadLine();
            string a = null;
            foreach (var authorlist in books)
            {

                if (authorlist.AuthorBook.sekondName == _authorlist)
                {
                    Console.WriteLine( authorlist.NameBook);

                    a = authorlist.AuthorBook.sekondName;
                }



            }
            if (a == null)
            {
                Console.WriteLine("В Библиотеке нет такого автора");
            }
        }

        public void SearchByKeyword()
        {
            Console.WriteLine("Введите слово : ");
            string element = Console.ReadLine();
            
            foreach (var elementName in books)
            {
                if (elementName.NameBook.ToLower().Contains(element.ToLower()))
                {
                    Console.WriteLine(elementName.NameBook+" : "+elementName.AuthorBook.firstName+" " + elementName.AuthorBook.sekondName);
                    return;
                }

            }
            Console.WriteLine("Нет такой книги в библиотеке ");


        }

       
        public void FillBooks()
        {
            books.Add(new Book("Vyi",  new Author("Anton", "Chehov")));
            books.Add(new Book("Idiot", new Author("Fedor", "Dostoevski")));
            books.Add(new Book("Igrok", new Author("Fedor", "Dostoevski")));
            books.Add(new Book("Hobit", new Author("Albert", "Tolkin")));
            books.Add(new Book("Prislyga", new Author("Alex", "Stoket")));
            books.Add(new Book("Noch", new Author("Max", "Vizel")));
            books.Add(new Book("Kameniari", new Author("Ivan", "Franko")));


        }

     


    }
}
