using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels.SavingSystem
{
    public class AnimalWriter
    {
        public List<Animal> Animals { get; set; }
        public IAnimalSaver SavingMode { get; set; }

        public AnimalWriter(List<Animal> animalsToSave, IAnimalSaver savingMode)
        {
            Animals = animalsToSave;
            SavingMode = savingMode;
        }

        public void SaveAnimals()
        {
            SavingMode.SaveAnimals(Animals);
        }
    }
}
