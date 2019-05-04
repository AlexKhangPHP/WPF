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

namespace WpfAppGroupByAndFilterByGridView
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
            try
            {
                using (ERPEF entity = new ERPEF())
                {

                    IQueryable<Employee> employees =null;
                    string keyword = textBoxKeyword.Text;
                    string state = Convert.ToString(comboBoxStates.SelectedValue).Trim() ;
                    if (keyword != "" || state!= "")
                    {
                        employees = entity.Employees.
                        Where(n => (keyword !="" && 
                        (n.FirstName.Contains(keyword)
                        || n.LastName.Contains(keyword))) 
                        || keyword == "").
                        Where (n => state == "" 
                        || (state != "" &&  
                        n.StateCode.Equals(state )));
                    }
                    else
                    {
                        employees = entity.Employees;
                    }
                    

                    CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(employees.ToList());
                    PropertyGroupDescription group  = new PropertyGroupDescription("StateCode");
                    view.GroupDescriptions.Add(group);
                    gridViewData.ItemsSource = view;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ERPEF entity = new ERPEF();
            comboBoxStates.ItemsSource = entity.States.ToList();
            comboBoxStates.SelectedIndex = 0;
        }

        private void gridViewData_RowDetailsVisibilityChanged(object sender, DataGridRowDetailsEventArgs e)
        {
            try
            {
                if (e.Row.DetailsVisibility == System.Windows.Visibility.Visible)
                {
                    var item = e.Row.Item;
                    Type type = item.GetType();
                    int employeeId = (int)type.GetProperty("EmployeeId").GetValue(item, null);
                    DataGrid dataGrid = e.DetailsElement as DataGrid;
                    using (ERPEF context = new ERPEF())
                    {
                        IQueryable<FamilyRelation> relations = context.FamilyRelations
                            .Where(n => n.EmployeeId == employeeId);
                        if (relations.Count() > 0)
                        {
                            dataGrid.ItemsSource = relations.ToList();

                        }
                        else
                        {
                            dataGrid.Visibility = Visibility.Hidden;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
