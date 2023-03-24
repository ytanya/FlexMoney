using FlexMoney.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Domain.Entities.Catalog
{
    public class MoneyLine : AuditableEntity<int>
    {
        public DateTime CreatedDate { get; set; }
        public int TypeId { get; set; }
        public virtual Type Type { get; set; }
        public string Name { get; set; }
        public Decimal Money { get; set; }
        public int Quantity { get; set; }
        public int Owner { get; set; }
    }
}
