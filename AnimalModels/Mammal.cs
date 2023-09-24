using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels
{
    public class Mammal : Animal
    {
        public Mammal(string name, string sex, string color)
        {
            this.AnimalType = "Mammal";
            this.Name = name;
            this.Sex = sex;
            this.Color = color;
        }

        public override bool Equals(object obj)
        {
            return obj is Mammal anotherMammal &&
                this.Name == anotherMammal.Name &&
                this.Sex == anotherMammal.Sex &&
                this.Color == anotherMammal.Color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Sex, Color);
        }

        public static bool operator ==(Mammal mammal_1, Mammal mammal_2)
        {
            if (mammal_1 is null && mammal_2 is null)
            {
                return true;
            }

            return !(mammal_1 is null) && mammal_1.Equals(mammal_2);
        }

        public static bool operator !=(Mammal mammal_1, Mammal mammal_2)
        {
            return !(mammal_1 == mammal_2);
        }


        public bool Conflicts(Mammal anotherMammal)
        {
            if (this != anotherMammal)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return $"Mammal: {this.Name} {this.Sex} {this.Color}";
        }
    }
}
