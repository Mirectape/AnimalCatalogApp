using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels
{
    public class Bird : Animal
    {
        public Bird(string name, string sex, string color)
        {
            this.AnimalType = "Bird";
            this.AnimalName = name;
            this.Sex = sex;
            this.Color = color;
        }

        public override bool Equals(object obj)
        {
            return obj is Bird anotherBird &&
                this.AnimalName == anotherBird.AnimalName &&
                this.Sex == anotherBird.Sex &&
                this.Color == anotherBird.Color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AnimalType, AnimalName, Sex, Color);
        }

        public static bool operator ==(Bird bird_1, Bird bird_2)
        {
            if (bird_1 is null && bird_2 is null)
            {
                return true;
            }

            return !(bird_1 is null) && bird_1.Equals(bird_2);
        }

        public static bool operator !=(Bird bird_1, Bird bird_2)
        {
            return !(bird_1 == bird_2);
        }


        public bool Conflicts(Bird anotherBird)
        {
            if (this != anotherBird)
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
            return $"Bird: {this.AnimalName} {this.Sex} {this.Color}";
        }
    }
}
