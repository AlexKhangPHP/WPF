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

namespace MultiWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();
            SplashScreen splashScreen = new SplashScreen("XOKRSplashScreen.png");
            splashScreen.Show(false, true);
            splashScreen.Close(TimeSpan.FromSeconds(5));

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AboutUs window = new AboutUs();
            window.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            SignIn window = new SignIn();
            window.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "XOKR", 
                MessageBoxButton.OKCancel, MessageBoxImage.Question,
                MessageBoxResult.Cancel) == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
