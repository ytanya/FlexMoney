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
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        public Decimal Money { get; set; }
        public int Quantity { get; set; }
        public int OwnerId { get; set; }
        public int StatusId { get; set; }
        public string OwnerName { get; set; }
        public int CurrentSection { get; set; }
    }
}
