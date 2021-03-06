using System;

using Objective.Core.Domain.Common;

namespace Objective.Core.Domain.Objectives
{
    public sealed class Comment : Entity
    {
        public Comment(Guid id, string text, Guid objectiveId, Guid createdByUserId)
            : base(id)
        {
            // TODO: think on cotract development
            if(string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Text should not be empty!", nameof(text));
            }

            if (objectiveId == Guid.Empty)
            {
                throw new ArgumentException("The ID cannot be the type's default value.", nameof(objectiveId));
            }

            if (createdByUserId == Guid.Empty)
            {
                throw new ArgumentException("The ID cannot be the type's default value.", nameof(createdByUserId));
            }

            Text = text;
            ObjectiveId = objectiveId;
            CreatedByUserId = createdByUserId;
            CreatedDate  = DateTime.UtcNow;
        }

        public string Text { get; private set; }

		public Guid ObjectiveId { get; }

        public Guid CreatedByUserId { get; }

		public DateTime CreatedDate { get; }

        public void UpdateText(string text)
        {
            // TODO: think on cotract development
            if(string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Text should not be empty!", nameof(text));
            }

            Text = text;

            // Raise Event
        }
    }
}