using SC.Business.Interfaces;
using SC.Domain.Models;
using SC.Domain.Validations;
using SC.Repository.Interfaces;

namespace SC.Business.Business
{
    public class ClientBusiness : IClientBusiness
    {
        private readonly IClientRepository _clientRepository;

        public ClientBusiness(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client Add(Client client)
        {
            if (!ValidatorClient(client)) return client;

            _clientRepository.Add(client);
            return client;
        }

        private bool ValidatorClient(Client client)
        {
            var clientValidator = new ClientValidator();
            var result = clientValidator.Validate(client);
            return result.IsValid;
        }
    }
}