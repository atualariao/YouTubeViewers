using Microsoft.EntityFrameworkCore;
using System.Windows;
using YouTubeViewers.Domain.Commands;
using YouTubeViewers.Domain.Queries;
using YouTubeViewers.EntityFrameworrk;
using YouTubeViewers.EntityFrameworrk.Commands;
using YouTubeViewers.EntityFrameworrk.Queries;
using YouTubeViewers.WPF.Stores;
using YouTubeViewers.WPF.ViewModels;

namespace YouTubeViewers.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly YouTubeViewersDbContextFactory _youTubeViewersDbContextFactory;

        private readonly IGetAllYouTubeViewersQuery? _getAllYouTubeViewerQuery;
        private readonly ICreateYouTubeViewerCommand? _createYouTubeViewerCommand;
        private readonly IUpdateYouTubeViewerCommand? _updateYouTubeViewerCommand;
        private readonly IDeleteYouTubeViewerCommand? _deleteYouTubeViewerCommand;

        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly YouTubeViewersStore _youTubeViewersStore;
        private readonly SelectedYouTubeViewerStore? _selectedYouTubeViewerStore;

        public App()
        {
            string connectionString = "Data Source=YouTubeViewers.db";

            _modalNavigationStore = new ModalNavigationStore();
            _youTubeViewersDbContextFactory = new YouTubeViewersDbContextFactory(
                new DbContextOptionsBuilder().UseSqlite(connectionString).Options);
            _getAllYouTubeViewerQuery = new GetAllYouTubeViewersQuery(_youTubeViewersDbContextFactory);
            _createYouTubeViewerCommand = new CreateYouTubeViewerCommand(_youTubeViewersDbContextFactory);
            _updateYouTubeViewerCommand = new UpdateYouTubeViewerCommand(_youTubeViewersDbContextFactory);
            _deleteYouTubeViewerCommand = new DeleteYouTubeViewerCommand(_youTubeViewersDbContextFactory);
            _youTubeViewersStore = new YouTubeViewersStore(
                _getAllYouTubeViewerQuery,
                _createYouTubeViewerCommand,
                _updateYouTubeViewerCommand,
                _deleteYouTubeViewerCommand);
            _selectedYouTubeViewerStore = new SelectedYouTubeViewerStore(_youTubeViewersStore);
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            using (YouTubeViewersDbContext context = _youTubeViewersDbContextFactory.Create())
            {
                context.Database.Migrate();
            };

            YouTubeViewersViewModel youTubeViewersViewModel = new YouTubeViewersViewModel(
                _youTubeViewersStore,
                _selectedYouTubeViewerStore,
                _modalNavigationStore);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, youTubeViewersViewModel)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
