using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string databasePath = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\ERP.mdf;";
        private void buttonDisplay_Click(object sender, RoutedEventArgs e)
        {
            listViewData.ItemsSource = new Employee(databasePath).Get().ToList();
        }
        
        void EditEmployee(Employee selectedEmployee)
        {
            try
            {
               
                if (selectedEmployee != null)
                {
                    labelId.Content = selectedEmployee.EmployeeId.ToString();
                    textBoxFirstName.Text = selectedEmployee.FirstName;
                    textBoxLastName.Text = selectedEmployee.LastName;
                    textBoxAddress.Text = selectedEmployee.Address;
                    DateOfBirth.SelectedDate = selectedEmployee.DateOfBirth;
                    textBoxTelephone.Text = selectedEmployee.Telephone;
                    textBoxCellphone.Text = selectedEmployee.Cellphone;
                    textBoxEmail.Text = selectedEmployee.Email;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        private void listViewData_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Employee selectedEmployee = (Employee)listViewData.SelectedItem;
            
            EditEmployee(selectedEmployee.Get(selectedEmployee.EmployeeId));
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            labelId.Content = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAddress.Text = "";
            DateOfBirth.SelectedDate = null;
            textBoxTelephone.Text = "";
            textBoxCellphone.Text = "";
            textBoxEmail.Text = "";
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            Employee selectedEmployee = (Employee)listViewData.SelectedItem;
            EditEmployee(selectedEmployee);
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Address = textBoxAddress.Text,
                    DateOfBirth = (DateTime)DateOfBirth.SelectedDate,
                    Telephone = textBoxTelephone.Text,
                    Cellphone = textBoxCellphone.Text,
                    Email = textBoxEmail.Text
                };
                employee.DatabasePath = databasePath;
                if (labelId.Content != null && labelId.Content.ToString() != "")
                {
                    employee.EmployeeId = Convert.ToInt32(labelId.Content);
                    
                    if (employee.Update(employee))
                        MessageBox.Show("Updated employee");
                    else
                        MessageBox.Show("Failed to update employee!");
                }
                else
                {
                     
                   
                    if (employee.Add(employee))
                    {
                        MessageBox.Show("Added employee");
                        buttonAdd_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Failed to add employee!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = (Employee)listViewData.SelectedItem;
            if (employee !=null &&
                MessageBox.Show("Are you sure to delete?","?",
                MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                employee.DatabasePath = databasePath;
                if (employee.Delete(employee.EmployeeId))
                {
                    MessageBox.Show("Deleted employee");
                    buttonDisplay_Click(sender, e);
                }
                else
                    MessageBox.Show("Failed to delete employee!");
                 
            }
        }
    }
}
