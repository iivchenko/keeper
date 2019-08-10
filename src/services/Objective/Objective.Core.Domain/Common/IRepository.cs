namespace Objective.Core.Domain.Common
{
    public interface IRepository<TEntity> 
        where TEntity : Entity, IAggregateRoot
    {
    }
}