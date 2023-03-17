using FlexMoney.Application.Requests.Mail;
using System.Threading.Tasks;

namespace FlexMoney.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}