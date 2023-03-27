using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.MoneyLines.Queries.GetAll
{
    public class GetAllMoneyLinesResponse
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public Decimal Money { get; set; }
        public int Quantity { get; set; }
        public int Owner { get; set; }
    }
}
