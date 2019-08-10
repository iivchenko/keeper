using System;

namespace Objective.Core.Domain.Common
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity(Guid reference)
        {
            if (reference == Guid.Empty)
            {
                throw new ArgumentException("The 'reference' cannot be the empty!", nameof(reference));
            }

            Reference = reference;
        }

        public ulong Id { get; protected set; }

        public Guid Reference { get; protected set; }

        public override bool Equals(object other)
        {
            return 
                other is Entity entity
                    ? Equals(entity)
                    : base.Equals(other);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public bool Equals(Entity other)
        {
            return 
                other == null 
                    ? false
                    : Id.Equals(other.Id);
        }
    }
}
