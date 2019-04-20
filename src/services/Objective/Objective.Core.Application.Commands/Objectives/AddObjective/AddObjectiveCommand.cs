using System;

using Objective.Core.Application.Commands.Common;

namespace Objective.Core.Application.Commands.Objectives.AddObjective
{
    public sealed class AddObjectiveCommand : ICommand
    {
        public string Name { get; set; }

        public Guid UserId { get ; set; } 
        
        public Guid? MilestoneId { get; set; }
    }
}