using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBills.Domain.Models;

namespace MyBills.Infra.Data.SqlServer.Configurations
{
    public class ContaConfiguration : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.HasKey(key => key.Id);
            builder.Property(prop => prop.Numero).HasMaxLength(20).IsRequired();
            builder.Property(prop => prop.Valor).IsRequired();
            builder.Property(prop => prop.Tipo).IsRequired();
            builder.Property(prop => prop.EstaPaga).IsRequired();
            builder.Property(prop => prop.DataVencimento).IsRequired();
        }
    }
}
