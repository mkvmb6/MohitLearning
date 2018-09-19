using System;
using System.Collections.Generic;
using BookLibrary;
using System.Linq;

namespace FirstLearning
{
    public class MyBookRunner
    {
        static void Main(string[] args)
        {
            var allBooks = new BookRepository().GetBooks();
            //PrintBooks(allBooks);

            var titles = allBooks.Select(book => book.Title);
            var anonyTypes = allBooks.Select(book => new {Ttl = book.Title, Prc = book.Price});


            foreach (var anonyType in anonyTypes)
            {
                Console.WriteLine($"Title: {anonyType.Ttl}, Price: {anonyType.Prc}");
            }



            //var lessThan30RsBooks = allBooks.Where(book => FilterByPrice(book,30));
            var lessThan30RsBooks = allBooks.Where(book => book.Price < 30);

            if (allBooks.Any(book => book.Price > 30 && book.Author == "Mohit"))
            {
                Console.WriteLine("Hi Naina");
            }


            var firstBook = allBooks.First(book => book.Title.StartsWith("A"));

            var skippedFirst = allBooks.First(book => book.Title.StartsWith("A"));



            //Select  <--To choose a specific property from the collection and return the collection of the type of chosen property.
            //Where <- Filter the list and return the collection of the filtered items.
            //Any  <-- Returns true if any item is present in the list otherwise false.
            //First <-- Returns the first element of the list. If not item is present then throws exception with the message, "Sequence contains no elements" (InvalidOperationException)
            //Skip <-- Skips the number of elements specified in the params and returns the collection of remaining.
            //All  <-- Returns true/false after evaluating the specified condition on all the items of the list.


            if (allBooks.All(book => book.Price > 0))
            {

            }

            var highestPriceBook = allBooks.Skip(2).Max(book => book.Title);

            var booksOfEachPrice = allBooks.GroupBy(book => book.Price).Select(g => g.Skip(1).First());
            
            PrintBooks(booksOfEachPrice);

            /*var dict = new Dictionary<int, IEnumerable<Book>>();

            dict[10] = new List<Book> {null, null};
            dict[20] = new List<Book> {null, null};
            dict[30] = new List<Book> {null, null,null};*/

            var products = new List<Product>
            {
                new Mobile(),
                new Mobile(),
                new Laptop(),
                new XBox(),
                new XBox()
            };

            var mobiles = products.OfType<Mobile>();
            var xboxes = products.OfType<XBox>();
            var something = products.GroupBy(p => p.GetType() == typeof(Mobile)).First();

        }

        public static bool FilterByPrice(Book book, int expectedPrice)
        {
            return book.Price < 30;
        }

        private static void PrintBooks(IEnumerable<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Price: {book.Price}, Author: {book.Author}");
            }
        }
    }
}
