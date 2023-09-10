using Chinook.Models;

namespace Chinook.ClientModels
{
    public class GenreViewModel
    {
        public GenreViewModel()
        {
            Tracks = new List<TrackViewModel>();
        }

        public long GenreId { get; set; }
        public string? Name { get; set; }

        public  List<TrackViewModel> Tracks { get; set; }
    }
}
