using Microsoft.EntityFrameworkCore;
using MyBills.Domain.Models;
using MyBills.Infra.Data.SqlServer.Configurations;

namespace MyBills.Infra.Data.SqlServer.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContaConfiguration());
        }

        public DbSet<Conta> Contas { get; set; }
    }
}
