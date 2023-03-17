using AutoMapper;
using FlexMoney.Infrastructure.Models.Audit;
using FlexMoney.Application.Responses.Audit;

namespace FlexMoney.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}