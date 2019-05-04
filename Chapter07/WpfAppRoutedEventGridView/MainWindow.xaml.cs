using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
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

namespace WpfAppRoutedEventGridView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ERPEF entity =  null;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void buttonDisplay_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                entity = new ERPEF();
                Console.WriteLine(entity.Employees.Count());
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (ERPDirectory entity = new ERPDirectory())
                {
                    comboBoxStates.ItemsSource = entity.States.ToList();
                    comboBoxStates.SelectedIndex = 0;
                    ComboBoxState.ItemsSource = entity.States.ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
       
        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                int effected = 0;
                DbChangeTracker tracker= entity.ChangeTracker;
                IEnumerable<DbEntityEntry> entries = tracker.Entries();
                Console.WriteLine(entity.Employees.Count());
                //dataGrid.ItemsSource = entries.ToList();
                if (tracker.HasChanges())
                {
                    
                    IEnumerable<DbEntityEntry> modifiedEntries = entries.Where(n => n.State == System.Data.Entity.EntityState.Modified);
                    List<Employee> changes = new List<Employee>();
                    foreach(DbEntityEntry entityEntry in modifiedEntries)
                    {
                        //DbPropertyValues oldValues = entityEntry.GetDatabaseValues();
                        DbPropertyValues newValues = entityEntry.CurrentValues;
                        Employee employee = (Employee)newValues.ToObject();
                        changes.Add(employee);
                    }
                    IEnumerable<DbEntityEntry> deletedEntries = entries.Where(n => n.State == System.Data.Entity.EntityState.Deleted || n.State == System.Data.Entity.EntityState.Detached);
                    List<Employee> deletes = new List<Employee>();
                    foreach (DbEntityEntry entityEntry in deletedEntries)
                    {
                        //DbPropertyValues oldValues = entityEntry.GetDatabaseValues();
                        DbPropertyValues newValues = entityEntry.CurrentValues;
                        Employee employee = (Employee)newValues.ToObject();
                        deletes.Add(employee);
                    }
                    IEnumerable<DbEntityEntry> addedEntries = entries.Where(n => n.State == System.Data.Entity.EntityState.Added);
                    List<Employee> adds = new List<Employee>();
                    foreach (DbEntityEntry entityEntry in addedEntries)
                    {
                        //DbPropertyValues oldValues = entityEntry.GetDatabaseValues();
                        DbPropertyValues newValues = entityEntry.CurrentValues;
                        Employee employee = (Employee)newValues.ToObject();
                        adds.Add(employee);
                    }
                    ItemChanges itemChanges = new ItemChanges();
                    itemChanges.Topmost = true;
                    itemChanges.dataGridChanges.ItemsSource = changes.ToList();
                    itemChanges.dataGridChangesDelete.ItemsSource = deletes.ToList();
                    itemChanges.dataGridChangesNew.ItemsSource = adds.ToList();
                    
                    itemChanges.ShowDialog();
                    if (itemChanges.IsAccepted)
                    {
                        effected = entity.SaveChanges();
                        MessageBox.Show("Success to update data: " + effected.ToString() + " item(s).");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BubblingRoutedEvent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button button = e.OriginalSource as Button;
                DataGrid item = e.Source as DataGrid;
                Employee employee = item.SelectedItem as Employee;
               
                if (button!=null )
                {
                    switch (button.Content.ToString())
                    {
                        case "Delete":
                            MessageBox.Show("Delete");
                            break;
                        case "Notify":
                            MessageBox.Show("Notify");
                            break;
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
