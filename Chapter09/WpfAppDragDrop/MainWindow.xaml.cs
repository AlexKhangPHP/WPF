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

namespace WpfAppDragDrop
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
        private void listView1_Drop(object sender, DragEventArgs e)
        {

            if (e.Data is DataObject && ((DataObject)e.Data).ContainsFileDropList())
            {
               
                foreach (string itemName in ((DataObject)e.Data).GetFileDropList())
                {
                    if (Directory.Exists(itemName))
                    {
                        this.Title += itemName;
                        FileInfo[] fileInfo = new DirectoryInfo(itemName).GetFiles();
                        listView1.ItemsSource = fileInfo;
                    }
                }
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data is DataObject && ((DataObject)e.Data).ContainsFileDropList())
            {
                this.Title = "";
                foreach (string itemName in ((DataObject)e.Data).GetFileDropList())
                {
                    if (!Directory.Exists(itemName))
                    {
                        e.Effects = DragDropEffects.None;
                    }
                }
            }
        }
    }
}
