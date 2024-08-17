using System;
using static Class1;

public class Class1
{
	public Class1()
	{

        internal class Trainerv2
    {
        private int id;
        private string name;
        private string skill;
        private string place;
        private int salary;

        //parameterized ctor
        public Trainerv2(int id, string name, string skill, string place, int salary)
        {
            this.id = id;
            this.name = name;
            this.skill = skill;
            this.place = place;
            this.salary = salary;
        }
        //no argument ctor
        public Trainerv2()
        {
            this.id = 0;
            this.name = "";
            this.skill = "";
            this.place = "";
            this.salary = 0;
        }


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Skill { get => skill; set => skill = value; }
        public string Place { get => place; set => place = value; }
        public int Salary { get => salary; set => salary = value; }
    }

    internal class TestTrainerV2
    {
        static void MainTrainerV2(string[] args)
        {
            TrainerV2 mahesh = new TrainerV2(10, "Mahesh", "C#", "Mysore", 9000);

            Console.WriteLine($"Mahesh : {mahesh.id}, {mahesh.name}, {mahesh.skill}, {mahesh.place}, {mahesh.salary}");
            TrainerV2 mishel = new TrainerV2();
        }
    }
}
