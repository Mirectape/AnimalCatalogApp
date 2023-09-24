using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnimalModels;
using AnimalModels.SerializingSystem;

namespace AnimalListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IAnimalView
    {
        private AnimalPresenter _animalPresenter;
        private List<Animal> _animals;
        private string _pathToSave;
        private string _pathToLoadFrom;

        public string AnimalType 
        {
            get => txtAnimalType.Text; 
            set => txtAnimalType.Text = value; 
        }

        public string AnimalName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }

        public string Sex
        {
            get => txtSex.Text;
            set => txtSex.Text = value;
        }

        public string Color
        {
            get => txtColor.Text;
            set => txtColor.Text = value;
        }

        public MainWindow()
        {
            InitializeComponent();

            _animals = new List<Animal>();
            _animalPresenter = new AnimalPresenter(this, _animals, new JsonAnimalSerializer());
            _pathToSave = "C:/Users/user/source/repos/AnimalCatalogApp/Animals.json";
            _pathToLoadFrom = "C:/Users/user/source/repos/AnimalCatalogApp/Animals.json";

            btnNContact.Click += (s, e) => _animalPresenter.NextAnimal();
            btnPContact.Click += (s, e) => _animalPresenter.PreviousAnimal();
            btnRContact.Click += (s, e) => _animalPresenter.RemoveAnimal();
            btnAContact.Click += (s, e) => _animalPresenter.AddAnimal(AnimalType);

            this.Closing += (s, e) => _animalPresenter.SaveAnimals(_pathToSave);
            this.Loaded += (s, e) => _animalPresenter.LoadAnimals(_pathToLoadFrom);
        }       
    }
}
