using FlexMoney.Application.Features.MoneyLines.Commands.AddEdit;
using FlexMoney.Application.Features.Types.Queries.GetAll;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
