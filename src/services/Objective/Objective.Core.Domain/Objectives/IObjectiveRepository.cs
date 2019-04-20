using System;

using Objective.Core.Domain.Common;

namespace Objective.Core.Domain.Objectives
{
    public interface IObjectiveRepository : IRepository<Objective, Guid>
    {
        void Create(Objective Objective);
    }
}