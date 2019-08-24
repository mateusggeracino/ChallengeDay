using SC.Domain.Models;

namespace SC.Repository.Interfaces
{
    public interface IQuestionRepository : IRepository<Question>
    {
        QuestionPoint GetPoint(int answerQuestionId, int answerClientId);
    }
}