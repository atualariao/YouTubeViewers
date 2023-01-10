using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.WPF.Models;

namespace YouTubeViewers.WPF.Stores
{
    public class SelectedYouTubeViewerStore
    {
		private YouTubeViewer? _selectedYouTubeViewer;
		public YouTubeViewer SelectedYouTubeViewer
        {
            get
            {
                return _selectedYouTubeViewer;
            }
            set
            {
                _selectedYouTubeViewer = value;
                SelectedYouTubeViewerChanged?.Invoke();
            }
        }

        public event Action? SelectedYouTubeViewerChanged;

    }
}
