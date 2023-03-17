using FlexMoney.Application.Features.Memberships.Commands.AddEdit;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexMoney.Application.Validators.Features.Memberships.Commands.AddEdit
{
    public class AddEditMembershipCommandValidator : AbstractValidator<AddEditMembershipCommand>
    {
        public AddEditMembershipCommandValidator(IStringLocalizer<AddEditMembershipCommandValidator> localizer)
        {
            RuleFor(request => request.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"]);
        }
    }
}
