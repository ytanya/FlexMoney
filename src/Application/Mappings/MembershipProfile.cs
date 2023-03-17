using AutoMapper;
using FlexMoney.Application.Features.Memberships.Commands.AddEdit;
using FlexMoney.Application.Features.Memberships.Queries.GetAll;
using FlexMoney.Application.Features.Memberships.Queries.GetById;
using FlexMoney.Domain.Entities.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Mappings
{
    public class MembershipProfile : Profile
    {
        public MembershipProfile()
        {
            CreateMap<AddEditMembershipCommand, Membership>().ReverseMap();
            CreateMap<GetMembershipByIdResponse, Membership>().ReverseMap();
            CreateMap<GetAllMembershipsResponse, Membership>().ReverseMap();
        }
    }
}
