using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalModels.SerializingSystem;

namespace AnimalModels
{
    public class AnimalListHandler
    {
        private AnimalList _animalList;
        public AnimalList AnimalList => this._animalList;

        private int _index;
        public int Index
        {
            get => this._index;
            set => this._index = value;
        }

        public Animal CurrentAnimal
        {
            get
            {
                if(Index >= 0)
                {
                    return _animalList[_index];
                }
                else
                {
                    return null;
                }
            }
        }

        private AnimalSerializer _animalSerializer;
        public IAnimalSerializer SerializerMode { private get; set; }

        public AnimalListHandler(List<Animal> animals)
        {
            _animalList = new AnimalList(animals);
            _index = 0;
            SerializerMode = new JsonAnimalSerializer();
            _animalSerializer = new AnimalSerializer(animals, SerializerMode);
        }

        public AnimalListHandler(List<Animal> animals, IAnimalSerializer serializerMode)
        {
            _animalList = new AnimalList(animals);
            _index = 0;
            SerializerMode = serializerMode;
            _animalSerializer = new AnimalSerializer(animals, SerializerMode);
        }

        public void SaveAnimals(string path)
        {
            _animalSerializer.SaveAnimals(path);
        }

        public void LoadAnimals(string path)
        {
            _animalList.Animals = _animalSerializer.GetAnimals(path);
        }
    }
}
