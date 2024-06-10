using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_enigpus.entities;
using dotnet_enigpus.services;

namespace dotnet_enigpus.view
{
    public class View
    {
        private InventoryService inventoryService = new InventoryService();
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Get All Books");
                Console.WriteLine("0. Exit");

                // Read user input
                string input = Console.ReadLine();

                // Validate input and perform the corresponding action
                switch (input)
                {
                    case "1":
                        inventoryService.AddBook();
                        break;
                    case "2":
                        inventoryService.SearchBook();
                        break;
                    case "3":
                        inventoryService.GetAllBooks();
                        break;
                    case "0":
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid selection. Please enter 1, 2, 3, or 0.");
                        break;
                }
            }
        }

    }
}