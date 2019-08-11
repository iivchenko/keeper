using System;
using System.ComponentModel.DataAnnotations;

namespace Objective.Api.Objectives
{
    public sealed class ObjectiveModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
