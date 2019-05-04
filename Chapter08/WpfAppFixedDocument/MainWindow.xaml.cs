using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using Microsoft.Office.Interop.Word;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Xps.Packaging;
 
 
namespace WpfAppFixedDocument
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonDisplay_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "XPS files |*.xps|Word files |*.doc;*.docx|Text files |*.txt;*.log";
            
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            Nullable<bool> result = openFileDialog.ShowDialog();
    
            if (result == true)
            {
                string fileName = openFileDialog.FileName;
                string extention = System.IO.Path.GetExtension(fileName);
                switch (extention.ToLower())
                {
                    case ".xps":
                        ShowXpsDocument(fileName);
                        
                        break;
                    case ".txt":
                        ShowTextDocument(fileName);
                        break;
                    case ".log":
                        ShowLogDocument(fileName);
                        break;
                    case ".doc":
                    case ".docx":
                        ShowWordDocument(fileName);
                        break;
                }
            }
        }

        private void ShowWordDocument(string fileName)
        {
            string path = System.IO.Path.GetDirectoryName(fileName);
            string name = System.IO.Path.GetFileNameWithoutExtension(fileName);
            documentViewer .Document =
              ConvertWordToXps(fileName, System.IO.Path.GetDirectoryName(fileName) + name +"-1.xps").GetFixedDocumentSequence();
        }

        private void ShowXpsDocument(string fileName )
        {
             XpsDocument xpsDocument = new XpsDocument(fileName, System.IO.FileAccess.Read);
             documentViewer.Document = xpsDocument.GetFixedDocumentSequence();
        }
        private void ShowTextDocument(string fileName)
        {
            FixedDocument fixedDocument = new FixedDocument();
             
            fixedDocument.DocumentPaginator.PageSize = new Size(900, 1200);
            string content = GetTextContent(fileName);

            PageContent pageContent = new PageContent();
            FixedPage fixedPage = new FixedPage();
            TextBlock textBlock = new TextBlock();
            fixedPage.Width = fixedDocument.DocumentPaginator.PageSize.Width - 50;
            fixedPage.Height = fixedDocument.DocumentPaginator.PageSize.Height;

            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.Width = fixedPage.Width - 100;
            
            textBlock.Margin = new Thickness(50);

            textBlock.Text = content;
            fixedPage.Children.Add(textBlock);
            ((System.Windows.Markup.IAddChild)pageContent).AddChild(fixedPage);
            fixedDocument.Pages.Add(pageContent);
            documentViewer.Document = fixedDocument;
        }
        private void ShowLogDocument(string fileName)
        {
            FixedDocument fixedDocument = new FixedDocument();

            fixedDocument.DocumentPaginator.PageSize = new Size(900, 1200);
            List<string> content = GetLogContent(fileName);
            for (int i = 0; i < content.Count(); i++)
            {
                PageContent pageContent = new PageContent();
                FixedPage fixedPage = new FixedPage();
                TextBlock textBlock = new TextBlock();
                fixedPage.Width = fixedDocument.DocumentPaginator.PageSize.Width - 50;
                fixedPage.Height = fixedDocument.DocumentPaginator.PageSize.Height;

                textBlock.TextWrapping = TextWrapping.Wrap;
                textBlock.Width = fixedPage.Width - 100;

                textBlock.Margin = new Thickness(50);

                textBlock.Text = content[i];
                fixedPage.Children.Add(textBlock);
                ((System.Windows.Markup.IAddChild)pageContent).AddChild(fixedPage);
                fixedDocument.Pages.Add(pageContent);
            }
            documentViewer.Document = fixedDocument;

        }
        private string GetTextContent(string filePath)
        {
            string content = "";
            try
            {

                content = System.IO.File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                content = ex.Message;
            }
            return content;
        }
        private List<string> GetLogContent(string filePath)
        {
            List<string> content = new List<string>();
            try
            {
                int i = 0;
                System.IO.StreamReader reader = new System.IO.StreamReader(filePath);
                
                string lines = "";
                string line = reader.ReadLine();
                while (line !=null)
                {
                    i++;
                    if (i == 45)
                    {
                        content.Add(lines);
                        lines = "";
                        i = 0;
                    }
                    else
                        lines += line + "\r\n";
                    line = reader.ReadLine() ;
                }
                if (i> 0)
                {
                    content.Add(lines);
                }
                }
            catch (Exception ex)
            {
                content.Add(ex.Message);
            }
            return content;
        }
        private XpsDocument ConvertWordToXps(string wordFileName, string xpsDocumentName)
        {
            object paramMissing = Type.Missing;

            Microsoft.Office.Interop.Word.Application
            wordApplication = new Microsoft.Office.Interop.Word.Application();
            wordApplication.Documents.Add(wordFileName);
            Document doc = wordApplication.ActiveDocument;
            doc.PageSetup.PaperSize = WdPaperSize.wdPaperA4;

            try
            {
                //Save as to XPS
                doc.SaveAs(xpsDocumentName, WdSaveFormat.wdFormatXPS);
                wordApplication = null;
                XpsDocument xpsDoc = new XpsDocument(xpsDocumentName, System.IO.FileAccess.Read);
                return xpsDoc;
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;

            }
            return null;
        }
    }
}
