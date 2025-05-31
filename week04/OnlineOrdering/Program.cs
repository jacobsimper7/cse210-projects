using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Widget", "W123", 9.99, 2),
            new Product("Gadget", "G456", 14.99, 1),
            new Product("Thingamajig", "T789", 4.99, 5)
        };
        Order order1 = new Order(customer1, products1);

        // Order 2
        Address address2 = new Address("456 Oak Ave", "Rivertown", "CA", "USA");
        Customer customer2 = new Customer("Jane Smith", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Book", "B001", 12.50, 1),
            new Product("Pen", "P002", 1.25, 10),
            new Product("Notebook", "N003", 3.75, 3)
        };
        Order order2 = new Order(customer2, products2);

        // Order 3
        Address address3 = new Address("789 Pine Rd", "Mapleton", "ON", "Canada");
        Customer customer3 = new Customer("Alice Brown", address3);
        List<Product> products3 = new List<Product>
        {
            new Product("Lamp", "L321", 22.99, 1),
            new Product("Bulb", "B654", 2.99, 4),
            new Product("Shade", "S987", 7.99, 2)
        };
        Order order3 = new Order(customer3, products3);

        // Display shipping labels for all orders
        Console.WriteLine("Order 1");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLable());
        Console.WriteLine("Total price:");
        Console.WriteLine($"${order1.GetTotalPrice()}");
        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLable());
        Console.WriteLine("Total price:");
        Console.WriteLine($"${order2.GetTotalPrice()}");
        Console.WriteLine();

        Console.WriteLine("Order 3");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order3.GetPackingLable());
        Console.WriteLine("Total price:");
        Console.WriteLine($"${order3.GetTotalPrice()}");
        Console.WriteLine();
    }
}