using Chinook.ClientModels;
using Chinook.Models;

namespace Chinook.Interfaces
{
    public interface IPlayListRepository
    {

        Task<List<PlayListViewModel>> GetPlayListAsync();

        void AddPlayListAsync(PlayListViewModel playList);
    }
}
