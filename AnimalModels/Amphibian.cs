using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels
{
    public class Amphibian : Animal
    {
        public Amphibian(string name, string sex, string color)
        {
            this.AnimalType = "Amphibian";
            this.Name = name;
            this.Sex = sex;
            this.Color = color;
        }

        public override bool Equals(object obj)
        {
            return obj is Amphibian anotherAmphibian &&
                this.Name == anotherAmphibian.Name &&
                this.Sex == anotherAmphibian.Sex &&
                this.Color == anotherAmphibian.Color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Sex, Color);
        }

        public static bool operator ==(Amphibian amphibian_1, Amphibian amphibian_2)
        {
            if(amphibian_1 is null && amphibian_2 is null)
            {
                return true;
            }

            return !(amphibian_1 is null) && amphibian_1.Equals(amphibian_2);
        }

        public static bool operator !=(Amphibian amphibian_1, Amphibian amphibian_2)
        {
            return !(amphibian_1 == amphibian_2);
        }


        public bool Conflicts(Amphibian anotherAmphibian)
        {
            if(this != anotherAmphibian)
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
            return $"Amphibian: {this.Name} {this.Sex} {this.Color}";
        }
    }
}
