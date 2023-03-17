using AutoMapper;
using FlexMoney.Infrastructure.Models.Identity;
using FlexMoney.Application.Responses.Identity;

namespace FlexMoney.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}