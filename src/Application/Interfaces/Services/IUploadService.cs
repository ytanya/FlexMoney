using FlexMoney.Application.Requests;

namespace FlexMoney.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}