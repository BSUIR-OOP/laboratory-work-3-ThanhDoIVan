using SerializerLab.Classes;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.IO;


namespace SerializerLab.Serialization
{
    public class JSONSerialization : ISerialization
    {
        public void Serialize(List<Animal> listOfAnimals, string filename)
        {
            string json = JsonSerializer.Serialize(listOfAnimals);

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<Animal>(fs, listOfAnimals);
            }
        }

        public List<Animal> Deserialize(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                List<Animal> list = JsonSerializer.Deserialize<Animal>(fs);
                return list;
            }
        }

    }
}
