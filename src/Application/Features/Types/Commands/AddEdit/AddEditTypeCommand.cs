using AutoMapper;
using FlexMoney.Application.Interfaces.Repositories;
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

namespace FlexMoney.Application.Features.Types.Commands.AddEdit
{
    public partial class AddEditTypeCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Note { get; set; }
    }
    internal class AddEditTypeCommandHandler : IRequestHandler<AddEditTypeCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditTypeCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly ITypeRepository _typeRepository;

        public AddEditTypeCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, ITypeRepository typeRepository, IStringLocalizer<AddEditTypeCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
            _typeRepository = typeRepository;
        }

        public async Task<Result<int>> Handle(AddEditTypeCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var isNameUnique = await _typeRepository.IsNameUnique(command.Name);
                if (!isNameUnique)
                {
                    var type = _mapper.Map<Domain.Entities.Catalog.Type>(command);
                    await _unitOfWork.Repository<Domain.Entities.Catalog.Type>().AddAsync(type);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllTypesCacheKey);
                    return await Result<int>.SuccessAsync(type.Id, _localizer["Type Saved"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Type Name Is Existed!"]);
                }
            }
            else
            {
                var type = await _unitOfWork.Repository<Domain.Entities.Catalog.Type>().GetByIdAsync(command.Id);
                if (type != null)
                {
                    type.Name = command.Name ?? type.Name;
                    type.Note = command.Note ?? type.Note;
                    await _unitOfWork.Repository<Domain.Entities.Catalog.Type>().UpdateAsync(type);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllTypesCacheKey);
                    return await Result<int>.SuccessAsync(type.Id, _localizer["Type Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Type Not Found!"]);
                }
            }

        }
    }
}
