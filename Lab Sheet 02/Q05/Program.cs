using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05
{
    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }

        public void BorrowBook()
        {
            if (Available)
            {
                Console.WriteLine($"You have borrowed '{Title}' by {Author}.");
                Available = false;
            }
            else
            {
                Console.WriteLine($"Sorry, '{Title}' by {Author} is not available.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<LibraryBook> books = new List<LibraryBook>
            {
                new LibraryBook("Robinson Crusoe", "Daniel Defoe", true),
                new LibraryBook("The Catcher in the Rye", "J.D. Salinger", false),
                new LibraryBook("Emma", "Jane Austen", false),
            };

            Console.WriteLine("Initial Library Status:");
            DisplayLibraryStatus(books);

            Console.WriteLine("\nBorrowing a Book:");
            books[1].BorrowBook();

            Console.WriteLine("\nUpdated Library Status:");
            DisplayLibraryStatus(books);

            Console.ReadLine();
        }

        static void DisplayLibraryStatus(List<LibraryBook> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available: {(book.Available ? "Yes" : "No")}");
            }
        }
    }
}
