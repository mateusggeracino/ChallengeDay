using System.Collections.Generic;
using SC.Services.ViewModels.Request;

namespace SC.Services.Interfaces
{
    public interface IAwsnerServices
    {
        bool Add(int clientId, IEnumerable<AwsnerRequestViewModel> awsner);
    }
}