using AutoMapper;
using FlexMoney.Application.Interfaces.Chat;
using FlexMoney.Application.Models.Chat;
using FlexMoney.Infrastructure.Models.Identity;

namespace FlexMoney.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}