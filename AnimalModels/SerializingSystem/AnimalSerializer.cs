using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels.SerializingSystem
{
    public class AnimalSerializer
    {
        private List<Animal> _animals;
        public IAnimalSerializer SerializerMode { get; set; }

        public AnimalSerializer(List<Animal> animals, IAnimalSerializer serializerMode)
        {
            _animals = animals;
            SerializerMode = serializerMode;
        }

        public void SaveAnimals(string path)
        {
            SerializerMode.SaveAnimals(_animals, path);
        }

        public List<Animal> GetAnimals(string path)
        {
            return SerializerMode.GetAnimals(path);
        }
    }
}
