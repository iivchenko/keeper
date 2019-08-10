using System;

namespace Objective.Core.Domain.Objectives
{
    public sealed class ObjectiveFactory : IObjectiveFactory
    {
        public Objective Create(string name, string description)
        {
            return new Objective(Guid.NewGuid(), name, description);
        }
    }
}
