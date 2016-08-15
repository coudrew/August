using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresList
{
    class Program
    {
        public static List<Book> books = new List<Book>();
        static void Main(string[] args)
        {
            
            bool running = true;
            while (running == true)
            {
                Console.WriteLine("Select an action: \n 'add' to add a book \n 'remove' to remove a book \n 'show' to display list of books \n 'sort' to sort books \n 'search' to search \n 'quit' to exit");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "add":
                        AddBook();
                        break;
                    case "remove":
                        RemoveBook();
                        break;
                    case "show":
                        ShowBooks();
                        break;
                    case "sort":
                        SortBooks();
                        break;
                    case "search":
                        SearchBooks();
                        break;
                    case "quit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid action");
                        break;
                }
            }
        }
        static void AddBook()
        {
            Console.Clear();
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter author: ");
            string author = Console.ReadLine();
            Book book = new Book(title, author);
            books.Add(book);
            return;
        }
        static void RemoveBook()
        {
            Console.Clear();
            ShowBooks();
            Console.WriteLine("Enter title of book to remove: ");
            string bookToRemove = Console.ReadLine();
            foreach (Book book in books)
            {
                if (book.Title == bookToRemove)
                {
                    books.Remove(book);
                    Console.WriteLine(book.Title + " removed");
                    break;
                } 
            }
            return;
        }
        static void SortBooks()
        {
            Console.Clear();
            Console.WriteLine("Sort by author or title? ('a' or 't')");
            string action = Console.ReadLine();
            switch (action)
            {
                case "a":
                    books.Sort((x, y) => string.Compare(x.Author, y.Author));
                    Console.WriteLine("\n Sorted by author");
                    break;
                case "t":
                    books.Sort((x, y) => string.Compare(x.Title, y.Title));
                    Console.WriteLine("\n Sorted by title");
                    break;
                default:
                    Console.WriteLine("\n Invalid selection");
                    break;
            }
            ShowBooks();
        }
        static void ShowBooks()
        {
            Console.Clear();
            Console.WriteLine("**********Books***********");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine("\n" + books[i].Title + ", by " + books[i].Author);
            }
            Console.WriteLine("\n**************************");
        }
        static Book Search(string searchFor, string searchBy)
        {
            foreach (Book book in books)
            {
                if (searchBy == "title")
                {
                    if (book.Title == searchFor)
                    {
                        return book;
                    }
                } else if (searchBy == "author")
                {
                    if (book.Author == searchFor)
                    {
                        return book;
                    }
                }
            }
            return;
        }
        static void SearchBooks()
        {
            Console.Clear();
            Console.WriteLine("Search by author or title? ('a' or 't')");
            string action = Console.ReadLine();
            Console.WriteLine("Search for: ");
            string target = Console.ReadLine();
            Book book = Search(target, action);
            Console.WriteLine(book.Title + ", by " + book.Author);
        }
    }
}
