using System;
using System.Threading.Tasks;
using Objective.Core.Domain.Common;

namespace Objective.Core.Domain.Objectives
{
    public interface IObjectiveRepository : IRepository<Objective>
    {
        Task Create(Objective objective);
    }
}