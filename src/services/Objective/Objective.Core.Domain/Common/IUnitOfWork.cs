using System.Threading.Tasks;

namespace Objective.Core.Domain.Common
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
