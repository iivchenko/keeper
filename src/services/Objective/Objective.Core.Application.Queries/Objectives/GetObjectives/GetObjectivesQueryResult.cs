using System;
using System.Collections.Generic;

namespace Objective.Core.Application.Queries.Objectives.GetObjectives
{
    public sealed class GetObjectivesQueryItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }

    public sealed class GetObjectivesQueryResult
    {
        public IEnumerable<GetObjectivesQueryItem> Objectives { get; set; }
    }
}
