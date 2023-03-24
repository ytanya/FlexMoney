using AutoMapper;
using FlexMoney.Application.Features.Members.Commands.AddEdit;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
using FlexMoney.Domain.Entities.TypeFlexMoney;
using FlexMoney.Shared.Constants.Application;
using FlexMoney.Shared.Wrapper;
using MediatR;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlexMoney.Application.Features.FlexMoneyTypes.Commands.AddFlexMoneyType
{
    public partial class AddFlexMonryTypeCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Note { get; set; }
    }
    internal class AddFlexMoneyTypeCommandHandler : IRequestHandler<AddFlexMonryTypeCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddFlexMoneyTypeCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public AddFlexMoneyTypeCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<AddFlexMoneyTypeCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddFlexMonryTypeCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var flexMoneyType = _mapper.Map<FlexMoneyType>(command);
                await _unitOfWork.Repository<FlexMoneyType>().AddAsync(flexMoneyType);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMembershipsCacheKey);
                return await Result<int>.SuccessAsync(flexMoneyType.Id, _localizer["Flex Money Type Saved"]);
            }
            else
            {
                var flexMoneyType = await _unitOfWork.Repository<FlexMoneyType>().GetByIdAsync(command.Id);
                if (flexMoneyType != null)
                {
                    flexMoneyType.Name = command.Name ?? flexMoneyType.Name;
                    flexMoneyType.Note = command.Note ?? flexMoneyType.Note;
                    await _unitOfWork.Repository<FlexMoneyType>().UpdateAsync(flexMoneyType);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMembershipsCacheKey);
                    return await Result<int>.SuccessAsync(flexMoneyType.Id, _localizer["Flex Money Type Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Flex Money Type Not Found!"]);
                }
            }
        }
    }
}
