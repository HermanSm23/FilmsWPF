using FilmsWPFClass;
using FilmsWPFClass.Serialization;
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

namespace FilmsWPF
{
    /// <summary>
    /// Логика взаимодействия для DeleteActorWindow.xaml
    /// </summary>
    public partial class DeleteActorWindow : Window
    {
        public DeleteActorWindow()
        {
            InitializeComponent();
        }

        private void deleteActorButton_Click(object sender, RoutedEventArgs e)
        {
            if(deleteActorComboBox.Text != "")
            {
                Person.actors.RemoveAt(deleteActorComboBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Заповніть поля");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboBoxActor fillComboBox = new FillComboBoxActor(deleteActorComboBox, Person.actors);
        }
    }
}
