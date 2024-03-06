using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01
{
    internal class Program
    {
        class Book
        {
            public string Title { set; get; }
            public string Author { set; get; }
        }

        static void Main(string[] args)
        {
            Book myBook = new Book();

            myBook.Title = "Robinson Crusoe";
            myBook.Author = "Daniel Defoe";

            Console.WriteLine($"Title: {myBook.Title}");
            Console.WriteLine($"Author: {myBook.Author}");

            Console.ReadLine();
        }
    }
}
