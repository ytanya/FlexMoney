using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Routes
{
    public static class ReportsEndpoints
    {
        public static string GetAll = "api/v1/reports/all";
        public static string GetById(int id)
        {
            return $"api/v1/reports/{id}";
        }
        public static string GetByOwnerId(int id)
        {
            return $"api/v1/reports/thankmoney/{id}";
        }
    }
}
