using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Objective.Infrastructure.Persistence.Objectives
{
    public sealed class ObjectiveMapping : IEntityTypeConfiguration<Core.Domain.Objectives.Objective>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Objectives.Objective> builder)
        {
            builder
                .ToTable("objectives");

            builder
                .HasKey(x => x.Id)
                .ForSqlServerIsClustered(false);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50);

            builder
                .Property(x => x.Description);

            builder
                .Property(x => x.CreatedDate);

            builder
                .HasIndex(x => x.CreatedDate)
                .IsUnique()
                .ForSqlServerIsClustered(true);
        }
    }
}
