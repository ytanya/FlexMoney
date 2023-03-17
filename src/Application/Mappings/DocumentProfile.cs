using AutoMapper;
using FlexMoney.Application.Features.Documents.Commands.AddEdit;
using FlexMoney.Application.Features.Documents.Queries.GetById;
using FlexMoney.Domain.Entities.Misc;

namespace FlexMoney.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}