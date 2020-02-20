using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Objective.Core.Application.Queries.Objectives.GetObjectives;
using Objective.Core.Application.Queries.Sql.Common;

namespace Objective.Core.Application.Queries.Sql.Objectives.GetObjective
{
    public sealed class GetObjectivesQueryHandler : IGetObjectivesQueryHandler
    {
        private readonly IConnectionFactory _connectionFactory;

        public GetObjectivesQueryHandler(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<GetObjectivesQueryResult> Handle(GetObjectivesQuery request, CancellationToken cancellationToken)
        {
            var query = "SELECT * FROM [dbo].[objectives] ORDER BY CreatedDate OFFSET @Skip ROWS FETCH NEXT @Take ROWS ONLY";

            using (var connection = _connectionFactory.Create())
            {
                var items = await connection.QueryAsync<GetObjectivesQueryItem>(query, new { Skip = request.Skip, Take = request.Take });

                return new GetObjectivesQueryResult
                {
                    Objectives = items
                };
            }
        }
    }
}
