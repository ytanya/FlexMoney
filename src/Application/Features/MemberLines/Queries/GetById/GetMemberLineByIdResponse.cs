using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.MemberLines.Queries.GetById
{
    public class GetMemberLineByIdResponse
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int LineId { get; set; }
        public int Position { get; set; }
    }
}
