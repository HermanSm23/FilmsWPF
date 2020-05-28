using FilmsWPF.EditWindows;
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
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
        }

        private void editActorButton_Click(object sender, RoutedEventArgs e)
        {
            EditActorWindow editActorWindow = new EditActorWindow();
            editActorWindow.Show();
        }

        private void editEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            EditEmployeeWindow editEmployeeWindow = new EditEmployeeWindow();
            editEmployeeWindow.Show();
        }

        private void editFilmButton_Click(object sender, RoutedEventArgs e)
        {
            EditFilmWindow editFilmWindow = new EditFilmWindow();
            editFilmWindow.Show();
        }

        private void editSceneButton_Click(object sender, RoutedEventArgs e)
        {
            EditSceneWindow editSceneWindow = new EditSceneWindow();
            editSceneWindow.Show();
        }
    }
}
