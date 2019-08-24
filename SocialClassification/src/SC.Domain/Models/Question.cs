using System.ComponentModel.DataAnnotations.Schema;
using SC.Domain.Models.Base;

namespace SC.Domain.Models
{
    [Table("Question")]
    public sealed class Question : Entity
    {
        public string Description { get; set; }
        public int QuestionPointId { get; set; }
        public QuestionPoint QuestionPoint { get; set; }
    }
}