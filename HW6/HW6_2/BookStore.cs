using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace HW6_2
{
    internal class BookStore
    {
        private static float balans = 0;
        private static readonly List<Book> books = new List<Book>();
        public static void Main(string[] args)
        {
            books.Add(new Book("50 оттенков грусти", "Драма", 1.99f, 8));
            books.Add(new Book("50 Капель печали", "Игра", 1.39f, 3));
            books.Add(new Book("50 памперсов печали", "Драма", 1.39f, 3));
            books.Add(new Book("50 оттенков леса", "Комедия", 2.97f, 6));
            //markUp("Драма", 0.5f);
            markUp(books[0], 0.5f);
            Console.WriteLine(books[1].Price);
            //purchase(books[2]);
            var rrar = new List<int>() {5, 6, 7, 8,9,45,34,75,2};
            var rar = rrar.Where(r => r%2==0).Select(r => r+=2).ToList();
            Console.WriteLine(string.Join(", ", rar));

        }

        private static void purchase(Book book)
        {
            balans += book.Price;
            book.Quantity--;
            Console.WriteLine($"Вы купили книгу {book.Name}, их осталось всего {book.Quantity}, выручка магазина: {balans} ");
        }
        private static void markUp(Book book, float upPrice)
        {
            var books8 = new List<Book>();
            books8 = books.Where(b => b.Genre == book.Genre).ToList();
            Console.WriteLine(books8[1].Price); 
            books8.Select(u => u.Price += upPrice);
            Console.WriteLine(books8[1].Price);
            
        }
 //      private static void markUp(Book book, float upPrice)
 //      {
 //         foreach (var b in books.Where(b => b.Genre == book.Genre)) b.Price += upPrice;
 //      }
        
        
        
        private static void markUp(string gnr, float upPrice)
        {
            foreach (var b in books.Where(b => b.Genre == gnr)) b.Price += upPrice;
        }
    }
}