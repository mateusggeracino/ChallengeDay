using SC.Domain.Models;

namespace SC.Business.Interfaces
{
    public interface IScoreBusiness
    {
        Score GetScoreClient(int clientId);
    }
}