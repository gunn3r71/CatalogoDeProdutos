using Catalogo.Domain.Entities;
using Catalogo.Domain.Repositories;
using Catalogo.Domain.Services;

namespace Catalogo.Services
{
    public abstract class Service<T> : IService<T> where T : EntityBase
    {
        protected readonly IUnitOfWork _unitOfWork;

        public Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
