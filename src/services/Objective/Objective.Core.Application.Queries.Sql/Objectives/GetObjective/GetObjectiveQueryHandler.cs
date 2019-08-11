using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Objective.Core.Application.Queries.Objectives.GetObjective;
using Objective.Core.Application.Queries.Sql.Common;

namespace Objective.Core.Application.Queries.Sql.Objectives.GetObjective
{
    public sealed class GetObjectiveQueryHandler : IGetObjectiveQueryHandler
    {
        private readonly IConnectionFactory _connectionFactory;

        public GetObjectiveQueryHandler(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<GetObjectiveQueryResult> Handle(GetObjectiveQuery request, CancellationToken cancellationToken)
        {
            var query = "SELECT * FROM [dbo].[objectives] WHERE Id = @Id;";

            using (var connection = _connectionFactory.Create())
            {
                return await connection.QuerySingleAsync<GetObjectiveQueryResult>(query, new { Id = request.Id });
            }
        }
    }
}
