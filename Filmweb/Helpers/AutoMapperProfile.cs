using AutoMapper;
using Filmweb.Dtos;
using Filmweb.Entities;

namespace Filmweb.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
