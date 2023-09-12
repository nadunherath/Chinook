using AutoMapper;
using Chinook.ClientModels;
using Chinook.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Repositories
{
    public class TrackRepository : ITrackRepository
    {
        private readonly ChinookContext _context;
        private readonly IMapper _mapper;

        public TrackRepository(ChinookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<List<TrackViewModel>> GetTracksByArtistId(long artistId)
        {
            try
            {
                var tracks = await _context.Tracks.Include(x => x.Album.Artist).Where(x => x.Album.ArtistId == artistId).ToListAsync();
                var trackViewModels = _mapper.Map<List<TrackViewModel>>(tracks);
                return trackViewModels;
            }
            catch (Exception ex)
            {
                //show error message
            }
            return new List<TrackViewModel>();
        }
    }
}
