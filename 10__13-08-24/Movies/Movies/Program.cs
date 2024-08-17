using System;

namespace Movies
{
    class Movie
    {
        public int id;
        public string name;
        //parameterized ctor
        public Movie(int _id, string _name)
        {
            id = _id;
            name = _name;
        }
        //non-parameterized ctor
        public Movie()
        {
            id = 0;
            name = "";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie manjummelBoys = new Movie(1001, "Manjummel Boys");
            Movie aavesham = new Movie();
            aavesham.id = 1002;
            aavesham.name = "Aavesham";

            Console.WriteLine($"id={manjummelBoys.id}, name={manjummelBoys.name}");
            Console.WriteLine($"id={aavesham.id}, name={aavesham.name}");
        }
    }
}

//Output:
//id = 1001, name = Manjummel Boys
//id = 1002, name = Aavesham