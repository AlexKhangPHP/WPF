using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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

namespace WpfAppDependencyProperty
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TitleTextBlock.SetText = "Hellow DependencyProperty World";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listBox.SelectedValuePath = "CountryAbbreviation";
            listBox.DisplayMemberPath = "CountryName";
            listBox.SetValue(ListBox.ItemsSourceProperty, 
                GetDataTable().DefaultView);
        }
        DataTable GetDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CountryAbbreviation");
            dataTable.Columns.Add("CountryName");
            DataRow dataRow = dataTable.NewRow();
            dataRow["CountryAbbreviation"] = "USA";
            dataRow["CountryName"] = "United States";
            dataTable.Rows.Add(dataRow);
            dataRow = dataTable.NewRow();
            dataRow["CountryAbbreviation"] = "CAD";
            dataRow["CountryName"] = "Canda United States";
            dataTable.Rows.Add(dataRow);
            dataRow = dataTable.NewRow();
            dataRow["CountryAbbreviation"] = "JPA";
            dataRow["CountryName"] = "Japan States";
            dataTable.Rows.Add(dataRow);
            return dataTable;
        }
    }
}
