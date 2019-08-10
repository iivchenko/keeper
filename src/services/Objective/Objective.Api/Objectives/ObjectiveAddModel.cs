using System.ComponentModel.DataAnnotations;

namespace Objective.Api.Objectives
{
    public sealed class ObjectiveAddModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }
    }     
}