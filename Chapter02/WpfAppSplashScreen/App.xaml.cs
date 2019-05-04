using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppSplashScreen
{
    using System.Threading;
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            SplashWelcome screen = new SplashWelcome();
            screen.Show();
            base.OnStartup(e);
            MainWindow main = new MainWindow();
            Thread.Sleep(15000);
            screen.Close();
        }
    }
}
