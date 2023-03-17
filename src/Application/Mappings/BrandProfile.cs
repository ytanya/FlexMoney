using AutoMapper;
using FlexMoney.Application.Features.Brands.Commands.AddEdit;
using FlexMoney.Application.Features.Brands.Queries.GetAll;
using FlexMoney.Application.Features.Brands.Queries.GetById;
using FlexMoney.Domain.Entities.Catalog;

namespace FlexMoney.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}