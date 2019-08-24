using System.Collections.Generic;
using AutoMapper;
using SC.Services.Interfaces;
using SC.Services.ViewModels.Request;

namespace SC.Services.Services
{
    public class AwsnerServices : IAwsnerServices
    {
        private readonly IMapper _mapper;
        private readonly IAwsnerBusiness _awsnerBusiness;

        public AwsnerServices(IMapper mapper, IAwsnerBusiness awsnerBusiness)
        {
            _mapper = mapper;
            _awsnerBusiness = awsnerBusiness;
        }

        public bool Add(int clientId, IEnumerable<AwsnerRequestViewModel> awsner)
        {
            _awsnerBusiness.Add(clientId, awsner);
            return true;
        }
    }
}