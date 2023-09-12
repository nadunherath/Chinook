using Chinook.ClientModels;

namespace Chinook.Interfaces
{
    public interface IChinookApi
    {
        Task<List<ArtistViewModel>> GetArtistsAsync();

    }
}
