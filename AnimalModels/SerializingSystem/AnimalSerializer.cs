using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels.SerializingSystem
{
    public class AnimalSerializer
    {
        public IAnimalSerializer SerializerMode { get; set; }

        public AnimalSerializer( IAnimalSerializer serializerMode)
        {
            SerializerMode = serializerMode;
        }

        public void SaveAnimals(List<Animal> animals, string path)
        {
            SerializerMode.SaveAnimals(animals, path);
        }

        public List<Animal> GetAnimals(string path)
        {
            return SerializerMode.GetAnimals(path);
        }
    }
}
