using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalModels.SerializingSystem;

namespace AnimalModels
{
    public class AnimalPresenter
    {
        private AnimalListModel _model;
        private IAnimalView _view;

        public AnimalPresenter(IAnimalView animalView, List<Animal> animals)
        {
            _view = animalView;
            _model = new AnimalListModel(animals);
        }

        public AnimalPresenter(IAnimalView animalView, List<Animal> animals, IAnimalSerializer serializerMode)
        {
            _view = animalView;
            _model = new AnimalListModel(animals, serializerMode);
        }

        public void LoadAnimals(string path)
        {
            _model.LoadAnimals(path);

            if (_model.AnimalList.Count > 0)
            {
                _model.Index = 0;
                var temp = _model.CurrentAnimal;

                _view.AnimalType = temp.AnimalType;
                _view.AnimalName = temp.AnimalName;
                _view.Sex = temp.Sex;
                _view.Color = temp.Color;
            }
        }

        public void SaveAnimals(string path)
        {
            _model.SaveAnimals(path);
        }

        public void AddAnimal(string animalType)
        {
            _model.AnimalList.AddAnimal(AnimalFactory.GetAnimal(_view.AnimalType, _view.AnimalName, _view.Sex, _view.Color));
        }

        public void RemoveAnimal()
        {
            var animalToRemove = AnimalFactory.GetAnimal(_view.AnimalType, _view.AnimalName, _view.Sex, _view.Color);
            _model.AnimalList.DeleteAnimal(animalToRemove);

            if (_model.AnimalList.Count < 1)
            {
                _model.Index = -1;

                _view.AnimalType = string.Empty;
                _view.AnimalName = string.Empty;
                _view.Sex = string.Empty;
                _view.Color = string.Empty;
            }
            else
            {
                _model.Index--;
                if (_model.Index < 0)
                {
                    _model.Index = 0;
                }

                _view.AnimalType = _model.CurrentAnimal.AnimalType;
                _view.AnimalName = _model.CurrentAnimal.AnimalName;
                _view.Sex = _model.CurrentAnimal.Sex;
                _view.Color = _model.CurrentAnimal.Color;
            }
        }

        public void NextAnimal()
        {
            if (_model.AnimalList.Count > 0)
            {
                if (_model.Index + 1 < _model.AnimalList.Count)
                {
                    _model.Index++;
                    _view.AnimalType = _model.CurrentAnimal.AnimalType;
                    _view.AnimalName = _model.CurrentAnimal.AnimalName;
                    _view.Sex = _model.CurrentAnimal.Sex;
                    _view.Color = _model.CurrentAnimal.Color;
                }
            }
        }

        public void PreviousAnimal()
        {
            if (_model.AnimalList.Count > 0)
            {
                if (_model.Index - 1 > -1)
                {
                    _model.Index--;
                    _view.AnimalType = _model.CurrentAnimal.AnimalType;
                    _view.AnimalName = _model.CurrentAnimal.AnimalName;
                    _view.Sex = _model.CurrentAnimal.Sex;
                    _view.Color = _model.CurrentAnimal.Color;
                }
            }
        }
    }
}
