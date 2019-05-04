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
using System.Data.SqlClient;
using System.Data;
namespace WpfAppControlToControl
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
            ERPEntities context = new ERPEntities();
            listBox1.ItemsSource = context.StateAbbreviations.ToList();
        }

        private void listBox1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Step1
            ListBox listBox = e.Source as ListBox;
            object data = GetDataObject(listBox, e.GetPosition(listBox));
            if (data != null)
            {
                //Step2
                DataObject dataObject = new DataObject("XOKR", data);
                //Step3
                DragDrop.DoDragDrop(listBox, dataObject, DragDropEffects.Move);
            }
        }

        private object GetDataObject(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == source)
                    {
                        return null;
                    }
                }
                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }
            return null;
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("XOKR"))
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void listBox2_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("XOKR"))
            {
                StateAbbreviation state = e.Data.GetData("XOKR") as StateAbbreviation;
                ListBox listBox = e.Source as ListBox;
                if(!listBox.Items.Contains(state))
                    listBox.Items.Add(state);
            }
        }
    }
}
