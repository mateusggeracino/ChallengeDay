using System.Collections.Generic;
using SC.Domain.Models;

namespace SC.Repository.Interfaces
{
    public interface IAnswerRepository : IRepository<Answer>
    {
        IEnumerable<Answer> GetByClient(int clientId);
    }
}