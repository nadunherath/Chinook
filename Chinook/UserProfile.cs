using AutoMapper;

namespace Chinook
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Models.Playlist, ClientModels.PlayListViewModel>();
            CreateMap<Models.Playlist, ClientModels.PlayListViewModel>().ReverseMap();
            CreateMap<Models.Album, ClientModels.AlbumViewModel>();
            CreateMap<Models.Album, ClientModels.AlbumViewModel>().ReverseMap();
            //CreateMap<Models.Artist, ClientModels.ArtistViewModel>();
            //CreateMap<Models.Artist, ClientModels.ArtistViewModel>().ReverseMap();
            CreateMap<Models.Artist, ClientModels.ArtistViewModel>()
                .ForMember(dest => dest.Albums, opt => opt.MapFrom(src => src.Albums));
            CreateMap<Models.Track, ClientModels.TrackViewModel>().
                ForMember(dest => dest.Album,opt=> opt.MapFrom(src => src.Album)).
                ForMember(dest=> dest.Genre,opt => opt.MapFrom(src=> src.Genre)).ReverseMap();
             
        }
    }
}
