using AutoMapper;
using FlexMoney.Application.Features.FlexMoneyTypes.Commands.AddFlexMoneyType;
using FlexMoney.Application.Features.FlexMoneyTypes.Queries.GetByID;
using FlexMoney.Application.Features.FlexMoneyTypes.Queries.GettAll;
using FlexMoney.Domain.Entities.TypeFlexMoney;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Mappings
{
    public class FlexMoneytypesProfile : Profile
    {
        public FlexMoneytypesProfile()
        {
            CreateMap<GetAllFlexMoneyResponse, FlexMoneyType>().ReverseMap();
            CreateMap<GetFlexMoneyTypeByIdResponse, FlexMoneyType>().ReverseMap();
            CreateMap<AddFlexMonryTypeCommand, FlexMoneyType>().ReverseMap();
        }
    }
}
