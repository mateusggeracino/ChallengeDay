using AutoMapper;
using SC.Business.Interfaces;
using SC.Domain.Models;
using SC.Services.Interfaces;
using SC.Services.ViewModels.Request;
using SC.Services.ViewModels.Response;

namespace SC.Services.Services
{
    public class ClientServices : IClientServices
    {
        private readonly IMapper _mapper;
        private readonly IClientBusiness _clientBusiness;

        public ClientServices(IClientBusiness clientBusiness, IMapper mapper)
        {
            _clientBusiness = clientBusiness;
            _mapper = mapper;
        }

        public ClientResponseViewModel Add(ClientRequestViewModel client)
        {
            var clientModel = _mapper.Map<Client>(client);
            var result = _clientBusiness.Add(clientModel);

            return _mapper.Map<ClientResponseViewModel>(result);
        }
    }
}