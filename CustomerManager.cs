using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace CustomerApp
{
    public class CustomerManager
    {
        private List<Customer> customers;
        private const string FilePath = "customers.json";

        public CustomerManager()
        {
            customers = new List<Customer>();
            LoadCustomers();
        }

        public void AddCustomer(string name, string address)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("Error: Name and Address cannot be empty!");
                return;
            }

            customers.Add(new Customer(name, address));
            Console.WriteLine($"Customer '{name}' added successfully!");
            SaveCustomers();
        }

        public void ViewAllCustomers()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
                return;
            }

            Console.WriteLine("\n--- Customer List ---");
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {customers[i]}");
            }
            Console.WriteLine();
        }

        public void DeleteCustomer(int index)
        {
            if (index < 0 || index >= customers.Count)
            {
                Console.WriteLine("Error: Invalid customer number!");
                return;
            }

            string name = customers[index].Name;
            customers.RemoveAt(index);
            Console.WriteLine($"Customer '{name}' deleted successfully!");
            SaveCustomers();
        }

        private void SaveCustomers()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(customers, options);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving customers: {ex.Message}");
            }
        }

        private void LoadCustomers()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    customers = JsonSerializer.Deserialize<List<Customer>>(json) ?? new List<Customer>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading customers: {ex.Message}");
                customers = new List<Customer>();
            }
        }

        public int GetCustomerCount()
        {
            return customers.Count;
        }
    }
}