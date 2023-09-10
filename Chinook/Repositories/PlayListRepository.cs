using AutoMapper;
using Chinook.ClientModels;
using Chinook.Interfaces;
using Chinook.Models;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Repositories
{
    public class PlayListRepository : IPlayListRepository
    {
        private readonly ChinookContext _context;
        private readonly IMapper _mapper;

        public PlayListRepository(ChinookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<List<PlayListViewModel>> GetPlayListAsync()
        {
            var playLists = await _context.Playlists.ToListAsync();
            var playListViewModels = _mapper.Map<List<PlayListViewModel>>(playLists);
            return playListViewModels;
        }

        public async void AddPlayListAsync(PlayListViewModel playListViewModel)
        {
            var playList = _mapper.Map<Playlist>(playListViewModel);
            _context.Playlists.Add(playList);
            await _context.SaveChangesAsync();
        }
    }
}
