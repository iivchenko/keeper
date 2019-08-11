using MediatR;

namespace Objective.Core.Application.Queries.Objectives.GetObjective
{
    public interface IGetObjectiveQueryHandler : IRequestHandler<GetObjectiveQuery, GetObjectiveQueryResult>
    {
    }
}
