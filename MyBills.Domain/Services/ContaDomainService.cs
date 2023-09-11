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

        public void Update(Conta model)
        {
            _unitOfWork.ContaRepository.Update(model);
            _unitOfWork.SaveChanges();
        }

        public void Delete(Conta model)
        {
            _unitOfWork.ContaRepository.Delete(model);
            _unitOfWork.SaveChanges();
        }

        public List<Conta> GetAll()
            => _unitOfWork.ContaRepository.GetAll();

        public Conta GetById(Guid id)
            => _unitOfWork.ContaRepository.GetById(id);

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
