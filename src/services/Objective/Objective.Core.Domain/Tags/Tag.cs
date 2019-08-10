using System;

using Objective.Core.Domain.Common;

namespace Objective.Core.Domain.Tags
{
    public sealed class Tag : Entity, IAggregateRoot
    {
        public Tag(Guid id, string name, string description, TagColor color)
            : base(id)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value should not be empty!", nameof(name));
            }

            if(string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Value should not be empty!", nameof(description));
            }

            if (color == null)
            {
                throw new ArgumentNullException(nameof(color));
            }

            Name = name;
            Description = description;
            Color = color;
        }

        public string Name { get; private set; }

		public string Description { get; private set; }
		
        public TagColor Color { get; private set; }

        public void UpdateName (string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value should not be empty!", nameof(name));
            }

            Name = name;

            // Event
        }

        public void UpdateDescription (string description)
        {
            if(string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Value should not be empty!", nameof(description));
            }

            Description = description;

            // Event
        }

        public void UpdateColor(TagColor color)
        {
            if (color == null)
            {
                throw new ArgumentNullException(nameof(color));
            }

            Color = color;

            // Event
        }
    }
}