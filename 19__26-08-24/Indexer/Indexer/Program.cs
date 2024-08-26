using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class EmployeeSalaries
    {
        private double[] salaries;
        public EmployeeSalaries(int size)
        {
            salaries = new double[size];//mem resource reservation
        }

        public double this[int index]
        {
            get
            {
                return salaries[index];
            }
            set
            {
                salaries[index] = value;
            }
        }
    }

    public class EmployeeSalaries2D
    {
        private double[,] salaries;
        public EmployeeSalaries2D(int rows, int cols)
        {
            salaries = new double[rows, cols];//mem resource reservation
        }

        public double this[int rowIndex, int colIndex]
        {
            get
            {
                return salaries[rowIndex, colIndex];
            }
            set
            {
                salaries[rowIndex, colIndex] = value;
            }
        }
    }

    //4 salaries
    public class EmployeeSalariesNoArray
    {
        private double firstSalary;
        private double secondSalary;
        private double thirdSalary;
        private double fourthSalary;

        public double this[int Index]
        {
            get
            {
                double sal = 0.0;
                switch(Index)
                {
                    case 1:
                        sal = firstSalary; 
                        break;
                    case 2:
                        sal = secondSalary;
                        break;
                    case 3:
                        sal = thirdSalary;
                        break;
                    case 4:
                        sal = fourthSalary;
                        break;
                }
                return sal;
            }
            set
            {
                switch (Index)
                {
                    case 1:
                        firstSalary = value; break;
                    case 2:
                        secondSalary = value; break;
                    case 3:
                        thirdSalary = value; break;
                    case 4:
                        fourthSalary = value; break;
                }
            }
        }
    }
    internal class Programs
    {
        static void Main()
        {
            Console.WriteLine("***Salary array***");
            Console.Write("Number of Salaries:");
            int N = int.Parse(Console.ReadLine());
            EmployeeSalaries employeeSalaries = new EmployeeSalaries(N);
            Console.WriteLine($"Enter {N} salaries one by one.");
            for (int I = 0; I < N; I++)
            {
                Console.Write($"Salary {I + 1}:");
                employeeSalaries[I] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Salaries:");
            for (int I = 0; I < N; I++)
            {
                Console.Write($"{employeeSalaries[I]} ");
            }
            Console.WriteLine();

            //salary matrix
            Console.WriteLine("***Salary matrix***");
            Console.Write("Number of rows of Salary:");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Number of rows of Salary:");
            int cols = int.Parse(Console.ReadLine());
            EmployeeSalaries2D employeeSalaries2D = new EmployeeSalaries2D(rows, cols);
            Console.WriteLine($"Enter {rows}x{cols} salaries row by row");
            for (int I = 0; I < N; I++)
            {
                for (int J = 0; J < N; J++)
                {
                    Console.Write($"Salary at {I},{J}: ");
                    employeeSalaries2D[I, J] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"Salaries:");
            for (int I = 0; I < N; I++)
            {
                for (int J = 0; J < N; J++)
                {
                    Console.Write($"{employeeSalaries2D[I, J]} ");
                }
            }
            Console.WriteLine();

            //4 salaries
            EmployeeSalariesNoArray employeeSal = new EmployeeSalariesNoArray();
            Console.WriteLine($"Enter 4 salaries one by one.");
            for (int I = 0; I < 4; I++)
            {
                Console.Write($"Salary at {I}:");
                employeeSal[I] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Salary Matrix:");
            for (int I = 0; I < 4; I++)
            {
                Console.Write($"{employeeSal[I]} ");
            }
            Console.WriteLine();
        }
    }
}
