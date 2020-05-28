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

namespace FilmsWPF.EditWindows
{
    /// <summary>
    /// Логика взаимодействия для EditActorWindow.xaml
    /// </summary>
    public partial class EditActorWindow : Window
    {
        public EditActorWindow()
        {
            InitializeComponent();
        }

        private void editActorButtonn_Click(object sender, RoutedEventArgs e)
        {
            if (fullNameTextBox.Text != "" && sexTypeComboBox.Text != "" && birthdayDate.Text != "" && roleTypeComboBox.Text != "" && actorsComboBox.Text != "")
            {
                Actor actor = new Actor(fullNameTextBox.Text, sexTypeComboBox.SelectedIndex, birthdayDate.SelectedDate.Value, roleTypeComboBox.SelectedIndex);
                Person.actors[actorsComboBox.SelectedIndex] = actor;
            }
            else
            {
                MessageBox.Show("Заповніть поля");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboBoxActor fillComboBoxActor = new FillComboBoxActor(actorsComboBox, Person.actors);
        }
    }
}
