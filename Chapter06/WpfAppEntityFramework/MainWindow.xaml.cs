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

namespace WpfAppEntityFramework
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
        private void buttonDisplay_Click(object sender, RoutedEventArgs e)
        {
            ERPEF entity = new ERPEF();
            listViewData.ItemsSource =entity.Employees.ToList();
        }
        
        void EditEmployee(Employee employee)
        {
            try
            {
               
                if (employee != null)
                {
                    labelId.Content = employee.EmployeeId.ToString();
                    textBoxFirstName.Text = employee.FirstName;
                    textBoxLastName.Text = employee.LastName;
                    textBoxAddress.Text = employee.Address;
                    DateOfBirth.SelectedDate = employee.DateOfBirth;
                    textBoxTelephone.Text = employee.Telephone;
                    textBoxCellphone.Text = employee.Cellphone;
                    textBoxEmail.Text = employee.Email;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void EditEmployee(int employeeId)
        {
            try
            {
                ERPEF entity = new ERPEF();
                Employee employee = 
                    entity.Employees.SingleOrDefault(
                        n=>n.EmployeeId == employeeId
                    );
                if (employee != null)
                {
                    labelId.Content = employee.EmployeeId.ToString();
                    textBoxFirstName.Text = employee.FirstName;
                    textBoxLastName.Text = employee.LastName;
                    textBoxAddress.Text = employee.Address;
                    DateOfBirth.SelectedDate = employee.DateOfBirth;
                    textBoxTelephone.Text = employee.Telephone;
                    textBoxCellphone.Text = employee.Cellphone;
                    textBoxEmail.Text = employee.Email;
                    comboBoxStates.SelectedValue = employee.StateCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listViewData_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Employee employee = (Employee)listViewData.SelectedItem;
            EditEmployee(employee.EmployeeId);
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
            comboBoxStates.SelectedValue = null;
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = (Employee)listViewData.SelectedItem;
            EditEmployee(employee.EmployeeId);
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (ERPEF entity = new ERPEF())
                {
                    
                    if (labelId.Content != null && labelId.Content.ToString() != "")
                    {
                        int employeeId = Convert.ToInt32(labelId.Content);
                        var employee =
                        entity.Employees.SingleOrDefault(
                            n => n.EmployeeId == employeeId
                        );
                        employee.FirstName = textBoxFirstName.Text;
                        employee.LastName = textBoxLastName.Text;
                        employee.Address = textBoxAddress.Text;
                        employee.DateOfBirth = DateOfBirth.SelectedDate ;
                        employee.Telephone = textBoxTelephone.Text;
                        employee.Cellphone = textBoxCellphone.Text;
                        employee.Email = textBoxEmail.Text;
                        employee.StateCode = Convert.ToString(comboBoxStates.SelectedValue);
                        if (entity.SaveChanges() > 0)
                            MessageBox.Show("Success to update employee!");
                        else
                        {
                            MessageBox.Show("Failed to update employee or nothing changes!");
                        }
                    }
                    else
                    {
                        var employee = new Employee()
                        {
                            FirstName = textBoxFirstName.Text,
                            LastName = textBoxLastName.Text,
                            Address = textBoxAddress.Text,
                            DateOfBirth = DateOfBirth.SelectedDate,
                            Telephone = textBoxTelephone.Text,
                            Cellphone = textBoxCellphone.Text,
                            Email = textBoxEmail.Text,
                            StateCode = Convert.ToString(comboBoxStates.SelectedValue)
                        };
                        entity.Employees.Add(employee);
                        if (entity.SaveChanges() > 0)
                            MessageBox.Show("Success to add new employee!");
                        else
                        {
                            MessageBox.Show("Failed to add new employee or duplicate data!");
                        }
                    }
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
            if (employee != null &&
                MessageBox.Show("Are you sure to delete?","?",
                MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                using (ERPEF entity = new ERPEF())
                {
                    int employeeId = Convert.ToInt32(labelId.Content);
                    employee = entity.Employees.SingleOrDefault(
                        n => n.EmployeeId == employeeId
                    );
                    entity.Employees.Remove(employee);
                    if (entity.SaveChanges()>0)
                    {
                        MessageBox.Show("Success to delete employee");
                        buttonDisplay_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Failed to delete employee!");
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ERPEF entity = new ERPEF();
            comboBoxStates.ItemsSource = entity.States.ToList();
        }
    }
}
