using System;

using Objective.Core.Domain.Common;

namespace Objective.Core.Domain.Objectives
{
    public sealed class Objective : Entity, IAggregateRoot
    {
        public Objective(Guid id, string name, string description)
            : base(id)
        {
            // TODO: Contract based development
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value should not be empty!", nameof(name));
            }

            Name = name;
            Description = description;
            CreatedDate = DateTime.UtcNow;
        }

        private Objective()
            : base(Guid.NewGuid())
        {
        }

        public string Name { get; private set; }

        public string Description { get; private set; }
	
		public DateTime CreatedDate { get; private set; }

        public void UpdateName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value should not be empty!", nameof(name));
            }

            Name = name;

            // Event
        }

        public void UpdateDescription(string description)
        {
            Description = description;

            // Event
        }
    }
}