using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels.SavingSystem
{
    public class TxtKeeper : IAnimalSaver
    {
        private string _nameOfFile;
        public TxtKeeper(string NameOfFile)
        {
            this._nameOfFile = NameOfFile;
        }

        private List<Animal> CreateDocx(List<Animal> animals)
        {
            return animals;
        }

        public void SaveAnimals(List<Animal> animals)
        {
            using (StreamWriter sw = new StreamWriter($"{_nameOfFile}.txt"))
            {
                sw.WriteLine(CreateDocx(animals));
            }
        }
    }
}
