using System.Collections.Generic;

namespace BookLibrary
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Title = "Xyz", Price = 20, Author = "Nayana"},
                new Book {Title = "Abc", Price = 10, Author = "Mohit"},
                new Book {Title = "Axm", Price = 10, Author = "Mohit"},
                new Book {Title = "Pqr", Price = 30, Author = "Dixit"},
                new Book {Title = "Qwerty", Price = 30, Author = "Bhanu"},
                new Book {Title = "Asdfg", Price = 30, Author = "Laxmi"},
                new Book {Title = "poiuy", Price = 20, Author = "Mausumi"}
            };
        }
        
    }
}