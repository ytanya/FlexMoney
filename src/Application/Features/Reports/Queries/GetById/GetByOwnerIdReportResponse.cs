using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Reports.Queries.GetById
{
    public class GetByOwnerIdReportResponse
    {
        public DateTime CreatedDate { get; set; }
        public string LineName { get; set; }
        public int Quantity { get; set; }
        public int CurrentSection { get; set; }
        public Decimal ThankMoney { get; set; }
    }
}
