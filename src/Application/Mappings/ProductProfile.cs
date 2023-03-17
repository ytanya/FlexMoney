using AutoMapper;
using FlexMoney.Application.Features.Products.Commands.AddEdit;
using FlexMoney.Domain.Entities.Catalog;

namespace FlexMoney.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}