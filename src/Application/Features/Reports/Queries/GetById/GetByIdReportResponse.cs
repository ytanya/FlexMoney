using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Reports.Queries.GetById
{
    public class GetByIdReportResponse
    {
        public DateTime CreatedDate { get; set; }
        public string LineName { get; set; }
        public int CurrentSection { get; set; }
        public Decimal Earn { get; set; }
        public Decimal Pay { get; set; }
    }
}
