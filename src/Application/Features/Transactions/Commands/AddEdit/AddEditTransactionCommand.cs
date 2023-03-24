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

namespace FlexMoney.Application.Features.Transactions.Commands.AddEdit
{
    public partial class AddEditTransactionCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }       
        public DateTime CreatedDate { get; set; }
        [Required]
        public int LineId { get; set; }
        [Required]
        public int TypeId { get; set; }
        [Required]
        public int Section { get; set; }
        [Required]
        public int CallerId { get; set; }
        public Decimal Pay { get; set; }
        public Decimal Call { get; set; }
        public Decimal Earn { get; set; }
        public Decimal ThankMoney { get; set; }
        public Decimal RealEarn { get; set; }
        public Decimal Dead { get; set; }
        public Decimal Alive { get; set; }
    }
    internal class AddEditTransactionCommandHandler : IRequestHandler<AddEditTransactionCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditTransactionCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public AddEditTransactionCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<AddEditTransactionCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditTransactionCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var transaction = _mapper.Map<Transaction>(command);
                await _unitOfWork.Repository<Transaction>().AddAsync(transaction);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllTransactionsCacheKey);
                return await Result<int>.SuccessAsync(transaction.Id, _localizer["Transaction Saved"]);
            }
            else
            {
                var transaction = await _unitOfWork.Repository<Transaction>().GetByIdAsync(command.Id);
                if (transaction != null)
                {
                    transaction.CreatedDate = command.CreatedDate;
                    transaction.LineId = (command.LineId == 0) ? transaction.LineId : command.LineId;
                    transaction.Section = command.Section;
                    transaction.CallerId = (command.CallerId == 0) ? transaction.CallerId : command.CallerId;
                    transaction.Pay = (command.Pay == 0) ? transaction.Pay : command.Pay;
                    transaction.Call = (command.Call == 0) ? transaction.Call : command.Call;
                    transaction.Earn = (command.Earn == 0) ? transaction.Earn : command.Earn;
                    transaction.ThankMoney = (command.ThankMoney == 0) ? transaction.ThankMoney : command.ThankMoney;
                    transaction.RealEarn = (command.RealEarn == 0) ? transaction.RealEarn : command.RealEarn;
                    transaction.Dead = (command.Dead == 0) ? transaction.Dead : command.Dead;
                    transaction.Alive = (command.Alive == 0) ? transaction.Alive : command.Alive;
                    await _unitOfWork.Repository<Transaction>().UpdateAsync(transaction);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllTransactionsCacheKey);
                    return await Result<int>.SuccessAsync(transaction.Id, _localizer["Transaction Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Transaction Not Found!"]);
                }
            }
        }
    }
}
