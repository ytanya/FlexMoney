using FlexMoney.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Domain.Entities.Catalog
{
    public class Type : AuditableEntity<int>
    {
        public string Name { get; set; }
        public string Note { get; set; }
    }
}
