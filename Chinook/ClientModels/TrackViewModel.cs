using Chinook.Models;

namespace Chinook.ClientModels
{
    public class TrackViewModel
    {
        public TrackViewModel()
        {
            InvoiceLines = new List<InvoiceLineViewModel>();
            Playlists = new List<PlayListViewModel>();
            //IsFavorite = Playlists.W
        }

        public long TrackId { get; set; }
        public string Name { get; set; } = null!;
        public long? AlbumId { get; set; }
        public long MediaTypeId { get; set; }
        public long? GenreId { get; set; }
        public string? Composer { get; set; }
        public long Milliseconds { get; set; }
        public long? Bytes { get; set; }
        public byte[] UnitPrice { get; set; } = null!;

        public Album? Album { get; set; }
        public Genre? Genre { get; set; }
        public MediaType MediaType { get; set; } = null!;
        public List<InvoiceLineViewModel> InvoiceLines { get; set; }

        public List<PlayListViewModel> Playlists { get; set; }

        public bool IsFavorite { get; set; }
    }
}
