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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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

        private void buttonGridControl_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.ShowDialog();
        }

        

        private void buttonTemplate_Click(object sender, RoutedEventArgs e)
        {
            Window4 window = new Window4();
            window.ShowDialog();
        }

        private void buttonListView_Click(object sender, RoutedEventArgs e)
        {
            Window3 window = new Window3();
            window.ShowDialog();
        }

        private void buttonTreeView_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.ShowDialog();
        }

        private void buttonStyles_Click(object sender, RoutedEventArgs e)
        {
            Window5 window = new Window5();
            window.ShowDialog();
        }

        private void buttonStates_Click(object sender, RoutedEventArgs e)
        {
            Window6 window = new Window6();
            window.ShowDialog();
        }
    }
}
