using FlexMoney.Application.Features.Transactions.Commands.AddEdit;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Validators.Features.Transactions.Commands.AddEdit
{
    public class AddEditTransactionCommandValidator : AbstractValidator<AddEditTransactionCommand>
    {
        public AddEditTransactionCommandValidator(IStringLocalizer<AddEditTransactionCommandValidator> localizer)
        {
            RuleFor(request => request.LineId)
                .GreaterThan(0).WithMessage(x => localizer["Line is required!"]);
            RuleFor(request => request.CallerId)
                .GreaterThan(0).WithMessage(x => localizer["Caller is required!"]);
            RuleFor(request => request.Section)
                    .GreaterThan(0).WithMessage(x => localizer["Section must be greater than 0"]);
        }
    }
}
