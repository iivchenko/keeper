using System;

namespace Objective.Api.Controllers
{
    public sealed class AddObjectiveDto
    {
        public string Name { get; set; }

        public Guid UserId { get ; set; }
        
        public Guid? MilestoneId { get; set; }
    }     
}