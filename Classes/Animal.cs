using System;

namespace SerializerLab.Classes
{
    public abstract class Animal
    {
        public string Name {get; set;}
        public int Age;
        public string Weight;

        public void AnimalWeight()
        {
            Console.WriteLine($"{Name} is a {Weight}");
        }

        public void AnimalAge()
        {
            Console.WriteLine($"{Name} is a {Age} years old");        
        }

        public abstract void AnimalHabitat();
    }
}