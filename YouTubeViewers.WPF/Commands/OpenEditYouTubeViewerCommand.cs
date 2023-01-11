using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.WPF.Models;
using YouTubeViewers.WPF.Stores;
using YouTubeViewers.WPF.ViewModels;

namespace YouTubeViewers.WPF.Commands
{
    public class OpenEditYouTubeViewerCommand : CommandBase
    {
        private readonly ModalNavigationStore? _modalNavigationStore;
        private readonly YouTubeViewer _youTubeViewer;

        public OpenEditYouTubeViewerCommand(YouTubeViewer youTubeViewer,  ModalNavigationStore? modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
            _youTubeViewer = youTubeViewer;
        }

        public override void Execute(object? parameter)
        {
            EditYouTubeViewerViewModel editYouTubeViewerViewModel = new EditYouTubeViewerViewModel(_youTubeViewer, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editYouTubeViewerViewModel;
        }
    }
}
