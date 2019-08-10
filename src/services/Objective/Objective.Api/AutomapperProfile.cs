using AutoMapper;
using Objective.Api.Objectives;
using Objective.Core.Application.Commands.Objectives.AddObjective;

namespace Objective.Api
{
    public sealed class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<ObjectiveAddModel, AddObjectiveCommand>();
        }
    }
}
