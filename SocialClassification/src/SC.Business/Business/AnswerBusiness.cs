using System.Collections.Generic;
using SC.Business.Interfaces;
using SC.Domain.Models;
using SC.Repository.Interfaces;

namespace SC.Business.Business
{
    public class AnswerBusiness : IAnswerBusiness
    {
        private readonly IAnswerRepository _answerRepository;

        public AnswerBusiness(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        public bool Add(int clientId, IEnumerable<Answer> awnser)
        {
            foreach (var awsner in awnser)
            {
                awsner.ClientId = clientId;
                _answerRepository.Add(awsner);
            }

            return true;
        }
    }
}