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

namespace WpfApp1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxMaritalStatus.Items.Add("Single");
            comboBoxMaritalStatus.Items.Add("Married");
            comboBoxMaritalStatus.Items.Add("Single Mom");
            comboBoxMaritalStatus.Items.Add("Divorce");
            comboBoxMaritalStatus.Items.Add("Others");
            comboBoxMaritalStatus.SelectedIndex = 0;
        }

        private void buttonChange_Click(object sender, RoutedEventArgs e)
        {
            buttonSave.SetResourceReference(TemplateProperty, "YButtonTemplate");
        }
    }
}
