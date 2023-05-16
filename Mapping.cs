using AutoMapper;
using OnDemandCarWash.DTO;
using OnDemandCarWash.Model.cs;

namespace OnDemandCarWash
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<User, user>();
            CreateMap<user, User>();
        }
    }
}
