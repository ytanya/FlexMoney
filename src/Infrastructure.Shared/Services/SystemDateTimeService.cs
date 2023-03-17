using FlexMoney.Application.Interfaces.Services;
using System;

namespace FlexMoney.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}