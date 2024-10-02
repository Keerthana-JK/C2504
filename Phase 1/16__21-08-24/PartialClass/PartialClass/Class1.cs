﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal partial class Person
    {
        public string FirstName;
        public string LastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string DisplayFullName()
        {
            return $"Full name : {FirstName.ToString()} {LastName.ToString() }";
        }
    }
}
