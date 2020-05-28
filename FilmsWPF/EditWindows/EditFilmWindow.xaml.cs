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

namespace FilmsWPF.EditWindows
{
    /// <summary>
    /// Логика взаимодействия для EditFilmWindow.xaml
    /// </summary>
    public partial class EditFilmWindow : Window
    {
        public EditFilmWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboBoxFilm fillComboBoxFilm = new FillComboBoxFilm(filmComboBox, Film.Films);
            FillComboBoxScene fillComboBoxScene = new FillComboBoxScene(sceneComboBox, Scene.scenes);
            FillComboBoxActor fillComboBoxActor = new FillComboBoxActor(actorComboBox, Person.actors);
            FillComboBoxEmployee fillComboBoxEmployee = new FillComboBoxEmployee(employeeComboBox, Person.employees);
        }

        private void editFilmButtonn_Click(object sender, RoutedEventArgs e)
        {
            if (filmNameTextBox.Text != "" && filmDurationTextBox.Text != "" && dateStartShoot.Text != "" && dateEndShoot.Text != ""
                            && premierDate.Text != "" && budgetTextBox.Text != "" && actorComboBox.Text != "" && employeeComboBox.Text != ""
                            && sceneComboBox.Text != "" && descriptionTextBox.Text != "" && filmComboBox.Text != "")
            {
                foreach (Actor actor in Person.actors.Where(i => i.Full_name == actorComboBox.Text))
                {
                    foreach (Employee employee in Person.employees.Where(y => y.Full_name == employeeComboBox.Text))
                    {
                        foreach (Scene scene in Scene.scenes.Where(x => x.Name == sceneComboBox.Text))
                        {
                            Film film = new Film(filmNameTextBox.Text, uint.Parse(filmDurationTextBox.Text), dateStartShoot.SelectedDate.Value, dateEndShoot.SelectedDate.Value,
                                premierDate.SelectedDate.Value, uint.Parse(budgetTextBox.Text), descriptionTextBox.Text, genreTypeComboBox.Text,
                                actor, employee, scene);

                            Film.Films[filmComboBox.SelectedIndex] = film;
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Заповніть поля");
            }
        }
    }
}
