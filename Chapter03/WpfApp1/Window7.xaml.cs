﻿using System;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string folder in System.IO.Directory.GetDirectories(@"D:\NewBookProject\ITBOOKS\"))
            {
                listBoxDirectory.Items.Add(folder);
            }
        }

        private void menuCopy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuCut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Bluetooth_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Documents_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
