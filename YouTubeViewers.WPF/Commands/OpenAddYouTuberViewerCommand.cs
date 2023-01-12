using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.WPF.Stores;
using YouTubeViewers.WPF.ViewModels;
using YouTubeViewers.WPF.Views;

namespace YouTubeViewers.WPF.Commands
{
    public class OpenAddYouTuberViewerCommand : CommandBase
    {
        private readonly YouTubeViewersStore _youTubeViewersStore;
        private readonly ModalNavigationStore? _modalNavigationStore;

        public OpenAddYouTuberViewerCommand(YouTubeViewersStore youTubeViewersStore, ModalNavigationStore? modalNavigationStore)
        {
            _youTubeViewersStore = youTubeViewersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            AddYouTubeViewerViewModel addYouTubeViewerViewModel = new AddYouTubeViewerViewModel(_youTubeViewersStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = addYouTubeViewerViewModel;
        }
    }
}
