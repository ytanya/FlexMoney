using FlexMoney.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Domain.Entities.Catalog
{
    public class Status : AuditableEntity<int>
    {
        public string LineStatus { get; set; }
    }
}
