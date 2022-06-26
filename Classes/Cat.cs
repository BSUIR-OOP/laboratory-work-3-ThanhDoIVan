using System;

namespace SerializerLab.Classes
{
    public class Cat : Animal
    {
        public override void AnimalHabitat()
        {
            Console.WriteLine($"Cat lives in neighbourhood");
        }
    }
}