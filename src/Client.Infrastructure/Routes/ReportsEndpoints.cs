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
        public static string ExportFiltered(string searchString)
        {
            return $"{Export}?searchString={searchString}";
        }
        public static string Export = "api/v1/reports/all/export";
        public static string ExportById(int id)
        {
            return $"api/v1/reports/{id}/export";
        }
        public static string ExportThankMoney(int id)
        {
            return $"api/v1/reports/thankmoney/{id}/export";
        }
    }
}
