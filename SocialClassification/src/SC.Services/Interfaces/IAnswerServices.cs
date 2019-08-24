using System.Collections.Generic;
using SC.Services.ViewModels.Request;

namespace SC.Services.Interfaces
{
    public interface IAnswerServices
    {
        bool Add(int clientId, IEnumerable<AnswerRequestViewModel> awsner);
    }
}