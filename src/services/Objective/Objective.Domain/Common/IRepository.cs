namespace Objective.Domain.Common
{
    public interface IRepository<TEntity, TId> 
        where TEntity : Entity<TId>, IAggregateRoot
    {
    }
}