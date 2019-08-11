using System.Data.SqlClient;

namespace Objective.Core.Application.Queries.Sql.Common
{
    public interface IConnectionFactory
    {
        SqlConnection Create();
    }
}
