using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.WPF.Models;

namespace YouTubeViewers.WPF.ViewModels
{
    public class YouTubeViewersListingItemViewModel : ViewModelBase
    {
        public YouTubeViewer YouTubeViewer;

        public string? Username => YouTubeViewer.Username;

        public ICommand? EditCommand { get; }
        public ICommand? Delete { get; }

        public YouTubeViewersListingItemViewModel(YouTubeViewer youTubeViewer, ICommand editCommand)
        {
            YouTubeViewer = youTubeViewer;
            EditCommand = editCommand;
        }
    }

}
