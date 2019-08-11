using System;

namespace Objective.Core.Application.Queries.Objectives.GetObjective
{
    public sealed class GetObjectiveQueryResult
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
