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
    /// Логика взаимодействия для AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public AddEmployeeWindow()
        {
            InitializeComponent();
        }

        private void addEmployeeButtonn_Click(object sender, RoutedEventArgs e)
        {
            if(fullNameTextBox.Text != "" && sexTypeComboBox.Text != "" && birthdayDate.Text != "" && positionTypeComboBox.Text != "")
            {
                Employee employee = new Employee(fullNameTextBox.Text, sexTypeComboBox.SelectedIndex, birthdayDate.SelectedDate.Value, positionTypeComboBox.Text);
                Person.employees.Add(employee);
                
            }
            else
            {
                MessageBox.Show("Заповніть поля");
            }
        }
    }
}
