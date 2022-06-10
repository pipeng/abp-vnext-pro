using AutoMapper;
using Lion.AbpPro.Users.Dtos;
using Volo.Abp.Identity;

namespace Lion.AbpPro.Users.Mappers
{
    public class UserApplicationAutoMapperProfile : Profile
    {
        public UserApplicationAutoMapperProfile()
        {
            CreateMap<IdentityUser, LoginOutput>();
        }
    }
}