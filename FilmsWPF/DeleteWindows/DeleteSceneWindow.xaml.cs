using FilmsWPFClass;
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
    /// Логика взаимодействия для DeleteSceneWindow.xaml
    /// </summary>
    public partial class DeleteSceneWindow : Window
    {
        public DeleteSceneWindow()
        {
            InitializeComponent();
        }

        private void deleteSceneButton_Click(object sender, RoutedEventArgs e)
        {
            if (deleteSceneComboBox.Text != "")
            {
                Scene.scenes.RemoveAt(deleteSceneComboBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Заповніть поля");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboBoxScene fillComboBoxScene = new FillComboBoxScene(deleteSceneComboBox, Scene.scenes);
        }
    }
}
