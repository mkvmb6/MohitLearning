using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }

        
    }

    public class BookRepository
    {
        public IList<Book> GetBooks()
        {
            var bookList = new List<Book>
            {
                new Book() {Name="Karvalo", Price = 200},
                new Book() {Name="JCross", Price = 300},
                new Book() {Name="And then there were none", Price = 500},
                new Book() {Name="Revolution 2020", Price = 200}
            };

            return bookList;
        }

    }
}
