using System.Threading.Tasks;
using Objective.Core.Domain.Objectives;

namespace Objective.Infrastructure.Persistence.Objectives
{
    public sealed class ObjectiveRepository : IObjectiveRepository
    {
        private readonly ObjectiveContext _context;

        public ObjectiveRepository(ObjectiveContext context)
        {
            _context = context;
        }

        public Task Create(Core.Domain.Objectives.Objective objective)
        {
            return _context.Objectives.AddAsync(objective);
        }
    }
}
