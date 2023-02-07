using System;
using System.Reflection.Metadata.Ecma335;

//LINQ = Language Integrated Query
//gives you the capability to query objects

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // normal methode without LINQ
            // var cheapBooks = new List<Book>();
            // foreach (var book in books)
            // {
            //     if (book.Price<10)
            //         cheapBooks.Add(book);
            // }
            //
            // foreach (var cheapBook in cheapBooks) {
            //     Console.WriteLine(cheapBook.Title + "   " + cheapBook.Price );
            // }


            // using LINQ extension methods

            var cheapBooks = books.Where(b => b.Price < 10);
            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine(cheapBook.Title + "   " + cheapBook.Price);
            }

            // or

            var orderByTitle = books.OrderBy(b => b.Title);
            foreach (var order in orderByTitle)
            {
                Console.WriteLine(order.Title + "  " + order.Price);
            }

            // by using LINQ query oprator 
            // var cheaperBooks = 
            //         from b in books
            //         where b.Price < 10
            //         orderby b.Title
            //         select b.Title;


        }
    }

}

