using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal partial class Person
    {
        public int age;

        public Person(int age)
        {
            this.age = age;
        }

        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            this.age = age;
        }

        public string DisplayAge()
        {
            return $"Age : {age}";
        }
    }
}
