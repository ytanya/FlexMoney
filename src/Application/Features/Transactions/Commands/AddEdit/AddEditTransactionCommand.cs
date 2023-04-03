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
        public int Position { get; set; }
        public int Quantity { get; set; }
        public string TypeName { get; set; }
        public decimal Money { get; set; }
        public string LineName { get; set; }
        public string Caller { get; set; }
    }
    internal class AddEditTransactionCommandHandler : IRequestHandler<AddEditTransactionCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditTransactionCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly ITransactionRepository _transactionRepository;

        public AddEditTransactionCommandHandler(ITransactionRepository transactionRepository, IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<AddEditTransactionCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
            _transactionRepository = transactionRepository;
        }

        public async Task<Result<int>> Handle(AddEditTransactionCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var transactionId = await _transactionRepository.AddTransactionAsync(command);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllTransactionsCacheKey);
                return await Result<int>.SuccessAsync(transactionId, _localizer["Transaction Saved"]);
            }
            else
            {
                var transaction = await _unitOfWork.Repository<Transaction>().GetByIdAsync(command.Id);
                if (transaction != null)
                {
                    var transactionId = await _transactionRepository.UpdateTransactionAsync(command);
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
