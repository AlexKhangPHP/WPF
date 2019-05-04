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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

         
        private void ShowOrders(string cityName)
        {
            listView.Items.Add(new Order("4191019101", "12/Aug/2020", "X.Microsoft Corporation", "12 Navada",  142000000));
            listView.Items.Add(new Order( "0191019101","12/Oct/2020","X. Pepsi Cola Corporation","12 Chicago", 42000000));
            listView.Items.Add(new Order("0191019141", "12/Nov/2020", "X. Dell Machine Corporation", "12 Los Angles", 32000000));
        }

        private void buttonLoad_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)treeViewCountry.SelectedValue;
            if (item != null)
            {
                string cityName = Convert.ToString(item.Header);
                textBlockTitle.Text = string.Format("Orders - {0}", cityName);
                ShowOrders(cityName);
            }
            else
            {
                MessageBox.Show("Please select city name and click Display button again.");
            }
        }

        private void buttonDetails_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)listView.SelectedItem;
            if(order!=null)
            {
                ShowOrderDetails(order);
            }
        }

        private void ShowOrderDetails(Order order)
        {
            MessageBox.Show(order.OrderNo);
        }
    }
}
