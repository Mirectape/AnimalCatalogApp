using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModels.SerializingSystem
{
    public class JsonAnimalSerializer : IAnimalSerializer
    {
        public void SaveAnimals(List<Animal> animals, string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileStream stream = File.Create(path);
            stream.Close();
            File.WriteAllText(path, JsonConvert.SerializeObject(animals));
        }

        public List<Animal> GetAnimals(string path)
        {
            if (!File.Exists(path))
            {
                return new List<Animal>();
            }
            else
            {
                var animals = JsonConvert.DeserializeObject<List<Animal>>(File.ReadAllText(path));
                return animals;
            }
        }
    }
}
