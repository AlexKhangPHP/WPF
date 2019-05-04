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

namespace WpfAppRoutedEventGridView
{
    /// <summary>
    /// Interaction logic for ItemChanges.xaml
    /// </summary>
    public partial class ItemChanges : Window
    {
        public ItemChanges()
        {
            InitializeComponent();
        }
        internal bool IsAccepted = false;
        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Data has changed, Do you want to update back to database?", "XOKR", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                IsAccepted = true;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            IsAccepted = false; this.Close();
        }

       
    }
}
