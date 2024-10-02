using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight
{
    internal class Program
    {
        class Flight
        {
            //auto-property (framework will provide)
            private int capacity { set; get; }
            public string number { set; get; }
            public Flight() 
            {
                capacity = 0;
                number = "";
            }
            public Flight(int capacity, string number)
            {
                this.capacity = capacity;
                this.number = number;
            }
            //public override string ToString()
            //{  return number; }
        }
        static void Main(string[] args)
        {
        }
    }
}
