using System;

namespace AnimalModels
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }
    }

    public enum Sex
    {
        Male,
        Female
    }
}
