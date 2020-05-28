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
using System.Windows.Shapes;
using FilmsWPFClass;
using FilmsWPFClass.Serialization;

namespace FilmsWPF
{
    /// <summary>
    /// Логика взаимодействия для StartUpWindow.xaml
    /// </summary>
    public partial class StartUpWindow : Window
    {
        public StartUpWindow()
        {
            InitializeComponent();
        }

        private void jsonButton_Click(object sender, RoutedEventArgs e)
        {
            String actorPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\JSON\\Actors.json";
            String employeePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\JSON\\Employees.json";
            String scenePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\JSON\\Scenes.json";
            String filmPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\JSON\\Films.json";

            JSONSerialization serialization = new JSONSerialization();
            DeserializeData(serialization, actorPath, employeePath, scenePath, filmPath);

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void xmlButton_Click(object sender, RoutedEventArgs e)
        {
            String actorPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\XML\\Actors.xml";
            String employeePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\XML\\Employees.xml";
            String scenePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\XML\\Scenes.xml";
            String filmPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\XML\\Films.xml";

            XMLSerialization serialization = new XMLSerialization();
            DeserializeData(serialization, actorPath, employeePath, scenePath, filmPath);

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void bdButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void ramButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void DeserializeData(ISerialize serialization, String actorPath, String employeePath, String scenePath, String filmPath)
        {
            Person.actors = serialization.RestoreData<Actor>(actorPath);
            Person.employees = serialization.RestoreData<Employee>(employeePath);
            Scene.scenes = serialization.RestoreData<Scene>(scenePath);
            Film.Films = serialization.RestoreData<Film>(filmPath);
        }

        private void binarButton_Click(object sender, RoutedEventArgs e)
        {
            String actorPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\BINARY\\Actors.dat";
            String employeePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\BINARY\\Employees.dat";
            String scenePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\BINARY\\Scenes.dat";
            String filmPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\BINARY\\Films.dat";

            BinarySerialization serialization = new BinarySerialization();
            DeserializeData(serialization, actorPath, employeePath, scenePath, filmPath);

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
