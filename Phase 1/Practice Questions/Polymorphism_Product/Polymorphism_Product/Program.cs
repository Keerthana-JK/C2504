//Create a base class Product with a virtual method Display()
//define two derived classes:
//ElectronicProduct with properties {Name, Price, WarrantyPeriod} and
//GroceryProduct with properties {Name, Price, ExpiryDate}
//Implement the Display() method in both derived classes to output the details of the products
//create objects of both ElectronicProduct and GroceryProduct, and demonstrate displaying their details using the Display() method.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polymorphism_Product
{
    internal class Program
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public virtual void Display()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Price: {Price}");
            }
        }
        public class ElectronicProduct : Product
        {
            public ElectronicProduct(string name, double price, int warrantyPeriod)
            {
                Name = name;
                Price = price;
                WarrantyPeriod = warrantyPeriod;
            }

            public int WarrantyPeriod { get; set; }
            public override void Display()
            { 
                base.Display();
                Console.WriteLine($"Warranty Period: {WarrantyPeriod}");
            }
        }
        public class GroceryProduct : Product
        {
            public GroceryProduct()
            {
            }

            public DateTime ExpiryDate { get; set; }
            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Expiry Date: {ExpiryDate:dd-MM-yyyy}");
            }
        }

        static void Main(string[] args)
        {
            // #1 method of obj creation
            Product tv = new ElectronicProduct("Samsung TV",23000,20);
            tv.Display();

            // #2 method of obj creation
            GroceryProduct apple = new GroceryProduct
            {
                Name = "Apple",
                Price = 20.5,
                ExpiryDate = new DateTime(2024, 12, 31)
            };
            apple.Display();
        }
    }
}
