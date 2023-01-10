using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.ViewModels
{
    public class YouTubeViewersViewModel : ViewModelBase
    {
        public YouTubeViewersListingViewModel? YouTubeViewersListingViewModel { get; }
        public YouTubeViewersDetailsViewModel? YouTubeViewersDetailsViewModel { get; }
        public ICommand? AddYouTubeViewersCommand { get; }

        public YouTubeViewersViewModel(SelectedYouTubeViewerStore _selectedYouTubeViewerStore)
        {
            YouTubeViewersListingViewModel = new YouTubeViewersListingViewModel(_selectedYouTubeViewerStore);
            YouTubeViewersDetailsViewModel = new YouTubeViewersDetailsViewModel(_selectedYouTubeViewerStore);
        }
    }
}
