using MediatR;
using System;

namespace Objective.Core.Application.Commands.Objectives.AddObjective
{
    public sealed class AddObjectiveCommand : IRequest<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}