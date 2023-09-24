using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AnimalModels.SerializingSystem
{
    public class XmlAnimalSerializer : IAnimalSerializer
    {
        public void SaveAnimals(List<Animal> animals, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Animal>));
            Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fStream, animals);
            fStream.Close();
        }

        public List<Animal> GetAnimals(string path)
        {
            if (!File.Exists(path))
            {
                return new List<Animal>();
            }
            else
            {
                List<Animal> animals = new List<Animal>();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Animal>));
                Stream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                animals = xmlSerializer.Deserialize(fStream) as List<Animal>;
                fStream.Close();
                return animals;
            }

            
        }
    }
}
