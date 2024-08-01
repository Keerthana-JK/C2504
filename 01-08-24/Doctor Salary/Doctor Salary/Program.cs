using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSalary
{
    internal class Program
    {
        static void Main()
        {
            //Does doctor have min 6 digit salary
            Console.WriteLine("--------------------TestIsDoctorSalaryMin6Digits--------------------");
            TestIsDoctorSalaryMin6Digits();
            Console.WriteLine("--------------------End of TestIsDoctorSalaryMin6Digits--------------------");

            //Does doctor have min 6 digit salary or not
            Console.WriteLine("--------------------TestIsDoctorSalaryMin6DigitsOrNot--------------------");
            TestIsDoctorSalaryMin6DigitsOrNot();
            Console.WriteLine("--------------------End of TestIsDoctorSalaryMin6Digits--------------------");

            //Count of Doctors having min 6 digit salary
            Console.WriteLine("--------------------TestCountMin6DigitsSalariedDoctors--------------------");
            TestCountMin6DigitsSalariedDoctors();
            Console.WriteLine("--------------------End of TestCountMin6DigitsSalariedDoctors--------------------");

            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();

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
        //test if doctor's salary is min 6 digits
        static void TestIsDoctorSalaryMin6Digits()
        {
            Console.WriteLine("Enter doctor salary:");
            int doctorSalary = int.Parse(Console.ReadLine());
            if (IsDoctorSalaryMin6Digits(doctorSalary))
            {
                Console.WriteLine("Doctor gets Min 6 digits salary");
            }
        }

        //test if doctor's salary is min 6 digits or not
        static void TestIsDoctorSalaryMin6DigitsOrNot()
        {
            Console.WriteLine("Enter doctor salary:");
            int doctorSalary = int.Parse(Console.ReadLine());
            if (IsDoctorSalaryMin6Digits(doctorSalary))
            {
                Console.WriteLine("Doctor gets Min 6 digits salary");
            }
            else
            {
                Console.WriteLine("Doctor does not get Min 6 digits salary");
            }
        }

        //Count of Doctors having min 6 digit salary

        static int CountMin6DigitsSalariedDoctors(int[] salaries, int size)
        {
            int count = 0;
            for (int I = 0; I <= size - 1; I++)
            {
                if (IsDoctorSalaryMin6Digits(salaries[I]))
                {
                    count += 1;
                }
            }
            return count;
        }
        static void TestCountMin6DigitsSalariedDoctors()
        {
            Console.Write("Number of Doctors:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter one by one doctors salaries.");
            int[] salaries = new int[size]; //new int[size] allocates the int memblocks of size "size" [Minnu|Sarika]
            for (int I = 0; I <= size - 1; I++)
            {
                Console.Write($"Salary of {I + 1}th Doctor:");
                salaries[I] = int.Parse(Console.ReadLine());
            }
            int sixDigitsSalariedCount = CountMin6DigitsSalariedDoctors(salaries, size);
            Console.WriteLine($"Number of Min 6 Digits Salaried Doctors : {sixDigitsSalariedCount}");
        }
    }

}
