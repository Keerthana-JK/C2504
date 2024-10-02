//1. Define the `Trainer` Class

using System;

namespace ProgramingFundamentalsProject.TrainerApp
{
    internal class Trainer
    {
        public int id;
        public string name;
        public string skill;
        public string place;

        public Trainer(int _id, string _name, string _skill, string _place)
        {
            id = _id;
            name = _name;
            skill = _skill;
            place = _place;
        }
        public Trainer() 
        { 
            id=0;   
            name="";
            skill = "";
            place = "";
        }

        public override string ToString()
        {
            return $"[id={id},name={name},skill={skill},place={place}]";
        }
    }
}
