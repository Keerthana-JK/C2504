//Employees
//    - Name
//    - Email
//    - Addresses
//        - AddressType
//        - FullAddress
//        - Country
//            - Name
//            - Code
//    - Experiences
//        - CompanyName
//        - Website
//        - Address
//        - ExperienceInYears
//    - PhoneNumbers

//EmployeeManager class 
//  - AddEmployee()
//  - SearchEmployeeByEmail()
//  - SearchEmployeeByCompanyName()

using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Country
    {
        public string CountryName { get; set; }
        public string Code { get; set; }

        public override string ToString()
        {
            return $"{CountryName} - {Code}";
        }
    }

    class Addresses
    {
        public string AddressType { get; set; }
        public string FullAddress { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Address Type: {AddressType}, Full Address: {FullAddress}, Country: {Country}";
        }
    }

    class Experiences
    {
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public int ExperienceInYears { get; set; }

        public override string ToString()
        {
            return $"{CompanyName}, {Website}, {Address}, {ExperienceInYears} years";
        }
    }
    class Employees
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Addresses[] Addresses { get; set; }
        public Experiences[] Experience { get; set; }
        public long[] PhoneNumbers { get; set; }

        public override string ToString()
        {
            string phoneNumbers = string.Join(", ", PhoneNumbers);
            string addresses = "";
            foreach (var address in Addresses)
            {
                addresses += address.ToString() + "\n";
            }

            string experiences = "";
            foreach (var experience in Experience)
            {
                experiences += experience.ToString() + "\n";
            }

            return $"Name: {Name} \nEmail: {Email} \nAddresses: \n{addresses}\nExperiences: \n{experiences}\nPhone Numbers: {phoneNumbers}";
        }
    }

    class EmployeeManager
    {
        public void AddEmployee()
        {
            //to do
        }
        public void SearchEmployeeByEmail()
        {
            //to do
        }
        public void SearchEmployeeByCompanyName()
        {
            //to do
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var ann = new Employees
            {
                Name = "Annett D'Souza",
                Email = "annett@gmail.com",
                Addresses = new Addresses[]
                {
                    new Addresses {AddressType="Home", FullAddress="xyz,abc,Columbia", Country="Columbia"},
                    new Addresses {AddressType="Office", FullAddress="abc,xyz,Columbia", Country="Columbia"},
                },
                Experience = new Experiences[]
                {
                    new Experiences {CompanyName="Infosys", Website="www.infy.in", Address="Colombia", ExperienceInYears=2 },
                    new Experiences {CompanyName="IBS", Website="ibs.in", Address="Australia", ExperienceInYears=4 },
                },
                PhoneNumbers = new long[2] { 98374745553, 2363218433 }
            };

            Console.WriteLine(ann);
        }
    }
}
