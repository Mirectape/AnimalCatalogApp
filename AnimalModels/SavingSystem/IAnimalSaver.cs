using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels.SavingSystem
{
    public interface IAnimalSaver
    {
        void SaveAnimals(List<Animal> animals);
    }
}
