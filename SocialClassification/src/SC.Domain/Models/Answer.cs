using System.ComponentModel.DataAnnotations.Schema;
using SC.Domain.Models.Base;

namespace SC.Domain.Models
{
    [Table("Answer")]
    public sealed class Answer : Entity
    {
        public int ClientId { get; set; }
        public int QuestionId { get; set; }
        public int ClientAwsner { get; set; }
    }
}