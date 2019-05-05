using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using System.IO;
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

            //TextBlock textBlockTitle = new TextBlock();
            //textBlockTitle.Text = "Personal Information";
            //textBlockTitle.Margin = new Thickness(28, 15, 0, 0);
            //MainLayout.Children.Add(textBlockTitle);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Item item = new Item();
            item.Id = "A001";
            item.Name = "New York";
            comboBox2.Items.Add(item);
            item = new Item();
            item.Id = "A002";
            item.Name = "Los Angeles";
            comboBox2.Items.Add(item);


            image1.Stretch = Stretch.Fill;
            image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/" + 
                Assembly.GetExecutingAssembly().GetName().Name   
                + ";component/Images/Microsoft.png", UriKind.Absolute));

            MemoryStream ms = new MemoryStream();
            FileStream stream = new FileStream(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Images\surface.jpg", FileMode.Open, FileAccess.Read);

            ms.SetLength(stream.Length);
            stream.Read(ms.GetBuffer(), 0, (int)stream.Length);

           
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.StreamSource = ms;
            src.EndInit();
            image2.Stretch = Stretch.UniformToFill;
            image2.Source = src;

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.ShowDialog();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Window5 window = new Window5();
            window.ShowDialog();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Window4 window = new Window4();
            window.ShowDialog();
        }

        private void buttonPopup_MouseEnter(object sender, MouseEventArgs e)
        {
            myPopup.IsOpen = true;
        }

        private void buttonPopup_MouseLeave(object sender, MouseEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window6 window = new Window6();
            window.ShowDialog();
        }

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.ShowDialog();
        }

        private void buttonContextMenu_Click(object sender, RoutedEventArgs e)
        {
            Window7 window = new Window7();
            window.ShowDialog();
        }

        private void buttonToolBar_Click(object sender, RoutedEventArgs e)
        {
            Window8 window = new Window8();
            window.ShowDialog();
        }
    }

    class Item
    {
        private string id = "";

        internal string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name = "";

        internal string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return name;
        }

    }
}
