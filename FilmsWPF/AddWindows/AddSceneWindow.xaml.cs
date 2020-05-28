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

namespace FilmsWPF
{
    /// <summary>
    /// Логика взаимодействия для AddSceneWindow.xaml
    /// </summary>
    public partial class AddSceneWindow : Window
    {
        public AddSceneWindow()
        {
            InitializeComponent();
        }

        private void addSceneButtonn_Click(object sender, RoutedEventArgs e)
        {
            if (nameSceneTextBox.Text != "" && LocationTextbox.Text != "" && periodTimeTextBox.Text != "" && actorComboBox.Text != "" && employeeComboBox.Text != "" && genreComboBox.Text != "")
            {
                foreach(Employee employee in Person.employees.Where(y => y.Full_name == employeeComboBox.Text))
                {
                    foreach (Actor actor in Person.actors.Where(i => i.Full_name == actorComboBox.Text))
                    {
                        Scene scene = new Scene(nameSceneTextBox.Text, LocationTextbox.Text, periodTimeTextBox.Text, genreComboBox.Text, actor, employee);
                        Scene.scenes.Add(scene);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заповніть поля");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboBoxActor fillComboBoxActor = new FillComboBoxActor(actorComboBox, Person.actors);
            FillComboBoxEmployee fillComboBoxEmployee = new FillComboBoxEmployee(employeeComboBox, Person.employees);
        }
    }
}
