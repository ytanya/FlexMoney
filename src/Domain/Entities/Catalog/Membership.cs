using FlexMoney.Domain.Contracts;

namespace FlexMoney.Domain.Entities.Catalog
{
    public class Membership : AuditableEntity<int>
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string Note { get; set; }
    }
}