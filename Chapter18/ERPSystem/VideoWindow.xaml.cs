using System;
using System.Collections.Generic;
using System.IO;
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

namespace ERPSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class VideoWindow : Window
    {
        public VideoWindow()
        {
            InitializeComponent();
        }
        
        bool hasReplay = false;
        bool hasSpeaker = true;
        private void imagePlay_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (xMediaPlayer.Position == xMediaPlayer.NaturalDuration.TimeSpan)
            {
                TimeSpan timeSpan = new TimeSpan(0, 0, 0);
                xMediaPlayer.Position = timeSpan;
            }
            string imageName = Convert.ToString(imagePlay.ToolTip);
            string imagePath = "";
            if (imageName == "Play")
            {
                imagePath = "Resources/pause.png";
                imagePlay.ToolTip = "Stop";
                xMediaPlayer.Play();
            }
            else
            {
                imagePath = "Resources/play.png";
                imagePlay.ToolTip = "Play";
                xMediaPlayer.Pause();
            }
            imagePlay.Source = GetBitmapImage(imagePath);
        }
        BitmapImage GetBitmapImage(string imagePath)
        {
            return new BitmapImage(new Uri(imagePath, UriKind.Relative));
        }
        private void Window_Drop(object sender, DragEventArgs e)
        {
            string videoName = "";
            if (e.Data is DataObject && ((DataObject)e.Data).ContainsFileDropList())
            {
                string path = "";
                foreach (string itemName in ((DataObject)e.Data).GetFileDropList())
                {
                    string extensionName = System.IO.Path.GetExtension(itemName);
                    videoName = System.IO.Path.GetFileNameWithoutExtension(itemName);
                    if (extensionName != "")
                    {
                        if (extensionName == ".wmv" || extensionName == ".mp3"
                         || extensionName == ".wav" || extensionName == ".avi" 
                         || extensionName == ".mp4")
                        {
                            if (path == "") path = itemName;
                            // Add danh sach Mefia vao ListView
                        }
                    }
                }
                xMediaPlayer.Source = new Uri(path, UriKind.RelativeOrAbsolute);
                this.Title = "Video Player - " + videoName;
                xMediaPlayer.Play();
            }
        }
        System.Windows.Threading.DispatcherTimer timer;
        private void MediaPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            VolumnSlider.Value = xMediaPlayer.Volume;
            PositionSilder.Maximum = xMediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
            StartValue.Text = xMediaPlayer.NaturalDuration.TimeSpan.ToString();
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!isDrag)
                {
                    PositionSilder.Value = xMediaPlayer.Position.TotalSeconds;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void VolumnSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            xMediaPlayer.Volume = VolumnSlider.Value;
            VolumnSlider.ToolTip = xMediaPlayer.Volume.ToString();
            string imagePath = "Resources/loudspeaker-on.png";
            if (VolumnSlider.Value == 0)
            {
                imagePath = "Resources/loudspeaker-off.png";
                hasSpeaker = false;
                loudSpeaker.ToolTip = "Off";
            }
            else
            {
                hasSpeaker = true;
                loudSpeaker.ToolTip = "On";
            }
            loudSpeaker.Source = GetBitmapImage(imagePath);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                PositionSilder.Minimum = 0;
                xMediaPlayer.Volume = 0.5;
                VolumnSlider.Value = 0.5;
                VolumnSlider.Maximum = 1;
                string videoName = "big_buck_bunny";
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
        
        private void PositionSilder_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan timeSpan = new TimeSpan(0, 0, Convert.ToInt32(PositionSilder.Value));
            EndValue.Text = timeSpan.ToString();
        }

        bool isDrag = false;
        private void PositionSilder_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            isDrag = false;
            TimeSpan timeSpan = new TimeSpan(0, 0, Convert.ToInt32(PositionSilder.Value));
            xMediaPlayer.Position = timeSpan;
            
        }

        private void PositionSilder_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            isDrag = true;
        }

        private void MediaPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            try
            {
                TimeSpan timeSpan = new TimeSpan(0, 0, 0);
                xMediaPlayer.Position = timeSpan;
                string imagePath = "Resources/play.png";
                if (!hasReplay)
                {
                    xMediaPlayer.Stop();
                    imagePlay.ToolTip = "Play";
                }
                else
                {
                    imagePlay.ToolTip = "Stop";
                    imagePath = "Resources/pause.png";
                }
                imagePlay.Source = GetBitmapImage(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReplayVideo_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                hasReplay = !hasReplay;
                string imagePath = "Resources/autoreplay.png";
                if (!hasReplay)
                {
                    imagePath = "Resources/notautoreplay.png";
                }

                ReplayVideo.Source = GetBitmapImage(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loudSpeaker_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string imagePath = "Resources/loudspeaker-on.png";
                hasSpeaker = !hasSpeaker;
                if (hasSpeaker)
                {
                    xMediaPlayer.IsMuted = false;
                    imagePath = "Resources/loudspeaker-on.png";
                    loudSpeaker.ToolTip = "On";
                    VolumnSlider.Value = 0;
                }
                else
                {
                    xMediaPlayer.IsMuted = true;
                    imagePath = "Resources/loudspeaker-off.png";
                    loudSpeaker.ToolTip = "Off";
                    VolumnSlider.Value = 0.5;
                }

                loudSpeaker.Source = GetBitmapImage(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FullScreen_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void MoveFirst_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TimeSpan timeSpan = new TimeSpan(0, 0, 0);
            xMediaPlayer.Position = timeSpan;
        }

        private void MoveLast_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            xMediaPlayer.Position = xMediaPlayer.NaturalDuration.TimeSpan;
        }

        
    }
}