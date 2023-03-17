using AutoMapper;
using FlexMoney.Application.Requests.Identity;
using FlexMoney.Application.Responses.Identity;

namespace FlexMoney.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}