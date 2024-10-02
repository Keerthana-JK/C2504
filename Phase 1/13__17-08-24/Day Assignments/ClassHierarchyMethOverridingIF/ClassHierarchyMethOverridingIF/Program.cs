//5.Implement a Class Hierarchy with Method Overriding and Interfaces
//   - Task: Create an interface `IIdentifiable` with a method `GetId()`. Create an abstract class `Document` that implements `IIdentifiable` and has a method `Print()`.
//          Derive classes `Invoice` and `Receipt` from `Document`.
//   - Requirements:
//     - `Invoice` should have properties `InvoiceNumber` and `Amount`. Implement the `GetId()` method to return the invoice number and `Print()` to print invoice details.
//     - `Receipt` should have properties `ReceiptNumber` and `TotalAmount`. Implement the `GetId()` method to return the receipt number and `Print()` to print receipt details.


using System;

namespace ClassHierarchyMethOverridingIF
{
    internal class Program
    {
        interface IIdentifiable
        {
            string GetId();
        }

        public abstract class Document : IIdentifiable
        {
            public abstract string GetId();
            public abstract void Print();
          
        }

        public class Invoice : Document
        {
            string InvoiceNumber;
            int Amount;

            public Invoice(string invoiceNumber, int amount)
            {
                InvoiceNumber = invoiceNumber;
                Amount = amount;
            }

            public override string GetId()
            {
                return InvoiceNumber;
            }
            public override void Print()
            {
                Console.WriteLine($"Invoice Number : {InvoiceNumber}, Amount : {Amount}");
            }
        }
        public class Receipt : Document
        {
            string ReceiptNumber;
            int TotalAmount;

            public Receipt(string receiptNumber, int totalAmount)
            {
                ReceiptNumber = receiptNumber;
                TotalAmount = totalAmount;
            }

            public override string GetId()
            {
                return ReceiptNumber;
            }
            public override void Print()
            {
                Console.WriteLine($"Receipt Number : {ReceiptNumber}, Total Amount : {TotalAmount}");
            }
        }
        static void Main(string[] args)
        {
            Document invoice = new Invoice("INV001", 1000);
            Console.WriteLine(invoice.GetId()); // Output: INV001
            invoice.Print(); // Output: Invoice details

            Document receipt = new Receipt("REC001", 200);
            Console.WriteLine(receipt.GetId()); // Output: REC001
            receipt.Print(); // Output: Receipt details
        }
    }
}
