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

namespace FlexMoney.Application.Features.MemberLines.Commands.AddEdit
{
    public partial class AddEditMemberLineCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public int MemberId { get; set; }
        [Required]
        public int LineId { get; set; }
        [Required]
        public int Position { get; set; }
    }
    internal class AddEditMemberLineCommandHandler : IRequestHandler<AddEditMemberLineCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditMemberLineCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public AddEditMemberLineCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<AddEditMemberLineCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditMemberLineCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var memberLine = _mapper.Map<MemberLine>(command);
                await _unitOfWork.Repository<MemberLine>().AddAsync(memberLine);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMemberLinesCacheKey);
                return await Result<int>.SuccessAsync(memberLine.Id, _localizer["Member Line Saved"]);
            }
            else
            {
                var memberLine = await _unitOfWork.Repository<MemberLine>().GetByIdAsync(command.Id);
                if (memberLine != null)
                {
                    memberLine.MemberId = command.MemberId;
                    memberLine.LineId = command.LineId;
                    await _unitOfWork.Repository<MemberLine>().UpdateAsync(memberLine);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllMemberLinesCacheKey);
                    return await Result<int>.SuccessAsync(memberLine.Id, _localizer["Member Line Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Member Line Not Found!"]);
                }
            }
        }
    }
}
