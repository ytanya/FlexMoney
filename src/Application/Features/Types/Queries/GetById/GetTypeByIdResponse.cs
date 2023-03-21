using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Types.Queries.GetById
{
    public class GetTypeByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
    }
}
