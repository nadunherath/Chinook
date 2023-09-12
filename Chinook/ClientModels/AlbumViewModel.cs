using Chinook.Models;

namespace Chinook.ClientModels
{
    public class AlbumViewModel
    {
        public AlbumViewModel()
        {
            Tracks = new List<TrackViewModel>();
        }

        public long AlbumId { get; set; }
        public string Title { get; set; } = null!;
        public long ArtistId { get; set; }

        public ArtistViewModel Artist { get; set; } = null!;
        public List<TrackViewModel> Tracks{ get; set; }
    }
}
