using MediatR;

namespace Objective.Core.Application.Queries.Objectives.GetObjectives
{
    public sealed class GetObjectivesQuery : IRequest<GetObjectivesQueryResult>
    {
        public int Skip { get; set; }

        public int Take { get; set; }
    }
}
