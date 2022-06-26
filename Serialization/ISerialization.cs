using SerializerLab.Classes;
using System.Collections.Generic;

namespace SerializerLab.Serialization
{
    public interface ISerialization
    {
        void Serialize(List<Animal> listOfPets, string filename);   
        List<Animal> Deserialize(string filename);
    }
}