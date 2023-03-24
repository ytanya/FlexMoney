using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Transactions.Queries.GetAll
{
    public class GetAllTransactionsResponse
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LineId { get; set; }
        public string MoneyLine { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
        public int Section { get; set; }
        public int CallerId { get; set; }
        public string Caller { get; set; }
        public Decimal Pay { get; set; }
        public Decimal Call { get; set; }
        public Decimal Earn { get; set; }
        public Decimal ThankMoney { get; set; }
        public Decimal RealEarn { get; set; }
        public Decimal Dead { get; set; }
        public Decimal Alive { get; set; }
    }
}
