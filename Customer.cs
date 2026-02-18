using System;

namespace CustomerApp
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}";
        }
    }
}