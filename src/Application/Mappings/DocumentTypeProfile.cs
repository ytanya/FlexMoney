using AutoMapper;
using FlexMoney.Application.Features.DocumentTypes.Commands.AddEdit;
using FlexMoney.Application.Features.DocumentTypes.Queries.GetAll;
using FlexMoney.Application.Features.DocumentTypes.Queries.GetById;
using FlexMoney.Domain.Entities.Misc;

namespace FlexMoney.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}