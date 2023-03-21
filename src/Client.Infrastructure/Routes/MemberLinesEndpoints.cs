using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Routes
{
    public static class MemberLinesEndpoints
    {
        public static string ExportFiltered(string searchString)
        {
            return $"{Export}?searchString={searchString}";
        }

        public static string Export = "api/v1/memberlines/export";

        public static string GetAll = "api/v1/memberlines";
        public static string Delete = "api/v1/memberlines";
        public static string Save = "api/v1/memberlines";
        public static string GetCount = "api/v1/memberlines/count";
    }
}
