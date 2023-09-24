using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels.SerializingSystem
{
    public interface IAnimalSerializer
    {
        void SaveAnimals(List<Animal> animals, string path);
        List<Animal> GetAnimals(string path);
    }
}
