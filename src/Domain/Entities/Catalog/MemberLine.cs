﻿using FlexMoney.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Domain.Entities.Catalog
{
    public class MemberLine : AuditableEntity<int>
    {
        public int MemberId { get; set; }
        public int LineId { get; set; }
        public int Position { get; set; }
        public int DeadSection { get; set; }
    }
}
