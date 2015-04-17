using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Sample.Wpf.Mvp
{
    public class App : Application
    {
        private MainWindow _window = null;

        //+
        //- #OnStartup -//
        protected override void OnStartup(StartupEventArgs e)
        {
            _window = new MainWindow();
            _window.Show();
            //+
            base.OnStartup(e);
        }

        //- @Main -//
        [STAThread]
        public static void Main(String[] args)
        {
            new App().Run();
        }
    }
}
