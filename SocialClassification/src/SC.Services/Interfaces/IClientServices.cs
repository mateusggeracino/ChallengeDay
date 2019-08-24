using SC.Services.ViewModels.Request;
using SC.Services.ViewModels.Response;

namespace SC.Services.Interfaces
{
    public interface IClientServices
    {
        ClientResponseViewModel Add(ClientRequestViewModel client);
    }
}