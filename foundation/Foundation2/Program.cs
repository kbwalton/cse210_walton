using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("24 S raccoon St", "Phoenix", "AZ", "USA");
        Address address2 = new Address("27 E Portal St", "West End","Dublin", "Ireland");

        Customer customer1 = new Customer("Joe Mama", address1);
        Customer customer2 = new Customer("Max Walnut", address2);

        Product product1 = new Product("Keyboard", "K27", 100m, 1);
        Product product2 = new Product("Ring", "R29", 200m, 1);
        Product product3 = new Product("Mouse", "M01", 300m, 1);
        Product product4 = new Product("Tire", "T37", 400m, 1);


        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}