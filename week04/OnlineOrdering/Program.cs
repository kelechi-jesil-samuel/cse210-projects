using System;

class Program
{
    static void Main(string[] args)
    {
        // Address 1 USA
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L1001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M205", 25.50, 2));

        // Address 2 NOT USA
        Address address2 = new Address("45 High Street", "London", "England", "UK");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Water Bottle", "L300", 15.00, 3));
        order2.AddProduct(new Product("Notebook", "N400", 5.25, 4));
        // Display Order1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("\n--------------------------\n");
        // Display Order2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
    }
}