using System;
using System.Collections.Generic;
using System.Linq;
using MyExtensions;

namespace BookLibrary
{
    public class BookRunner
    {
        public static  void Main()
        {
            var bookRepository = new BookRepository();
            var books = bookRepository.GetBooks();

            var costlyBooks = books.Where(x=>x.Price > 200).ToList();
            //var costlyBooks2=new List<Book>();
            //foreach (var x in books)
            //{
            //    if (x.Price>20)
            //    {
            //        costlyBooks2.Add(x);
            //    }
            //}
            costlyBooks.ForEach(x=>Console.WriteLine(x.Name));
         
            Console.WriteLine(3.MiliSeconds());

            var numList = new List<int>() {2,4,5,7,3};

            var myfirst = numList.MyFirst();
            Console.WriteLine(myfirst);

        }

    }
}