using System.Collections.Generic;
using SC.Business.Interfaces;
using SC.Domain.Models;
using SC.Repository.Interfaces;
using SC.Repository.Repository;

namespace SC.Business.Business
{
    public class ScoreBusiness : IScoreBusiness
    {
        private readonly IAnswerRepository _answerRepository;
        private readonly IQuestionRepository _questionRepository;

        public ScoreBusiness(IAnswerRepository answerRepository, IQuestionRepository questionRepository)
        {
            _answerRepository = answerRepository;
            _questionRepository = questionRepository;
        }

        public Score GetScoreClient(int clientId)
        {
            var answers = _answerRepository.GetByClient(clientId);
            var score = SumPoint(answers);

            return score;
        }

        private Score SumPoint(IEnumerable<Answer> answers)
        {
            var score = new Score();
            foreach (var answer in answers)
            {
                var questionPoint = _questionRepository.GetPoint(answer.QuestionId, answer.ClientId);
                score.TotalScore += questionPoint.Point;
            }

            return score;
        }
    }
}