using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
 

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        bool isChangeSlider = false;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           // this.mediaElement1.Source = new Uri("http://books.xokr.net/resources/android.mp3", UriKind.RelativeOrAbsolute);
            this.mediaElement1.Source = new Uri("http://books.xokr.net/resources/CreaToon.wmv", UriKind.RelativeOrAbsolute);
            mediaElement1.Play();
            dispatcherTimer = new  DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dispatcherTimer.Start();
        }

        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (!isChangeSlider)
                slider1.Value = mediaElement1.Position.TotalMilliseconds; 
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (button1.Content.ToString()== "||")
            {
                button1.Content = ">";
                mediaElement1.Pause();
              
            }
            else
            {
                dispatcherTimer.Start();
                button1.Content = "||";
                mediaElement1.Play();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Stop();
            mediaElement1.Position = new TimeSpan(0, 0, 0, 0, 0);
            slider1.Value = mediaElement1.Position.TotalMilliseconds;
            button1.Content = ">";
            dispatcherTimer.Stop();
        }

        private void mediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
             
            slider1.Maximum = mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds;
          
        }
        DispatcherTimer dispatcherTimer ;
         
        private void slider1_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            mediaElement1.Position =  new TimeSpan(0, 0, 0, 0, Convert.ToInt32(slider1.Value));
            isChangeSlider = false;
        }

        private void slider1_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            isChangeSlider = true;
        }

        private void mediaElement1_MediaEnded(object sender, RoutedEventArgs e)
        {
            mediaElement1.Position = new TimeSpan(0, 0, 0, 0, 0);
            slider1.Value = mediaElement1.Position.TotalMilliseconds; 
            button1.Content = ">";
            
        }
    }
}
