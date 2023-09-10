namespace Chinook.ClientModels;

public class PlayListViewModel
{

    
    public PlayListViewModel()
    {
        UserPlayLists = new List<UserPlayListModel>();
        Tracks = new List<TrackViewModel>();
    }

    public long PlaylistId { get; set; }
    public string? Name { get; set; }

    public  List<TrackViewModel> Tracks { get; set; }
    public List<UserPlayListModel> UserPlayLists { get; set; }

    public bool IsFavourite { get; set; }
}