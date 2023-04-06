using FlexMoney.Application.Specifications.Base;
using FlexMoney.Domain.Entities.Catalog;

namespace FlexMoney.Application.Specifications.Report
{
    public class AllMemberReportSpecification : HeroSpecification<Member>
    {
        public AllMemberReportSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Name.Contains(searchString);
            }
        }
    }
}