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
using System.Windows.Threading;
using System.IO;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }
        private delegate void UpdateTextBlockDelegate(
        DependencyProperty dp, Object title );
        private delegate void UpdateProgressBarDelegate(
        DependencyProperty dp,  Object value);
        private void buttonScan_Click(object sender, RoutedEventArgs e)
        {
            string path = @"D:\NewBookProject\ITBOOKS\WPF\";
            ScanFiles(path);
            ScanFolders(path );
        }
        
        private void ScanFolders(string path )
        {
            UpdateProgressBarDelegate updateProgressBar1 =
               new UpdateProgressBarDelegate(progressBarScan1.SetValue);
            string[] folders = Directory.GetDirectories(path);
            progressBarScan1.Minimum = 0;
            progressBarScan1.Value = 0;
            progressBarScan1.Maximum = folders.Count();
            for (double j = 0; j < folders.Count(); j++)
            {
                textBlock1.Text = folders[(int)j];
                Dispatcher.Invoke(updateProgressBar1,
                    DispatcherPriority.Background,
                    new object[] { ProgressBar.ValueProperty, j });
                System.Threading.Thread.Sleep(15);
                ScanFolders(textBlock1.Text);
            }
            progressBarScan1.Value = progressBarScan1.Maximum;

        }
        private void ScanFiles(string path)
        {
            FileInfo[] fileInfos = new DirectoryInfo(path).GetFiles();
            progressBarScan2.Maximum = fileInfos.Count();
            progressBarScan2.Minimum = 0;
            progressBarScan2.Value = 0;

            UpdateProgressBarDelegate updateProgressBar2 =
               new UpdateProgressBarDelegate(progressBarScan2.SetValue);

            for (double i = 0; i < progressBarScan2.Maximum; i++)
            {
                textBlock2.Text = fileInfos[(int)i].Name;
                Dispatcher.Invoke(updateProgressBar2,
                    DispatcherPriority.Background,
                    new object[] { ProgressBar.ValueProperty, i });
                System.Threading.Thread.Sleep(15);
            }
            progressBarScan2.Value = progressBarScan2.Maximum;
        }
    }
}
