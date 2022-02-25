using Evernote.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Evernote
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            LoadLoader();
        }

        //Load the loader
        private static void LoadLoader()
        {
            Loader loader = new Loader();
            loader.Show();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Thread.Sleep(2500);
            stopwatch.Stop();

            loader.Hide();
        }
    }
}
