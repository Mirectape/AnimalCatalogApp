﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels.SavingSystem
{
    public class XlsxKeeper : IAnimalSaver
    {
        private string _nameOfFile;
        public XlsxKeeper(string NameOfFile)
        {
            this._nameOfFile = NameOfFile;
        }

        private List<Animal> CreateDocx(List<Animal> animals)
        {
            return animals;
        }

        public void SaveAnimals(List<Animal> animals)
        {
            using (StreamWriter sw = new StreamWriter($"{_nameOfFile}.xlsx"))
            {
                sw.WriteLine(CreateDocx(animals));
            }
        }
    }
}