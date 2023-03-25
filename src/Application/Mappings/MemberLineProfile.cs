using AutoMapper;
using FlexMoney.Application.Features.MemberLines.Commands.AddEdit;
using FlexMoney.Application.Features.MemberLines.Queries.GetAll;
using FlexMoney.Application.Features.MemberLines.Queries.GetById;
using FlexMoney.Domain.Entities.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Mappings
{
    public class MemberLineProfile : Profile
    {
        public MemberLineProfile()
        {
            CreateMap<AddEditMemberLineCommand, MemberLine>().ReverseMap();
            CreateMap<GetMemberLineByIdResponse, MemberLine>().ReverseMap();
            CreateMap<GetAllMemberLinesResponse, MemberLine>().ReverseMap();
            CreateMap<GetMemberLineByLineIdResponse, MemberLine>().ReverseMap();
            //CreateMap<List<GetMemberLineByIdResponse>, List<MemberLine>>().ReverseMap();
        }
    }
}
