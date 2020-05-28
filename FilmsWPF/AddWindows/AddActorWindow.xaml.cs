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
    /// Логика взаимодействия для AddActorWindow.xaml
    /// </summary>
    public partial class AddActorWindow : Window
    {
        public AddActorWindow()
        {
            InitializeComponent();
        }

        private void addActorButtonn_Click(object sender, RoutedEventArgs e)
        {
            if(fullNameTextBox.Text != "" && sexTypeComboBox.Text != "" && birthdayDate.Text != "" && roleTypeComboBox.Text != "")
            {
                Actor actor = new Actor(fullNameTextBox.Text, sexTypeComboBox.SelectedIndex, birthdayDate.SelectedDate.Value, roleTypeComboBox.SelectedIndex); ;
                Person.actors.Add(actor);
            } 
            else
            {
                MessageBox.Show("Заповніть поля");
            }
        }
    }
}
