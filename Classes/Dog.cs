using System;

namespace SerializerLab.Classes
{
    public class Dog : Animal
    {
        public override void AnimalHabitat()
        {
            Console.WriteLine($"Dog lives in the doghouse");
        }
    }
}