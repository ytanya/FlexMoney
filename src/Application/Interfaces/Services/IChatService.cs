using FlexMoney.Application.Responses.Identity;
using FlexMoney.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlexMoney.Application.Interfaces.Chat;
using FlexMoney.Application.Models.Chat;

namespace FlexMoney.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}