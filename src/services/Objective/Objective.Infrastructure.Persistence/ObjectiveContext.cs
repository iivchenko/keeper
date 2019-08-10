using Microsoft.EntityFrameworkCore;
using Objective.Infrastructure.Persistence.Objectives;

namespace Objective.Infrastructure.Persistence
{
    public sealed class ObjectiveContext : DbContext
    {
        public ObjectiveContext(DbContextOptions<ObjectiveContext> options)
            : base(options)
        {
        }

        public DbSet<Core.Domain.Objectives.Objective> Objectives { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ObjectiveMapping());
        }
    }
}
