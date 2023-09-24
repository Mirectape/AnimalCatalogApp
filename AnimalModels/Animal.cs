using System;

namespace AnimalModels
{
    public class Animal
    {
        public string AnimalType { get; set; }
        public string AnimalName { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Animal anotherAnimal &&
                this.AnimalType == anotherAnimal.AnimalType &&
                this.AnimalName == anotherAnimal.AnimalName &&
                this.Sex == anotherAnimal.Sex &&
                this.Color == anotherAnimal.Color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AnimalType, AnimalName, Sex, Color);
        }

        public static bool operator ==(Animal animal_1, Animal animal_2)
        {
            if (animal_1 is null && animal_2 is null)
            {
                return true;
            }

            return !(animal_1 is null) && animal_1.Equals(animal_2);
        }

        public static bool operator !=(Animal animal_1, Animal animal_2)
        {
            return !(animal_1 == animal_2);
        }


        public bool Conflicts(Animal anotherAnimal)
        {
            if (this != anotherAnimal)
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
            return $"Amphibian: {this.AnimalName} {this.Sex} {this.Color}";
        }
    }

    public enum Sex
    {
        Male,
        Female
    }
}
