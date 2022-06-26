using System;

namespace SerializerLab.Classes
{
    public class Cow : Animal
    {
        public override void AnimalHabitat()
        {
            Console.WriteLine($"Cow lives in village field");
        }
    }
}