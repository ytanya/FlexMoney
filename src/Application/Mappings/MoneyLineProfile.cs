using AutoMapper;
using FlexMoney.Application.Features.MoneyLines.Commands.AddEdit;
using FlexMoney.Application.Features.MoneyLines.Queries.GetAll;
using FlexMoney.Application.Features.MoneyLines.Queries.GetById;
using FlexMoney.Domain.Entities.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Mappings
{
    public class MoneyLineProfile : Profile
    {
        public MoneyLineProfile()
        {
            CreateMap<AddEditMoneyLineCommand, MoneyLine>().ReverseMap();
            CreateMap<GetMoneyLineByIdResponse, MoneyLine>().ReverseMap();
            CreateMap<GetAllMoneyLinesResponse, MoneyLine>().ReverseMap();
        }
    }
}
