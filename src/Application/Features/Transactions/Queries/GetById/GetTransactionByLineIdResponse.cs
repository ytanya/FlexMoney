using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Transactions.Queries.GetById
{
    public class GetTransactionByLineIdResponse
    {
        public int Id { get; set; }
        public int LineId { get; set; }
        public int CallerId { get; set; }
        public int Section { get; set; }
        public Decimal ThankMoney { get; set; }
        public int Position { get; set; }
    }
}
