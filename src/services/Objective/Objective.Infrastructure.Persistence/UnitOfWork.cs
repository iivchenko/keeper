using Objective.Core.Domain.Common;
using System.Threading.Tasks;

namespace Objective.Infrastructure.Persistence
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ObjectiveContext _context;

        public UnitOfWork(ObjectiveContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
