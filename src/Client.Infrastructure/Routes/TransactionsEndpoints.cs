using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Routes
{
    public static class TransactionsEndpoints
    {
        public static string ExportFiltered(string searchString)
        {
            return $"{Export}?searchString={searchString}";
        }

        public static string GetByLineId(int lineId)
        {
            return $"api/v1/transactions/line/{lineId}";
        }

        public static string GetTransactionInfoByLineId(int lineId)
        {
            return $"api/v1/transactions/transantioninfo/{lineId}";
        }

        public static string GetReadyCallerByLineId(int lineId)
        {
            return $"api/v1/transactions/readycaller/{lineId}";
        }

        public static string Export = "api/v1/transactions/export";

        public static string GetAll = "api/v1/transactions";
        public static string Delete = "api/v1/transactions";
        public static string Save = "api/v1/transactions";
        public static string GetCount = "api/v1/transactions/count";
    }
}
