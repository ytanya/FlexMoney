using AutoMapper;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Catalog;
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

namespace FlexMoney.Application.Features.MoneyLines.Commands.AddEdit
{
    public partial class AddEditMoneyLineCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public int TypeId { get; set; }
            [Required]
            public string Name { get; set; }
        [Required]
        public Decimal Money { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Owner { get; set; }
    }
    internal class AddEditMoneyLineCommandHandler : IRequestHandler<AddEditMoneyLineCommand, Result<int>>
    {
        private readonly IMoneyLineRepository _moneyLineRepository;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditMoneyLineCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public AddEditMoneyLineCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<AddEditMoneyLineCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditMoneyLineCommand command, CancellationToken cancellationToken)
        {
            var isNameUnique = await _moneyLineRepository.IsNameUnique(command.Name);
            if (!isNameUnique)
            {
                if (command.Id == 0)
                {
                    var moneyLine = _mapper.Map<MoneyLine>(command);
                    await _unitOfWork.Repository<MoneyLine>().AddAsync(moneyLine);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMoneyLinesCacheKey);
                    return await Result<int>.SuccessAsync(moneyLine.Id, _localizer["Money Line Saved"]);
                }
                else
                {
                    var moneyLine = await _unitOfWork.Repository<MoneyLine>().GetByIdAsync(command.Id);
                    if (moneyLine != null)
                    {
                        moneyLine.Name = command.Name;
                        moneyLine.CreatedDate = command.CreatedDate;
                        moneyLine.TypeId = command.TypeId;
                        moneyLine.Money = command.Money;
                        moneyLine.Quantity = command.Quantity;
                        moneyLine.Owner = command.Owner;
                        await _unitOfWork.Repository<MoneyLine>().UpdateAsync(moneyLine);
                        await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMoneyLinesCacheKey);
                        return await Result<int>.SuccessAsync(moneyLine.Id, _localizer["Money Line Updated"]);
                    }
                    else
                    {
                        return await Result<int>.FailAsync(_localizer["Money Line Not Found!"]);
                    }
                }
            }
            else
            {
                return await Result<int>.FailAsync(_localizer["Money Line Name in use!"]);
            }
        }
    }
}
