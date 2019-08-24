using SC.Services.ViewModels.Response;

namespace SC.Services.Interfaces
{
    public interface IScoreServices
    {
        ScoreResponseViewModel GetScoreClient(int clientId);
    }
}