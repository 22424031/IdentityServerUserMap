using AutoMapper;
using UserLoginBE.Entities.Models;
using UserLoginBE.Models;

namespace UserLoginBE.ProfilesMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<District, DistrictDto>().ReverseMap();
            CreateMap<Ward, WardDto>().ReverseMap();
            CreateMap<User, UserRegistrationDto>().ReverseMap();
            CreateMap<User, AdminRegistrationDto>().ReverseMap();
        }
    }
}
