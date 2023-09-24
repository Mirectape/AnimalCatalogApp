﻿using System;

namespace AnimalModels
{
    public abstract class Animal
    {
        public string AnimalType { get; set; }
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
