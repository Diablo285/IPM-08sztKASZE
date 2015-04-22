using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Core.src;

namespace Core
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindow _window;
        private CoreViewModel _viewmodel;

        public App() 
        {
 
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _viewmodel = new CoreViewModel();
            _window = new MainWindow();

            _window.DataContext = _viewmodel;
            _window.Show();
        }
    }
}
