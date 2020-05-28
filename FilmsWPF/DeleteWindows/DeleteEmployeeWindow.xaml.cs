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
    /// Логика взаимодействия для DeleteEmployeeWindow.xaml
    /// </summary>
    public partial class DeleteEmployeeWindow : Window
    {
        public DeleteEmployeeWindow()
        {
            InitializeComponent();
        }

        private void deleteEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (deleteEmployeeComboBox.Text != "")
            {
                Person.employees.RemoveAt(deleteEmployeeComboBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Заповніть поля");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboBoxEmployee fillComboBoxEmployee = new FillComboBoxEmployee(deleteEmployeeComboBox, Person.employees);
        }
    }
}
