using System;

using Objective.Domain.Common;

namespace Objective.Domain.Users
{
    public sealed class User : Entity<Guid>, IAggregateRoot
    {
        public User(Guid id, string name)
            : base(id)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Value should not be empty!", nameof(name));
            }

            Name = name;
        }

        public string Name { get; }
    }
}