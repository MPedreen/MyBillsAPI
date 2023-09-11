using MyBills.Domain.Interfaces.Repositories;
using MyBills.Domain.Interfaces.Services;
using MyBills.Domain.Models;

namespace MyBills.Domain.Services
{
    public class ContaDomainService : IContaDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContaDomainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Conta model)
        {
            _unitOfWork.ContaRepository.Add(model);
            _unitOfWork.SaveChanges();
        }

        public void Delete(Conta model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Conta> GetAll()
        {
            throw new NotImplementedException();
        }

        public Conta GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Conta model)
        {
            throw new NotImplementedException();
        }
    }
}
