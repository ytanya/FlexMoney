using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Members.Queries.GetById
{
    public class GetMemberByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string Note { get; set; }
        public bool IsDeleted { get; set; }

    }
}
