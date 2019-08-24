using System.Collections.Generic;
using AutoMapper;
using SC.Business.Interfaces;
using SC.Domain.Models;
using SC.Services.Interfaces;
using SC.Services.ViewModels.Request;

namespace SC.Services.Services
{
    public class AnswerServices : IAnswerServices
    {
        private readonly IMapper _mapper;
        private readonly IAnswerBusiness _awsnerBusiness;

        public AnswerServices(IMapper mapper, IAnswerBusiness awsnerBusiness)
        {
            _mapper = mapper;
            _awsnerBusiness = awsnerBusiness;
        }

        public bool Add(int clientId, IEnumerable<AnswerRequestViewModel> answer)
        {
            var answerList = _mapper.Map<IEnumerable<Answer>>(answer);

            _awsnerBusiness.Add(clientId, answerList);
            return true;
        }
    }
}