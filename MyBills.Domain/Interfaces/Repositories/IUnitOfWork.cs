namespace MyBills.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IContaRepository ContaRepository { get; }

        void SaveChanges();
    }
}
