using AutoMapper;
using Chinook.ClientModels;
using Chinook.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly ChinookContext _context;
        private readonly IMapper _mapper;

        public ArtistRepository(ChinookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ArtistViewModel>> GetArtistsAsync()
        {
            var artists = await _context.Artists.Include( x => x.Albums).ToListAsync();
            var artitstViewModels = _mapper.Map<List<ArtistViewModel>>(artists);
            return artitstViewModels;
        }

        public async Task<ArtistViewModel> GetArtistById(long artistId)
        {
            var artist = await _context.Artists.Include( x => x.Albums).FirstOrDefaultAsync(x => x.ArtistId == artistId);
            var artistViewModel = _mapper.Map<ArtistViewModel>(artist);
            return artistViewModel;
        }

    }
}
