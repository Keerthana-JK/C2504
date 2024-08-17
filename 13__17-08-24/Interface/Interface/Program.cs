using System;
using System.Data.SqlClient;

namespace Interface
{
    public abstract class Flyable
    {
        public abstract void Fly();
    }
    public class Crow : Flyable
    {
        public override void Fly()
        {
            Console.WriteLine("Crow is flying");
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Flyable f = new Flyable();// instance of abstract/interface cant be created
            Crow c = new Crow();
            c.Fly();
        }
    }
}
