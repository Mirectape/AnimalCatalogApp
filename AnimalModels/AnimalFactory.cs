using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels
{
    public static class AnimalFactory
    {
        public static Animal GetAnimal(string animalType,
                                        string name,
                                        string sex,
                                        string color)
        {
            switch(animalType)
            {
                case "Amphibian": return new Amphibian(name, sex, color);
                case "Bird": return new Bird(name, sex, color);
                case "Mammal": return new Mammal(name, sex, color);
                default: return new NullAnimal(name, sex, color);
            }
        }
    }
}
