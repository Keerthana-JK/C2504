//8.Create a Class Hierarchy with Interfaces and Method Implementation
//   - Task: Create an interface `IExportable` with a method `Export()`. Create a base class `Document` that implements `IExportable` and has a method `Save()`.
//          Derive classes `PDFDocument` and `WordDocument` from `Document`.
//   - Requirements:
//     - `PDFDocument` should implement `Export()` to export as PDF and `Save()` to save the document.
//     - `WordDocument` should implement `Export()` to export as Word format and `Save()` to save the document.


using System;

namespace ClassHierarchyIFAndMethImplementation
{
    internal class Program
    {
        interface IExportable
        {
            void Export();
        }
        public abstract class Document : IExportable
        {
            public abstract void Save();
            public abstract void Export();  
        }
        public class PDFDocument : Document
        {
            public override void Export()
            {
                Console.WriteLine("Export as PDF");
            }
            public override void Save()
            {
                Console.WriteLine("PDF saved");
            }
        }

        public class WordDocument : Document 
        {
            public override void Export()
            {
                Console.WriteLine("Export as Word");
            }
            public override void Save()
            {
                Console.WriteLine("Word document saved");
            }
        }
        static void Main(string[] args)
        {
            Document pdfDoc = new PDFDocument();
            pdfDoc.Export();
            pdfDoc.Save();

            Document wordDoc = new WordDocument();
            wordDoc.Export();
            wordDoc.Save();
        }
    }
}
