using SC.Domain.Models.Base;

namespace SC.Domain.Models
{
    public class Question : Entity
    {
        public string Description { get; set; }
        public int QuestionPointId { get; set; }
        public QuestionPoint QuestionPoint { get; set; }
    }
}