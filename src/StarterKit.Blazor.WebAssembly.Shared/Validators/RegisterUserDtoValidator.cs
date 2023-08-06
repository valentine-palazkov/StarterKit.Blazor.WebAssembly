using FluentValidation;
using StarterKit.Blazor.WebAssembly.Shared.Models;

namespace StarterKit.Blazor.WebAssembly.Shared.Validators
{
    public class RegisterUserDtoValidator : BaseUserDtoValidator<RegisterUserDto>
    {
        public RegisterUserDtoValidator() : base()
        {
            RuleFor(rp => rp.PasswordConfirm)
                .NotEmpty().WithMessage("Password Confirmation is required.")
                .Equal(rp => rp.Password).WithMessage("Password values should be equal.");
        }
    }
}
