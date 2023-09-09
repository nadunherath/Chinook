using AutoMapper;

namespace Chinook
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Models.Playlist, ClientModels.Playlist>();
            CreateMap<Models.Playlist, ClientModels.Playlist>().ReverseMap();
        }
    }
}
