using MediatR;
using System;

namespace Objective.Core.Application.Queries.Objectives.GetObjective
{
    public sealed class GetObjectiveQuery : IRequest<GetObjectiveQueryResult>
    {
        public Guid Id { get; set; }
    }
}
