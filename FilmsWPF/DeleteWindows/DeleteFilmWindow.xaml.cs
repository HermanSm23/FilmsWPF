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
    /// Логика взаимодействия для DeleteFilmWindow.xaml
    /// </summary>
    public partial class DeleteFilmWindow : Window
    {
        public DeleteFilmWindow()
        {
            InitializeComponent();
        }

        private void deleteFilmButton_Click(object sender, RoutedEventArgs e)
        {
            if (deleteFilmComboBox.Text != "")
            {
                Film.Films.RemoveAt(deleteFilmComboBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Заповніть поля");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboBoxFilm fillComboBoxFilm = new FillComboBoxFilm(deleteFilmComboBox, Film.Films);
        }
    }
}
