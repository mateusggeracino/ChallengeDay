using System.Collections.Generic;
using Dapper;
using Microsoft.Extensions.Configuration;
using SC.Domain.Models;
using SC.Repository.Interfaces;

namespace SC.Repository.Repository
{
    public class AnswerRepository : Repository<Answer>, IAnswerRepository
    {
        public AnswerRepository(IConfiguration config) : base(config)
        {
        }

        public IEnumerable<Answer> GetByClient(int clientId)
        {
            var query = "SELECT * FROM Answer WHERE ClientId = @clientId";

            return Conn.Query<Answer>(query, new { clientId });
        }
    }
}