using System;
using System.Collections.Generic;

using Objective.Core.Domain.Common;
using Objective.Core.Domain.Objectives;

namespace Objective.Core.Domain.Milestones
{
    public sealed class Milestone : Entity, IAggregateRoot
    {
        private readonly IList<Objectives.Objective> _objectives;

        public Milestone(Guid id, string name, string description, DateTime dueDate)
            : base(id)
        {
            // TODO: Contract based development
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value should not be empty!", nameof(name));
            }

            if(string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Value should not be empty!", nameof(description));
            }

            Name = name;
            Description = description;
            DueDate = dueDate; // TODO: add posibility not to set due date

            Status = MilestoneStatus.Open.Id;
            CreatedDate = DateTime.UtcNow;

            _objectives = new List<Objectives.Objective>();
        }

        public string Name { get; private set; }
		    
        public string Description { get; private set; }
        
        public int Status { get; set; }

        public DateTime CreatedDate { get; }

        public DateTime DueDate { get; private set; }
    
        public IEnumerable<Objectives.Objective> Objectives => _objectives;

        public void UpdateName(string name)
        {
            // TODO: Contract based development
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value should not be empty!", nameof(name));
            }

            Name = name;

            // Event
        }

        public void UpdateDescription(string description)
        {
            // TODO: Contract based development
            if(string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Value should not be empty!", nameof(description));
            }

            Description = description;

            // Event
        }

        public void Close()
        {
            if (Status == MilestoneStatus.Open.Id)
            {
                Status = MilestoneStatus.Close.Id;

                // Event
            }
            else
            {
               // TODO: Add Domain Exception here
               throw new Exception($"Can't close milestone {Id} in {Enumeration.FromValue<MilestoneStatus>(Status).Name} status!");
            }
        }

        public void Reopen()
        {
            if (Status == MilestoneStatus.Close.Id)
            {
                Status = MilestoneStatus.Open.Id;

                // Event
            }
            else
            {
               // TODO: Add Domain Exception here
               throw new Exception($"Can't reopent milestone {Id} in {Enumeration.FromValue<MilestoneStatus>(Status).Name} status!");
            }
        }

        public void UpdateDueDate(DateTime dueDate)
        {
            DueDate = dueDate;

            // Event
        }

        public void AddObjective(Objectives.Objective objective)
        {
            if (_objectives.Contains(objective))
            {
                // TODO: To domain exeption
                throw new Exception($"Can't add objective '{objective.Id} as milestone '{Name}' already contains the objective!");
            }

            _objectives.Add(objective);

            // Event
        }
    }
}