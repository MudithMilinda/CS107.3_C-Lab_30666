using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03
{
    internal class Program
    {
        public class Product
        {
            // Private fields
            private int productId;
            private string productName;
            private double price;
            private int quantityInStock;

            // Constructor
            public Product(int productId, string productName, double price, int quantityInStock)
            {
                this.productId = productId;
                this.productName = productName;
                this.price = price;
                this.quantityInStock = quantityInStock;
            }

            // Method to add product
            public void AddProduct(int quantity)
            {
                quantityInStock += quantity;
                Console.WriteLine($"{quantity} {productName}(s) added");
            }

            // Method to buy product
            public void BuyProduct(int quantity)
            {
                if (quantityInStock <= quantity)
                {
                    Console.WriteLine($"Not enough {productName}(s) in stock");
                }
                else
                {
                    quantityInStock -= quantity;
                    Console.WriteLine($"{quantity} {productName}(s) bought");
                }
            }

            // Display product details
            public void DisplayProductDetails()
            {
                Console.WriteLine($"Product ID: {productId}");
                Console.WriteLine($"Product Name: {productName}");
                Console.WriteLine($"Price: ${price}");
                Console.WriteLine($"Quantity in Stock: {quantityInStock}");
            }
        }

        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Laptop", 800, 10);
            product1.DisplayProductDetails();

            Console.ReadLine();


            // product1.productId = 102;
            // When uncomment the above line the error message will be: 'Product1.productId' is inaccessible due to its protection level
            // It cannot be accessed or modified from outside the class when productId is a private field
        }
    }
}
