using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 1100.00);
            Product product2 = new Product("Keyboard", 30.00);
            Product product3 = new Product("Motherboard", 100.00);

            Console.WriteLine($"Product Name: {product1.ProductName}" + $"Price: {product1.Price}");
            Console.WriteLine($"Product Name: {product2.ProductName}" + $"Price: {product2.Price}");
            Console.WriteLine($"Product Name: {product3.ProductName}" + $"Price: {product3.Price}");

            Console.ReadLine();
        }
    }
}
