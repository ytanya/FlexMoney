using AutoMapper;
using FlexMoney.Application.Features.Transactions.Commands.AddEdit;
using FlexMoney.Application.Features.Transactions.Queries.GetAll;
using FlexMoney.Application.Features.Transactions.Queries.GetById;
using FlexMoney.Domain.Entities.Catalog;

namespace FlexMoney.Application.Mappings
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<AddEditTransactionCommand, Transaction>().ReverseMap();
            CreateMap<GetTransactionByIdResponse, Transaction>().ReverseMap();
            CreateMap<GetAllTransactionsResponse, Transaction>().ReverseMap();
            CreateMap<GetTransactionByLineIdResponse, Transaction>().ReverseMap();
            CreateMap<GetTransactionByLineIdResponse, Transaction>().ReverseMap();
        }
    }
}
