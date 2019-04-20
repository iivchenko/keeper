namespace Objective.Core.Domain.Common
{
    public interface IRepository<TEntity, TId> 
        where TEntity : Entity<TId>, IAggregateRoot
    {
    }
}