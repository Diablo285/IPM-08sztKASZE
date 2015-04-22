using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Core.src;
using Core.src.Utils;

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

            _viewmodel.LaunchGame += LaunchNewGame;

            _window.DataContext = _viewmodel;
            _window.Show();
        }

        private void LaunchNewGame(object sender, src.InterFaces.IGameApp e)
        {
            GameAppWrapper wrap = (GameAppWrapper)e;
            wrap.Initialize();
        }
    }
}
