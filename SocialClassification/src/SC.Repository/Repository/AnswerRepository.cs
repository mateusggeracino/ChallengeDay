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
    }
}