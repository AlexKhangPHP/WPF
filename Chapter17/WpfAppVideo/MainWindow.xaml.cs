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
using IO=System.IO;

namespace WpfAppVideo
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string videoName = "Wildlife";
                string path = "Videos/" + videoName + ".mp4";
                xMediaPlayer.Source = new Uri(path, UriKind.RelativeOrAbsolute);
                xMediaPlayer.Play();
                this.Title = "Video Player - " + videoName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Drop(object sender, DragEventArgs e)
        {
            string videoName = "";
            if (e.Data is DataObject && ((DataObject)e.Data).ContainsFileDropList())
            {
                string path = "";
                foreach (string itemName in ((DataObject)e.Data).GetFileDropList())
                {
                    string extensionName = IO.Path.GetExtension(itemName);
                    videoName = IO.Path.GetFileNameWithoutExtension(itemName);
                    if (extensionName != "")
                    {
                        if (extensionName == ".wmv" || 
                            extensionName == ".mp3"||
                            extensionName == ".wav" ||  
                            extensionName == ".avi" || 
                            extensionName == ".mp4")
                        {
                            if (path == "") path = itemName;
                        }
                    }
                }
                xMediaPlayer.Source = new Uri(path, UriKind.RelativeOrAbsolute);
                this.Title = "Video Player - " + videoName;
                xMediaPlayer.Play();
            }
        }
    }
}
