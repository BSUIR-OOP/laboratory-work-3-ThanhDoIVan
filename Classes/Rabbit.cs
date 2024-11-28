using System;

namespace SerializerLab.Classes
{
    public class Rabbit : Animal
    {
        public override void AnimalHabitat()
        {
            Console.WriteLine($"Rabbit lives in forest");
        }
    }
}