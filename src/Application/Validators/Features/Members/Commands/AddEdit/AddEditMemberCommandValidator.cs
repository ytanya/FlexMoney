using FlexMoney.Application.Features.Members.Commands.AddEdit;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Validators.Features.Members.Commands.AddEdit
{
    public class AddEditMemberCommandValidator : AbstractValidator<AddEditMemberCommand>
    {
        public AddEditMemberCommandValidator(IStringLocalizer<AddEditMemberCommandValidator> localizer)
        {
            RuleFor(request => request.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"]);
        }
    }
}
