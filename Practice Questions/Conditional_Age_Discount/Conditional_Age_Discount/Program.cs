//Calculate discounted amount based on below criteria
//- Age less than 10 years apply 50 % discount
//- Age between 11 - 18 apply 55 %
//- Age between 19 - 60 no discount
//- Age above 61 - Apply 65 %
//Input - Date of birth and actual amount.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Age_Discount
{
    internal class Program
    {
        public static void ApplyDiscount(DateTime dob, double amount)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - dob.Year;

            if (age < 10)
            {
                double discount = 0.50;
                amount = amount - amount * discount;
            }
            else if((age<11)&&(age>18))
            {
                double discount = 0.55;
                amount = amount - amount * discount;
            }
            //else if((age>=19)&&(age<=60))
            //{
                
            //}
            else if(age>60)
            {
                double discount = 0.65;
                amount = amount - amount * discount;
            }
            Console.WriteLine(amount);
        }
        static void Main()
        {
            Console.Write("Enter dob:");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter amount:");
            double amount = int.Parse(Console.ReadLine());
            ApplyDiscount(dob,amount);
        }
    }
}
