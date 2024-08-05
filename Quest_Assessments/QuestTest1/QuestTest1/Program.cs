using System;

namespace TestRevision
{
    internal class Program
    {
        static int age, totalAge = 0, avgAge, count = 0, primeSum = 0, oddSum = 0, teenSum = 0, minAge = 120, maxAge, secondMaxAge;

        //Read patients age till we read <0 without array
        static int ReadAge()
        {
            int age = int.Parse(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("Entered age is less than 0!!!");
            }
            return age;
        }

        //prime ages sum
        static bool IsPrime(int age)
        {
            for (int i = 2; i <= age / 2; i++)
            {
                if (age % i == 0)
                    return false;
            }
            return true;
        }

        static void PrimeSum()
        {
            if (IsPrime(age))
            {
                primeSum += age;
            }
        }

        //age sum
        static void AgeSum()
        {
            totalAge += age;
            count++;
        }

        //teenager ages sum
        static bool IsTeen()
        {
            return (age >= 13 && age <= 19);

        }

        static void TeenSum()
        {
            if (IsTeen())
            {
                teenSum += age;
            }
        }
        //min age
        static void MinAge()
        {
            if (age < minAge)
            {
                minAge = age;
            }
            else
            {
                //age>min

            }
        }
        //odd ages sum
        static bool IsOdd()
        {
            return age % 2 != 0;
        }

        static void OddSum()
        {
            if (IsOdd())
            {
                oddSum = oddSum + age;
            }
        }

        //2nd max age
        static int SecMaxAge()
        {
            if ((age > maxAge) && (age > secondMaxAge))
            {
                if (maxAge > secondMaxAge)//age max secmax
                {
                    secondMaxAge = maxAge;
                    maxAge = age;
                }
                else//age secmax max
                {
                    maxAge = age;
                }
            }
            else if ((age < maxAge) && (age > secondMaxAge))//max age secmax
            {
                secondMaxAge = age;

            }
            else //max secmax age
            {
                if (maxAge < secondMaxAge)
                {
                    maxAge = secondMaxAge;
                }
            }
            return secondMaxAge;
        }
        //check min age is also prime age

        static bool IsMinAlsoPrime()
        {
            if (IsPrime(minAge))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter ages");
            while ((age = ReadAge()) >= 0)
            {
                AgeSum();
                avgAge = totalAge / count;
                PrimeSum();
                TeenSum();
                MinAge();
                OddSum();
                SecMaxAge();
            }
            Console.WriteLine($"Avg age: {avgAge}");
            Console.WriteLine($"Prime ages sum: {primeSum}");
            Console.WriteLine($"Teen ages sum: {teenSum}");
            Console.WriteLine($"Min age: {minAge}");
            Console.WriteLine($"Odd ages sum: {oddSum}");
            Console.WriteLine($"2nd max age: {secondMaxAge}");
            if (IsMinAlsoPrime())
            {
                Console.WriteLine("Min age is also Prime");
            }
            else
                Console.WriteLine("Min age is NOT Prime");
        }
    }
}
