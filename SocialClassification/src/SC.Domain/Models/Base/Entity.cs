using FluentValidation.Results;

namespace SC.Domain.Models.Base
{
    public abstract class Entity : IEntity
    {
        protected Entity()
        {
            ValidationResult = new ValidationResult();
        }

        public int Id { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }
}