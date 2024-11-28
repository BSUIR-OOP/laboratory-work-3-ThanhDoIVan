using System;

namespace SerializerLab.Classes
{
    public class Fish : Animal
    {
        public override void AnimalHabitat()
        {
            Console.WriteLine($"Fish lives under water");
        }
    }
}
