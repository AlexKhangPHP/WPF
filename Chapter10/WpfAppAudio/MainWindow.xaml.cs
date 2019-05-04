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
using System.IO;
namespace WpfAppAudio
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

        private void clickSound_Click(object sender, RoutedEventArgs e)
        {
            string path =   @"Audio/Alex.Khang.wav";
            SoundPlayer1.Source = new Uri(path, UriKind.RelativeOrAbsolute);

        }

        private void playSound_Click(object sender, RoutedEventArgs e)
        {
            string path =  @"Audio/Kawai-K3-Violin-C6.wav";
            SoundPlayer2.Source = new Uri(path, UriKind.RelativeOrAbsolute);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string path =  @"/wpf.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(path, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            Adv.Source = bitmap;
        }
    }
}
