using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels
{
    public class NullAnimal : Animal
    {
        public NullAnimal(string name, string sex, string color)
        {
            this.AnimalType = "Not Determined";
            this.AnimalName = "Not Determined";
            this.Sex = "Not Determined";
            this.Color = "Not Determined";
        }
        public override string ToString()
        {
            return $"Not Determined";
        }
    }
}
