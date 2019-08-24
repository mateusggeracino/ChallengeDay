using Dapper.Contrib.Extensions;
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

        [Write(false)]
        public ValidationResult ValidationResult { get; set; }
    }
}