using AutoMapper;
using Objective.Api.Objectives;
using Objective.Core.Application.Commands.Objectives.AddObjective;
using Objective.Core.Application.Queries.Objectives.GetObjective;

namespace Objective.Api
{
    public sealed class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            // Objective
            
            // Model To Commands\Queries
            CreateMap<ObjectiveAddModel, AddObjectiveCommand>();

            // Commands\Queries to Model
            CreateMap<GetObjectiveQueryResult, ObjectiveModel>();
        }
    }
}
