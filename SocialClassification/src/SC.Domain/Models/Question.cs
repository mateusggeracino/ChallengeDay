namespace SC.Domain.Models
{
    public class Question
    {
        public string Description { get; set; }
        public int QuestionPointId { get; set; }
        public QuestionPoint QuestionPoint { get; set; }
    }
}