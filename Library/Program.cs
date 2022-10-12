using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            Library library = new Library();
            while (b)
            {
                Console.WriteLine();
                Console.WriteLine("Закрыть меню клавиша 0");
                Console.WriteLine("Добавить книгу - клавиша 1");
                Console.WriteLine("Удалить книгу- клавиша 2");
                Console.WriteLine("Содержимое по алфавиту(по имени автора)- клавиша 3 ");
                Console.WriteLine("Содержимое по алфавиту(по фамилии автора)- клавиша 4 ");
                Console.WriteLine("Содержимое по алфавиту(по названию)- клавиша 5");
                Console.WriteLine("Список книг автора- клавиша 6");
                Console.WriteLine("Найти книгу по ключевым словам- клавиша 7");
                Console.WriteLine("Выбор жанра клавиша 8");
                Console.WriteLine("Выберите действие : ");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 0:
                        b = false;
                        break;
                    case 1:
                        library.AddBook();
                        break;
                    case 2:
                        library.RemoveBook();
                        break;
                    case 3:
                        library.AlphabeticalContentByAuthorName();
                        break;
                    case 4:
                        library.AlphabeticalContentByAuthorSurname();
                        break;
                    case 5:
                        library.AlphabeticalContentByTitle();
                        break;
                    case 6:
                        library.AuthorBookList();
                        break;
                    case 7:
                        library.SearchByKeyword();
                        break;
                    case 8:
                        library.GenreSelection();
                        break;
                }

            }
            Console.WriteLine("Вы закончили работу");
            Console.ReadLine();
        }
    }
}
