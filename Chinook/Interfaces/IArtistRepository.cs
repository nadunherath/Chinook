using Chinook.ClientModels;

namespace Chinook.Interfaces
{
    public interface IArtistRepository
    {
        Task<List<ArtistViewModel>> GetArtistsAsync();

        Task<ArtistViewModel> GetArtistById(long artistId);
    }
}
