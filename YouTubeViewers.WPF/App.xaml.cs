using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using YouTubeViewers.WPF.Stores;
using YouTubeViewers.WPF.ViewModels;

namespace YouTubeViewers.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedYouTubeViewerStore? _selectedYouTubeViewerStore;

        public App()
        {
            _selectedYouTubeViewerStore = new SelectedYouTubeViewerStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new YouTubeViewersViewModel(_selectedYouTubeViewerStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
