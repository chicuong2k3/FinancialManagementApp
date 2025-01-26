using IncomeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncomeManagement.Infrastructure.Configurations
{
    internal class IncomeSourceConfiguration : IEntityTypeConfiguration<IncomeSource>
    {
        public void Configure(EntityTypeBuilder<IncomeSource> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.HasMany(x => x.Transactions)
                   .WithOne(x => x.IncomeSource)
                   .HasForeignKey(x => x.IncomeSourceId);
        }
    }

}
