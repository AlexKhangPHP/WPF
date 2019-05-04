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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete");
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save");
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
