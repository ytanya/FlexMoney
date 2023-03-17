﻿using FlexMoney.Application.Specifications.Base;
using FlexMoney.Domain.Entities.Misc;

namespace FlexMoney.Application.Specifications.Misc
{
    public class DocumentTypeFilterSpecification : HeroSpecification<DocumentType>
    {
        public DocumentTypeFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Name.Contains(searchString) || p.Description.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}