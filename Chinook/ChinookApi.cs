using Chinook.ClientModels;
using Chinook.Interfaces;

namespace Chinook
{
    public class ChinookApi : IChinookApi
    {
        public Task<List<ArtistViewModel>> GetArtistsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
