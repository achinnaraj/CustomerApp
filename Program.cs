using System;

namespace CustomerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();
            bool running = true;

            Console.WriteLine("=== Welcome to Customer Manager ===\n");

            while (running)
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. Add a new customer");
                Console.WriteLine("2. View all customers");
                Console.WriteLine("3. Delete a customer");
                Console.WriteLine("4. Exit");
                Console.Write("\nSelect an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewCustomer(manager);
                        break;
                    case "2":
                        manager.ViewAllCustomers();
                        break;
                    case "3":
                        DeleteCustomer(manager);
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("\nThank you for using Customer Manager!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddNewCustomer(CustomerManager manager)
        {
            Console.WriteLine("\n--- Add New Customer ---");
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter customer address: ");
            string address = Console.ReadLine();

            manager.AddCustomer(name, address);
        }

        static void DeleteCustomer(CustomerManager manager)
        {
            if (manager.GetCustomerCount() == 0)
            {
                Console.WriteLine("No customers to delete.");
                return;
            }

            Console.WriteLine("\n--- Delete Customer ---");
            manager.ViewAllCustomers();
            Console.Write("Enter customer number to delete: ");

            if (int.TryParse(Console.ReadLine(), out int index))
            {
                manager.DeleteCustomer(index - 1);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}