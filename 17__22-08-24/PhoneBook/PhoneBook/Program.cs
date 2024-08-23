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
        public enum AddressTypes
        {
            Home, Office
        }
        public AddressTypes AddressType { get; set; }
        public string FullAddress { get; set; }
        public Country Country { get; set; }

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
            var emp = new Employees
            {
                Name = "Annett D'Souza",
                Email = "annett@gmail.com",
                Addresses = new Addresses[]
                {
                    new Addresses
                    {
                        AddressType = Addresses.AddressTypes.Home, 
                        FullAddress="xyz,abc", 
                        Country=new Country
                        {
                            Code="IN", CountryName="India" 
                        }
                    },
                    new Addresses
                    {
                        AddressType=Addresses.AddressTypes.Office, 
                        FullAddress="abc,xyz", 
                        Country=new Country
                        {
                            Code="IN", CountryName="India" 
                        }
                    },
                },
                Experience = new Experiences[]
                {
                    new Experiences {CompanyName="Infosys", Website="www.infy.in", Address="Colombia", ExperienceInYears=2 },
                    new Experiences {CompanyName="IBS", Website="ibs.in", Address="Australia", ExperienceInYears=4 },
                },
                PhoneNumbers = new long[2] { 9837474553, 2363218433 }
            };
            //#1 emp.Experiences=new Experiences[] {....
            //#2 emp.Experiences=new Experiences[1] 
                //emp.Experiences[0] = new Experiences
                //{.... }
            Console.WriteLine(emp);
        }
    }
}