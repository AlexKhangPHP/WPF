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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void treeViewCountry_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem item = (TreeViewItem)e.NewValue;
            if(item!=null)
                textBlockTitle.Text = Convert.ToString(item.Header);
        }

        private void treeViewCountry_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TreeViewItem item = (TreeViewItem) treeViewCountry.SelectedValue;
            if (item != null)
            {
                string cityName = Convert.ToString(item.Header);
                textBlockTitle.Text = string.Format("Orders - {0} city", cityName);
                ShowOrders(cityName);
            }
        }

        private void ShowOrders(string cityName)
        {
             
        }
    }
}
