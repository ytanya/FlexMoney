using FlexMoney.Domain.Contracts;
using System;

namespace FlexMoney.Domain.Entities.Catalog
{
    public class Transaction : AuditableEntity<int>
    {
        public DateTime CreatedDate { get; set; }
        public int LineId { get; set; }
        public virtual MoneyLine Line { get; set; }
        public int TypeId { get; set; }
        public int Section { get; set; }
        public int CallerId { get; set; }
        public int Position { get; set; }
        public virtual Member Caller { get; set; }
        public Decimal Pay { get; set; }
        public Decimal Call { get; set; }
        public Decimal Earn { get; set; }
        public Decimal ThankMoney { get; set; }
        public Decimal RealEarn { get; set; }
        public Decimal Dead { get; set; }
        public Decimal Alive { get; set; }
    }
}