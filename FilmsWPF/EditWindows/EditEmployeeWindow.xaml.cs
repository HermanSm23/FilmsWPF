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
    /// Логика взаимодействия для EditEmployeeWindow.xaml
    /// </summary>
    public partial class EditEmployeeWindow : Window
    {
        public EditEmployeeWindow()
        {
            InitializeComponent();
        }

        private void editEmployeeButtonn_Click(object sender, RoutedEventArgs e)
        {
            if (fullNameTextBox.Text != "" && sexTypeComboBox.Text != "" && birthdayDate.Text != "" && positionTypeComboBox.Text != "" && employeeComboBix.Text != "")
            {
                Employee employee = new Employee(fullNameTextBox.Text, sexTypeComboBox.SelectedIndex, birthdayDate.SelectedDate.Value, positionTypeComboBox.Text);
                Person.employees[employeeComboBix.SelectedIndex] = employee;
            } 
            else
            {
                MessageBox.Show("Заповніть поля");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboBoxEmployee fillComboBoxEmployee = new FillComboBoxEmployee(employeeComboBix, Person.employees);
        }
    }
}
