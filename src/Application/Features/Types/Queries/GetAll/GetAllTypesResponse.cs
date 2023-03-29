using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.Types.Queries.GetAll
{
    public class GetAllTypesResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
    }
}
