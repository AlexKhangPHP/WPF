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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppFlowDocument
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

        private void buttonDisplay_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Text files |*.txt;*.log";

            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            Nullable<bool> result = openFileDialog.ShowDialog();

            if (result == true)
            {
                string fileName = openFileDialog.FileName;
                string extention = System.IO.Path.GetExtension(fileName);
                switch (extention.ToLower())
                {
                     
                    case ".txt":
                    case ".log":
                        ShowTextDocument(fileName);
                        break;
                     
                    
                }
            }

        }
        private void ShowTextDocument(string fileName)
        {
            
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(System.IO.File.ReadAllText(fileName));
            FlowDocument document = new FlowDocument(paragraph);
            documentViewer.Document = document;
        }
         
    }
}
