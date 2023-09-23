using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels.SavingSystem
{
    public class AnimalWriter
    {
        private List<Animal> _animals;
        public IAnimalSaver SavingMode { get; set; }

        public AnimalWriter(List<Animal> animalsToSave, IAnimalSaver savingMode)
        {
            _animals = animalsToSave;
            SavingMode = savingMode;
        }

        public void SaveAnimals()
        {
            SavingMode.SaveAnimals(_animals);
        }
    }
}
