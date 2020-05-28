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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void addActorButton_Click(object sender, RoutedEventArgs e)
        {
            AddActorWindow addActorWindow = new AddActorWindow();
            addActorWindow.Show();
        }

        private void addEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            addEmployeeWindow.Show();
        }

        private void addFilmButton_Click(object sender, RoutedEventArgs e)
        {
            AddFilmWindow addFilmWindow = new AddFilmWindow();
            addFilmWindow.Show();
        }

        private void addSceneButton_Click(object sender, RoutedEventArgs e)
        {
            AddSceneWindow addSceneWindow = new AddSceneWindow();
            addSceneWindow.Show();
        }
    }
}
