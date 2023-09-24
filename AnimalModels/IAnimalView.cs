using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels
{
    public interface IAnimalView
    {
        public string AnimalType { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }
    }
}
