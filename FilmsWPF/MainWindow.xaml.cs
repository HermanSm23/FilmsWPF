using System;
using System.Windows;
using FilmsWPFClass;
using FilmsWPFClass.Serialization;

namespace FilmsWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteWindow deleteWindow = new DeleteWindow();
            deleteWindow.Show();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow();
            editWindow.Show();
        }

        private void viewButton_Click(object sender, RoutedEventArgs e)
        {
            ViewWindow viewWindow = new ViewWindow();
            viewWindow.Show();
        }

        private void jsonButton_Click(object sender, RoutedEventArgs e)
        {
            String actorPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\JSON\\Actors.json";
            String employeePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\JSON\\Employees.json";
            String scenePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\JSON\\Scenes.json";
            String filmPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\JSON\\Films.json";

            JSONSerialization serialization = new JSONSerialization();
            SerializeData(serialization, actorPath, employeePath, scenePath, filmPath);
        }

        private void xmlButton_Click(object sender, RoutedEventArgs e)
        {
            String actorPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\XML\\Actors.xml";
            String employeePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\XML\\Employees.xml";
            String scenePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\XML\\Scenes.xml";
            String filmPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\XML\\Films.xml";

            XMLSerialization serialization = new XMLSerialization();
            SerializeData(serialization, actorPath, employeePath, scenePath, filmPath);
        }

        private void binarButton_Click(object sender, RoutedEventArgs e)
        {
            String actorPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\BINARY\\Actors.dat";
            String employeePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\BINARY\\Employees.dat";
            String scenePath = Environment.CurrentDirectory.ToString() + "\\Serialization\\BINARY\\Scenes.dat";
            String filmPath = Environment.CurrentDirectory.ToString() + "\\Serialization\\BINARY\\Films.dat";

            BinarySerialization serialization = new BinarySerialization();
            SerializeData(serialization, actorPath, employeePath, scenePath, filmPath);
        }

        private void SerializeData(ISerialize serialization, String actorPath, String employeePath, String scenePath, String filmPath)
        {
            serialization.SaveData(Person.actors, actorPath);
            serialization.SaveData(Person.employees, employeePath);
            serialization.SaveData(Scene.scenes, scenePath);
            serialization.SaveData(Film.Films, filmPath);
        }
    }
}
