using Chinook.ClientModels;

namespace Chinook.Interfaces
{
    public interface ITrackRepository
    {
        Task<List<TrackViewModel>> GetTracksByArtistId(long artistId);
    }
}
