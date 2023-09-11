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

        public async Task<List<ArtistViewModel>> GetArtistsAsync(string searchText = "")
        {
            try
            {
                var artists = await _context.Artists.Where( x => searchText == "" || x.Name.Contains(searchText)).Include(x => x.Albums).ToListAsync();
                var artitstViewModels = _mapper.Map<List<ArtistViewModel>>(artists);
                return artitstViewModels;
            }
            catch (Exception ex)
            {
               //show error message
            }
            return new List<ArtistViewModel>();
        }

        public async Task<ArtistViewModel> GetArtistById(long artistId)
        {
            try
            {
                var artist = await _context.Artists.Include(x => x.Albums).FirstOrDefaultAsync(x => x.ArtistId == artistId);
                var artistViewModel = _mapper.Map<ArtistViewModel>(artist);
                return artistViewModel;
            }
            catch (Exception ex)
            {
                //show error message
            }
            return new ArtistViewModel();
        }

    }
}
