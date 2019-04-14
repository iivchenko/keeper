using System;
using System.Collections.Generic;

using Objective.Domain.Comments;
using Objective.Domain.Common;
using Objective.Domain.Tags;
using Objective.Domain.Users;

namespace Objective.Domain.Objectives
{
    public sealed class Objective : Entity<Guid>
    {
        private readonly IList<Tag> _tags;
        private readonly IList<Comment> _comments;

        public Objective(Guid id, string name, Guid userId, Guid? milestoneId)
            : base(id)
        {
            // TODO: Contract based development
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value should not be empty!", nameof(name));
            }

            if (userId == Guid.Empty)
            {
                throw new ArgumentException("The value cannot be the type's default value.", nameof(userId));
            }

            if (milestoneId.HasValue && milestoneId == Guid.Empty)
            {
                throw new ArgumentException("The value cannot be the type's default value.", nameof(milestoneId));
            }

            Name = name;
            CreatedByUserId = userId;
            MilestoneId = milestoneId;

            Status = ObjectiveStatus.Open.Id;
            
            _tags = new List<Tag>();
            _comments = new List<Comment>();
        }

		public string Name { get; private set; }

		public int Status { get; private set; }

		public IEnumerable<Tag> Tags => _tags;
		
        public Guid? MilestoneId { get; }

		public IEnumerable<Comment> Comments => _comments;

		public Guid CreatedByUserId { get; }

		public DateTime CreatedDate { get; }

        public void UpdateName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value should not be empty!", nameof(name));
            }

            Name = name;

            // Event
        }

        public void Close()
        {
            if (Status == ObjectiveStatus.Open.Id)
            {
                Status = ObjectiveStatus.Close.Id;

                // Event
            }
            else
            {
               // TODO: Add Domain Exception here
               throw new Exception($"Can't close objective {Id} in {Enumeration.FromValue<ObjectiveStatus>(Status).Name} status!");
            }
        }

        public void Reopen()
        {
            if (Status == ObjectiveStatus.Close.Id)
            {
                Status = ObjectiveStatus.Open.Id;

                // Event
            }
            else
            {
               // TODO: Add Domain Exception here
               throw new Exception($"Can't reopent objective {Id} in {Enumeration.FromValue<ObjectiveStatus>(Status).Name} status!");
            }
        }

        public void AddTag(Tag tag)
        {
            if (_tags.Contains(tag))
            {
                // TODO: To domain exeption
                throw new Exception($"Can't add tag '{tag.Name} as objective '{Name}' already contains the tag!");
            }

            _tags.Add(tag);

            // Event
        }

        public void RemoveTag(Tag tag)
        {
            if (!_tags.Contains(tag))
            {
                // TODO: To domain exeption
                throw new Exception($"Can't remove tag '{tag.Name} as objective '{Name}' doesn't  contain the tag!");
            }

            _tags.Remove(tag);

            // Event
        }

        public void AddComment(Comment comment)
        {
            if (_comments.Contains(comment))
            {
                // TODO: To domain exeption
                throw new Exception($"Can't add comment '{comment.Id} as objective '{Name}' already contains the comment!");
            }

            _comments.Add(comment);

            // Event
        }
    }
}