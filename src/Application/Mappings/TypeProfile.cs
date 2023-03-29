using AutoMapper;
using FlexMoney.Application.Features.Types.Commands.AddEdit;
using FlexMoney.Application.Features.Types.Queries.GetById;
using FlexMoney.Application.Features.Types.Queries.GetAll;

namespace FlexMoney.Application.Mappings
{
    public class TypeProfile : Profile
    {
        public TypeProfile()
        {
            CreateMap<GetAllTypesResponse, Domain.Entities.Catalog.Type>().ReverseMap();
            CreateMap<GetTypeByIdResponse, Domain.Entities.Catalog.Type>().ReverseMap();
            CreateMap<AddEditTypeCommand, Domain.Entities.Catalog.Type>().ReverseMap();
        }
    }
}
