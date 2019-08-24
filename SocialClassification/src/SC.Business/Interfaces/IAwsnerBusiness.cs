using System.Collections.Generic;

namespace SC.Business.Interfaces
{
    public interface IAwsnerBusiness
    {
        bool Add(int clientId, IEnumerable<Awsner> awnser);
    }
}