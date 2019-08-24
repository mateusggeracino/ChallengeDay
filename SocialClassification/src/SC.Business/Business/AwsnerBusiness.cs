using System.Collections.Generic;
using SC.Business.Interfaces;

namespace SC.Business.Business
{
    public class AwsnerBusiness : IAwsnerBusiness
    {
        private readonly IAwsnerRepository _awsnerRepository;

        public AwsnerBusiness(IAwsnerRepository awsnerRepository)
        {
            _awsnerRepository = awsnerRepository;
        }

        public bool Add(int clientId, IEnumerable<Awsner> awnser)
        {
            throw new System.NotImplementedException();
        }
    }
}