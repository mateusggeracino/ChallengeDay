using Dapper;
using Microsoft.Extensions.Configuration;
using SC.Domain.Models;
using SC.Repository.Interfaces;

namespace SC.Repository.Repository
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(IConfiguration config) : base(config)
        {
        }

        public QuestionPoint GetPoint(int questionId, int answer)
        {
            var query = "SELECT * FROM QuestionPoint WHERE QuestionId = @questionId and Quantity = @answer";

            return Conn.QueryFirstOrDefault<QuestionPoint>(query, new { QuestionId = @questionId, Quantity = @answer, });
        }
    }
}