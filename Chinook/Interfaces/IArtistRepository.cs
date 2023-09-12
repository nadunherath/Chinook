using Chinook.ClientModels;

namespace Chinook.Interfaces
{
    public interface IArtistRepository
    {
        Task<List<ArtistViewModel>> GetArtistsAsync(string searchText = "");

        Task<ArtistViewModel> GetArtistById(long artistId);


    }
}
