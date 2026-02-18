# Customer App

A simple C# console application to manage customer information (name and address).

## Features

- ✅ Add new customers with name and address
- ✅ View all customers
- ✅ Delete customers
- ✅ Persistent storage using JSON file
- ✅ Input validation

## Project Structure

- **Program.cs** - Main entry point with menu-driven interface
- **Customer.cs** - Customer class definition
- **CustomerManager.cs** - Business logic for managing customers
- **customers.json** - Data file (auto-created)

## How to Run

### Prerequisites
- .NET SDK installed on your machine
- Visual Studio, Visual Studio Code, or any text editor

### Steps

1. Clone the repository:
```bash
git clone https://github.com/achinnaraj/CustomerApp.git
cd CustomerApp
```

2. Run the application:
```bash
dotnet run
```

3. Follow the menu options to:
   - Add customers
   - View all customers
   - Delete customers
   - Exit

## Example Usage

```
=== Welcome to Customer Manager ===

--- Main Menu ---
1. Add a new customer
2. View all customers
3. Delete a customer
4. Exit

Select an option (1-4): 1

--- Add New Customer ---
Enter customer name: John Doe
Enter customer address: 123 Main St, City, State 12345
Customer 'John Doe' added successfully!
```

## Data Storage

Customer data is automatically saved to a `customers.json` file in the application directory. This file persists between sessions.

## Learning Objectives

This project is designed to teach:
- C# fundamentals (classes, properties, methods)
- File I/O operations
- JSON serialization/deserialization
- User input handling
- Error handling and validation
- Object-oriented programming concepts

## Future Enhancements

- Edit customer information
- Search functionality
- Phone number and email fields
- Database integration (SQL Server/SQLite)
- Web interface (ASP.NET Core)

---

Happy learning! 🚀