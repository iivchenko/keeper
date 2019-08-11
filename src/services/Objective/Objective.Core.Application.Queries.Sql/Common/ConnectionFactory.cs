using System.Data.SqlClient;

namespace Objective.Core.Application.Queries.Sql.Common
{
    public sealed class ConnectionFactory : IConnectionFactory
    {
        public string _connectionString;

        public ConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection Create()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
