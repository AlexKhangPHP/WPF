using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ERPSystem
{
    
    public class ExportCommand : ICommand
    {
        
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public void Execute(object sender)
        {
            if (sender != null)
            {
                System.Windows.Controls.ListView listView
                       = sender as System.Windows.Controls.ListView;
                List<Employee> employees = (List<Employee>)listView.ItemsSource;
                Reporting reporting = new Reporting();
                reporting.GenerateXPSReporting(employees);
            }
        }
        public bool CanExecute(object sender)
        {
            bool enableExecute = false;
            if (sender is System.Windows.Controls.ListView)
            {
                System.Windows.Controls.ListView listView
                    = sender as System.Windows.Controls.ListView;
                enableExecute = listView.Items.Count > 0;
            }
            return enableExecute;
        }
    }
}
