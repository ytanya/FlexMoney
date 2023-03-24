using FlexMoney.Application.Features.MoneyLines.Commands.AddEdit;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Validators.Features.MoneyLines.Commands.AddEdit
{
    public class AddEditMoneyLineCommandValidator : AbstractValidator<AddEditMoneyLineCommand>
    {
        public AddEditMoneyLineCommandValidator(IStringLocalizer<AddEditMoneyLineCommandValidator> localizer)
        {
            RuleFor(request => request.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"]);
        }
    }
}
