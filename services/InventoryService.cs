using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_enigpus.entities;

namespace dotnet_enigpus.services
{
    public class InventoryService : IInventoryService
    {
        public static List<Book> books = new List<Book>();
        public void AddBook()

        {
            while (true)
            {
                Console.WriteLine("Add Book Menu");
                Console.WriteLine("1. Add Novel");
                Console.WriteLine("2. Add Magazine");
                Console.WriteLine("0. Back to Main Menu");

                // Read user input
                string input = Console.ReadLine();

                // Validate input and perform the corresponding action
                switch (input)
                {
                    case "1":
                        AddNovel();
                        break;
                    case "2":
                        AddMagazine();
                        break;
                    case "0":
                        return; // Return to main menu
                    default:
                        Console.WriteLine("Invalid selection. Please enter 1, 2, or 0.");
                        break;
                }
            }
        }

        private void AddNovel()
        {
            Console.WriteLine("Add Novel");
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Publisher: ");
            string publisher = Console.ReadLine();
            Console.Write("Enter Release Year: ");
            int releaseYear = int.Parse(Console.ReadLine());
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Novel novel = new Novel(id, title, publisher, releaseYear, author);
            books.Add(novel);
            Console.WriteLine("Novel added successfully.");
        }

        private void AddMagazine()
        {
            Console.WriteLine("Add Magazine");
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Publisher: ");
            string publisher = Console.ReadLine();
            Console.Write("Enter Release Year: ");
            int releaseYear = int.Parse(Console.ReadLine());

            Magazine magazine = new Magazine(id, title, publisher, releaseYear);
            books.Add(magazine);
            Console.WriteLine("Magazine added successfully.");
        }

        public void SearchBook()
        {
            Console.WriteLine("Search Book");
            Console.Write("Enter Book ID: ");
            string id = Console.ReadLine();

            Book foundBook = books.Find(book => book.Id == id);

            if (foundBook != null)
            {
                Console.WriteLine($"Found Book: {foundBook.Title}, Publisher: {foundBook.Publisher}, Release Year: {foundBook.ReleaseYear}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void GetAllBooks()
        {
            Console.WriteLine("Novels:");
            foreach (var book in books)
            {
                if (book is Novel novel)
                {
                    Console.WriteLine($"ID: {novel.Id}, Title: {novel.Title}, Publisher: {novel.Publisher}, Release Year: {novel.ReleaseYear}, Author: {novel.Author}");
                }
            }

            Console.WriteLine("Magazines:");
            foreach (var book in books)
            {
                if (book is Magazine magazine)
                {
                    Console.WriteLine($"ID: {magazine.Id}, Title: {magazine.Title}, Publisher: {magazine.Publisher}, Release Year: {magazine.ReleaseYear}");
                }
            }
        }
    }
}