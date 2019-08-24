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
    }
}