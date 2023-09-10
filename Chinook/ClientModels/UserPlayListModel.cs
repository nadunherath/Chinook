using Chinook.Models;

namespace Chinook.ClientModels
{
    public class UserPlayListModel
    {
        public string UserId { get; set; }
        public long PlaylistId { get; set; }
        public ChinookUser User { get; set; }
        public PlayListViewModel Playlist { get; set; }
    }
}
