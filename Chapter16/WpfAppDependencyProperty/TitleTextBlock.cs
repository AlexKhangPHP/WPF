using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace WpfAppDependencyProperty
{
    public partial class TitleTextBlock : TextBlock
    {
        public TitleTextBlock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TitleTextBlock), new
               FrameworkPropertyMetadata(typeof(TitleTextBlock)));
        }
        public static readonly DependencyProperty SetTextProperty =
            DependencyProperty.Register(
            "SetText", typeof(string),
            typeof(TitleTextBlock)
        );
        public string SetText
        {
            get { return (string)GetValue(SetTextProperty); }
            set { SetValue(SetTextProperty,  Text = value); }
        }
 
    }
}
