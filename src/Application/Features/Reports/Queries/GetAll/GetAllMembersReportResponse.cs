using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Reports.Queries.GetAll
{
    public class GetAllMembersReportResponse
    {
        public string MemberName { get; set; }
        public Decimal Earn { get; set; }
        public Decimal Pay { get; set; }
        public Decimal ThankMoney { get; set; }
        public Decimal Alive { get; set; }
        public Decimal Dead { get; set; }

    }
}
