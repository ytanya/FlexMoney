using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.FlexMoneyTypes.Queries.GetByID
{
    public class GetFlexMoneyTypeByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
    }
}
