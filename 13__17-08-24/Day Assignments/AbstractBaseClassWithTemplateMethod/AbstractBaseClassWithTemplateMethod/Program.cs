//3.Create an Abstract Base Class with a Template Method
//   - Task: Implement an abstract class `Report` with a method `GenerateReport()` that calls two methods `CreateHeader()` and `CreateBody()`.
//      Derive classes `AnnualReport` and `MonthlyReport` from `Report`.
//   - Requirements:
//     - `AnnualReport` should override `CreateHeader()` and `CreateBody()` to provide a header and body for an annual report.
//     - `MonthlyReport` should override `CreateHeader()` and `CreateBody()` to provide a header and body for a monthly report.
//   - Example:
//     Report annual = new AnnualReport();
//annual.GenerateReport(); // Output: Annual report header and body

//Report monthly = new MonthlyReport();
//monthly.GenerateReport(); // Output: Monthly report header and body

//using abstract and virtual methods to define a template for generating reports
//allows to define a template method (GenerateReport) that outlines the steps of an algorithm, while allowing subclasses to provide specific implementations for certain steps.
using System;
namespace AbstractBaseClassWithTemplateMethod
{
    internal class Program
    {
        public abstract class Report
        {
            public void GenerateReport()
            {
                CreateHeader();
                CreateBody();
                CreateFooter();
            }
            public abstract void CreateHeader();//must be implemented by derived classes
            public abstract void CreateBody();//must be implemented by derived classes
            public virtual void CreateFooter()//provides a default implementation that can be overridden by derived classes if needed
            {
                Console.WriteLine("Creating footer...");
            }
        }

        public class AnnualReport : Report
        {
            public override void CreateHeader()
            {
                Console.WriteLine("Creating annual report header...");
            }
            public override void CreateBody()
            {
                Console.WriteLine("Creating annual report body...");
            }
        }

        public class MonthlyReport : Report
        {
            public override void CreateHeader()
            {
                Console.WriteLine("Creating monthly report header...");
            }
            public override void CreateBody()
            {
                Console.WriteLine("Creating monthly report body...");
            }

        }
        static void Main(string[] args)
        {
            Report annual = new AnnualReport();
            annual.GenerateReport();
            // Output: Creating annual report header...
            //         Creating annual report body...
            //         Creating footer...

            Report monthly = new MonthlyReport();
            monthly.GenerateReport();
            // Output: Creating monthly report header...
            //         Creating monthly report body...
            //         Creating footer...

        }
    }
}
