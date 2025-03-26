using System;

class Program
{
    static void Main(string[] args)
    {
        // FIRST ORDER
        Console.WriteLine("\nJohns Order");
        Product product1 = new Product("Iphone", "12345", 1500, 2);
        Product product2 = new Product("Macbook", "12346", 2000, 1);

        Address johnAddress = new Address("123 Main St", "Cityville", "Stateville", "usa");

        Customer john = new Customer("John Smith", johnAddress);

        List<Product> johnProducts = new List<Product> {product1, product2};
        Order johnOrder = new Order(john, johnProducts);

        string johnTotal = johnOrder.CalculateTotalCost();

        Console.WriteLine($"\n{johnOrder.GetPackingLabel()}\n");
        Console.WriteLine($"{johnTotal}\n");
        Console.WriteLine($"{johnOrder.GetShippingLabel()}\n");
        
        // SECOND ORDER
        Console.WriteLine("Janes Order");
        Product janeproduct1 = new Product("Apple Watch", "22345", 200, 1);
        Product janeproduct2 = new Product("AirPods", "22346", 300, 2);
        Product janeproduct3 = new Product("iPad", "22347", 550, 1);

        Address janeAddress = new Address("456 Oak St", "Metropolis", "New York", "Canada");

        Customer jane = new Customer("Jane Doe", janeAddress);

        List<Product> janeProducts = new List<Product> {janeproduct1, janeproduct2, janeproduct3};
        Order janeOrder = new Order(jane, janeProducts);

        string janeTotal = janeOrder.CalculateTotalCost();

        Console.WriteLine($"\n{janeOrder.GetPackingLabel()}\n");
        Console.WriteLine($"{janeTotal}\n");
        Console.WriteLine($"{janeOrder.GetShippingLabel()}\n");
    }
}