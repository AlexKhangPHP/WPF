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

namespace ERPSystem
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
        //XCommand command = new XCommand();//command = new XCommand();
        //public XCommand GetCommand
        //{
        //    get { return command; }
        //}
        public int ListViewItemCount
        {
            get { return listViewData.Items.Count; }
        }

        private void DisplayData()
        {
            ERPEF entity = new ERPEF();
            listViewData.ItemsSource =entity.Employees.ToList();
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
        

        private void CanExecuteSave(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (
                textBoxFirstName.Text != "" && textBoxLastName.Text != ""
                && textBoxEmail.Text != "" && textBoxAddress.Text != ""
                && DateOfBirth.SelectedDate !=null
            );
        }
        private void ExecuteFind(object sender, ExecutedRoutedEventArgs e)
        {
            DisplayData ();
        }

        private void CanExecuteFind(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public void ExecuteSave (object sender, RoutedEventArgs e)
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
                            StateCode = Convert.ToString(comboBoxStates.SelectedValue),
                            IsActivated = true
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

        private bool DeleteById (int employeeId)
        {
            try
            {
                using (ERPEF entity = new ERPEF())
                {
                    Employee employee = entity.Employees.SingleOrDefault(
                        n => n.EmployeeId == employeeId
                    );
                    entity.Employees.Remove(employee);
                    return (entity.SaveChanges() > 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ERPEF entity = new ERPEF();
            comboBoxStates.ItemsSource = entity.States.ToList();
        }

        public void ExecuteOpen (object sender, ExecutedRoutedEventArgs e)
        {
            Employee employee = (Employee)listViewData.SelectedItem;
            EditEmployee(employee.EmployeeId);
        }
        public void CanExecuteOpen (object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = listViewData.SelectedItem != null;
        }
        public void ExecuteDelete(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                Employee employee = (Employee)listViewData.SelectedItem;
                if (MessageBox.Show(string.Format(
                    "Are you sure to delete {0} {1} ?",
                    employee.FirstName, employee.LastName), "?",
                    MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {

                    if (DeleteById(employee.EmployeeId))
                    {
                        MessageBox.Show("Success to delete employee");
                        DisplayData();
                    }
                    else
                        MessageBox.Show("Failed to delete employee!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CanExecuteDelete(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = listViewData.SelectedItem != null ;
        
        }
        public void ExecutePrint(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                List<Employee> employees = (List<Employee>)listViewData.ItemsSource;
                Reporting reporting = new Reporting();
                reporting.GenerateXPSReporting(employees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CanExecutePrint(object sender, CanExecuteRoutedEventArgs e)
        {
            
            e.CanExecute = listViewData.Items.Count>0;
        }

        private void MenuDocument_Checked(object sender, RoutedEventArgs e)
        {
            ReportWindow reportWindow = new ReportWindow();
            reportWindow.ShowDialog();
        }

        private void MenuMedia_Checked(object sender, RoutedEventArgs e)
        {
            VideoWindow videoWindow = new VideoWindow();
            videoWindow.ShowDialog();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
