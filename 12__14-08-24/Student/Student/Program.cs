using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhyMarks { get; set; }
        public int ChemMarks { get; set; }
        public int BioMarks { get; set; }
        public Student(int Id, string Name, int PhyMarks, int ChemMarks, int BioMarks) 
        { 
            this.Id = Id;
            this.Name = Name;
            this.PhyMarks = PhyMarks;
            this.ChemMarks = ChemMarks;
            this.BioMarks = BioMarks;
        }
        public int TotalMarks()
        {
            return PhyMarks + ChemMarks + BioMarks;
        }
        public double AvgMarks()
        {
            return PhyMarks + ChemMarks + BioMarks / 3;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1,"Anu", 86,95,42);
            Student s2 = new Student(2, "Ivin", 74,66,99);
            Console.WriteLine($"Student {s1.Id} details : ID:{ s1.Id}, Name:{ s1.Name}, PhyMarks:{ s1.PhyMarks}, ChemMarks: {s1.ChemMarks}, BioMarks: {s1.BioMarks}, TotalMarks: {s1.TotalMarks()}, AvgMarks: {s1.AvgMarks()}" );
            Console.WriteLine($"Student {s2.Id} details : ID:{s2.Id}, Name:{s2.Name}, PhyMarks:{s2.PhyMarks}, ChemMarks {s2.ChemMarks}, BioMarks: {s2.BioMarks}, TotalMarks: {s1.TotalMarks()}, AvgMarks: {s2.AvgMarks()}");
        }
    }
}
