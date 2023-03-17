using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Domain.Entities.Misc;

namespace FlexMoney.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}