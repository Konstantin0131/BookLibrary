using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
            FillBooks();
        }

        public void AddBook()
        {
            string namebook = null;
            string firstName = null;
            string secondName = null;

            while (string.IsNullOrEmpty(namebook))
            {
                Console.WriteLine("Введите название книги : ");
                namebook = Console.ReadLine();

                if (string.IsNullOrEmpty(namebook))
                {
                    Console.WriteLine(" Вы ничего не ввели  ");
                }
            }

            while (string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine("Введите имя автора : ");
                firstName = Console.ReadLine();

                if (string.IsNullOrEmpty(firstName))
                {
                    Console.WriteLine(" Вы ничего не ввели  ");
                }

            }

            while (string.IsNullOrEmpty(secondName))
            {
                Console.WriteLine("Введите фамилию автора : ");
                secondName = Console.ReadLine();

                if (string.IsNullOrEmpty(secondName))
                {
                    Console.WriteLine(" Вы ничего не ввели  ");
                }
            }

            foreach (var bookName in books)
            {
                if (bookName.NameBook == namebook)
                {
                    Console.WriteLine("В библиртеке уже есть такая книга ");
                    return;
                }
            }

            books.Add(new Book(namebook, new Author(firstName, secondName)));
        }

        public void RemoveBook()
        {
            Console.WriteLine("Какую книгу вы хотите удалить : ");
            string bookName = Console.ReadLine();

            foreach (var currentBook in books)
            {
                if (currentBook.NameBook.ToLower().Equals(bookName.ToLower()))
                {
                    books.Remove(currentBook);
                    return;
                }
            }

            Console.WriteLine("В Библиотеке нет такой книги");
        }

        public void AlphabeticalContentByAuthorName()
        {
            var sortedBooks = books.OrderBy(p => p.AuthorBook.FirstName);
            foreach (var book in sortedBooks)
            {
                Console.WriteLine(book.AuthorBook.FirstName + "  " + book.AuthorBook.SecondName + " : " + book.NameBook);
            }
        }

        public void AlphabeticalContentByAuthorSurname()
        {
            var sorteBookAuthor = books.OrderBy(p => p.AuthorBook.SecondName);

            foreach (var book in sorteBookAuthor)
            {
                Console.WriteLine(book.AuthorBook.SecondName + "-" + book.AuthorBook.FirstName + " : " + book.NameBook);
            }
        }

        public void AlphabeticalContentByTitle()
        {
            var sorteBooks = books.OrderBy(b => b.NameBook);

            foreach (var book in sorteBooks)
            {
                Console.WriteLine(book.NameBook + " : " + book.AuthorBook.FirstName + " " + book.AuthorBook.SecondName);
            }
        }

        public void AuthorBookList()
        {
            Console.WriteLine("Введите автора :  ");
            string Authorlist = Console.ReadLine();

            string compar = null;

            foreach (var currentBook in books)
            {
                if (currentBook.AuthorBook.SecondName == Authorlist)
                {
                    Console.WriteLine(currentBook.NameBook);

                    compar = currentBook.AuthorBook.SecondName;
                }
            }

            if (compar == null)
            {
                Console.WriteLine("В Библиотеке нет такого автора");
            }
        }

        public void SearchByKeyword()
        {
            Console.WriteLine("Введите слово : ");
            string element = Console.ReadLine();

            foreach (var currentBook in books)
            {
                if (currentBook.NameBook.ToLower().Contains(element.ToLower()))
                {
                    Console.WriteLine(currentBook.NameBook + " : " + currentBook.AuthorBook.FirstName + " " + currentBook.AuthorBook.SecondName);
                    return;
                }
            }

            Console.WriteLine("Нет такой книги в библиотеке ");
        }

        public void FillBooks()
        {
            books.Add(new Book("Vyi", new Author("Anton", "Chehov")));
            books.Add(new Book("Idiot", new Author("Fedor", "Dostoevski")));
            books.Add(new Book("Igrok", new Author("Fedor", "Dostoevski")));
            books.Add(new Book("Hobit", new Author("Albert", "Tolkin")));
            books.Add(new Book("Prislyga", new Author("Alex", "Stoket")));
            books.Add(new Book("Noch", new Author("Max", "Vizel")));
            books.Add(new Book("Kameniari", new Author("Ivan", "Franko")));
        }
    }
}
