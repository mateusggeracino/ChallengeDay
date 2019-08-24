using Microsoft.Extensions.Configuration;
using SC.Domain.Models;
using SC.Repository.Interfaces;

namespace SC.Repository.Repository
{
    public sealed class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(IConfiguration config) : base(config)
        {
        }
    }
}