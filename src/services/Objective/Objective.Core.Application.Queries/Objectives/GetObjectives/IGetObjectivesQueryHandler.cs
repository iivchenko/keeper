using MediatR;

namespace Objective.Core.Application.Queries.Objectives.GetObjectives
{
    public interface IGetObjectivesQueryHandler : IRequestHandler<GetObjectivesQuery, GetObjectivesQueryResult>
    {
    }
}
