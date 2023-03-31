using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Transactions.Queries.GetById
{
    public class GetReadyCallerByLineIdResponse
    {
        public int Id {  get; set; }
        public string MemberName { get; set; }
        public int Position { get; set; }
    }
}
