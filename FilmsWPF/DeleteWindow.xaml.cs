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
    /// Логика взаимодействия для DeleteWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        public DeleteWindow()
        {
            InitializeComponent();
        }

        private void deleteActorButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteActorWindow deleteActorWindow = new DeleteActorWindow();
            deleteActorWindow.Show();
        }

        private void deleteEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteEmployeeWindow deleteEmployeeWindow = new DeleteEmployeeWindow();
            deleteEmployeeWindow.Show();
        }

        private void deleteFilmButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteFilmWindow deleteFilmWindow = new DeleteFilmWindow();
            deleteFilmWindow.Show();
        }

        private void deleteSceneButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteSceneWindow deleteSceneWindow = new DeleteSceneWindow();
            deleteSceneWindow.Show();
        }
    }
}
