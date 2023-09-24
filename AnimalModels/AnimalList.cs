using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels
{
    public class AnimalList : IEnumerable
    {
        private List<Animal> _animals;
        public List<Animal> Animals
        {
            private get
            {
                return _animals;
            }
            set
            {
                _animals = value;
            }
        }

        public int Count => _animals.Count;

        public AnimalList(List<Animal> animals)
        {
            _animals = animals;
        }

        public IEnumerator GetEnumerator()
        {
            foreach(var animal in _animals)
            {
                yield return animal;
            }
        }

        public Animal this[int position]
        {
            get => !IsNull() ? _animals[position] : null;
        }

        private bool IsNull()
        {
            bool check = true;

            if(_animals != null)
            {
                if(_animals.Count > 0)
                {
                    check = false;
                }
            }
            return check;
        }

        public bool AddAnimal(Animal newAnimal)
        {
            bool check = false;
            if (!_animals.Contains(newAnimal))
            {
                _animals.Add(newAnimal);
                check = true;
            }
            return check;
        }

        public bool DeleteAnimal(Animal newAnimal)
        {

            bool check = false;
            if (_animals.IndexOf(newAnimal) != -1)
            {
                _animals.Remove(newAnimal);
                check = true;
            }
            return check;
        }
    }
}
