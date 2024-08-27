//Inventory Check Challenge:

//You are tasked with developing a function for a warehouse management system that checks the stock levels of a product.
//The function should provide the following information:
//  The name of the product.
//  The current stock quantity available in the warehouse.
//  A boolean value indicating whether the stock quantity is below a predefined threshold.

//Your goal is to design and implement a function that returns this information in a way that allows other parts of the system to easily access and utilize these details.
//Consider how you might structure this function to ensure the information is both comprehensive and easy to work with.

using System;


namespace ArrayOfTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array of Tuples containing 3 elements
            var products = new[]
            {
                (ProductName: "Product A", StockQuantity: 100, Threshold: 50),
                (ProductName: "Product B", StockQuantity: 20, Threshold: 50),
                (ProductName: "Product C", StockQuantity: 150, Threshold: 50)
            };
            foreach (var product in products)
            {
                //For each product, tuple destructured into productName, stockQuantity, and threshold
                var (productName, stockQuantity, threshold) = product;
                var isLowStock = stockQuantity < threshold;
                Console.WriteLine($"Product Name: {productName}");
                Console.WriteLine($"Stock Quantity: {stockQuantity}");
                Console.WriteLine($"Is Low Stock: {isLowStock}");
                Console.WriteLine();
            }
        }
    }
}