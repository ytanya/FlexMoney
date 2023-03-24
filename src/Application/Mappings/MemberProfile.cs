using AutoMapper;
using FlexMoney.Application.Features.Members.Commands.AddEdit;
using FlexMoney.Application.Features.Members.Queries.GetAll;
using FlexMoney.Application.Features.Members.Queries.GetById;
using FlexMoney.Domain.Entities.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Mappings
{
    public class MemberProfile : Profile
    {
        public MemberProfile()
        {
            CreateMap<AddEditMemberCommand, Member>().ReverseMap();
            CreateMap<GetMemberByIdResponse, Member>().ReverseMap();
            CreateMap<GetAllMembersResponse, Member>().ReverseMap();
        }
    }
}
