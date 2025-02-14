﻿using System.Linq;

namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operator
            // var cheapBooks = from b in books where b.Price < 10 orderby b.Title select b.Title;

            // var cheapBooks = books
            //     .Where(b => b.Price < 10)
            //     .OrderBy(b => b.Title)
            //     .Select(b => b.Title);

            // foreach (var book in cheapBooks)
            // {
            //     System.Console.WriteLine(book);
            //     // System.Console.WriteLine(book.Title);
            // }

            var book = books.SingleOrDefault(b => b.Title == "Book 3");
            System.Console.WriteLine(book.Title);
        }
    }
}
