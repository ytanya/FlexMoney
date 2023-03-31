using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Transactions.Queries.GetById
{
    public class GetTransactionInfoByLineIdResponse
    {
        public string TypeName { get; set; }
        public int CurrentSection { get; set; }
        public Decimal Money { get; set; }
        public Decimal TotalThankMoney { get; set; }
    }
}
