using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSalaryWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read and find Count of doctors having a min of 6 digit salary

            Console.WriteLine("--------------------ReadAndCountDoctorsMin6DigitsSalaries--------------------");
            ReadAndCountDoctorsMin6DigitsSalaries();
            Console.WriteLine("--------------------End of ReadAndCountDoctorsMin6DigitsSalaries--------------------");

            //Read and find Min salary of N doctors
            Console.WriteLine("--------------------ReadAndFindMinSalaryOfNDoctors--------------------");
            ReadAndFindMinSalaryOfNDoctors();
            Console.WriteLine("--------------------End of ReadAndFindMinSalaryOfNDoctors--------------------");

            //Read and find Sum of doctor's salaries till zero is entered by user
            Console.WriteLine("--------------------ReadAndFindSumOfDoctorsSalariesTillZero--------------------");
            ReadAndFindSumOfDoctorsSalariesTillZero();
            Console.WriteLine("--------------------End of ReadAndFindSumOfDoctorsSalariesTillZero--------------------");
        }

        static bool IsDoctorSalaryMin6Digits(int doctorSalary)
        {
            int salary = doctorSalary;

            int count = 0;
            while (salary > 0)
            {
                int digit = salary % 10;
                count += 1;
                salary = salary / 10;
            }

            return count >= 6;
        }

        //Count of Doctors with Min 6Digits Salaries (without array or N salaries)

        static bool ReadAndCountDoctorsMin6DigitsSalaries()
        {
            int count = 0;
            int n; //number of salaries 
            Console.WriteLine("Enter no. of doctors");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the {n} salaries");
            for (int i = 0; i < n; i++)
            {
                int salary = int.Parse(Console.ReadLine());
                bool isMin6Digits = IsDoctorSalaryMin6Digits(salary);
                if (isMin6Digits)
                {
                    count += 1;
                }

            }
            Console.WriteLine($"Count:{count}");
            return count >= 6;
        }


        //Read and Find Min Salary of N Doctors

        static void ReadAndFindMinSalaryOfNDoctors()
        {
            int MinSalary = -1;
            int n; //number of salaries 
            Console.WriteLine("Enter no. of doctors");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the {n} salaries");
            for (int i = 0; i < n; i++)
            {
                int salary = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    MinSalary = salary;
                    continue;
                }
                if (salary < MinSalary)
                {
                    MinSalary = salary;
                }
            }
            Console.WriteLine($"Min salary is {MinSalary}");
        }

        //Sum of Doctors Salaries till 0 is entered (use do-while loop)

        static void ReadAndFindSumOfDoctorsSalariesTillZero()
        {
            int sum = 0;
            Console.WriteLine("Enter salaries of doctor");
            int salary = int.Parse(Console.ReadLine());
            while (salary != 0)
            {
                if (salary < 0) //Invalid salary
                {
                    Console.WriteLine("Input valid salary");
                    salary = int.Parse(Console.ReadLine());
                }

                sum += salary;
                salary = int.Parse(Console.ReadLine()); ;
            }
            Console.WriteLine(sum);
        }

    }
}

    
