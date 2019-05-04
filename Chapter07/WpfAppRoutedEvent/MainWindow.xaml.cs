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

namespace WpfAppRoutedEvent
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

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("YesButton");
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NoButton");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("CancelButton");
        }

        private void RoutedEvent_ClickHandler(object sender, RoutedEventArgs e)
        {
            FrameworkElement element = e.Source as FrameworkElement;
            switch (element.Name)
            {
                case "Yes":
                    MessageBox.Show("Yes Button");
                    // do more thing here for Yes option...
                    break;
                case "No":
                    MessageBox.Show("No Button");
                    // do more thing here for No option...
                    break;
                case "Cancel":
                    MessageBox.Show("Cancel Button");
                    // do more thing here for Cancel option...
                    break;
            }
            e.Handled = true;
        }

        private void RoutedEvent_BaseClickHandler(object sender, RoutedEventArgs e)
        {
           
            FrameworkElement element = e.Source as FrameworkElement;
            switch (element.Name)
            {
                case "ButtonYes":
                    MessageBox.Show("Button Yes");
                    // do more thing here for Yes option...
                    break;
                case "ButtonNo":
                    MessageBox.Show("Button No");
                    // do more thing here for No option...
                    break;
                case "ButtonCancel":
                    MessageBox.Show("Button Cancel");
                    // do more thing here for Cancel option...
                    break;
            }
            e.Handled = true;
        }

        private void ButtonYes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tunneling event");
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bubbling event");
        }
    }
}
