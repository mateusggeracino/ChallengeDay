using System.Collections.Generic;
using SC.Domain.Models;

namespace SC.Business.Interfaces
{
    public interface IAnswerBusiness
    {
        bool Add(int clientId, IEnumerable<Answer> answer);
    }
}