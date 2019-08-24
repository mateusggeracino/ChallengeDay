using FluentValidation;
using SC.Domain.Models;

namespace SC.Domain.Validations
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Name not Empty");
        }   
    }
}