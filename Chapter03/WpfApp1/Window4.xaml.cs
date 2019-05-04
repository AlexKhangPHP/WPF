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
using System.IO;
namespace WpfApp1
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

        private void Calendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            label1.Content = Calendar1.SelectedDate?.ToString("dd/MMM/yyyy");
            listBox1.Items.Clear();
            foreach (FileInfo fileInfo in new DirectoryInfo(@"D:\NewBookProject\ITBOOKS\WPF\").GetFiles())
            {
                if(fileInfo.CreationTime.Year == Calendar1.SelectedDate?.Year)
                    listBox1.Items.Add(fileInfo.Name);
            }
        }
    }
}
